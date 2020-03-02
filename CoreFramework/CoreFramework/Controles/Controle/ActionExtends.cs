using CoreFramework.Controles.Controle.Base;
using CoreFramework.Objetos;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class ActionExtends : DesignControlBase
    {
        public event EventHandler AoChamar;

        public ActionExtends()
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
        [Description("Texto da label")]
        public String Messagem
        {
            get
            {
                return lbl_message.Text;
            }

            set
            {
                lbl_message.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Cor do painel")]
        public Color Cor
        {
            get
            {
                return pnl_action.BackColor;
            }
            set
            {
                pnl_action.BackColor = value;
            }
        }

        [Category("Custom")]
        [Description("Carregar Imagem")]
        public System.Drawing.Image Imagem
        {
            get { return pcb_action.Image; }
            set
            {
                pcb_action.Image = value;
            }
        }

        [Category("Custom")]
        [Description("Fechar Ação")]
        [DefaultValue(true)]
        public bool FecharAcao { get; set; }

        #endregion

        #region Metodos

        #endregion

        #region Eventos

        private void pcb_fechar_Click(object sender, EventArgs e)
        {
            if (FecharAcao)
                this.Visible = false;
            if (this.AoChamar != null)
            {
                this.AoChamar(this, e);
            }
        }

        protected override void OnCreateControl()
        {
            base.InicializarTipo(Enums.TipoControle.Visual);
        }

        #endregion
    }
}
