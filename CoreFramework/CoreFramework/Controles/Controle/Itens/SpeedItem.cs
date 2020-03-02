﻿using System;
using System.ComponentModel;

namespace CoreFramework.Controles.Controle.Itens
{
    public class SpeedItem
    {
        private int item = 0;
        private string valor = "valor";
        private string display = "";

        [Category("Custom")]
        [DefaultValue(typeof(int), "0")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Item
        {
            get { return item; }
            set { item = value; }
        }

        [Category("Custom")]
        [DefaultValue(typeof(string), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [Category("Custom")]
        [DefaultValue(typeof(string), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String Display
        {
            get { return display; }
            set { display = value; }
        }

        public SpeedItem()
        { }

        public SpeedItem(int pitem, String pvalor, String pdisplay)
        {
            this.Item = pitem;
            this.Valor = pvalor;
            this.Display = pdisplay;
        }
    }
}
