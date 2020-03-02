using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Controles.Controle.Designer;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(LabelDesigner))]

    public partial class LabelExtends : DesignControlBase
    {
        bool destacado = false;
        int tamanhoTitulo = 20;

        public LabelExtends()
        {
            InitializeComponent();
            inicializar();
        }

        #region propriedades

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

        [Category("Custom")]
        [Description("Alinhar a Esquerda")]
        public RightToLeft AlinhamentoEsquerda
        {
            get { return lbl_valor.RightToLeft; }
            set
            {
                lbl_valor.RightToLeft = value;
                Invalidate();
            }
        }

        private void destaque()
        {
            if (destacado)
                this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Bold);
            else
                this.lbl_valor.Font = new Font("Microsoft Sans Serif", this.lbl_valor.Font.Size, FontStyle.Regular);
        }

        private void inicializar()
        {
            lbl_valor.Location = new Point(2, 4);
            lbl_valor.RightToLeft = AlinhamentoEsquerda;
        }

        private void atualizar()
        {
            lbl_titulo.Size = new Size(tamanhoTitulo, this.Height);
            Invalidate();
        }

        #endregion

    }
}
