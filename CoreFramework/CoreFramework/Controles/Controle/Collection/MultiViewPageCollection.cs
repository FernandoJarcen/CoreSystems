using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace CoreFramework.Controles.Controle.Collection
{
    public class MultiViewPageCollection : Control.ControlCollection
    {
        public MultiViewPageCollection(Control owner)
            : base(owner)
        {
            if (owner == null)
                throw new ArgumentNullException("owner", "Tried to create a MultiPanelPagesCollection with a null owner.");
            _owner = owner as MultiViewExtends;
            if (_owner == null)
                throw new ArgumentException("Tried to create a MultiPanelPagesCollection with a non-MultiPanel owner.", "owner");
        }

        public override void Add(Control value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "Tried to add a null value to the MultiPanelPagesCollection.");
            Itens.MultiViewPageItem p = value as Itens.MultiViewPageItem;
            if (p == null)
                throw new ArgumentException("Tried to add a non-MultiPanelPage control to the MultiPanelPagesCollection", "value");
            p.SendToBack();
            base.Add(p);
        }

        public override void AddRange(Control[] controls)
        {
            foreach (Itens.MultiViewPageItem p in controls)
                Add(p);
        }

        public override void Remove(Control value)
        {
            base.Remove(value);
        }

        public override int IndexOfKey(string key)
        {
            Control ctrl = base[key];
            return GetChildIndex(ctrl);
        }

        private MultiViewExtends _owner;
    }
}
