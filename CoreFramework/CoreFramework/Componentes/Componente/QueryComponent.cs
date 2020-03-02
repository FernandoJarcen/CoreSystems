using CoreFramework.Controles.Controle.Designer;
using CoreFramework.Objetos;
using System.ComponentModel;

namespace CoreFramework.Componentes.Componente
{
    //[Designer(typeof(QueryDesigner))]
    [Author("CoreSystems","10/06/2018","1.0")]
    public partial class QueryComponent : Component
    {
        public QueryComponent()
        {
            InitializeComponent();
        }

        public QueryComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Category("Custom")]
        [Description("Listagem de consultas a executar")]
        public string[] Query { get; set; }
    }
}
