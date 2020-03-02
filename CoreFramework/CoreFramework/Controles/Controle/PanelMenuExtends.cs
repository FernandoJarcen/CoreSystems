using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoreFramework.Controles.Controle.Editors;

namespace CoreFramework.Controles.Controle
{
    public class PanelMenuExtends:Panel
    {
        public void New()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(0);
        }

        [Category("Custom")]
        [Description("Grupo de Itens")]
        [EditorBrowsable(EditorBrowsableState.Always)
        , Browsable(true)
        , DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
        , Bindable(true), Editor(typeof(MenuCollectionEditor),
        typeof(System.Drawing.Design.UITypeEditor))]
        public ControlCollection Item
        {
            get { return base.Controls; }
            set { }
        }
    }
}
