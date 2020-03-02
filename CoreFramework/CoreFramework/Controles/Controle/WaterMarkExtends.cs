using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public partial class WaterMarkExtends : DesignControlBase
    {
        public event EventHandler AoAlterarTexto;
        Label lbl_action = new Label();
        TextBoxExtends tbx_action = new TextBoxExtends();

        private bool obrigatorio = false;
        private string waterMarkText = "Water Mark";
        private Enums.ValidacaoCaracteres validacaoTexto = Enums.ValidacaoCaracteres.Nenhum;

        #region Propriedades

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
                return this.lbl_action.Text;
            }

            set
            {
                this.lbl_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return this.tbx_action.Size.Width;
            }

            set
            {
                this.tbx_action.Size = new System.Drawing.Size(value, 23);
            }
        }

        [Category("Custom")]
        [Description("Valor do controle")]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public String Valor
        {
            get
            {
                return this.tbx_action.Text;
            }
            set { this.tbx_action.Text = value; }
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
                    this.tbx_action.BackColor = SystemColors.Info;
                    this.lbl_action.ForeColor = SystemColors.HotTrack;
                    this.lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                }
                else
                {
                    this.tbx_action.BackColor = SystemColors.Window;
                    this.lbl_action.ForeColor = SystemColors.ControlText;
                    this.lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                }
            }
        }

        [Category("Custom")]
        [Description("Configura o texto da marca dagua")]
        public string TextoMarca
        {
            get { return waterMarkText; }
            set
            {
                waterMarkText = value;
                tbx_action.MarcaDagua = value;
            }
        }

        [Category("Custom")]
        [Description("Tipo de validação de texto")]
        public Enums.ValidacaoCaracteres ValidacaoTexto
        {
            get { return validacaoTexto; }
            set
            {
                validacaoTexto = value;
            }
        }

        [Category("Custom")]
        [Description("Tipo de Caractere de texto")]
        public char Caractere
        {
            get { return this.tbx_action.PasswordChar; }
            set { this.tbx_action.PasswordChar = value; }
        }

        [Category("Custom")]
        [Description("Tamanho máximo de caracteres")]
        public int ComprimentoMaximo
        {
            get { return this.tbx_action.MaxLength; }
            set { this.tbx_action.MaxLength = value; }
        }

        #endregion

        #region Metodos

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Water";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 2);

            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.KeyPress +=tbx_action_KeyPress;
            tbx_action.TextChanged +=tbx_action_TextChanged;

            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
        }

        public int Quantidade()
        {
            return tbx_action.Text.Length;
        }

        private void atualizar()
        {
            tbx_action.Size = new Size(this.TamanhoTexto, 23);
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        #endregion

        #region Eventos

        private void tbx_action_TextChanged(object sender, EventArgs e)
        {
            if (this.AoAlterarTexto != null)
            {
                this.AoAlterarTexto(this, e);
            }
        }

        private void tbx_action_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validacaoTexto == Enums.ValidacaoCaracteres.Texto)
            {
                if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
            else if (validacaoTexto == Enums.ValidacaoCaracteres.Numeros)
            {
                if (!(Char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
            else if (validacaoTexto == Enums.ValidacaoCaracteres.Decimais)
            {
                if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == (char)44))
                    e.Handled = true;
            }
            else e.Handled = false;
        }

        #endregion

        public WaterMarkExtends()
        {
            inicializar();
            this.Size = new Size(150, 23);
            atualizar();
        }
    }
}
