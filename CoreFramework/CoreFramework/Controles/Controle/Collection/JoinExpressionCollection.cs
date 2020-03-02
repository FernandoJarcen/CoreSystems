using CoreMDK.Query;
using System.Collections;

namespace CoreFramework.Controles.Controle.Collection
{
    public class JoinExpressionCollection:CollectionBase
    {
        public void Add(Join item)
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
        public Join this[int index]
        {
            get { return (Join)this.List[index]; }
            set { this.List[index] = value; }
        }

    }
}
