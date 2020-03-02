using System.ComponentModel;
using System.Windows.Forms;
using CoreStudio.Controles.Controle.Expandable;

namespace CoreStudio.Controles.Controle.Expandable
{
    [TypeConverter(typeof(FieldAttribute.FieldAppearanceConverter))]
    public class FieldExpandable
    {
        private Label _titulo = new Label();
        private Control _campo;

        internal FieldExpandable(Label titulo, Control action)
        {
            this._titulo = titulo;
            this._campo = action;
        }

        [
        Browsable(true),
        Field(),
        NotifyParentProperty(true),
        Category("Custom"),
        EditorBrowsable(EditorBrowsableState.Always),
        DefaultValue(1),
        ]
        public int Titulo
        {
            get
            {
                return _titulo.Size.Width;
            }
            set
            {
                _titulo.Size = new System.Drawing.Size(value, 23);
            }
        }

        [
        Browsable(true),
        Field(),
        NotifyParentProperty(true),
        Category("Custom"),
        EditorBrowsable(EditorBrowsableState.Always),
        DefaultValue(1),
        ]
        public int Campo
        {
            get
            {
                return _campo.Size.Width;
            }
            set
            {
                _campo.Size = new System.Drawing.Size(value, 23);
            }
        }
    }
}
