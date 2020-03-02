using System;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Editors
{
    public class MenuCollectionEditor:CollectionEditor
    {
        public MenuCollectionEditor(Type type)
            : base(type)
        {

        }

        protected override Type[] CreateNewItemTypes()
        {
            Type[] ValidTypes = { typeof(MenuItemExtends) };
            return ValidTypes;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            return base.EditValue(context, provider, value);
        }

    }
}
