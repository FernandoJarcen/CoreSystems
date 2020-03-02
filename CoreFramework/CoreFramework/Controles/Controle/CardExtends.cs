using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;
using CoreFramework.Controles.Controle.Base;

namespace CoreFramework.Controles.Controle
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))] 
    public partial class CardExtends : DesignControlBase
    {
        bool visivel = true;

        public CardExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Mostra Mensagem rodape")]
        public bool MostrarMensagem
        {
            get { return visivel; }
            set
            {
                visivel = value;
                if (!visivel)
                    sts_action.Visible = false;
                else
                    sts_action.Visible = true;
            }
        }


        [Category("Custom")]
        [Description("Titulo do rodape")]
        public string Mensagem
        {
            get { return tss_action.Text; }
            set { tss_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor Mensagem")]
        public System.Drawing.Color Cor
        {
            get { return sts_action.BackColor; }
            set { sts_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Cor do texto")]
        public System.Drawing.Color CorTexto
        {
            get { return tss_action.ForeColor; }
            set { tss_action.ForeColor = value; }
        }

        #endregion
    }
}