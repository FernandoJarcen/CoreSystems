using CoreFramework.Controles.Controle.Base;
using CoreFramework.Objetos;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class ButtonImageExtends : DesignControlBase
    {
        public event EventHandler AoClicar;
        public Button btn_action = new Button();

        public ButtonImageExtends()
        {
            inicializar();
            this.Size = new Size(25, 23);
        }

        #region propriedades

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
        [Description("Cor do texto")]
        public System.Drawing.Color Cor
        {
            get { return this.btn_action.BackColor; }
            set { this.btn_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Carregar Imagem")]
        public System.Drawing.Image Imagem
        {
            get { return btn_action.Image; }
            set
            {
                btn_action.Image = value;
            }
        }

        #endregion

        #region metodos

        private void inicializar()
        {            
            btn_action.Text = string.Empty;
            btn_action.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_action.Image = CoreFramework.Properties.Resources.acrescimo;
            btn_action.ImageAlign = ContentAlignment.MiddleCenter;
            btn_action.Click += btn_action_Click;
            btn_action.Size = new Size(25, 23);

            this.btn_action.FlatAppearance.BorderSize = 0;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size = new Size(25, 23);
            this.Controls.Add(btn_action);
            base.InicializarTipo(Enums.TipoControle.Visual);
        }

        #endregion

        #region eventos

        void btn_action_Click(object sender, EventArgs e)
        {
            if (this.AoClicar != null)
            {
                this.AoClicar(this, e);
            }
        }

        #endregion

    }
}
