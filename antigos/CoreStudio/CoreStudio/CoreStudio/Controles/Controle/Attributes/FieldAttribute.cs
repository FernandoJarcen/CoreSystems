using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace CoreStudio.Controles.Controle.Expandable
{
    internal sealed class FieldAttribute : Attribute
    {
        public FieldAttribute()
        {
        }

        internal class FieldAppearanceConverter : ExpandableObjectConverter
        {

            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                if (destinationType == typeof(string))
                {
                    return "";
                }

                return base.ConvertTo(context, culture, value, destinationType);
            }

            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
            {
                if (context != null && context.Instance is Button)
                {
                    Attribute[] attributes2 = new Attribute[attributes.Length + 1];
                    attributes.CopyTo(attributes2, 0);
                    attributes2[attributes.Length] = new FieldAttribute();
                    attributes = attributes2;
                }

                return TypeDescriptor.GetProperties(value, attributes);
            }
        }

    }
}
