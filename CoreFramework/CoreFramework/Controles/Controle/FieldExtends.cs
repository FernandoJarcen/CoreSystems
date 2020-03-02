using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Forms;
using CoreFramework.Controles.Controle.Collection;
using CoreFramework.Controles.Controle.Editors;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Objetos;
using CoreFramework.Controles.Controle.Designer;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(FieldDesigner))]
    public partial class FieldExtends : DesignControlBase
    {
        //private Enums.TipoControle tipoControle = Enums.TipoControle.Edicao;
        public event EventHandler AoPerderFoco;
        public event EventHandler AoAlterarTexto;
        Label lbl_action = new Label();
        TextBox tbx_action = new TextBox();
        Button btn_action = new Button();

        private bool obrigatorio = false;
        private bool destacado = false;
        private Enums.ValidacaoCaracteres validacaoTexto = Enums.ValidacaoCaracteres.Nenhum;
        private Enums.TipoCaractere tipoCaractere = Enums.TipoCaractere.Nenhum;
        private Enums.Posicao posicao = Enums.Posicao.Horizontal;
        private Point localizacao;

        public FieldExtends()
        {
            inicializar();
            this.Size = new Size(150, 23);
            atualizar();
            base.InicializarTipo(Enums.TipoControle.Edicao);
        }

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
                    this.lbl_action.Text += "*";
                }
                else
                {
                    this.tbx_action.BackColor = SystemColors.Window;
                    this.lbl_action.ForeColor = SystemColors.ControlText;
                    this.lbl_action.Text = lbl_action.Text.Replace("*", "");
                }
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
        [Description("Valor destacado do cabeçalho")]
        public bool Destacado
        {
            get { return destacado; }
            set
            {
                destacado = value;
                if (destacado)
                {
                    this.lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                }
                else
                {
                    this.lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                }
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

        [Category("Custom")]
        [Description("Tipo de Caractere")]
        public Enums.TipoCaractere TipoCaractere
        {
            get { return tipoCaractere; }
            set
            {
                tipoCaractere = value;
                if (tipoCaractere == Enums.TipoCaractere.Nenhum)
                    tbx_action.CharacterCasing = CharacterCasing.Normal;
                else if (tipoCaractere == Enums.TipoCaractere.Maiuscula)
                    this.tbx_action.CharacterCasing = CharacterCasing.Upper;
                else
                    this.tbx_action.CharacterCasing = CharacterCasing.Lower;

            }
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
                    this.tbx_action.Dock = DockStyle.None;
                    localizacao = new Point(this.tbx_action.Location.X, this.tbx_action.Location.Y);
                    this.Size = new Size(this.Size.Width - this.lbl_action.Size.Width, this.Size.Height + 18);
                    Point pt = new Point(1, this.tbx_action.Location.Y + 18);
                    this.tbx_action.Location = pt;
                }
                else
                {
                    this.tbx_action.Dock = DockStyle.Right;
                    this.tbx_action.Location = localizacao;
                    this.Size = new Size(this.Size.Width + this.lbl_action.Size.Width, this.Size.Height - 18);
                }
            }
        }

        [Category("Custom")]
        [Description("AlinhamentoTexto")]
        public HorizontalAlignment AlinhamentoTexto
        {
            get { return tbx_action.TextAlign; }
            set { tbx_action.TextAlign = value; }
        }

        #endregion

        #region Metodos

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Field";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 4);
            lbl_action.Dock = DockStyle.Left;

            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.GotFocus += onFocus;
            tbx_action.LostFocus += onDefocus;
            tbx_action.KeyPress +=tbx_action_KeyPress;
            this.SizeChanged += FieldExtends_SizeChanged;
            this.tbx_action.TextChanged +=tbx_action_TextChanged;

            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
            ComprimentoMaximo = 50;            
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

        private void tbx_action_LostFocus(object sender, EventArgs e)
        {
            if (this.AoPerderFoco != null)
            {
                this.AoPerderFoco(this, e);
            }
        }

        void tbx_action_TextChanged(object sender, EventArgs e)
        {
            if (this.AoAlterarTexto != null)
            {
                this.AoAlterarTexto(this, e);
            }
        }

        private void FieldExtends_SizeChanged(object sender, EventArgs e)
        {
            if (posicao == Enums.Posicao.Vertical)
                tbx_action.Dock = DockStyle.Bottom;
            else
                tbx_action.Dock = DockStyle.Right;
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

        private void onFocus(object sender, EventArgs e)
        {
            this.tbx_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void onDefocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.tbx_action.BackColor = SystemColors.Info;
            else
                this.tbx_action.BackColor = SystemColors.Window;
            if (this.AoPerderFoco != null)
            {
                this.AoPerderFoco(this, e);
            }
        }

        #endregion        
      
    }
}
