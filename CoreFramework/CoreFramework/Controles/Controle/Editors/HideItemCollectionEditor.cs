using CoreFramework.Controles.Controle.Itens;
using System;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Editors
{
    public class HideItemCollectionEditor: CollectionEditor
    {
        public HideItemCollectionEditor(Type type)
            : base(type)
        { }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object returnObject = base.EditValue(context, provider, value);
            return returnObject;
        }

        protected override object CreateInstance(Type itemType)
        {
            HideItem item = new HideItem("Nome", "Valor");
            return item;
        }
    }
}
