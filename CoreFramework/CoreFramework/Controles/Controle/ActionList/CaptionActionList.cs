using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle.ActionList
{
    public class CaptionActionList: System.ComponentModel.Design.DesignerActionList
    {
        private CaptionExtends linkedControl;
        public CaptionActionList(CaptionExtends ctrl): base(ctrl)
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
            items.Add(new DesignerActionPropertyItem("Imagem", "Imagem", "Controle", "Imagem do controle"));
            items.Add(new DesignerActionPropertyItem("Titulo", "Titulo", "Controle", "Titulo do controle"));
            items.Add(new DesignerActionPropertyItem("Subtitulo", "Subtitulo", "Controle", "Subtitulo do controle"));
            items.Add(new DesignerActionPropertyItem("Cor", "Cor", "Controle", "Cor do controle"));
            items.Add(new DesignerActionPropertyItem("CorTitulo", "Cortitulo", "Controle", "Cor do titulo do controle"));
            items.Add(new DesignerActionPropertyItem("CorSubtitulo", "CorSubtitulo", "Controle", "Cor do Subtitulo do controle"));
            items.Add(new DesignerActionPropertyItem("MostrarImagem", "MostrarImagem", "Controle", "Mostrar Imagem do controle"));
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

        public string Subtitulo
        {
            get { return linkedControl.Subtitulo; }
            set { GetPropertyByName("Subtitulo").SetValue(linkedControl, value); }
        }

        public Color Cor
        {
            get { return linkedControl.Cor; }
            set { GetPropertyByName("Cor").SetValue(linkedControl, value); }
        }

        public Color CorTitulo
        {
            get { return linkedControl.CorTitulo; }
            set { GetPropertyByName("CorTitulo").SetValue(linkedControl, value); }
        }

        public Color CorSubtitulo
        {
            get { return linkedControl.CorSubtitulo; }
            set { GetPropertyByName("CorSubtitulo").SetValue(linkedControl, value); }
        }

        public bool MostrarImagem
        {
            get { return linkedControl.MostrarImagem; }
            set { GetPropertyByName("MostrarImagem").SetValue(linkedControl, value); }
        }

        public Image Imagem
        {
            get { return linkedControl.Imagem; }
            set { GetPropertyByName("Imagem").SetValue(linkedControl, value); }
        }
        #endregion
    }
}
