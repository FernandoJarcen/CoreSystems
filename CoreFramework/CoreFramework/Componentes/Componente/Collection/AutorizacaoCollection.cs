using CoreFramework.Componentes.Componente.Itens;
using System.Collections;

namespace CoreFramework.Componentes.Componente.Collection
{
    public class AutorizacaoCollection : CollectionBase
    {
        public void Add(AutorizacaoItem item)
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
        public AutorizacaoItem this[int index]
        {
            get { return (AutorizacaoItem)this.List[index]; }
            set { this.List[index] = value; }
        }
    }
}
