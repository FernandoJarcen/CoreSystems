using CoreFramework.Controles.Controle.Editors;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public class PanelImageExtends:Panel
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
        , Bindable(true), Editor(typeof(ImageCollectionEditor),
        typeof(System.Drawing.Design.UITypeEditor))]
        public ControlCollection Item
        {
            get { return base.Controls; }
            set { }
        }
    }
}
