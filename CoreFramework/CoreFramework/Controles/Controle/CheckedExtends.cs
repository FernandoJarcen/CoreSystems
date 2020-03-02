using CoreFramework.Controles.Controle.Designer;
using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;


namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(CheckedDesigner))]
    public partial class CheckedExtends : DesignControlBase
    {
        CheckBox chk_action = new CheckBox();
        TextBox tbx_action = new TextBox();
        private bool obrigatorio = false;
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
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return this.tbx_action.Size.Width;
            }

            set
            {
                this.tbx_action.Size = new System.Drawing.Size(value, 22);
            }
        }

        [Category("Custom")]
        [Description("Texto da label")]
        public String Titulo
        {
            get
            {
                return this.chk_action.Text;
            }

            set
            {
                this.chk_action.Text = value;
            }
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
                    this.chk_action.ForeColor = SystemColors.HotTrack;
                    this.chk_action.Text += "*";
                }
                else
                {
                    this.tbx_action.BackColor = SystemColors.Window;
                    this.chk_action.ForeColor = SystemColors.ControlText;
                    this.chk_action.Text = chk_action.Text.Replace("*", "");
                }
            }
        }

        [Category("Custom")]
        [Description("Valor do checkbox")]
        public bool Ativado
        {
            get
            {
                return this.chk_action.Checked;
            }
            set
            {
                this.chk_action.Checked = value;
            }
        }

        [Category("Custom")]
        [Description("Valor do combo")]
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
            chk_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            chk_action.Checked = true;
            chk_action.Location = new Point(2, 1);
            chk_action.Text = "Check";
            chk_action.AutoSize = true;
            chk_action.CheckedChanged += chk_action_CheckedChanged;


            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.GotFocus += OnFocus;
            tbx_action.LostFocus += OnDefocus;
            tbx_action.KeyPress +=tbx_action_KeyPress;

            this.Controls.Add(chk_action);
            this.Controls.Add(tbx_action);
            ComprimentoMaximo = 50;
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

        private void OnFocus(object sender, EventArgs e)
        {
            this.tbx_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void OnDefocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.tbx_action.BackColor = SystemColors.Info;
            else
                this.tbx_action.BackColor = SystemColors.Window;
        }
        
        private void atualiza()
        {
            tbx_action.Size = new Size(this.TamanhoTexto, 23);
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        #endregion

        #region eventos
        
        void chk_action_CheckedChanged(object sender, EventArgs e)
        {
            tbx_action.Enabled = chk_action.Checked;
            if (chk_action.Checked == false)
                tbx_action.Text = String.Empty;
            else
                tbx_action.Focus();
        }
        
        #endregion

        public CheckedExtends()
        {
            inicializar();
            this.Size = new Size(200, 23);
            atualiza();
        }
    }
}
