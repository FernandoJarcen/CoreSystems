using CoreFramework.Controles.Controle.Base;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class TitleBlockExtends : DesignControlBase
    {
        bool imagem = true;

        public TitleBlockExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Titulo do controle")]
        public string Titulo
        {
            get { return lbl_mensagem.Text; }
            set { lbl_mensagem.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do controle")]
        public System.Drawing.Color Cor
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Alinhamento do Titulo")]
        public System.Drawing.ContentAlignment Alinhamento
        {
            get { return lbl_mensagem.TextAlign; }
            set { lbl_mensagem.TextAlign = value; }
        }

        [Category("Custom")]
        [Description("Cor do Texto")]
        public System.Drawing.Color CorTexto
        {
            get { return lbl_mensagem.ForeColor; }
            set { lbl_mensagem.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Mostrar/Ocultar Imagem")]
        public bool MostrarImagem
        {
            get { return imagem; }
            set
            {
                imagem = value;
                visibilidade(imagem);
            }
        }

        [Category("Custom")]
        [Description("Carregar Imagem")]
        public System.Drawing.Image Imagem
        {
            get { return pcb_action.Image; }
            set
            {
                if (imagem)
                {
                    pcb_action.Image = value;
                }
            }
        }
        #endregion

        #region metodos

        private void visibilidade(bool valor)
        {
            if (valor)
            {
                pcb_action.Visible = true;
                lbl_mensagem.Location = new System.Drawing.Point(64, 7);
            }
            else
            {
                pcb_action.Visible = false;
                lbl_mensagem.Location = new System.Drawing.Point(10, 7);
            };
            //tamanhoReferencia();
        }
                
        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            inicializar();
        }

        private void inicializar()
        {
            pnl_action.BackColor = Cor;
            pnl_action.ForeColor = CorTexto;
            visibilidade(imagem);
        }
    }
}
