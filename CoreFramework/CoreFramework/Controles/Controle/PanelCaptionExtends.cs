using CoreFramework.Controles.Controle.Designer;
using CoreFramework.Controles.Controle.Editors;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(PanelCaptionDesigner))]

    public class PanelCaptionExtends:Panel
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
        , Bindable(true), Editor(typeof(CaptionCollectionEditor),
        typeof(System.Drawing.Design.UITypeEditor))]
        public ControlCollection Item
        {
            get { return base.Controls; }
            set { }
        }
    }
}
