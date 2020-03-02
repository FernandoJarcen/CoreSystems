using System;
using System.ComponentModel;
using System.Drawing;
using CoreFramework.Controles.Controle.Base;

namespace CoreFramework.Controles.Controle
{
    public partial class FilterDataExtends : DesignControlBase
    {
        private bool ativado = true;

        public FilterDataExtends()
        {
            InitializeComponent();
            inicializar();
            this.Size = new Size(453, 29);
            atualizar();
        }


        #region propriedades
        [Category("Custom")]
        [Description("Tamanho")]
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
        [Description("Texto do Titulo")]
        public string Titulo
        {
            get { return chk_action.Text; }
            set { chk_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Controle Ativado")]
        public bool Ativado
        {
            get { return ativado; }
            set
            {
                ativado = value;
                chk_action.Checked = ativado;
            }
        }

        [Category("Custom")]
        [Description("Texto da primeira opção")]
        public string Opcao1
        {
            get { return dte_opcao1.Valor; }
            set { dte_opcao1.Valor = value; }
        }

        [Category("Custom")]
        [Description("Texto da segunda opção")]
        public string Opcao2
        {
            get { return dte_opcao2.Valor; }
            set { dte_opcao2.Valor = value; }
        }

        [Category("Custom")]
        [Description("Titulo da primeira opção")]
        public string TituloOpcao1
        {
            get { return dte_opcao1.Titulo; }
            set { dte_opcao1.Titulo = value; }
        }

        [Category("Custom")]
        [Description("Titulo da segunda opção")]
        public string TituloOpcao2
        {
            get { return dte_opcao2.Titulo; }
            set { dte_opcao2.Titulo = value; }
        }

        [Category("Custom")]
        [Description("Tamanho da primeira opcao")]
        public int TamanhoOpcao1
        {
            get { return dte_opcao1.Size.Width; }
            set { dte_opcao1.Size = new Size(value, dte_opcao1.Size.Height); }
        }

        [Category("Custom")]
        [Description("Tamanho da segunda opcao")]
        public int TamanhoOpcao2
        {
            get { return dte_opcao2.Size.Width; }
            set { dte_opcao2.Size = new Size(value, dte_opcao2.Size.Height); }
        }   

        [Category("Custom")]
        public int PosicaoOpcao1
        {
            get { return dte_opcao1.Location.X; }
            set { dte_opcao1.Location = new Point(value, 3); }
        }

        [Category("Custom")]
        public int PosicaoOpcao2
        {
            get { return dte_opcao2.Location.X; }
            set { 
                dte_opcao2.Location = new Point(value, 3);
                int valor = value + 183;
                this.Size = new Size(valor, this.Size.Height);
            }
        }
        
        #endregion

        #region metodos
        
        #endregion

        #region eventos

        private void inicializar()
        {
            this.Size = new System.Drawing.Size(Tamanho, 29);
            chk_action.Checked = ativado;
        }

        private void chk_action_CheckedChanged(object sender, EventArgs e)
        {
            ativado = chk_action.Checked;
        }

        private void atualizar()
        {
            this.Size = new System.Drawing.Size(Tamanho, 29);
        }

        #endregion
    }
}
