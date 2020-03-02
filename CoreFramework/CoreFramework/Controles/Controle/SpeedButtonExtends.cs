using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using frm = CoreFramework.Forms;
using CoreFramework.Controles.Controle.Collection;
using CoreFramework.Controles.Controle.Editors;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Controles.Controle.Designer;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(SpeedButtonDesigner))]

    public partial class SpeedButtonExtends : DesignControlBase
    {
        Label lbl_action = new Label();
        TextBox tbx_action = new TextBox();
        Button btn_action = new Button();

        private bool obrigatorio = false;
        private bool editavel = true;
        private Label destino;
        private SpeedItemCollection lista = new SpeedItemCollection();

        public SpeedButtonExtends()
        {
            inicializar();
            this.Size = new Size(150, 23);
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

        [Editor(typeof(SpeedItemCollectionEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Custom")]
        [Description("A collection of the employees within the organization")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SpeedItemCollection Items
        {
            get { return lista; }
            set { lista = value; }
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

        #endregion

        #region Metodos

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Speed";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 4);
            lbl_action.Dock = DockStyle.Left;

            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.GotFocus += onFocus;
            tbx_action.LostFocus += onDefocus;
            tbx_action.KeyDown += tbx_action_KeyDown;

            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
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

            if (editavel)
            {
                if (buscarReferencia(tbx_action.Text))
                {
                    if (Destino != null)
                    {
                        Destino.Text = buscarValor(tbx_action.Text);
                    }
                }
                else
                {
                    if (Destino != null)
                        Destino.Text = String.Empty;
                }
            }
        }

        private string buscarValor(string display)
        {
            string retorno = string.Empty;
            for (int indice = 0; indice < this.Items.Count; indice++)
            {
                if (display == this.Items[indice].Display)
                {
                    retorno = this.Items[indice].Valor;
                    break;
                }
            }
            return retorno;
        }

        private bool buscarReferencia(String valor)
        {
            bool retorno = false;
            for (int indice = 0; indice < this.Items.Count; indice++)
            {
                if (this.Items[indice].Display == valor)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public string BuscarNome(string display)
        {
            string retorno = string.Empty;
            for (int indice = 0; indice < this.Items.Count; indice++)
            {
                if (display == this.Items[indice].Display)
                {
                    retorno = this.Items[indice].Valor;
                    break;
                }
            }
            return retorno;
        }

        private void atualizar()
        {
            tbx_action.Size = new Size(this.TamanhoTexto, 23);
        }

        private void acessar_form()
        {
            frm.ListForm list = new frm.ListForm(this, this.tbx_action, Destino);
            list.ShowDialog();
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        #endregion

        #region eventos

        protected void acao_Click(object sender, EventArgs e)
        {
            if (this.Items.Count > 0)
                acessar_form();
        }

        private void tbx_action_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 113)
                {
                    acessar_form();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            btn_action.Size = new Size(25, this.ClientSize.Height + 2);
            btn_action.Dock = DockStyle.Right;
            btn_action.Cursor = Cursors.Default;
            btn_action.Image = CoreFramework.Properties.Resources.execucao;
            btn_action.FlatStyle = FlatStyle.Flat;
            btn_action.ForeColor = Color.White;
            btn_action.FlatAppearance.BorderSize = 0;
            btn_action.Click += new EventHandler(acao_Click);

            this.tbx_action.Controls.Add(btn_action);

            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn_action.Width << 16));
        }
    }
}
