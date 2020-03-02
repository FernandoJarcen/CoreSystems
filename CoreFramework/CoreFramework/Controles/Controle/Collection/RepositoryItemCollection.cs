using CoreFramework.Controles.Controle.Itens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.Controles.Controle.Collection
{
    public class RepositoryItemCollection : CollectionBase
    {
        public void Add(RepositoryItem item)
        {
            List.Add(item);
        }
        public void Remove(int index)
        {
            if ((index > Count - 1) || (index < 0))
            {
                throw new System.IndexOutOfRangeException();
            }
            else
            {
                this.List.RemoveAt(index);
            }
        }
        public RepositoryItem this[int index]
        {
            get { return (RepositoryItem)this.List[index]; }
            set { this.List[index] = value; }
        }
    }
}
