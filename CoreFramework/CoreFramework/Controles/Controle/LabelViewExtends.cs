using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class LabelViewExtends : DesignControlBase
    {
        bool destacado = false;
        float tamanhoTitulo = 30;

        public LabelViewExtends()
        {
            InitializeComponent();
            //this.Size = new Size(150, 23);
            atualizar();
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
        public float TamanhoTitulo
        {
            get { return this.tlp_action.ColumnStyles[0].Width; }
            set
            {
                tamanhoTitulo = value;
                this.tlp_action.ColumnStyles[0].Width = tamanhoTitulo;
            }
        }

        #endregion

        #region metodos
                
        private void destaque()
        {
            if (destacado)
                this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Bold);
            else
                this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Regular);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            atualizar();
        }

        private void atualizar()
        {
            this.tlp_action.ColumnStyles[0].Width = TamanhoTitulo;
            destaque();
        }

        #endregion
    }
}
