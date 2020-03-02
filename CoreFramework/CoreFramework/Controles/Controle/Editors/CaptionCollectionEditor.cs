using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle.Editors
{
    public class CaptionCollectionEditor : CollectionEditor
    {
        public CaptionCollectionEditor(Type type)
            : base(type)
        {

        }

        protected override Type[] CreateNewItemTypes()
        {
            Type[] ValidTypes = { typeof(CaptionItemExtends) };
            return ValidTypes;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            return base.EditValue(context, provider, value);
        }
    }
}
