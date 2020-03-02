using CoreFramework.Controles.Controle.Designer;
using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(CalculateDesigner))]

    public partial class CalculateExtends : DesignControlBase
    {
        public event EventHandler AoPerderFoco;
        public event EventHandler AoCalcular;
        public event EventHandler AoAlterarTexto;
        Label lbl_action = new Label();
        MaskedTextBox msk_action = new MaskedTextBox();
        Button btn_action = new Button();
        private bool obrigatorio = false;
        private bool destacado = false;
        private Enums.Posicao posicao = Enums.Posicao.Horizontal;
        private Point ret;
        private bool negrito = false;
        private Enums.ValidacaoCaracteres validacaoTexto = Enums.ValidacaoCaracteres.Nenhum;
        private bool calculado = false;

        public CalculateExtends()
        {
            inicializar();
            this.Size = new Size(196, 23);
            base.InicializarTipo(Enums.TipoControle.Edicao);
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
                return this.msk_action.Size.Width;
            }
            set
            {
                this.msk_action.Size = new System.Drawing.Size(value, 23);
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
        [Description("Cor do texto")]
        public System.Drawing.Color CorTexto
        {
            get { return this.msk_action.ForeColor; }
            set { this.msk_action.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Negritado")]
        public bool Negrito
        {
            get { return negrito; }
            set
            {
                negrito = value;
                if (negrito)
                    this.msk_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                else
                    this.msk_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            }
        }

        [Category("Custom")]
        [Description("Valor do controle")]
        public String Valor
        {
            get
            {
                return this.msk_action.Text;
            }
            set { this.msk_action.Text = value; }
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
                    ret = new Point(this.msk_action.Location.X, this.msk_action.Location.Y);
                    this.Size = new Size(this.Size.Width - this.lbl_action.Size.Width, this.Size.Height + 18);
                    Point pt = new Point(1, this.msk_action.Location.Y + 18);
                    this.msk_action.Location = pt;
                }
                else
                {
                    this.msk_action.Dock = DockStyle.Right;
                    this.msk_action.Location = ret;
                    this.Size = new Size(this.Size.Width + this.lbl_action.Size.Width, this.Size.Height - 18);
                }
            }
        }

        [Category("Custom")]
        [Description("Posicionamento do Texto")]
        [DefaultValue("HorizontalAlignment.Right")]
        public System.Windows.Forms.HorizontalAlignment AlinhamentoTexto
        {
            get { return msk_action.TextAlign; }
            set { msk_action.TextAlign = value; }
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
        [Description("Campo Calculado")]
        public bool Calculado
        {
            get { return calculado; }
            set
            {
                calculado = value;
                msk_action.ReadOnly = calculado;
            }
        }

        #endregion

        #region metodos

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Calc";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(5, 5);
            lbl_action.Dock = DockStyle.Left;

            msk_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            msk_action.Location = new Point(44, 1);
            msk_action.TextAlign = AlinhamentoTexto;
            msk_action.Size = new System.Drawing.Size(149, 23);
            msk_action.ForeColor = System.Drawing.Color.Maroon;
            msk_action.GotFocus += onFocus;
            msk_action.LostFocus += onDefocus;
            msk_action.Dock = DockStyle.Right;
            msk_action.KeyPress += msk_action_KeyPress;
            msk_action.TextChanged += msk_action_TextChanged;
            msk_action.LostFocus +=msk_action_LostFocus;

            this.Controls.Add(lbl_action);
            this.Controls.Add(msk_action);
            this.SizeChanged += CalculateExtends_SizeChanged;
            ret = new Point(this.msk_action.Location.X, this.msk_action.Location.Y);
        }

        public void Atualizar(object sender, EventArgs e)
        {
            if (this.AoCalcular != null)
            {
                this.AoCalcular(this, e);
            }
        }

        public void Habilitar(bool status)
        {
            this.msk_action.Enabled = status;
        }

        #endregion

        #region eventos

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            btn_action.Size = new Size(25, this.ClientSize.Height + 2);
            btn_action.Dock = DockStyle.Right;
            btn_action.Cursor = Cursors.Default;
            btn_action.Image = CoreFramework.Properties.Resources.limpar;
            btn_action.FlatStyle = FlatStyle.Flat;
            btn_action.ForeColor = Color.White;
            btn_action.FlatAppearance.BorderSize = 0;
            btn_action.Click += new EventHandler(acao_Click);

            this.msk_action.Controls.Add(btn_action);

            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn_action.Width << 16));
            base.InicializarTipo(Enums.TipoControle.Edicao);
        }

        private void acao_Click(object sender, EventArgs e)
        {
            msk_action.Text = string.Empty;
            msk_action.Focus();
        }
        private void msk_action_LostFocus(object sender, EventArgs e)
        {
            if (this.AoPerderFoco != null)
            {
                this.AoPerderFoco(this, e);
            }
        }

        private void msk_action_KeyPress(object sender, KeyPressEventArgs e)
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
            this.msk_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void onDefocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.msk_action.BackColor = SystemColors.Info;
            else
                this.msk_action.BackColor = SystemColors.Window;
        }

        private void CalculateExtends_SizeChanged(object sender, EventArgs e)
        {
            if (posicao == Enums.Posicao.Vertical)
                msk_action.Dock = DockStyle.Bottom;
            else
                msk_action.Dock = DockStyle.Right;
        }

        private void msk_action_TextChanged(object sender, EventArgs e)
        {
            if (this.AoAlterarTexto != null)
            {
                this.AoAlterarTexto(this, e);
            }
        }

        #endregion
    }
}
