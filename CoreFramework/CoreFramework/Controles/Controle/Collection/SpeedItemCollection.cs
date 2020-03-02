using CoreFramework.Controles.Controle.Itens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.Controles.Controle.Collection
{
    public class SpeedItemCollection : CollectionBase
    {
        public void Add(SpeedItem item)
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
        public SpeedItem this[int index]
        {
            get { return (SpeedItem)this.List[index]; }
            set { this.List[index] = value; }
        }
    }
}
