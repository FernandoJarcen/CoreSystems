using System;
using System.ComponentModel;
using System.Drawing;
using CoreFramework.Controles.Controle.Base;

namespace CoreFramework.Controles.Controle
{
    public partial class ResultExtends : DesignControlBase
    {
        bool destacado = false;
        int tamanhoTitulo = 20;
        public event EventHandler AoAlterar;

        public ResultExtends()
        {
            InitializeComponent();
        }

        #region propriedade

        [Category("Custom")]
        [Description("Tamanho do controle")]
        public int Tamanho
        {
            get
            {
                return this.Width;
            }

            set
            {
                this.Width = value;
            }
        }

        [Category("Custom")]
        [Description("Tamanho do controle")]
        public String Titulo
        {
            get
            {
                return this.lbl_titulo.Text;
            }

            set
            {
                this.lbl_titulo.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Tamanho do controle")]
        public String Valor
        {
            get
            {
                return this.lbl_valor.Text;
            }

            set
            {
                this.lbl_valor.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Cor Titulo")]
        public System.Drawing.Color CorTitulo
        {
            get { return this.lbl_titulo.ForeColor; }
            set { lbl_titulo.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Cor Valor")]
        public System.Drawing.Color CorValor
        {
            get { return this.lbl_valor.ForeColor; }
            set { this.lbl_valor.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Destacar os valores")]
        public bool MostrarDestacado
        {
            get { return destacado; }
            set
            {
                destacado = value;
                if (destacado)
                    this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Bold);
                else
                    this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Regular);
            }
        }

        [Category("Custom")]
        [Description("Tamanho do componente")]
        public float TamanhoTextoValor
        {
            get { return lbl_valor.Font.Size; }
            set
            {
                lbl_valor.Font = new Font("Microsoft Sans Serif", value, FontStyle.Regular);
            }
        }

        [Category("Custom")]
        public float TamanhoTextoTitulo
        {
            get { return lbl_titulo.Font.Size; }
            set
            {
                lbl_titulo.Font = new Font("Microsoft Sans Serif", value, FontStyle.Regular);
                destaque();
            }
        }

        [Category("Custom")]
        [Description("Tamanho do Titulo do controle")]
        public int TamanhoTitulo
        {
            get { return lbl_titulo.Size.Width; }
            set
            {
                tamanhoTitulo = value;
                lbl_titulo.Size = new Size(tamanhoTitulo, this.Height);
            }
        }

        #endregion

        private void destaque()
        {
            if (destacado)
                this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Bold);
            else
                this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Regular);
        }

        private void lbl_valor_TextChanged(object sender, EventArgs e)
        {
            if (this.AoAlterar != null)
            {
                this.AoAlterar(this, e);
            }
        }
    }
}
