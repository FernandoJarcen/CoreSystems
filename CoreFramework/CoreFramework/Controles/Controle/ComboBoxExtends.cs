using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Design;
using CoreFramework.Controles.Controle.Base;
using System.Reflection;
using CoreFramework.Controles.Controle.Designer;
using CoreSDK.ODB.DataBase;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(ComboDesigner))]

    public partial class ComboBoxExtends : DesignControlBase
    {
        private CoreFramework.Objetos.Enums.TipoControle tipoControle = Enums.TipoControle.Edicao;
        private Label lbl_action = new Label();
        private ComboBox cbo_action = new ComboBox();
        private ComboBox.ObjectCollection itemsCollection;
        private string chave = String.Empty;
        private String display = String.Empty;
        private String query = String.Empty;

        private bool obrigatorio = false;
        private bool dados = true;
        private string tabela = string.Empty;
        private Enums.Posicao posicao = Enums.Posicao.Horizontal;
        private Point ret;
        public event EventHandler AoMudarIndice;
        private string querysecundaria = string.Empty;
        private string indice = string.Empty;

        public ComboBoxExtends()
        {
            inicializar();
            this.Size = new Size(180, 24);
            this.SizeChanged += ComboBoxExtends_SizeChanged;
        }

        #region Propriedades

        [Browsable(true)]
        public CoreFramework.Objetos.Enums.TipoControle TipoControle
        {
            get
            {
                return tipoControle;
            }
        }

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
                return this.cbo_action.Size.Width;
            }

            set
            {
                this.cbo_action.Size = new System.Drawing.Size(value, 23);
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
                    this.cbo_action.BackColor = SystemColors.Info;
                    this.lbl_action.ForeColor = SystemColors.HotTrack;
                    this.lbl_action.Text += "*";
                }
                else
                {
                    this.cbo_action.BackColor = SystemColors.Window;
                    this.lbl_action.ForeColor = SystemColors.ControlText;
                    this.lbl_action.Text = lbl_action.Text.Replace("*", "");
                }
            }
        }

        [Category("Custom")]
        [Description("Campo a ser mostrado no display")]
        public string Display
        {
            get
            {
                return display;
            }

            set
            {
                this.display = value;
            }
        }

        [Category("Custom")]
        [Description("Campo chave da consulta")]
        public String Chave
        {
            get
            {
                return chave;
            }

            set
            {
                this.chave = value;
            }
        }

        [Category("Custom")]
        [Description("Consulta a ser executada no controle")]
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

        [Category("Custom"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Localizable(true),
        Description("Itens"),
        Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, " + "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
        MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                if (itemsCollection == null)
                {
                    itemsCollection = new ComboBox.ObjectCollection(this.cbo_action);
                }
                return itemsCollection;
            }
            set { itemsCollection = value; }
        }

        [Category("Custom")]
        [Description("Valor do combo")]
        public String Valor
        {
            get
            {
                return this.cbo_action.Text;
            }
            set { this.cbo_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Indice do combo")]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Indice
        {
            get { return this.cbo_action.SelectedIndex; }
            set
            {                
                if (this.cbo_action.Items.Count > 0)
                    this.cbo_action.SelectedIndex = value;
            }
        }

        [Category("Custom")]
        [Description("É um Controle de dados?")]
        [DefaultValue(true)]
        public bool Dados
        {
            get { return dados; }
            set { dados = value; }
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
                    this.cbo_action.Dock = DockStyle.None;
                    ret = new Point(this.cbo_action.Location.X, this.cbo_action.Location.Y);
                    this.Size = new Size(this.Size.Width, this.Size.Height + 21);
                    Point pt = new Point(1, this.cbo_action.Location.Y + 21);
                    this.cbo_action.Location = pt;
                }
                else
                {
                    this.cbo_action.Dock = DockStyle.Right;
                    this.cbo_action.Location = ret;
                    this.Size = new Size(this.Size.Width, this.Size.Height - 21);
                }
            }
        }

        [Category("Custom")]
        [Description("Tabela principal")]
        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        [Category("Custom")]
        [Description("Consulta Secundaria")]
        public string QuerySecundaria
        {
            get { return querysecundaria; }
            set { querysecundaria = value; }
        }


        #endregion

        #region Metodos

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Combo";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(0, 6);
            lbl_action.Dock = DockStyle.Left;

            cbo_action.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            cbo_action.Dock = DockStyle.Right;
            cbo_action.SelectedIndexChanged += cbo_action_SelectedIndexChanged;

            this.Controls.Add(lbl_action);
            this.Controls.Add(cbo_action);
            ret = new Point(this.cbo_action.Location.X, this.cbo_action.Location.Y);
        }

        private void carregarDados()
        {
            if (dados)
                carregarQuery();
            else
                carregarLista();
        }

        private void carregarQuery()
        {
            DataTable dt = default(DataTable);
            if (cbo_action.Items.Count > 0)
            {
                this.cbo_action.DataSource = null;
                this.cbo_action.Items.Clear();
            }


            if (dados)
            {
                if (validarDados())
                {
                    dt = DB.ExecutaReader(Query);
                    this.cbo_action.DataSource = dt;
                    this.cbo_action.DisplayMember = Display;
                    this.cbo_action.ValueMember = Chave;
                }
            }
            else
            {
                for (int indice = 0; indice < itemsCollection.Count; indice++)
                {
                    this.cbo_action.Items.Add(itemsCollection[indice].ToString());
                }
            }
        }
        
        private void apagarLista()
        {
            if (cbo_action.Items.Count > 0)
            {
                this.cbo_action.DataSource = null;
                this.cbo_action.Items.Clear();
            }
        }
        private void carregarLista()
        {
            apagarLista();

            for (int indice = 0; indice < itemsCollection.Count; indice++)
            {
                this.cbo_action.Items.Add(itemsCollection[indice].ToString());
            }
        }

        private bool validarDados()
        {
            bool retorno = false;

            if (!string.IsNullOrEmpty(chave))
                retorno = true;
            else if (!string.IsNullOrEmpty(query))
                retorno = true;
            else if (!string.IsNullOrEmpty(display))
                retorno = true;
            else
                retorno = false;
            return retorno;
        }

        public int BuscaIndice(string campo)
        {
            int retorno = -1;

            for (int indice = 0; indice < this.cbo_action.Items.Count; indice++)
            {
                string busca = this.cbo_action.GetItemText(this.cbo_action.Items[indice]);
                if (busca == campo)
                {
                    retorno = indice;
                    break;
                }
            }

            return retorno;
        }

        public string BuscaNome(Int32 indice)
        {
            string retorno = string.Empty;
            if (indice <= this.cbo_action.Items.Count - 1)
                retorno = this.cbo_action.Items[indice].ToString();
            return retorno;
        }

        private void atualizarPosicao()
        {
            if (posicao == Enums.Posicao.Horizontal)
                cbo_action.Size = new Size(this.TamanhoTexto, 23);
            else
                cbo_action.Size = new Size(this.TamanhoTexto, 46);
        }

        public void Atualizar()
        {
            if (dados)
                carregarQuery();
            else
                carregarLista();

            this.Refresh();
        }

        public int ChavePrimaria(string valor)
        {
            indice = "select " + chave + " from " + tabela + " where " + display + " = '" + this.Valor + "'";
            int retorno = DB.ExecutaScalar(indice);
            return retorno;
        }

        public void AtualizaRelacionamento(CoreFramework.Controles.Controle.ComboBoxExtends master, CoreFramework.Controles.Controle.ComboBoxExtends details, string consulta)
        {
            int idc = master.ChavePrimaria(master.Valor);
            details.Query = string.Empty;
            details.Query = consulta + idc;
            details.Atualizar();
        }

        public int Count()
        {
            return this.Items.Count;
        }

        public void Habilitar(bool status)
        {
            this.cbo_action.Enabled = status;
        }

        public int SelecionarCombo<T>(T entidade, string campo, string criteria)
        {
            Type tipoEntidade = typeof(T);
            int indiceCombo = -1;

            try
            {
                ConstructorInfo construtor = tipoEntidade.GetConstructor(Type.EmptyTypes);
                object instancia = construtor.Invoke(new object[] { });

                MethodInfo metodo = tipoEntidade.GetMethod("SelecionarPor");
                object[] parametros = new object[] { campo, criteria };
                object descricaoCodigo = metodo.Invoke(instancia, parametros);

                indiceCombo = BuscaIndice(descricaoCodigo.ToString());
            }
            catch (Exception)
            {
                indiceCombo = 0;
            }

            return indiceCombo;
        }

        public void SelecionarItem(int valor)
        {
            if (cbo_action.Items.Count > 0)
                cbo_action.SelectedItem = valor;
        }

        #endregion

        #region eventos

        void ComboBoxExtends_SizeChanged(object sender, EventArgs e)
        {
            if (posicao == Enums.Posicao.Vertical)
                cbo_action.Dock = DockStyle.Bottom;
            else
                cbo_action.Dock = DockStyle.Right;
        }

        public void cbo_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.AoMudarIndice != null)
            {
                this.AoMudarIndice(this, e);
            }
        }

        protected override void OnCreateControl()
        {
            if (cbo_action.Items.Count == 0)
            carregarDados();
        }

        #endregion

        private void ComboBoxExtends_Load(object sender, EventArgs e)
        {
            if (this.cbo_action.Items.Count > 0)
                this.cbo_action.SelectedIndex = 0;
        }
    }
}
