using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class CalculateActionList : System.ComponentModel.Design.DesignerActionList
    {
        private CalculateExtends linkedControl;
        public CalculateActionList(CalculateExtends ctrl)
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
            items.Add(new DesignerActionPropertyItem("Valor", "Valor", "Controle", "Valor Controle"));
            items.Add(new DesignerActionPropertyItem("TamanhoTexto", "TamanhoTexto", "Controle", "Tamanho Texto"));
            items.Add(new DesignerActionPropertyItem("ValidacaoTexto", "ValidacaoTexto", "Controle", "Validacao Texto"));
            items.Add(new DesignerActionPropertyItem("Obrigatorio", "Obrigatorio", "Designer", "Campo Obrigatorio"));
            items.Add(new DesignerActionPropertyItem("Cor", "Cor", "Designer", "Cor do Texto"));
            items.Add(new DesignerActionPropertyItem("Calculado", "Calculado", "Designer", "Campo Calculado"));
            items.Add(new DesignerActionPropertyItem("Destacado", "Destacado", "Designer", "Campo Destacado"));
            items.Add(new DesignerActionPropertyItem("Negrito", "Negrito", "Designer", "Campo em Negrito"));

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

        public int TamanhoTexto
        {
            get { return linkedControl.TamanhoTexto; }
            set { GetPropertyByName("TamanhoTexto").SetValue(linkedControl, value); }
        }

        public Enums.ValidacaoCaracteres ValidacaoTexto
        {
            get { return linkedControl.ValidacaoTexto; }
            set { GetPropertyByName("ValidacaoTexto").SetValue(linkedControl, value); }
        }

        public Color Cor
        {
            get { return linkedControl.CorTexto; }
            set { GetPropertyByName("CorTexto").SetValue(linkedControl, value); }
        }

        public bool Calculado
        {
            get { return linkedControl.Calculado; }
            set { GetPropertyByName("Calculado").SetValue(linkedControl, value); }
        }

        public bool Destacado
        {
            get { return linkedControl.Destacado; }
            set { GetPropertyByName("Destacado").SetValue(linkedControl, value); }
        }

        public bool Negrito
        {
            get { return linkedControl.Negrito; }
            set { GetPropertyByName("Negrito").SetValue(linkedControl, value); }
        }

        public bool Obrigatorio
        {
            get { return linkedControl.Obrigatorio; }
            set { GetPropertyByName("Obrigatorio").SetValue(linkedControl, value); }
        }

        #endregion
    }
}
