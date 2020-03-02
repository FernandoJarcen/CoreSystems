using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using CoreFramework.Controles.Controle.Base;

namespace CoreFramework.Controles.Controle
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]

    public partial class GroupExtends : DesignControlBase
    {
        public GroupExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Cor Mensagem")]
        public System.Drawing.Color Cor
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Texto da mensagem")]
        public string Mensagem
        {
            get { return cbx_action.Text; }
            set { cbx_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do texto da mensagem")]
        public System.Drawing.Color CorMensagem
        {
            get { return cbx_action.ForeColor; }
            set { cbx_action.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Grupo selecionado?")]
        public bool Selecionado
        {
            get { return this.cbx_action.Checked; }
            set
            {
                this.cbx_action.Checked = value;
            }
        }

        [Category("Custom")]
        [Description("Cabeçalho em negrito?")]
        public bool Negrito
        {
            get
            {
                return cbx_action.Font.Bold;
            }
            set
            {
                if (value)
                    negritar(true);
                else
                    negritar(false);
            }
        }

        #endregion

        #region metodos

        private void negritar(bool status)
        {
            if (status)
                cbx_action.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            else
                cbx_action.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular);


        }
        private void comportamento(bool status)
        {
            if (this.Controls.Count > 1)
                for (int indice = 1; indice <= this.Controls.Count - 1; indice++)
                {
                    this.Controls[indice].Enabled = status;
                }
        }

        #endregion

        #region eventos

        private void cbx_action_CheckedChanged(object sender, System.EventArgs e)
        {
            if (cbx_action.Checked)
                comportamento(true);
            else
                comportamento(false);
        }

        #endregion
    }
}
