using CoreFramework.Controles.Controle.Base;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using clr = System.Drawing;

namespace CoreFramework.Controles.Controle
{
    public partial class EntityItemExtends : DesignControlBase
    {
        System.Drawing.Color cor = SystemColors.GradientActiveCaption;

        public EntityItemExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Texto Valores")]
        public string Valor
        {
            get { return lbl_valor.Text; }
            set { lbl_valor.Text = value; }
        }

        [Category("Custom")]
        [Description("Texto Itens")]
        public string Item
        {
            get { return lbl_item.Text; }
            set { lbl_item.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do controle")]
        public clr.Color Cor
        {
            get { return cor; }
            set
            {
                cor = value;
                lbl_valor.BackColor = cor;
                lbl_item.BackColor = cor;
            }
        }

        [Category("Custom")]
        [Description("Cor do Texto Valor")]
        public clr.Color CorValor
        {
            get { return lbl_valor.ForeColor; }
            set { lbl_valor.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Cor do Texto Item")]
        public clr.Color CorItem
        {
            get { return lbl_item.ForeColor; }
            set { lbl_item.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Tamanho do Valor")]
        public int Tamanho
        {
            get { return lbl_valor.Size.Width; }
            set { lbl_valor.Size = new Size(value, this.Size.Height); }
        }

        #endregion

        #region metodos

        public void Valores(string valor, string item)
        {
            this.lbl_valor.Text = valor;
            this.lbl_item.Text = item;
        }

        public void Valores(string valor, string item, clr.Color cor)
        {
            this.lbl_valor.Text = valor;
            this.lbl_item.Text = item;
            this.lbl_item.ForeColor = cor;
        }

        public void Valores(string valor, string item, clr.Color cor, clr.Color fundo)
        {
            this.lbl_valor.Text = valor;
            this.lbl_item.Text = item;
            this.lbl_item.ForeColor = cor;
            this.lbl_item.BackColor = fundo;
        }

        public void Cores(clr.Color corValor)
        {
            this.lbl_valor.ForeColor = corValor;
        }

        public void Cores(clr.Color corValor, clr.Color corItem)
        {
            this.lbl_valor.ForeColor = corValor;
            this.lbl_item.ForeColor = corItem;
        }

        public void Cores(clr.Color corValor, clr.Color corItem, clr.Color fundoValor)
        {
            this.lbl_valor.ForeColor = corValor;
            this.lbl_item.ForeColor = corItem;
            this.lbl_valor.BackColor = fundoValor;
        }

        public void Cores(clr.Color corValor, clr.Color corItem, clr.Color fundoValor, clr.Color fundoItem)
        {
            this.lbl_valor.ForeColor = corValor;
            this.lbl_item.ForeColor = corItem;
            this.lbl_valor.BackColor = fundoValor;
            this.lbl_item.BackColor = fundoItem;
        }

        #endregion

        #region eventos

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Cor = SystemColors.GradientActiveCaption;
        }

        #endregion

    }
}
