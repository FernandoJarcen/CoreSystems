using CoreSDK.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CoreFramework.BaseObjects;

namespace CoreFramework.Componentes.Componente
{
    public partial class ValidationComponent : Component
    {
        private static readonly object EVENT_ValidationExecute = new object();
        private ContainerControl _containerControl = null;
        public ValidationComponent()
        {
            InitializeComponent();
        }

        public ValidationComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Campos

        [Category("Custom")]
        [Description("Itens do controle")]
        public IEnumerable<Control> Itens { get; set; }

        public ContainerControl ContainerControl
        {
            get { return _containerControl; }
            set { _containerControl = value; }
        }

        #endregion

        #region Metodos

        public override ISite Site
        {
            get { return base.Site; }
            set
            {
                base.Site = value;
                if (value == null)
                {
                    return;
                }

                IDesignerHost host = value.GetService(
                    typeof(IDesignerHost)) as IDesignerHost;
                if (host != null)
                {
                    IComponent componentHost = host.RootComponent;
                    if (componentHost is ContainerControl)
                    {
                        ContainerControl = componentHost as ContainerControl;
                    }
                }
            }
        }

        public string ValidarCampos(Control control)
        {
            string mensagem = string.Empty;
            List<Control> controles = new List<Control>();
            controles = BaseControls.RetornarEditaveis(control);

            var items = from i in controles
                        where Convert.ToBoolean(CoreService.RetornarPropriedade(i, "Obrigatorio")) == true
                        select i;

            foreach (var item in items)
            {
                string valor = CoreService.RetornarPropriedade(item, "Valor").ToString();
                valor = valor.Replace(" ", "");
                string propriedadePadrao = CoreService.RetornarPropriedade(item, "MensagemPadrao").ToString();

                if (string.IsNullOrEmpty(valor))
                {
                    mensagem = propriedadePadrao;
                    break;
                }
            }

            return mensagem;
        }

        //public List<Control> RetornarEditaveis(Control control)
        //{
        //    var controls = control.Controls.Cast<Control>();

        //    return controls.SelectMany(ctrl => RetornarEditaveis(ctrl))
        //                   .Concat(controls)
        //                   .Where(c => ObterTipoControle(c) == "Edicao").ToList();

        //}

        //private string ObterTipoControle(Object obj)
        //{
        //    string retorno = string.Empty;
        //    Type Tipo = obj.GetType();
        //    PropertyInfo[] props = Tipo.GetProperties();
        //    PropertyInfo opcao = props.FirstOrDefault(x => x.Name == "TipoControle");

        //    foreach (var prop in props)
        //        if (prop.GetIndexParameters().Length == 0)
        //            if (prop.Name == "TipoControle")
        //            {
        //                retorno = prop.GetValue(obj).ToString();
        //                break;
        //            }

        //    if (opcao != null)
        //    {
        //        if (opcao.GetIndexParameters().Length == 0)
        //            retorno = opcao.GetValue(obj).ToString();
        //    }
        //    else retorno = string.Empty;
        //    return retorno;
        //}

        #endregion

        #region Eventos

        [Category("Custom"), Description("Evento de validação do componente")]
        public event EventHandler ValidationExecute
        {
            add
            {
                Events.AddHandler(EVENT_ValidationExecute, value);
            }
            remove
            {
                Events.RemoveHandler(EVENT_ValidationExecute, value);
            }
        }

        #endregion
    }
}
