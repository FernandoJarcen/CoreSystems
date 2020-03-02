using CoreFramework.Controles.Controle.Collection;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class SpeedButtonActionList : System.ComponentModel.Design.DesignerActionList
    {
        private SpeedButtonExtends linkedControl;
        public SpeedButtonActionList(SpeedButtonExtends ctrl)
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
            items.Add(new DesignerActionHeaderItem("Consulta"));
            items.Add(new DesignerActionHeaderItem("Designer"));
            items.Add(new DesignerActionPropertyItem("Nome", "Nome", "Controle", "Nome do controle"));
            items.Add(new DesignerActionPropertyItem("Titulo", "Titulo", "Controle", "Titulo do controle"));
            items.Add(new DesignerActionPropertyItem("Item", "Item", "Controle", "Itens do controle"));
            items.Add(new DesignerActionPropertyItem("Editavel", "Editavel", "Designer", "Designer editavel"));
            items.Add(new DesignerActionPropertyItem("Obrigatorio", "Obrigatorio", "Designer", "obrigatorio"));
            items.Add(new DesignerActionPropertyItem("Destino", "Destino", "Designer", "Controle destino"));
            items.Add(new DesignerActionPropertyItem("Tamanho", "TamanhoTexto", "Designer", "Controle editavel"));

            return items;
        }

        #region propertylist

        public string Nome
        {
            get { return linkedControl.Name; }
            set { GetPropertyByName("Name").SetValue(linkedControl, value); }
        }

        public string Titulo
        {
            get { return linkedControl.Titulo; }
            set { GetPropertyByName("Titulo").SetValue(linkedControl, value); }
        }

        public Label Destino
        {
            get
            {
                return linkedControl.Destino;
            }
            set
            {
                GetPropertyByName("Destino").SetValue(linkedControl, value);
            }
        }

        public bool Editavel
        {
            get { return linkedControl.Editavel; }
            set { GetPropertyByName("Editavel").SetValue(linkedControl, value); }
        }

        public bool Obrigatorio
        {
            get { return linkedControl.Obrigatorio; }
            set { GetPropertyByName("Obrigatorio").SetValue(linkedControl, value); }
        }

        public int Tamanho
        {
            get { return linkedControl.TamanhoTexto; }
            set { GetPropertyByName("TamanhoTexto").SetValue(linkedControl, value); }
        }

        public SpeedItemCollection Item
        {
            get { return linkedControl.Items; }
            set { GetPropertyByName("Items").SetValue(linkedControl, value); }
        }
        #endregion

    }
}
