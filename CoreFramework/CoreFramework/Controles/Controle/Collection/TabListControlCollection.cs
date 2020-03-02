using System;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    partial class TabListExtends
    {
        #region  Nested Classes


        public class TabListControlCollection
          : Control.ControlCollection
        {
            #region  Public Constructors

            public TabListControlCollection(TabListExtends owner)
                : base(owner)
            {

            }

            #endregion  Public Constructors

            #region  Public Overridden Methods

            public override void Add(Control value)
            {
                TabListPageExtends page;

                if (!(value is TabListPageExtends))
                    throw new ArgumentException("Only TabListPage controls can be hosted in this control.");

                page = (TabListPageExtends)value;
                page.Visible = false; // all pages should be hidden by default
                page.Bounds = this.Owner.DisplayRectangle;

                base.Add(page);

                this.Owner.AddPage(page);
            }

            public override void Remove(Control value)
            {
                base.Remove(value);

                if (value is TabListPageExtends)
                {
                    int index;

                    index = this.Owner.TabListPages.IndexOf((TabListPageExtends)value);

                    if (index != -1)
                        this.Owner.RemovePageAt(index);
                }
            }

            #endregion  Public Overridden Methods

            #region  Protected Properties

            protected new TabListExtends Owner
            { get { return (TabListExtends)base.Owner; } }

            #endregion  Protected Properties
        }
        #endregion  Nested Classes

    }
}
