using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle.Editors
{
    public class DisplayCollectionEditor : CollectionEditor
    {
        public DisplayCollectionEditor(Type type)
            : base(type)
        {

        }

        protected override Type[] CreateNewItemTypes()
        {
            Type[] ValidTypes = { typeof(DisplayItemExtends) };
            return ValidTypes;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            return base.EditValue(context, provider, value);
        }
    }
}
