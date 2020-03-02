using CoreMDK.Query;
using System.Collections;

namespace CoreFramework.Controles.Controle.Collection
{
    public class ConditionExpressionCollection:CollectionBase
    {
        public void Add(Condition item)
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
        public Condition this[int index]
        {
            get { return (Condition)this.List[index]; }
            set { this.List[index] = value; }
        }
    }
}
