using CoreFramework.Controles.Controle.Collection;
using CoreFramework.Controles.Controle.Editors;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class HideExtends : UserControl
    {
        private HideItemCollection lista = new HideItemCollection();

        
        public HideExtends()
        {
            InitializeComponent();
            this.Visible = false;
        }

        #region Campos

        [Editor(typeof(HideItemCollectionEditor),
    typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Custom")]
        [Description("Itens retornaveis")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public HideItemCollection Items
        {
            get { return lista; }
            set { lista = value; }
        }        

        #endregion
    }
}
