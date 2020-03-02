using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class ImageButtonExtends : DesignControlBase
    {
        public event EventHandler AoClicar;

        public ImageButtonExtends()
        {
            InitializeComponent();
            inicializar();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Valor do Titulo do botão")]
        public String Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }

        [Category("Custom")]
        [Description("Valor do Subtitulo do botão")]
        public String SubTitulo
        {
            get { return lbl_descricao.Text; }
            set { lbl_descricao.Text = value; }
        }

        [Category("Custom")]
        [Description("Imagem do botão")]
        public System.Drawing.Image Imagem
        {
            get { return pct_action.Image; }
            set { pct_action.Image = value; }
        }

        [Category("Custom")]
        [Description("Cor do Titulo")]
        public System.Drawing.Color CorTitulo
        {
            get { return lbl_titulo.ForeColor; }
            set { lbl_titulo.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Cor do Subtítulo")]
        public System.Drawing.Color CorSubTitulo
        {
            get { return lbl_descricao.ForeColor; }
            set { lbl_descricao.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Tamanho de título")]
        public float TamanhoTitulo
        {
            get { return lbl_titulo.Font.Size; }
            set { lbl_titulo.Font = new Font("Microsoft Sans Serif", value, FontStyle.Bold); }
        }

        [Category("Custom")]
        [Description("Tamanho do Subtitulo")]
        public float TamanhoSubtitulo
        {
            get { return lbl_descricao.Font.Size; }
            set { lbl_descricao.Font = new Font("Microsoft Sans Serif", value, FontStyle.Bold); }
        }

        #endregion

        #region metodos

        private void inicializar()
        {
            this.pct_action.Click += acao_Click;
            this.lbl_descricao.Click += acao_Click;
            this.lbl_titulo.Click += acao_Click;
            this.Size = new Size(120, this.Size.Height);
        }

        #endregion

        #region eventos

        private void acao_Click(object sender, EventArgs e)
        {
            if (this.AoClicar != null)
            {
                this.AoClicar(this, e);
            }
        }

        #endregion        
    }
}
