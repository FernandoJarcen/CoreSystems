using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public partial class ButtonMaxExtends : DesignControlBase
    {
        public event EventHandler AoChamar;

        public ButtonMaxExtends()
        {
            InitializeComponent();
            base.InicializarTipo(Enums.TipoControle.Visual);
        }

        #region propriedades

        [Category("Custom")]
        [Description("Texto da label")]
        public String Mensagem
        {
            get
            {
                return btn_action.Text;
            }

            set
            {
                btn_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Cor do painel")]
        public System.Drawing.Color Cor
        {
            get
            {
                return btn_action.BackColor;
            }
            set
            {

                this.btn_action.BackColor = value;
            }
        }

        [Category("Custom")]
        [Description("Imagem do botão")]
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


        #endregion

        #region eventos

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (this.AoChamar != null)
            {
                this.AoChamar(this, e);
            }   
        }

        #endregion
    }
}
