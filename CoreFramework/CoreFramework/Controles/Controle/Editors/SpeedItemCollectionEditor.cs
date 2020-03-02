using CoreFramework.Controles.Controle.Itens;
using System;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Editors
{
    public class SpeedItemCollectionEditor : CollectionEditor
    {
        public SpeedItemCollectionEditor(Type type)
            : base(type)
        { }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object returnObject = base.EditValue(context, provider, value);
            return returnObject;
        }

        protected override object CreateInstance(Type itemType)
        {
            SpeedItem item = new SpeedItem(0, "item","display");
            return item;
        }
    }
}
