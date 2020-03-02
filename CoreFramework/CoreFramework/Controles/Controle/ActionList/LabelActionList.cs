using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class LabelActionList: System.ComponentModel.Design.DesignerActionList
    {
        private LabelExtends linkedControl;
        public LabelActionList(LabelExtends ctrl)
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
            items.Add(new DesignerActionHeaderItem("Designer"));
            items.Add(new DesignerActionPropertyItem("Nome", "Nome", "Controle", "Nome do controle"));
            items.Add(new DesignerActionPropertyItem("Titulo", "Titulo", "Controle", "Titulo do controle"));
            items.Add(new DesignerActionPropertyItem("Valor", "Valor", "Controle", "Valor do controle"));
            items.Add(new DesignerActionPropertyItem("Alinhamento", "AlinhamentoEsquerda", "Designer", "Alinhamento"));
            items.Add(new DesignerActionPropertyItem("TamanhoTitulo", "TamanhoTitulo", "Designer", "Tamanho do titulo do controle"));
            items.Add(new DesignerActionPropertyItem("TamanhoTextoTitulo", "TamanhoTextoTitulo", "Designer", "Tamanho do titulo do controle"));
            items.Add(new DesignerActionPropertyItem("TamanhoTextoValor", "TamanhoTextoValor", "Designer", "Tamanho do valor do controle"));
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

        public string Valor
        {
            get { return linkedControl.Valor; }
            set { GetPropertyByName("Valor").SetValue(linkedControl, value); }
        }

        public RightToLeft Alinhamento
        {
            get { return linkedControl.AlinhamentoEsquerda; }
            set { GetPropertyByName("AlinhamentoEsquerda").SetValue(linkedControl, value); }
        }

        public float TamanhoTextoTitulo
        {
            get { return linkedControl.TamanhoTextoTitulo; }
            set { GetPropertyByName("TamanhoTextoValor").SetValue(linkedControl, value); }
        }

        public float TamanhoTextoValor
        {
            get { return linkedControl.TamanhoTextoValor; }
            set { GetPropertyByName("TamanhoTextoValor").SetValue(linkedControl, value); }
        }

        public int TamanhoTitulo
        {
            get { return linkedControl.TamanhoTitulo; }
            set { GetPropertyByName("TamanhoTitulo").SetValue(linkedControl, value); }
        }
        #endregion
    }
}