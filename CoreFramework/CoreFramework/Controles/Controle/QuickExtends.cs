using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Objetos;
using CoreSDK.ODB.DataBase;
using CoreFramework.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class QuickExtends : DesignControlBase
    {
        Label lbl_action = new Label();
        TextBox tbx_action = new TextBox();
        Button btn_action = new Button();
        Label lbl_retorno = new Label();
        Button btn_cadastro = new Button();

        private bool obrigatorio = false;
        private bool editavel = true;
        private string query = String.Empty;
        private string chave = String.Empty;
        private string display = string.Empty;
        private string secundaria = String.Empty;
        private bool campoPadrao = false;
        private bool dinamico = false;
        private Enums.ValidacaoCaracteres validacaoTexto = Enums.ValidacaoCaracteres.Nenhum;
        private bool ocultar = false;
        private string criteria = string.Empty;
        public event EventHandler AoChamar;
        public event EventHandler AoFormulario;
        private bool dados = true;
        
        public QuickExtends()
        {
            inicializar();
            this.Size = new Size(274, 23);
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
        [Description("Texto do título")]
        public string Titulo
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Tamanho de texto")]
        [DefaultValue(0)]
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
        [Description("Valor do Campo")]
        public string Valor
        {
            get { return tbx_action.Text; }
            set { tbx_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Valor do Retorno")]
        [DefaultValue("0")]
        public string Retorno
        {
            get { return lbl_retorno.Text; }
            set { lbl_retorno.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do Retorno")]
        public System.Drawing.Color CorRetorno
        {
            get { return lbl_retorno.ForeColor; }
            set { lbl_retorno.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Tamanho do retorno")]
        [DefaultValue("100")]
        public Int32 TamanhoRetorno
        {
            get { return lbl_retorno.Size.Width; }
            set { lbl_retorno.Size = new Size(value, this.lbl_retorno.Size.Height); }
        }

        [Category("Custom")]
        [Description("Controle de dados")]
        public bool Dados
        {
            get { return dados; }
            set { dados = value; }
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
        public Enums.ValidacaoCaracteres ValidacaoTexto
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

        [Category("Custom")]
        [Description("Mostra campo estilo padrão")]
        public bool CampoPadrao
        {
            get { return campoPadrao; }
            set
            {
                campoPadrao = value;
                if (campoPadrao)
                {
                    lbl_retorno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lbl_retorno.FlatStyle = FlatStyle.Popup;
                }
                else
                {
                    lbl_retorno.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    lbl_retorno.FlatStyle = FlatStyle.Standard;
                }
            }
        }       

        #endregion

        #region metodos

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Quick";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 4);
            lbl_action.Dock = DockStyle.Left;

            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.GotFocus += onFocus;
            tbx_action.LostFocus += onDefocus;
            tbx_action.KeyPress += tbx_action_KeyPress;
            tbx_action.KeyDown += tbx_action_KeyDown;

            lbl_retorno.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_retorno.Text = "Retorno";
            lbl_retorno.AutoSize = false;
            lbl_retorno.Location = new Point(2, 4);
            lbl_retorno.Dock = DockStyle.Right;

            btn_cadastro.Text = string.Empty;
            btn_cadastro.Size = new Size(25, this.ClientSize.Height + 2);
            btn_cadastro.Dock = DockStyle.Right;
            btn_cadastro.Cursor = Cursors.Default;
            btn_cadastro.Image = CoreFramework.Properties.Resources.cadastro;
            btn_cadastro.FlatStyle = FlatStyle.Flat;
            btn_cadastro.ForeColor = Color.White;
            btn_cadastro.FlatAppearance.BorderSize = 0;
            btn_cadastro.Click += btn_cadastro_Click;

            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
            this.Controls.Add(lbl_retorno);
            this.Controls.Add(btn_cadastro);
        }

        private void onFocus(object sender, EventArgs e)
        {
            this.tbx_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void onDefocus(object sender, EventArgs e)
        {
            string concatenado = string.Empty;
            DataTable dtQuery;
            DataRow drLinhas;
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
                            dtQuery = DB.ExecutaReader(querySecundaria);
                            if (dtQuery.Rows.Count > 0)
                            {
                                drLinhas = dtQuery.Rows[0];
                                indice = buscarReferencia(dtQuery);
                                lbl_retorno.Text = drLinhas.ItemArray[indice].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Valor não encontrado!");
                                lbl_retorno.Text = String.Empty;
                                this.tbx_action.Text = string.Empty;
                                this.tbx_action.Focus();
                            }
                        }
                    }
                }
            }
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

        private void acessarForm()
        {
            String concatenado = String.Empty;

            if (string.IsNullOrEmpty(criteria))
            {
                LookupForm lookup = new LookupForm(Query, this.tbx_action, Display, lbl_retorno, ocultar);
                lookup.ShowDialog();
            }
            else
            {
                concatenado = Query + " " + criteria;
                LookupForm lookup = new LookupForm(concatenado, this.tbx_action, Display, lbl_retorno, ocultar);
                lookup.ShowDialog();
            }
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        #endregion

        #region eventos

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

        private void acao_Click(object sender, EventArgs e)
        {
            if (dados)
            {
                if (Query != string.Empty)
                    acessarForm();
            }
            else
            {
                if (this.AoChamar != null)
                {
                    this.AoChamar(this, e);
                }
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (this.AoFormulario != null)
            {
                this.AoFormulario(this, e);
            }
        }

        private void tbx_action_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 113)
            {
                acessarForm();
            }
        }

        void tbx_action_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
