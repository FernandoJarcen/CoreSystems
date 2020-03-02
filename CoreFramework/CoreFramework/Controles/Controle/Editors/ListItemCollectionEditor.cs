using System;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Editors
{
    public class ListItemCollectionEditor : CollectionEditor
    {
        public ListItemCollectionEditor(Type type)
            : base(type)
        {

        }

        protected override Type[] CreateNewItemTypes()
        {
            Type[] ValidTypes = { typeof(ListItemExtends) };
            return ValidTypes;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            return base.EditValue(context, provider, value);
        }
    }
}
