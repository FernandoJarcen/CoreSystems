using CoreFramework.Controles.Controle.Base;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class DivisionBarExtends : DesignControlBase
    {
        public DivisionBarExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Cor do controle")]
        public System.Drawing.Color Cor
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
        }

        #endregion
    }
}
