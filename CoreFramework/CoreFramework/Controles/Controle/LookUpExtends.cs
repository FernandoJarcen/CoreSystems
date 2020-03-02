
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Controles.Controle.Designer;
using System.Data;
using CoreSDK.ODB.DataBase;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(LookUpDesigner))]
    public partial class LookUpExtends : DesignControlBase
    {
        public event EventHandler AoModificar;
        public event EventHandler AoPerderFoco;
        public event EventHandler AoValidar;
        public event EventHandler AoMudarTexto;

        Label lbl_action = new Label();
        TextBox tbx_action = new TextBox();
        Button btn_action = new Button();

        private bool obrigatorio = false;
        private bool editavel = true;
        private string chave = String.Empty;
        private Label destino;
        private string display = string.Empty;
        private string query = String.Empty;
        private bool dinamico = false;
        private string secundaria = String.Empty;
        private CoreFramework.Objetos.Enums.ValidacaoCaracteres validacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
        private bool ocultar = false;
        private string criteria = string.Empty;

        public LookUpExtends()
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
        [Description("Campo chave da visualização")]
        public string Chave
        {
            get
            {
                return chave;
            }
            set
            {
                chave = value;
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
        [Description("Dado a ser exibido no controle associado")]
        public string Display
        {
            get { return display; }
            set { display = value; }
        }

        [Category("Custom")]
        [Description("consulta a ser executada no controle")]
        public String Query
        {
            get
            {
                return query;
            }

            set
            {
                this.query = value;
            }
        }

        [Category("Custom")]
        [Description("Retorna valor no controle associado?")]
        public bool Dinamico
        {
            get { return dinamico; }
            set { dinamico = value; }
        }

        [Category("Custom")]
        [Description("Retorna query secundaria para consulta")]
        public string Secundaria
        {
            get { return secundaria; }
            set { secundaria = value; }
        }

        [Category("Custom")]
        [Description("Tipo de dado da query secundaria")]
        public CoreFramework.Objetos.Enums.ValidacaoCaracteres ValidacaoTexto
        {
            get { return validacaoTexto; }
            set { validacaoTexto = value; }
        }

        [Category("Custom")]
        [Description("Ocultar Campo Chave")]
        public bool Ocultar
        {
            get { return ocultar; }
            set { ocultar = value; }
        }

        [Category("Custom")]
        public String Criteria
        {
            get { return criteria; }
            set { criteria = value; }
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
            tbx_action.GotFocus += onFocus;
            tbx_action.LostFocus += onDefocus;
            tbx_action.KeyPress += tbx_action_KeyPress;
            tbx_action.KeyDown += tbx_action_KeyDown;
            tbx_action.Validated += tbx_action_Validated;
            tbx_action.TextChanged += tbx_action_TextChanged;
            //tbx_action.Leave +=tbx_action_Leave;
            this.LostFocus += LookUpExtends_LostFocus;

            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
        }

        private void tbx_action_TextChanged(object sender, EventArgs e)
        {
            if (this.AoMudarTexto != null)
            {
                this.AoMudarTexto(this, e);
            }   
        }

        void tbx_action_Validated(object sender, EventArgs e)
        {
            if (this.AoValidar != null)
            {
                this.AoValidar(this, e);
            }
        }

        private void onFocus(object sender, EventArgs e)
        {
            this.tbx_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void onDefocus(object sender, EventArgs e)
        {
            string concatenado = string.Empty;
            DataTable dt;
            DataRow dr;
            string querySecundaria = String.Empty;
            int indice = 0;

            if (obrigatorio)
                this.tbx_action.BackColor = SystemColors.Info;
            else
                this.tbx_action.BackColor = SystemColors.Window;

            if (Dinamico)
            {
                if (chave != string.Empty)
                {
                    if (secundaria != string.Empty)
                    {
                        querySecundaria = secundaria + " where " + chave + " = " + tbx_action.Text;
                        if (!string.IsNullOrEmpty(criteria))
                            if ((criteria.Substring(0, 5) == "where") || (criteria.Substring(0, 5) == "WHERE"))
                            {
                                concatenado = " and" + criteria.Substring(5);
                                querySecundaria += " " + concatenado;
                            }
                        if (Dinamico)
                        {
                            dt = DB.ExecutaReader(querySecundaria);
                            if (dt.Rows.Count > 0)
                            {
                                dr = dt.Rows[0];
                                indice = buscarReferencia(dt);
                                Destino.Text = dr.ItemArray[indice].ToString();
                            }
                            else
                            {

                                MessageBox.Show("Valor não encontrado!");
                                Destino.Text = String.Empty;
                                this.tbx_action.Text = string.Empty;
                                this.btn_action.Focus();
                            }
                        }
                    }
                }
            }
            //if (this.AoModificar != null)
            //    Modificar(this, e);
        }

        private int buscarReferencia(DataTable dt)
        {
            int retorno = 0;
            for (int indice = 0; indice < dt.Columns.Count; indice++)
            {
                if (dt.Columns[indice].ColumnName == display)
                {
                    retorno = indice;
                    break;
                }
            }
            return retorno;
        }

        private void atualizar()
        {
            tbx_action.Size = new Size(this.TamanhoTexto, 23);
        }

        private void Modificar(object sender, EventArgs e)
        {
            if (this.AoModificar != null)
            {
                this.AoModificar(this, e);
            }
        }

        private void PerderFoco(LookUpExtends lookUpExtends, EventArgs e)
        {
            if (this.AoPerderFoco != null)
            {
                this.AoPerderFoco(this, e);
            }
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        private void acessarForm(object sender, EventArgs e)
        {
            String concatenado = String.Empty;

            if (this.AoModificar != null)
                Modificar(this, e);

            try
            {
                if (string.IsNullOrEmpty(criteria))
                {
                    CoreFramework.Forms.LookupForm lookup = new CoreFramework.Forms.LookupForm(Query, this.tbx_action, Display, destino, ocultar);
                    lookup.ShowDialog();
                }
                else
                {
                    concatenado = Query + " " + criteria;
                    CoreFramework.Forms.LookupForm lookup = new CoreFramework.Forms.LookupForm(concatenado, this.tbx_action, Display, destino, ocultar);
                    lookup.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            btn_action.Click += new EventHandler(acao_Click);

            this.tbx_action.Controls.Add(btn_action);

            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn_action.Width << 16));
        }

        protected void acao_Click(object sender, EventArgs e)
        {
            if (Query != string.Empty)
                acessarForm(this, e);
        }

        private void tbx_action_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbx_action_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 113)
                {
                    acessarForm(this, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LookUpExtends_LostFocus(object sender, EventArgs e)
        {
            if (this.AoPerderFoco != null)
                PerderFoco(this, e);
        }

        #endregion
    }
}
