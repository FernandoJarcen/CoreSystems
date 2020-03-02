using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreStudio.Controles.Base
{
    [ToolboxItem(false)]
    public class TextBoxBase:UserControl
    {
        TextBox tbx_action;
        private string marca = string.Empty;
        Color _borderColor = Color.SteelBlue;

        public TextBoxBase()
        {
            inicializar();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return this.tbx_action.Size.Width;
            }

            set
            {
                this.tbx_action.Size = new System.Drawing.Size(value, 23);
            }
        }

        [Category("Custom")]
        [Description("Configura o texto da marca dagua")]
        public string MarcaDagua
        {
            get { return marca; }
            set
            {
                marca = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Valor padrão")]
        public string Valor
        {
            get { return tbx_action.Text; }
            set { tbx_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor quando focado")]
        public Color FocusColor { get; set; }

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

        #endregion

        #region metodos

        private void inicializar()
        {
            tbx_action = new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(-1, -1),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular)
            };

            Control container = new ContainerControl()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1)
            };
            container.Controls.Add(tbx_action);
            this.Controls.Add(container);

            FocusColor = Color.Red;
            Padding = new Padding(1);
            Size = tbx_action.Size;
            BackColor = _borderColor;
        }

        public void Habilitar(bool status)
        {
            this.Enabled = status;
        }

        #endregion

        #region eventos

        /* desenvolvimento de borda - 10-08-18 */

        protected override void OnEnter(EventArgs e)
        {
            BackColor = FocusColor;
            base.OnEnter(e);
            if (tbx_action.Text == MarcaDagua)
            {
                tbx_action.Text = "";
                tbx_action.ForeColor = SystemColors.WindowText;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            BackColor = this._borderColor;
            base.OnLeave(e);
            if (tbx_action.Text.Length == 0)
            {
                tbx_action.Text = MarcaDagua;
                tbx_action.ForeColor = SystemColors.GrayText;
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, tbx_action.PreferredHeight, specified);
        }

        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!String.IsNullOrEmpty(MarcaDagua))
            {
                tbx_action.Text = MarcaDagua;
                tbx_action.ForeColor = SystemColors.GrayText;
            }
        }


    }
}
