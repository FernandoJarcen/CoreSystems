using CoreFramework.Controles.Controle.Collection;
using CoreFramework.Controles.Controle.Editors;
using System.ComponentModel;

namespace CoreFramework.Componentes.Componente
{
    public partial class RepositoryComponent : Component
    {
        private RepositoryItemCollection lista = new RepositoryItemCollection();

        public RepositoryComponent()
        {
            InitializeComponent();
        }

        public RepositoryComponent(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        [Editor(typeof(RepositoryItemCollectionEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Custom")]
        [Description("A collection of the employees within the organization")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RepositoryItemCollection Items
        {
            get { return lista; }
            set { lista = value; }
        }
    }
}
