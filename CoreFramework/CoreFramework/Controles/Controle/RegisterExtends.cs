using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using enm = CoreFramework.Objetos.Enums;

namespace CoreFramework.Controles.Controle
{
    public partial class RegisterExtends : DesignControlBase
    {
        Label lbl_action = new Label();
        TextBox tbx_action = new TextBox();
        Button btn_action = new Button();
        public event EventHandler AoChamar;
        private bool obrigatorio = false;
        private bool editavel = true;
        private enm.Posicao posicao = enm.Posicao.Horizontal;
        private Point localizacao;

        public RegisterExtends()
        {
            inicializar();
            this.Size = new Size(196, 23);
            atualizar();
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
        [Description("Habilitado para edição?")]
        public bool Editavel
        {
            get { return editavel; }
            set
            {
                editavel = value;
                if (editavel)
                    tbx_action.ReadOnly = false;
                else
                    tbx_action.ReadOnly = true;
            }
        }

        [Category("Custom")]
        [Description("Posição do titulo do controle")]
        public enm.Posicao Posicao
        {
            get { return posicao; }
            set
            {
                posicao = value;
                if (posicao == enm.Posicao.Vertical)
                {
                    this.tbx_action.Dock = DockStyle.None;
                    localizacao = new Point(this.tbx_action.Location.X, this.tbx_action.Location.Y);
                    this.Size = new Size(this.Size.Width - this.lbl_action.Size.Width, this.Size.Height + 16);
                    Point pt = new Point(1, this.tbx_action.Location.Y + 16);
                    this.tbx_action.Location = pt;
                }
                else
                {
                    this.tbx_action.Dock = DockStyle.Right;
                    this.tbx_action.Location = localizacao;
                    this.Size = new Size(this.Size.Width + this.lbl_action.Size.Width, this.Size.Height - 16);
                }
            }
        }

        #endregion

        #region Metodos

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Register";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 2);
            lbl_action.Dock = DockStyle.Left;

            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.GotFocus += OnFocus;
            tbx_action.LostFocus += OnDefocus;
            tbx_action.Dock = DockStyle.Right;

            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
            this.SizeChanged += RegisterExtends_SizeChanged;
            localizacao = new Point(this.tbx_action.Location.X, this.tbx_action.Location.Y);
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

        [Category("Custom"), Description("Ocorre ao clicar no botão ...")]
        void acao_Click(object sender, EventArgs e)
        {
            if (this.AoChamar != null)
                this.AoChamar(this, e);
        }

        void RegisterExtends_SizeChanged(object sender, EventArgs e)
        {
            if (posicao == enm.Posicao.Vertical)
                tbx_action.Dock = DockStyle.Bottom;
            else
                tbx_action.Dock = DockStyle.Right;
        }

        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            btn_action.Size = new Size(25, this.ClientSize.Height + 2);
            btn_action.Dock = DockStyle.Right;
            btn_action.Cursor = Cursors.Default;
            btn_action.Image = CoreFramework.Properties.Resources.registerform;
            btn_action.FlatStyle = FlatStyle.Flat;
            btn_action.ForeColor = Color.White;
            btn_action.FlatAppearance.BorderSize = 0;
            btn_action.Click += acao_Click;

            this.tbx_action.Controls.Add(btn_action);

            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn_action.Width << 16));
        }
    }
}
