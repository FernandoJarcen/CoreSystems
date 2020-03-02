using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.Controles.Controle.Itens
{
    public class ReferenceItem
    {
        [Category("Custom")]
        [DefaultValue(typeof(int), "0")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Item { get; set; }

        [Category("Custom")]
        [DefaultValue(typeof(string), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String Valor { get; set; }


        [Category("Custom")]
        [DefaultValue(typeof(string), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String Display { get; set; }

        public ReferenceItem() { }

        public ReferenceItem(int pitem, String pvalor, String pdisplay)
        {
            this.Item = pitem;
            this.Valor = pvalor;
            this.Display = pdisplay;
        }
    }
}
