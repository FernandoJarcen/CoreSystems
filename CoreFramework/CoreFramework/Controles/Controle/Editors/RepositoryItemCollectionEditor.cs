using CoreFramework.Controles.Controle.Itens;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.Controles.Controle.Editors
{
    public class RepositoryItemCollectionEditor:CollectionEditor
    {
        public RepositoryItemCollectionEditor(Type type)
        : base(type)
        { }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object returnObject = base.EditValue(context, provider, value);
            return returnObject;
        }

        protected override object CreateInstance(Type itemType)
        {
            RepositoryItem item = new RepositoryItem(0, "item","display");
            return item;
        }
    }
}
