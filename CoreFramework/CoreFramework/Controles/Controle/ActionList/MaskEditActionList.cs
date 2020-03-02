using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class MaskEditActionList : System.ComponentModel.Design.DesignerActionList
    {
        private MaskEditExtends linkedControl;

        public MaskEditActionList(MaskEditExtends ctrl): base(ctrl)
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
            items.Add(new DesignerActionPropertyItem("Mascara", "Mascara", "Controle", "Mascara do controle"));
            items.Add(new DesignerActionPropertyItem("Valor", "Valor", "Controle", "Valor do texto"));
            items.Add(new DesignerActionPropertyItem("Padrao", "Padrao", "Controle", "Padrão de máscara"));
            items.Add(new DesignerActionPropertyItem("TamanhoTexto", "TamanhoTexto", "Controle", "Tamanho do box"));
            items.Add(new DesignerActionPropertyItem("Obrigatorio", "Obrigatorio", "Designer", "Controle Obrigatório"));
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
        public String Mascara
        {
            get { return linkedControl.Mascara;}
            set { GetPropertyByName("Mascara").SetValue(linkedControl, value); }
        }
        public String Valor
        {
            get { return linkedControl.Valor; }
            set { GetPropertyByName("Valor").SetValue(linkedControl, value); }
        }
        public Enums.Mascaras Padrao
        {
            get { return linkedControl.Padrao; }
            set { GetPropertyByName("Padrao").SetValue(linkedControl, value); }
        }
        public int TamanhoTexto
        {
            get { return linkedControl.TamanhoTexto; }
            set { GetPropertyByName("TamanhoTexto").SetValue(linkedControl, value); }
        }
        public bool Obrigatorio
        {
            get { return linkedControl.Obrigatorio; }
            set { GetPropertyByName("Obrigatorio").SetValue(linkedControl, value); }
        }

        #endregion
    }
}
