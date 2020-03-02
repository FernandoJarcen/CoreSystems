using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class ComboActionList : System.ComponentModel.Design.DesignerActionList
    {
        private ComboBoxExtends linkedControl;

        public ComboActionList(ComboBoxExtends ctrl)
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
            items.Add(new DesignerActionHeaderItem("Dados"));
            items.Add(new DesignerActionHeaderItem("Designer"));
            items.Add(new DesignerActionPropertyItem("Nome", "Nome", "Controle", "Nome do controle"));
            items.Add(new DesignerActionPropertyItem("Titulo", "Titulo", "Controle", "Titulo do controle"));
            items.Add(new DesignerActionPropertyItem("TamanhoTexto", "TamanhoTexto", "Controle", "Tamanho do box"));
            items.Add(new DesignerActionPropertyItem("Query", "Query", "Dados", "Consulta"));
            items.Add(new DesignerActionPropertyItem("Display", "Display", "Dados", "Valor mostrado no componente"));
            items.Add(new DesignerActionPropertyItem("Chave", "Chave", "Dados", "Chave da consulta"));
            items.Add(new DesignerActionPropertyItem("Items", "Items", "Controle", "Itens do controle"));
            items.Add(new DesignerActionPropertyItem("Obrigatorio", "Obrigatorio", "Designer", "Controle Obrigatório"));
            items.Add(new DesignerActionPropertyItem("Dados", "Dados", "Designer", "Controle de Dados"));

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
        public int TamanhoTexto
        {
            get { return linkedControl.TamanhoTexto; }
            set { GetPropertyByName("TamanhoTexto").SetValue(linkedControl, value); }
        }
        public String Display
        {
            get { return linkedControl.Display; }
            set { GetPropertyByName("Display").SetValue(linkedControl, value); }
        }
        public String Chave
        {
            get { return linkedControl.Chave; }
            set { GetPropertyByName("Chave").SetValue(linkedControl, value); }
        }
        public String Query
        {
            get { return linkedControl.Query; }
            set { GetPropertyByName("Query").SetValue(linkedControl, value); }
        }
                [Category("Custom"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Localizable(true),
        Description("Itens"),
        Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, " + "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
        MergableProperty(false)]

        public ComboBox.ObjectCollection Items
        {
            get { return linkedControl.Items; }
            set { GetPropertyByName("Items").SetValue(linkedControl, value); }
        }
        public bool Obrigatorio
        {
            get { return linkedControl.Obrigatorio; }
            set { GetPropertyByName("Obrigatorio").SetValue(linkedControl, value); }
        }
        public bool Dados
        {
            get { return linkedControl.Dados; }
            set { GetPropertyByName("Dados").SetValue(linkedControl, value); }
        }

        #endregion
    }
}
