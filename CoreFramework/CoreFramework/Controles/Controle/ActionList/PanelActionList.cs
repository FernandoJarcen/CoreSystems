using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class PanelActionList : System.ComponentModel.Design.DesignerActionList
    {
        private PanelExtends linkedControl;
        public PanelActionList(PanelExtends ctrl)
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
            items.Add(new DesignerActionHeaderItem("Design"));
            items.Add(new DesignerActionPropertyItem("Nome", "Nome", "Controle", "Nome do controle"));
            items.Add(new DesignerActionPropertyItem("Cabecalho", "Cabecalho", "Controle", "Texto"));
            items.Add(new DesignerActionPropertyItem("Cor", "Cor", "Controle", "altera a cor"));
            items.Add(new DesignerActionPropertyItem("TipoPainel", "TipoPainel", "Design", "Tipo de Painel"));
            items.Add(new DesignerActionPropertyItem("Centralizar", "Centralizar", "Design", "Centralizar"));
            return items;
        }

        #region propertylist

        public string Nome
        {
            get { return linkedControl.Name; }
            set { GetPropertyByName("Name").SetValue(linkedControl, value); }
        }

        public Color Cor
        {
            get { return linkedControl.Cor; }
            set { GetPropertyByName("Cor").SetValue(linkedControl, value); }
        }

        public string Cabecalho
        {
            get { return linkedControl.Cabecalho; }
            set { GetPropertyByName("Cabecalho").SetValue(linkedControl, value); }
        }

        public Enums.TipoPainel TipoPainel
        {
            get { return linkedControl.TipoPainel; }
            set { GetPropertyByName("TipoPainel").SetValue(linkedControl, value); }
        }

        public bool Centralizar
        {
            get { return linkedControl.Centralizar; }
            set { GetPropertyByName("Centralizar").SetValue(linkedControl, value); }
        }

        #endregion
    }
}
