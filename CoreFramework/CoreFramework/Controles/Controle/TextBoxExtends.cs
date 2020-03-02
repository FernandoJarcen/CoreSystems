using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using enm = CoreFramework.Objetos.Enums;

namespace CoreFramework.Controles.Controle
{
    public class TextBoxExtends : TextBox
    {
        const int WM_NCPAINT = 0x85;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private bool obrigatorio = false;
        private Font fonteAntiga = null;
        private Boolean marcaHabilitada = false;
        private Color marcaCor = Color.Gray;        
        private string marcaTexto = "Dica do controle";
        private enm.ValidacaoCaracteres validacaoCaracteres = enm.ValidacaoCaracteres.Nenhum;
        Color borderColor = Color.SteelBlue;

        #region propriedades

        [Category("Custom")]
        [Description("Verifica se o campo é obrigatorio")]
        public bool Obrigatorio
        {
            get { return obrigatorio; }
            set
            {
                obrigatorio = value;
                if (obrigatorio)
                    this.BackColor = SystemColors.Info;
                else
                    this.BackColor = SystemColors.Window;
            }
        }

        [Category("Custom")]
        [Description("Configura o texto da marca dagua")]
        public string MarcaDagua
        {
            get { return marcaTexto; }
            set { marcaTexto = value; Invalidate(); }
        }

        [Category("Custom")]
        [Description("Configura o tipo de entrada")]
        public enm.ValidacaoCaracteres ValidacaoTexto
        {
            get { return validacaoCaracteres; }
            set
            {
                validacaoCaracteres = value;
            }
        }

        [Category("Custom")]
        [Description("Valor padrão")]
        public string ValorPadrao { get; set; }

        [Category("Custom")]
        [Description("Cor da Borda")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }

        #endregion

        #region metodos

        private void inicializar()
        {
            this.GotFocus += textbox_GotFocus;
            this.LostFocus += textbox_LostFocus;
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.KeyPress += textbox_KeyPress;
        }

        private void inicializarEventos(Boolean evento)
        {
            if (evento)
            {
                this.TextChanged += new System.EventHandler(this.alternarMarca);
                this.LostFocus += new System.EventHandler(this.alternarMarca);
                this.FontChanged += new System.EventHandler(this.marca_FontChanged);
            }
        }

        private void alternarMarca(object sender, EventArgs args)
        {
            if (this.Text.Length <= 0)
                habilitarMarca();
            else
                desabilitarMarca();
        }

        private void habilitarMarca()
        {
            //fonteAntiga = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,Font.Unit);
            fonteAntiga = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,Font.Unit);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.marcaHabilitada = true;
            Refresh();
        }

        private void desabilitarMarca()
        {
            this.marcaHabilitada = false;
            this.SetStyle(ControlStyles.UserPaint, false);
            if (fonteAntiga != null)
                this.Font = new System.Drawing.Font(fonteAntiga.FontFamily, fonteAntiga.Size, fonteAntiga.Style, fonteAntiga.Unit);
            Refresh();
        }

        public void Habilitar(bool status)
        {
            this.Enabled = status;
        }

        #endregion

        #region eventos
                
        private void marca_FontChanged(object sender, EventArgs args)
        {
            if (marcaHabilitada)
            {
                //fonteAntiga = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);
                fonteAntiga = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, Font.Unit);
                Refresh();
            }
        }

        private void textbox_GotFocus(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void textbox_LostFocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.BackColor = SystemColors.Info;
            else
                this.BackColor = SystemColors.Window;
        }

        void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validacaoCaracteres == enm.ValidacaoCaracteres.Numeros)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        
        protected override void OnPaint(PaintEventArgs args)
        {
            System.Drawing.Font drawFont = new System.Drawing.Font(Font.FontFamily,
                Font.Size, Font.Style, Font.Unit);
            SolidBrush drawBrush = new SolidBrush(marcaCor);
            args.Graphics.DrawString((marcaHabilitada ? MarcaDagua : Text),
                drawFont, drawBrush, new PointF(0.0F, 0.0F));
            base.OnPaint(args);
        }

        /* desenvolvimento de borda - 10-08-18 */

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
                BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
            {
                var hdc = GetWindowDC(this.Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(this.Handle, hdc);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                   RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }

        #endregion
        
        public TextBoxExtends()
        {
            inicializarEventos(true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            alternarMarca(null, null);
            inicializar();
            //this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
        }
    }
}
