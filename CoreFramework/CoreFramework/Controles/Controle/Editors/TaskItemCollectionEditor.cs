using System;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Editors
{
    public class TaskItemCollectionEditor:CollectionEditor
    {
        public TaskItemCollectionEditor(Type type)
            : base(type)
        {

        }

        protected override Type[] CreateNewItemTypes()
        {
            Type[] ValidTypes = { typeof(TaskItemExtends) };
            return ValidTypes;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            return base.EditValue(context, provider, value);
        }
    }
}
