using CoreFramework.Controles.Controle.ActionList;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.Designer
{
    public class CaptionGridDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        private DesignerActionListCollection actionLists;

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (actionLists == null)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new CaptionGridActionList((CaptionGridExtends)Control));
                }
                return actionLists;
            }
        }
    }
}
