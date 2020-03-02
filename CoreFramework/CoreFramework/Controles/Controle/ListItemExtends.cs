using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class ListItemExtends : DesignControlBase
    {
        public event EventHandler AoClicar;

        public ListItemExtends()
        {
            InitializeComponent();
            inicializar();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Mensagem do controle")]
        public string Mensagem
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor da mensagem")]
        public System.Drawing.Color Cor
        {
            get { return lbl_action.ForeColor; }
            set { lbl_action.ForeColor = value; }
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
            this.Click += acao_Click;
            this.lbl_action.Click += acao_Click;
            this.Size = new System.Drawing.Size(100, this.Size.Height);
        }

        #endregion

        #region eventos

        private void acao_Click(object sender, System.EventArgs e)
        {
            if (this.AoClicar != null)
            {
                this.AoClicar(this, e);
            }
        }

        #endregion
    }
}
