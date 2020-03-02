using CoreFramework.Controles.Controle.Base;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class DisplayItemExtends :ChooseControlBase
    {
        public DisplayItemExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Texto do cabecalho do controle")]
        public string Titulo
        {
            get
            {
                return chk_action.Text;
            }
            set
            {
                chk_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Valor do controle")]
        public bool Ativado
        {
            get { return chk_action.Checked; }
            set { chk_action.Checked = value; }
        }

        #endregion

    }
}
