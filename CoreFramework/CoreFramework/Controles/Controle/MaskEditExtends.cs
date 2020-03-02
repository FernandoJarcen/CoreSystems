using CoreFramework.Controles.Controle.Designer;
using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(MaskEditDesigner))]
    public partial class MaskEditExtends : DesignControlBase
    {
        //private Enums.TipoControle tipoControle = Enums.TipoControle.Edicao;
        Label lbl_action = new Label();
        MaskedTextBox msk_action = new MaskedTextBox();
        private bool obrigatorio = false;
        private Enums.Mascaras padrao = Enums.Mascaras.Nulo;
        private Enums.Posicao posicao = Enums.Posicao.Horizontal;
        private Point localizacao;

        public MaskEditExtends()
        {
            inicializar();
            this.Size = new Size(150, 23);
            base.InicializarTipo(Enums.TipoControle.Edicao);
            atualizar();
        }

        #region Propriedades

        //[Browsable(false)]
        //public Enums.TipoControle TipoControle
        //{
        //    get
        //    {
        //        return tipoControle;
        //    }
        //}

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
        [Description("Texto da label")]
        public String Titulo
        {
            get
            {
                return lbl_action.Text;
            }

            set
            {
                lbl_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Valor do texto")]
        public string Valor
        {
            get
            {
                string retorno = string.Empty;
                retorno = msk_action.Text;
                if (verificarVazio())
                    retorno = string.Empty;
                if (!RetornaMascara)
                    retorno = limparCaracteres(retorno);
                return retorno;
            }
            set
            {
                msk_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return msk_action.Size.Width;
            }

            set
            {
                msk_action.Size = new System.Drawing.Size(value, 25);
            }
        }

        [Category("Custom")]
        [Description("Máscara do campo")]
        public string Mascara
        {
            get { return msk_action.Mask; }
            set { msk_action.Mask = value; }
        }

        [Category("Custom")]
        [Description("Verifica se o campo é obrigatorio")]
        public bool Obrigatorio
        {
            get { return obrigatorio; }
            set
            {
                obrigatorio = value;
                if (obrigatorio)
                {
                    this.msk_action.BackColor = SystemColors.Info;
                    this.lbl_action.ForeColor = SystemColors.HotTrack;
                    this.lbl_action.Text += "*";
                }
                else
                {
                    this.msk_action.BackColor = SystemColors.Window;
                    this.lbl_action.ForeColor = SystemColors.ControlText;
                    this.lbl_action.Text = lbl_action.Text.Replace("*", "");
                }
            }
        }

        [Category("Custom")]
        [Description("Tamanho máximo de caracteres")]
        public int ComprimentoMaximo
        {
            get { return this.msk_action.MaxLength; }
            set { this.msk_action.MaxLength = value; }
        }

        [Category("Custom")]
        [Description("Configura mascara padrão")]
        public Enums.Mascaras Padrao
        {
            get { return padrao; }
            set { padrao = value; inserirPadrao(); }
        }

        [Category("Custom")]
        [Description("Posição do titulo do controle")]
        public Enums.Posicao Posicao
        {
            get { return posicao; }
            set
            {
                posicao = value;
                if (posicao == Enums.Posicao.Vertical)
                {
                    this.msk_action.Dock = DockStyle.None;
                    localizacao = new Point(this.msk_action.Location.X, this.msk_action.Location.Y);
                    this.Size = new Size(this.Size.Width - this.lbl_action.Size.Width, this.Size.Height + 18);
                    Point pt = new Point(1, this.msk_action.Location.Y + 18);
                    this.msk_action.Location = pt;
                }
                else
                {
                    this.msk_action.Dock = DockStyle.Right;
                    this.msk_action.Location = localizacao;
                    this.Size = new Size(this.Size.Width + this.lbl_action.Size.Width, this.Size.Height - 18);
                }
            }
        }

        [Category("Custom")]
        [Description("Tipo de mascara")]
        public MaskFormat FormatoMascara
        {
            get { return msk_action.TextMaskFormat; }
            set { msk_action.TextMaskFormat = value; }
        }

        [Category("Custom")]
        [Description("Retornar Mascara?")]
        public bool RetornaMascara { get; set; }

        #endregion

        #region metodos

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Mask";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 4);
            lbl_action.Dock = DockStyle.Left;

            msk_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            msk_action.Dock = DockStyle.Right;
            msk_action.GotFocus += onFocus;
            msk_action.LostFocus += onDefocus;

            this.Controls.Add(lbl_action);
            this.Controls.Add(msk_action);
            this.SizeChanged += MaskEditExtends_SizeChanged;
            localizacao = new Point(this.msk_action.Location.X, this.msk_action.Location.Y);
        }

        private void inserirPadrao()
        {
            switch (padrao)
            {
                case Enums.Mascaras.CEP:
                    {
                        msk_action.Mask = "99.999-999";
                        break;
                    }
                case Enums.Mascaras.CPF:
                    {
                        msk_action.Mask = "999.999.999-99";
                        break;
                    }
                case Enums.Mascaras.CNPJ:
                    {
                        msk_action.Mask = "99.999.999/9999-99";
                        break;
                    }
                case Enums.Mascaras.RG:
                    {
                        msk_action.Mask = "99.999.999-A";
                        break;
                    }
                case Enums.Mascaras.Tel:
                    {
                        msk_action.Mask = "0000-0000";
                        break;
                    }
                case Enums.Mascaras.TelDDD:
                    {
                        msk_action.Mask = "(99)0000-0000";
                        break;
                    }
                case Enums.Mascaras.TelDDDLongo:
                    {
                        msk_action.Mask = "(999)0000-0000";
                        break;
                    }
                case Enums.Mascaras.Celular:
                    {
                        msk_action.Mask = "0000-0000";
                        break;
                    }
                case Enums.Mascaras.CelularDDD:
                    {
                        msk_action.Mask = "(99)00000-0000";
                        break;
                    }
                case Enums.Mascaras.CelularDDDLongo:
                    {
                        msk_action.Mask = "(999)00000-0000";
                        break;
                    }
                case Enums.Mascaras.Data:
                    {
                        msk_action.Mask = "99/99/99";
                        break;
                    }
                case Enums.Mascaras.DataLonga:
                    {
                        msk_action.Mask = "99/99/9999";
                        break;
                    }
                case Enums.Mascaras.Hora:
                    {
                        msk_action.Mask = "99:99";
                        break;
                    }
                case Enums.Mascaras.Nulo:
                    {
                        msk_action.Mask = String.Empty;
                        break;
                    }
                default:
                    break;
            }
        }

        public void Habilitar(bool status)
        {
            this.msk_action.Enabled = status;
        }

        private void validarMascara()
        {
            if (RetornaMascara)
                this.msk_action.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            else
                this.msk_action.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        public string limparCaracteres(string palavra)
        {
            string retorno = string.Empty;
            retorno = palavra;
            retorno = retorno.Replace(".", "");
            retorno = retorno.Replace("-", "");
            retorno = retorno.Replace("/", "");
            retorno = retorno.Replace("(", "");
            retorno = retorno.Replace(")", "");
            retorno = retorno.Replace(":", "");
            retorno = retorno.Replace("_", "");
            return retorno;
        }

        public bool verificarVazio()
        {
            bool retorno = false;
            string palavra = string.Empty;
            palavra = this.msk_action.Text;
            palavra = limparCaracteres(this.msk_action.Text);
            if (palavra.Length == 0)
                retorno = true;
            return retorno;
        }

        #endregion

        #region Eventos

        private void onFocus(object sender, EventArgs e)
        {
            this.msk_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void onDefocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.msk_action.BackColor = SystemColors.Info;
            else
                this.msk_action.BackColor = SystemColors.Window;
        }

        private void atualizar()
        {
            msk_action.Size = new Size(this.TamanhoTexto, 23);
        }

        private void MaskEditExtends_SizeChanged(object sender, EventArgs e)
        {
            if (posicao == Enums.Posicao.Vertical)
                msk_action.Dock = DockStyle.Bottom;
            else
                msk_action.Dock = DockStyle.Right;
        }

        #endregion
    }
}
