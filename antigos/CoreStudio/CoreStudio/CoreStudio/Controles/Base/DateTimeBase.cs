using CoreStudio.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreStudio.Controles.Base
{
    public class DateTimeBase : DateTimePicker
    {
        private Color _borderAntiga = Color.SteelBlue;
        private Color _borderColor = Color.SteelBlue;
        Enums.EnumTipoDatas _tipoData = Enums.EnumTipoDatas.DataCurta;

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

        private const int WM_NCPAINT = 0x0085;
        private const int WM_ERASEBKGND = 0x0014;
        private const int WM_PAINT = 0x000F;

        #region propriedades

        [Category("Custom")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Category("Custom")]
        [Description("Cor quando focado")]
        public Color FocusColor { get; set; }

        [Category("Custom")]
        [Description("Valor do texto")]
        public string Valor
        {
            get
            {
                return this.Text;
            }
            set
            {
                if (value != " ")
                    this.Text = value;
            }
        }

        [Category("Custom")]
        public bool Habilitado
        {
            get { return this.Enabled; }
            set
            {
                this.Enabled = value;
            }
        }

        [Category("Custom")]
        [Description("Verifica o formato do campo")]
        public Enums.EnumTipoDatas Formato
        {
            get { return _tipoData; }
            set
            {
                _tipoData = value;
                verificarFormato();
            }
        }

        #endregion

        #region metodos

        public void Habilitar(bool status)
        {
            this.Habilitado = status;
        }

        public void DataCorrente()
        {
            this.Valor = DateTime.Now.ToString();
        }

        #endregion

        #region eventos

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT || m.Msg == WM_ERASEBKGND || m.Msg == WM_PAINT)
            {
                IntPtr hdc = GetDC(m.HWnd);
                try
                {
                    if (hdc != IntPtr.Zero)
                    {
                        using (Graphics graphics = Graphics.FromHdc(hdc))
                        {
                            ControlPaint.DrawBorder(
                              graphics,
                              ClientRectangle, // Rect
                              _borderColor,       // BorderColor
                              ButtonBorderStyle.Solid);
                        }

                        m.Result = (IntPtr)1;
                    }
                }
                finally
                {
                    if (hdc != IntPtr.Zero)
                    {
                        ReleaseDC(m.HWnd, hdc);
                    }
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            //this.Format = DateTimePickerFormat.Short;
            this.Format = verificarFormato();
            this.FocusColor = Color.Red;
        }

        private DateTimePickerFormat verificarFormato()
        {
            DateTimePickerFormat formato = DateTimePickerFormat.Short;
            if (_tipoData == Enums.EnumTipoDatas.DataCurta)
                formato = DateTimePickerFormat.Short;
            else if (_tipoData == Enums.EnumTipoDatas.DataLonga)
                formato = DateTimePickerFormat.Long;
            else if (_tipoData == Enums.EnumTipoDatas.Hora)
                formato = DateTimePickerFormat.Time;
            else if (_tipoData == Enums.EnumTipoDatas.EspecíficaSefaz)
            {
                formato = DateTimePickerFormat.Custom;
            }
            return formato;
        }

        protected override void OnEnter(EventArgs e)
        {
            _borderAntiga = _borderColor;
            BorderColor = FocusColor;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            BorderColor = _borderAntiga;
            base.OnLeave(e);
        }

        #endregion

    }
}
