using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class CaptionGridActionList : System.ComponentModel.Design.DesignerActionList
    {
        private CaptionGridExtends linkedControl;
        public CaptionGridActionList(CaptionGridExtends ctrl)
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
            items.Add(new DesignerActionPropertyItem("Query", "Query", "Controle", "Consulta"));
            items.Add(new DesignerActionPropertyItem("Chave", "Chave", "Controle", "Chave da consulta"));
            items.Add(new DesignerActionPropertyItem("Cabecalho", "Cabecalho", "Controle", "Chave da consulta"));
            items.Add(new DesignerActionPropertyItem("CorCabecalho", "CorCabecalho", "Designer", "Mostrar Cabeçalho"));
            items.Add(new DesignerActionPropertyItem("CorTextoCabecalho", "CorTextoCabecalho", "Designer", "Mostrar Cabeçalho"));
            items.Add(new DesignerActionPropertyItem("TamanhoCombo", "TamanhoCombo", "Controle", "Tamanho do combo"));
            items.Add(new DesignerActionPropertyItem("TamanhoTexto", "TamanhoTexto", "Controle", "Tamanho do texto"));
            items.Add(new DesignerActionPropertyItem("MostrarCabecalho", "MostrarCabecalho", "Designer", "Mostrar Cabeçalho"));
            items.Add(new DesignerActionPropertyItem("MostrarFiltro", "MostrarFiltro", "Designer", "Mostrar Filtro"));
            items.Add(new DesignerActionPropertyItem("MostrarRodape", "MostrarRodape", "Designer", "Mostrar Rodapé"));
            return items;
        }

        #region propertylist

        public string Nome
        {
            get { return linkedControl.Name; }
            set { GetPropertyByName("Name").SetValue(linkedControl, value); }
        }

        public string Query
        {
            get { return linkedControl.Query; }
            set { GetPropertyByName("Query").SetValue(linkedControl, value); }
        }

        public string Chave
        {
            get { return linkedControl.Chave; }
            set { GetPropertyByName("Chave").SetValue(linkedControl, value); }
        }

        public string Cabecalho
        {
            get { return linkedControl.Cabecalho; }
            set { GetPropertyByName("Cabecalho").SetValue(linkedControl, value); }
        }
        public int TamanhoCombo
        {
            get { return linkedControl.TamanhoCombo; }
            set { GetPropertyByName("TamanhoCombo").SetValue(linkedControl, value); }
        }
        public int TamanhoTexto
        {
            get { return linkedControl.TamanhoTexto; }
            set { GetPropertyByName("TamanhoTexto").SetValue(linkedControl, value); }
        }

        public Color CorCabecalho
        {
            get { return linkedControl.CorCabecalho; }
            set { GetPropertyByName("CorCabecalho").SetValue(linkedControl, value); }
        }

        public Color CorTextoCabecalho
        {
            get { return linkedControl.CorTextoCabecalho; }
            set { GetPropertyByName("CorTextoCabecalho").SetValue(linkedControl, value); }
        }
        public bool MostrarCabecalho
        {
            get { return linkedControl.MostrarCabecalho; }
            set { GetPropertyByName("MostrarCabecalho").SetValue(linkedControl, value); }
        }

        public bool MostrarFiltro
        {
            get { return linkedControl.MostrarFiltro; }
            set { GetPropertyByName("MostrarFiltro").SetValue(linkedControl, value); }
        }

        public bool MostrarRodape
        {
            get { return linkedControl.MostrarRodape; }
            set { GetPropertyByName("MostrarRodape").SetValue(linkedControl, value); }
        }

        #endregion
    }
}
