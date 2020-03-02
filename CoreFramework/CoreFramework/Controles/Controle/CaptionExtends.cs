using CoreFramework.Controles.Controle.Designer;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Objetos;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(CaptionDesigner))]

    public partial class CaptionExtends : DesignControlBase
    {
        bool imagem = true;
        Enums.TipoCaption tipoPainel = Enums.TipoCaption.Grande;

        public CaptionExtends()
        {
            InitializeComponent();
        }

        #region Propriedades

        [Category("Custom")]
        [Description("Tamanho do controle")]
        public int Tamanho
        {
            get
            {
                return this.Width;
            }

            set
            {
                this.Width = value;
            }
        }

        [Category("Custom")]
        [Description("Texto da label principal")]
        public String Titulo
        {
            get
            {
                return lbl_principal.Text;
            }

            set
            {
                lbl_principal.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Valor do texto")]
        public string Subtitulo
        {
            get
            {
                return lbl_referencia.Text;
            }
            set
            {
                lbl_referencia.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Cor do painel")]
        public System.Drawing.Color Cor
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Cor do Titulo")]
        public System.Drawing.Color CorTitulo
        {
            get { return lbl_principal.ForeColor; }
            set { lbl_principal.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Cor do SubTitulo")]
        public System.Drawing.Color CorSubtitulo
        {
            get { return lbl_referencia.ForeColor; }
            set { lbl_referencia.ForeColor = value; }
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

        [Category("Custom")]
        [Description("Tipo de Painel")]
        [DefaultValue(Enums.TipoCaption.Grande)]
        public Enums.TipoCaption TipoPainel
        {
            get { return tipoPainel; }
            set
            {
                tipoPainel = value;
                tamanhoPainel();
            }
        }

        #endregion

        #region metodos

        private void visibilidade(bool valor)
        {
            if (valor)
            {
                pcb_action.Visible = true;
                lbl_principal.Location = new System.Drawing.Point(64, 6);
                lbl_referencia.Location = new System.Drawing.Point(64, 36);
            }
            else
            {
                pcb_action.Visible = false;
                lbl_principal.Location = new System.Drawing.Point(10, 6);
                lbl_referencia.Location = new System.Drawing.Point(10, 36);
            };
            tamanhoReferencia();
        }

        private void tamanhoReferencia()
        {
            int tamanho = this.Width;
            int altura = this.Height;
            int tamanho_convertido = 0;

            if (imagem)
                tamanho_convertido = (tamanho - 68) - 5;
            else
                tamanho_convertido = tamanho - 10;

            this.lbl_referencia.Size = new System.Drawing.Size(tamanho_convertido, altura);
        }

        private void tamanhoPainel()
        {
            if (TipoPainel == Enums.TipoCaption.Grande)
            {
                this.Height = 62;
                this.pcb_action.Size = new Size(48, 50);
                this.pcb_action.Location = new Point(7, 6);
                this.lbl_principal.Location = new Point(56, 9);
            }
            else
            {
                this.Height = 33;
                this.pcb_action.Size = new Size(33, 33);
                this.pcb_action.Location = new Point(2, 0);
                this.lbl_principal.Location = new Point(33, 4);
            }
        }

        private void inicializa()
        {
            tamanhoReferencia();
            tamanhoPainel();
        }


        #endregion

        #region eventos

        protected override void OnCreateControl()
        {
            base.InicializarTipo(Enums.TipoControle.Visual);
        }
        private void CaptionExtends_Load(object sender, EventArgs e)
        {
            inicializa();
        }

        private void CaptionExtends_Resize(object sender, EventArgs e)
        {
            inicializa();
        }

        #endregion
    }
}
