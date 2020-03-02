using CoreFramework.Controles.Controle.Editors;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class PanelCaptionActionList : System.ComponentModel.Design.DesignerActionList
    {
        private PanelCaptionExtends linkedControl;
        public PanelCaptionActionList(PanelCaptionExtends ctrl)
            : base(ctrl)
        {
            linkedControl = ctrl;
        }

        private PropertyDescriptor GetPropertyByName(string propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(linkedControl)[propName];

            if (null == prop)
                throw new ArgumentException("Matching Property not found", propName);
            else
                return prop;
        }


        public override System.ComponentModel.Design.DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("Controle"));
            items.Add(new DesignerActionPropertyItem("Nome", "Nome", "Controle", "Nome do controle"));
            items.Add(new DesignerActionPropertyItem("Itens", "Itens", "Controle", "Itens do controle"));
            return items;
        }

        #region propertylist

        public string Nome
        {
            get { return linkedControl.Name; }
            set { GetPropertyByName("Name").SetValue(linkedControl, value); }
        }

        [EditorBrowsable(EditorBrowsableState.Always)
        , Browsable(true)
        , DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
        , Bindable(true), Editor(typeof(CaptionCollectionEditor),
        typeof(System.Drawing.Design.UITypeEditor))]
        public System.Windows.Forms.Control.ControlCollection Itens
        {
            get { return linkedControl.Item; }
            set { GetPropertyByName("Item").SetValue(linkedControl, value); }
        }

        #endregion

    }
}
