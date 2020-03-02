using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class MenuItemExtends : DesignControlBase
    {
        public event EventHandler AoClicar;

        public MenuItemExtends()
        {
            InitializeComponent();
            inicializar();
        }
        
        #region propriedades

        [Category("Custom")]
        [Description("Titulo do botão")]
        public string Titulo
        {
            get { return this.btn_action.Text; }
            set { this.btn_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Imagem do botão")]
        public System.Drawing.Image Imagem
        {
            get { return this.btn_action.Image; }
            set { this.btn_action.Image = value; }
        }

        [Category("Custom")]
        [Description("Cor do botão")]
        public System.Drawing.Color Cor
        {
            get { return this.btn_action.BackColor; }
            set { this.btn_action.BackColor = value; }
        }

        #endregion

        #region metodos

        private void inicializar()
        {
            this.btn_action.Click += acao_Click;
            this.btn_action.Dock = DockStyle.Left;
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

        private void MenuItemExtends_SizeChanged(object sender, EventArgs e)
        {
            this.btn_action.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height);
        }

        #endregion
    }
}
