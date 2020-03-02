using CoreFramework.Controles.Controle.ActionList;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Designer
{
    public class LookUpDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        private DesignerActionListCollection actionLists;

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (actionLists == null)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new LookUpActionList((LookUpExtends)Control));
                }
                return actionLists;
            }
        }
    }
}
