using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace CoreFramework.Controles.Controle.Itens
{
    [Designer(typeof(CoreFramework.Controles.Controle.Designer.MultiViewPageDesigner))]
    [ToolboxItem(false)]
    public class MultiViewPageItem : ContainerControl
    {
        public MultiViewPageItem()
        {
            base.Dock = DockStyle.Fill;
        }

        public override DockStyle Dock
        {
            get
            {
                return base.Dock;
            }
            set
            {
                base.Dock = DockStyle.Fill;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        protected override System.Windows.Forms.Control.ControlCollection CreateControlsInstance()
        {
            return new MultiViewPageItem.ControlCollection(this);
        }

        #region Classes
        public new class ControlCollection : Control.ControlCollection
        {
            public ControlCollection(Control owner)
                : base(owner)
            {
                if (owner == null)
                    throw new ArgumentNullException("owner", "Tried to create a MultiPanelPage.ControlCollection with a null owner.");
                MultiViewPageItem c = owner as MultiViewPageItem;
                if (c == null)
                    throw new ArgumentException("Tried to create a MultiPanelPage.ControlCollection with a non-MultiPanelPage owner.", "owner");
            }

            public override void Add(Control value)
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Tried to add a null value to the MultiPanelPage.ControlCollection.");
                MultiViewPageItem p = value as MultiViewPageItem;
                if (p != null)
                    throw new ArgumentException("Tried to add a MultiPanelPage control to the MultiPanelPage.ControlCollection.", "value");
                base.Add(value);
            }
        }
        #endregion
    }
}
