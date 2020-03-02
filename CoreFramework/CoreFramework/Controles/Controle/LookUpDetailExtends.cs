using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public class LookUpDetailExtends : DesignControlBase
    {
        public event EventHandler AoClicar;
        public event EventHandler AoMudarTexto;
        public event EventHandler AoValidar;
        public event EventHandler AoPerderFoco;
        public event EventHandler AoModificar;
        public event EventHandler AoAtalho;

        Label lbl_action = new Label();
        TextBox tbx_action = new TextBox();
        Button btn_action = new Button();

        private bool obrigatorio = false;
        private Label destino;
        private Enums.ValidacaoCaracteres validacaoTexto = Enums.ValidacaoCaracteres.Nenhum;
        private bool editavel = true;
        
        public LookUpDetailExtends()
        {
            inicializar();
            this.Size = new Size(180, 23);
            atualizar();
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
        [Description("controle de retorno de dados")]
        public Label Destino
        {
            get
            {
                return destino;
            }
            set
            {
                destino = value;
            }
        }

        [Category("Custom")]
        [Description("Validação do texto digitado")]
        public Enums.ValidacaoCaracteres ValidacaoTexto
        {
            get { return validacaoTexto; }
            set
            {
                validacaoTexto = value;
            }
        }
        
        #endregion

        #region metodos

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Lookup";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 4);
            lbl_action.Dock = DockStyle.Left;

            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.GotFocus += textbox_GotFocus;
            tbx_action.LostFocus += textbox_LostFocus;
            tbx_action.KeyPress += textbox_KeyPress;
            //tbx_action.KeyDown += textbox_KeyDown;
            tbx_action.KeyDown += tbx_action_KeyDown;
            tbx_action.Validated += textbox_Validated;
            tbx_action.TextChanged += textbox_TextChanged;
            this.LostFocus += LookUpDetailExtends_LostFocus;

            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
        }


                
        private void atualizar()
        {
            tbx_action.Size = new Size(this.TamanhoTexto, 23);            
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        public void Limpar()
        {
            if (tbx_action.ReadOnly)
            {
                tbx_action.ReadOnly = false;
                this.tbx_action.Clear();
                tbx_action.ReadOnly = true;
            }
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
            btn_action.Image = CoreFramework.Properties.Resources.lookup;
            btn_action.FlatStyle = FlatStyle.Flat;
            btn_action.ForeColor = Color.White;
            btn_action.FlatAppearance.BorderSize = 0;
            btn_action.Click += new EventHandler(botao_Click);

            this.tbx_action.Controls.Add(btn_action);
            validacaoTexto = Enums.ValidacaoCaracteres.Nenhum;

            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn_action.Width << 16));
        }

        protected void botao_Click(object sender, EventArgs e)
        {
            if (this.AoClicar != null)
            {
                this.AoClicar(this, e);
            }
        }

        private void textbox_GotFocus(object sender, EventArgs e)
        {
            this.tbx_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void textbox_LostFocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.tbx_action.BackColor = SystemColors.Info;
            else
                this.tbx_action.BackColor = SystemColors.Window;
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacaoDigitado(e);
        }

        private void validacaoDigitado(KeyPressEventArgs e)
        {
            if (validacaoTexto == CoreFramework.Objetos.Enums.ValidacaoCaracteres.Texto)
            {
                if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
            else if (validacaoTexto == CoreFramework.Objetos.Enums.ValidacaoCaracteres.Numeros)
            {
                if (!(Char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
            else if (validacaoTexto == CoreFramework.Objetos.Enums.ValidacaoCaracteres.Decimais)
            {
                if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == (char)44))
                    e.Handled = true;
            }
            else e.Handled = false;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (this.AoMudarTexto != null)
            {
                this.AoMudarTexto(this, e);
            }
        }

        void textbox_Validated(object sender, EventArgs e)
        {
            if (this.AoValidar != null)
            {
                this.AoValidar(this, e);
            }
        }
  
        private void LookUpDetailExtends_LostFocus(object sender, EventArgs e)
        {
            if (this.AoPerderFoco != null)
                PerderFoco(this, e);
        }

        private void PerderFoco(LookUpDetailExtends lookUpExtends, EventArgs e)
        {
            if (this.AoPerderFoco != null)
            {
                this.AoPerderFoco(this, e);
            }
        }

        //private void textbox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (this.AoModificar != null)
        //    {
        //        this.AoModificar(this, e);                
        //    }
        //}

        void tbx_action_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 113)
            {
                if (this.AoAtalho != null)
                {
                    this.AoAtalho(this, e);
                }
            }
            else
            {
                if (this.AoModificar != null)
                {
                    this.AoModificar(this, e);
                }
            }
        }

        #endregion

    }
}
