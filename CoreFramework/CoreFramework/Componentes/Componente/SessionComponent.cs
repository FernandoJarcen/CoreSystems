using System.ComponentModel;
using CoreFramework.Componentes.Componente.Collection;
using CoreFramework.Componentes.Componente.Editors;

namespace CoreFramework.Componentes.Componente
{
    public partial class SessionComponent : Component
    {
        private AutorizacaoCollection lista = new AutorizacaoCollection();

        public SessionComponent()
        {
            InitializeComponent();
        }

        public SessionComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region propriedades

        public int CodigoModulo { get; set; }
        public string NomeModulo { get; set; }
        public int CodigoUnidade { get; set; }
        public string NomeUnidade { get; set; }
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Base { get; set; }
        public int CodigoEquipe { get; set; }
        public string NomeEquipe { get; set; }
        public int Privilegio { get; set; }
        [Editor(typeof(AutorizacaoCollectionEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Custom")]
        [Description("Coleção de configuracoes")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AutorizacaoCollection Rotina
        {
            get { return lista; }
            set { lista = value; }
        }
        #endregion
        
    }
}
