using System;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Designer
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]

    public class MultiViewDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            _mpanel = component as MultiViewExtends;
            if (_mpanel == null)
            {
                this.DisplayError(new ArgumentException("Tried to use the MultiPanelControlDesign with a class that does not inherit from MultiPanel.", "component"));
                return;
            }
            base.Initialize(component);
            IComponentChangeService iccs = (IComponentChangeService)this.GetService(typeof(IComponentChangeService));
            if (iccs != null)
            {
                iccs.ComponentRemoved += new ComponentEventHandler(ComponentRemoved);
            }
            ISelectionService s = (ISelectionService)GetService(typeof(ISelectionService));
            if (s != null)
            {
                s.SelectionChanged += new EventHandler(s_SelectionChanged);
            }
        }

        public override void DoDefaultAction()
        {
        }

        public override DesignerVerbCollection Verbs
        {
            get
            {
                if (_verbs == null)
                {
                    _verbs = new DesignerVerbCollection();
                    _verbs.Add(new DesignerVerb("Add Page", new EventHandler(AddPage)));
                    _verbs.Add(new DesignerVerb("Remove Page", new EventHandler(RemovePage)));
                }
                return _verbs;
            }
        }

        public override ICollection AssociatedComponents
        {
            get
            {
                return _mpanel.Controls;
            }
        }

        private void AddPage(object sender, EventArgs ea)
        {
            IDesignerHost dh = (IDesignerHost)GetService(typeof(IDesignerHost));
            if (dh != null)
            {
                DesignerTransaction dt = dh.CreateTransaction("Added new page");

                Itens.MultiViewPageItem before = _mpanel.SelectedPage;

                string name = GetNewPageName();
                Itens.MultiViewPageItem ytp = dh.CreateComponent(typeof(Itens.MultiViewPageItem), name) as Itens.MultiViewPageItem;
                ytp.Text = name;
                _mpanel.Controls.Add(ytp);
                _mpanel.SelectedPage = ytp;

                RaiseComponentChanging(TypeDescriptor.GetProperties(Control)["SelectedPage"]);
                RaiseComponentChanged(TypeDescriptor.GetProperties(Control)["SelectedPage"], before, ytp);

                dt.Commit();
            }
        }


        private void RemovePage(object sender, EventArgs ea)
        {
            IDesignerHost dh = (IDesignerHost)GetService(typeof(IDesignerHost));
            if (dh != null)
            {
                DesignerTransaction dt = dh.CreateTransaction("Removed page");

                Itens.MultiViewPageItem page = _mpanel.SelectedPage;
                if (page != null)
                {
                    Itens.MultiViewPageItem ytp = _mpanel.SelectedPage;
                    _mpanel.Controls.Remove(ytp);
                    dh.DestroyComponent(ytp);

                    if (_mpanel.Controls.Count > 0)
                        _mpanel.SelectedPage = (Itens.MultiViewPageItem)_mpanel.Controls[0];
                    else
                        _mpanel.SelectedPage = null;

                    RaiseComponentChanging(TypeDescriptor.GetProperties(Control)["SelectedPage"]);
                    RaiseComponentChanged(TypeDescriptor.GetProperties(Control)["SelectedPage"], ytp, _mpanel.SelectedPage);
                }

                dt.Commit();
            }
        }

        private string GetNewPageName()
        {
            int i = 1;
            Hashtable h = new Hashtable(_mpanel.Controls.Count);
            foreach (Control c in _mpanel.Controls)
            {
                h[c.Name] = null;
            }
            while (h.ContainsKey("Page_" + i))
            {
                i++;
            }
            return "Page_" + i;
        }

        #region Private Methods

        private void s_SelectionChanged(object sender, EventArgs e)
        {
            ISelectionService s = (ISelectionService)GetService(typeof(ISelectionService));
            if (s != null)
            {
                if (s.PrimarySelection != null)
                {
                    Itens.MultiViewPageItem page = GetMultiPanelPage((Control)s.PrimarySelection);
                    if (page != null)
                        _mpanel.SelectedPage = page;
                }
            }
        }

        private Itens.MultiViewPageItem GetMultiPanelPage(Control ctrl)
        {
            if (ctrl is Itens.MultiViewPageItem)
            {
                Itens.MultiViewPageItem p = (Itens.MultiViewPageItem)ctrl;
                if (object.ReferenceEquals(_mpanel, p.Parent))
                    return p;
                else
                    return null;
            }
            else if (ctrl.Parent != null)
                return GetMultiPanelPage(ctrl.Parent);
            else
                return null;
        }


        private void ComponentRemoved(object sender, ComponentEventArgs cea)
        {
        }
        #endregion

        #region Constants

        private const int WM_LBUTTONDOWN = 0x0201;


        private const int WM_LBUTTONDBLCLK = 0x0203;
        #endregion

        #region Private Variables
        private MultiViewExtends _mpanel;
        private DesignerVerbCollection _verbs;
        #endregion

    }

}
