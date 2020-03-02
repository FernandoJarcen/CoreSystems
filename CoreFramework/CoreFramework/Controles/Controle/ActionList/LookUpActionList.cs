using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class LookUpActionList : System.ComponentModel.Design.DesignerActionList
    {
        private LookUpExtends linkedControl;
        public LookUpActionList(LookUpExtends ctrl)
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
            items.Add(new DesignerActionPropertyItem("Query", "Query", "Consulta", "query"));
            items.Add(new DesignerActionPropertyItem("Secundaria", "Secundaria", "Consulta", "query secundaria"));
            items.Add(new DesignerActionPropertyItem("Display", "Display", "Consulta", "Dado a ser mostrado no controle"));
            items.Add(new DesignerActionPropertyItem("Chave", "Chave", "Consulta", "Controle editavel"));
            items.Add(new DesignerActionPropertyItem("Editavel", "Editavel", "Designer", "Designer editavel"));
            items.Add(new DesignerActionPropertyItem("Obrigatorio", "Obrigatorio", "Designer", "obrigatorio"));
            items.Add(new DesignerActionPropertyItem("Ocultar", "Ocultar", "Designer", "ocultar chave"));
            items.Add(new DesignerActionPropertyItem("Dinam", "Dinamico", "Designer", "Controle editavel"));
            items.Add(new DesignerActionPropertyItem("Destino", "Destino", "Designer", "Controle destino"));
            items.Add(new DesignerActionPropertyItem("Validacao", "ValidacaoTexto", "Designer", "Validação do texto"));
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

        public string Query
        {
            get { return linkedControl.Query; }
            set { GetPropertyByName("Query").SetValue(linkedControl, value); }
        }

        public string Secundaria
        {
            get { return linkedControl.Secundaria; }
            set { GetPropertyByName("Secundaria").SetValue(linkedControl, value); }
        }

        public string Display
        {
            get { return linkedControl.Display; }
            set { GetPropertyByName("Display").SetValue(linkedControl, value); }
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

        public string Chave
        {
            get { return linkedControl.Chave; }
            set { GetPropertyByName("Chave").SetValue(linkedControl, value); }
        }

        public bool Dinam
        {
            get { return linkedControl.Dinamico; }
            set { GetPropertyByName("Dinamico").SetValue(linkedControl, value); }
        }

        public bool Obrigatorio
        {
            get { return linkedControl.Obrigatorio; }
            set { GetPropertyByName("Obrigatorio").SetValue(linkedControl, value); }
        }

        public bool Ocultar
        {
            get { return linkedControl.Ocultar; }
            set { GetPropertyByName("Ocultar").SetValue(linkedControl, value); }
        }

        public int Tamanho
        {
            get { return linkedControl.TamanhoTexto; }
            set { GetPropertyByName("TamanhoTexto").SetValue(linkedControl, value); }
        }

        public Enums.ValidacaoCaracteres Validacao
        {
            get { return linkedControl.ValidacaoTexto; }
            set { GetPropertyByName("ValidacaoTexto").SetValue(linkedControl, value); }
        }

        #endregion
    }
}
