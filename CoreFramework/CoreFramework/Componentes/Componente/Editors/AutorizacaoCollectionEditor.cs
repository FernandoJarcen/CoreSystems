using CoreFramework.Componentes.Componente.Itens;
using System;
using System.ComponentModel.Design;

namespace CoreFramework.Componentes.Componente.Editors
{
    public class AutorizacaoCollectionEditor:CollectionEditor
    {


        public AutorizacaoCollectionEditor(Type type)
            : base(type)
        { }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object returnObject = base.EditValue(context, provider, value);
            return returnObject;
        }

        protected override object CreateInstance(Type itemType)
        {
            AutorizacaoItem item = new AutorizacaoItem("Aplicacao", "Modulo", "Rotina","Nivel");
            return item;
        }
    }
}
