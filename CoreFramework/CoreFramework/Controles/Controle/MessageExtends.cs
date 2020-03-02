using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class MessageExtends : DesignControlBase
    {
        int tamanhomensagem = 200;
        string texto = string.Empty;

        public MessageExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Texto do cabeçalho")]
        public string Titulo
        {
            get { return this.lbl_titulo.Text; }
            set { this.lbl_titulo.Text = value; }
        }

        [Category("Custom")]
        [Description("Texto da mensagem")]
        public string Mensagem
        {
            get { return this.lbl_mensagem.Text; }
            set
            {
                texto = value;
                if (texto.Length > tamanhomensagem)
                {
                    texto = texto.Substring(0, tamanhomensagem);
                }
                this.lbl_mensagem.Text = texto;
            }
        }

        [Category("Custom")]
        [Description("Tamanho máximo da mensagem")]
        [DefaultValue(200)]
        public int TamanhoMensagem
        {
            get { return tamanhomensagem; }
            set
            {
                tamanhomensagem = value;
            }
        }

        [Category("Custom")]
        [Description("Cabecalho em negrito")]
        public bool Negrito
        {
            get
            {
                return lbl_titulo.Font.Bold;
            }
            set
            {
                if (value)
                    lbl_titulo.Font = new Font("Timew New Roman", 16F, FontStyle.Bold);
                else
                    lbl_titulo.Font = new Font("Timew New Roman", 16F, FontStyle.Regular);
            }
        }

        [Category("Custom")]
        [Description("Cor da mensagem")]
        public System.Drawing.Color Cor
        {
            get { return pnl_superior.BackColor; }
            set { pnl_superior.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Imagem da mensagem")]
        public System.Drawing.Image Imagem
        {
            get { return this.pbx_titulo.Image; }
            set { this.pbx_titulo.Image = value; }
        }

        #endregion

        #region metodos
                
        #endregion

        #region eventos

        private void MessageExtends_SizeChanged(object sender, EventArgs e)
        {
            lbl_mensagem.Size = new Size(this.Size.Width - 15, this.Size.Height);
        }

        #endregion
    }
}
