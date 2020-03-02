using System;
using System.Collections;

namespace CoreFramework.Controles.Controle
{
    partial class TabListExtends
    {
        #region  Nested Classes


        public class TabListPageCollection
          : IList, ICollection, IEnumerable
        {
            #region  Public Constructors

            public TabListPageCollection(TabListExtends owner)
            {
                if (owner == null)
                    throw new ArgumentNullException("owner");

                this.Owner = owner;
            }

            #endregion  Public Constructors

            #region  Public Methods

            public TabListPageExtends Add(string text)
            {
                TabListPageExtends page;

                page = new TabListPageExtends()
                {
                    Text = text
                };

                this.Add(page);

                return page;
            }

            public void Add(TabListPageExtends value)
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                this.Owner.Controls.Add(value);
            }

            public void Clear()
            {
                this.Owner.ClearAllPages();
            }

            public bool Contains(TabListPageExtends value)
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                return this.IndexOf(value) != -1;
            }

            public void CopyTo(Array array, int index)
            {
                if (this.Count != 0)
                    Array.Copy(this.Owner.GetTabListPages(), 0, array, index, this.Count);
            }

            public IEnumerator GetEnumerator()
            {
                TabListPageExtends[] tabPages;

                tabPages = this.Owner.GetTabListPages();
                if (tabPages == null)
                    tabPages = new TabListPageExtends[0];

                return tabPages.GetEnumerator();
            }

            public int IndexOf(TabListPageExtends value)
            {
                int index;

                if (value == null)
                    throw new ArgumentNullException("value");

                index = -1;
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i] == value)
                    {
                        index = i;
                        break;
                    }
                }

                return index;
            }

            public void Insert(int index, TabListPageExtends value)
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                this.Owner.InsertPage(index, value);
                this.Owner.Controls.Add(value);
                this.Owner.Controls.SetChildIndex(value, index);
            }

            public void Remove(TabListPageExtends value)
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                this.Owner.Controls.Remove(value);
            }

            public void RemoveAt(int index)
            {
                this.Owner.Controls.RemoveAt(index);
            }

            #endregion  Public Methods

            #region  Public Properties

            public int Count
            { get { return this.Owner.TabListPageCount; } }

            public bool IsFixedSize
            { get { return false; } }

            public bool IsReadOnly
            { get { return false; } }

            public bool IsSynchronized
            { get { return false; } }

            public object SyncRoot
            { get { return this; } }

            public virtual TabListPageExtends this[int index]
            {
                get { return this.Owner.GetTabListPages()[index]; }
                set { this.Owner.SelectedIndex = index; }
            }

            #endregion  Public Properties

            #region  Private Properties

            object IList.this[int index]
            {
                get { return this[index]; }
                set
                {
                    if (!(value is TabListPageExtends))
                        throw new ArgumentException("Only controls of type TabListPage can be added to this collection.", "value");

                    this[index] = (TabListPageExtends)value;
                }
            }

            #endregion  Private Properties

            #region  Private Methods

            int IList.Add(object value)
            {
                TabListPageExtends page;

                if (!(value is TabListPageExtends))
                    throw new ArgumentException("value");

                page = (TabListPageExtends)value;

                this.Add(page);

                return this.IndexOf(page);
            }

            bool IList.Contains(object value)
            {
                return value is TabListPageExtends && this.Contains((TabListPageExtends)value);
            }

            int IList.IndexOf(object value)
            {
                int index;

                if (value is TabListPageExtends)
                    index = this.IndexOf((TabListPageExtends)value);
                else
                    index = -1;

                return index;
            }

            void IList.Insert(int index, object value)
            {
                if (!(value is TabListPageExtends))
                    throw new ArgumentException("value");

                this.Insert(index, (TabListPageExtends)value);
            }

            void IList.Remove(object value)
            {
                if (value is TabListPageExtends)
                    this.Remove((TabListPageExtends)value);
            }

            #endregion  Private Methods

            #region  Protected Properties

            protected TabListExtends Owner { get; set; }

            #endregion  Protected Properties
        }
        #endregion  Nested Classes
    }
}
