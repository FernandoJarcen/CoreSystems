using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class TaskItemExtends : DesignControlBase
    {
        public event EventHandler AoClicar;

        public TaskItemExtends()
        {
            InitializeComponent();
            inicializar();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Mensagem do Titulo")]
        public string Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }

        [Category("Custom")]
        [Description("Mensagem do SubTitulo")]
        public string SubTitulo
        {
            get { return lbl_subtitulo.Text; }
            set { lbl_subtitulo.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do Titulo")]
        public System.Drawing.Color CorTitulo
        {
            get { return lbl_titulo.ForeColor; }
            set { lbl_titulo.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Cor do Subtitulo")]
        public System.Drawing.Color CorSubTitulo
        {
            get { return lbl_subtitulo.ForeColor; }
            set { lbl_subtitulo.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Imagem do controle")]
        public System.Drawing.Image Imagem
        {
            get { return pct_action.Image; }
            set { pct_action.Image = value; }
        }

        #endregion

        #region metodos

        private void inicializar()
        {
            this.Click += Acao_Click;
            this.lbl_titulo.Click += Acao_Click;
            this.lbl_subtitulo.Click += Acao_Click;
            this.Size = new System.Drawing.Size(100, this.Size.Height);
        }

        #endregion

        #region eventos

        private void Acao_Click(object sender, System.EventArgs e)
        {
            if (this.AoClicar != null)
            {
                this.AoClicar(this, e);
            }
        }

        #endregion
    }
}
