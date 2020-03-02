using CoreFramework.Controles.Controle.Itens;
using System;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Editors
{
    public class ListSearchCollectionEditor : CollectionEditor
    {
        public ListSearchCollectionEditor(Type type)
            : base(type)
        { }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object returnObject = base.EditValue(context, provider, value);
            return returnObject;
        }

        protected override object CreateInstance(Type itemType)
        {
            ListSearchItem item = new ListSearchItem(0, "item", "display");
            return item;
        }
    }
}
