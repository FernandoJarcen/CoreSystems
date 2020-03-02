using CoreFramework.Controles.Controle.Designer;
using CoreFramework.Controles.Controle.Base;
using CoreFramework.Objetos;
using CoreMDK.Query;
using CoreSDK.Enums;
using CoreSDK.ODB.DataBase;
using CoreSDK.Services;
using CoreSDK.Specific;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(CaptionGridDesigner))]

    public partial class CaptionGridExtends : DesignControlBase
    {
        public event EventHandler AoClique;
        public event EventHandler AoDuploClique;
        public event EventHandler AoAlterarCelula;
        public event EventHandler AoValidar;

        int cont = 0;
        bool selecionados = false;
        bool canonico = true;
        bool cabecalho = true;
        bool rodape = true;
        bool filtro = true;
        bool subconsulta = false;
        bool filtroParcial = true;
        private bool ocultar = false;
        private string query = String.Empty;
        private string criteria = String.Empty;
        string ordenacao = string.Empty;
        private String chave = string.Empty;
        private String mensagem = String.Empty;
        System.Drawing.Color colEditavel = System.Drawing.Color.Red;
        Dictionary<String, String> colecao = new Dictionary<string, string>();
        Enums.EscolhaBooleana master = Enums.EscolhaBooleana.Não;
        string[] consultas;
        Control[] details;
        Enums.ExportaExcel exportarPadrao = Enums.ExportaExcel.Excel2007;
        Forms.ProcessForm alerta;
        private delegate void FechaPopUP();

        public CaptionGridExtends()
        {
            InitializeComponent();
        }

        #region propriedades

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

        [Category("Custom")]
        [Description("Chave do controle")]
        public string Chave
        {
            get { return chave; }
            set { chave = value; }
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
        [Description("Utilizar nome canônico para consulta")]
        public bool Canonico
        {
            get { return canonico; }
            set { this.canonico = value; }
        }

        [Category("Custom")]
        [Description("Texto da mensagem")]
        public string Mensagem
        {
            get { return tss_action.Text; }
            set { tss_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Metodo de ordenação de consulta")]
        public string Ordenacao
        {
            get { return ordenacao; }
            set { ordenacao = value; }
        }

        [Category("Custom")]
        [Description("Verifica se é subconsulta")]
        public bool Subconsulta
        {
            get { return subconsulta; }
            set { subconsulta = value; }
        }

        [Category("Custom")]
        [Description("Modo de apresentação das colunas")]
        public DataGridViewAutoSizeColumnsMode Modo
        {
            get { return (DataGridViewAutoSizeColumnsMode)this.dgv_consulta.AutoSizeColumnsMode; }
            set { this.dgv_consulta.AutoSizeColumnsMode = value; }
        }

        [Category("Custom")]
        [Description("Ocultar Campo Chave")]
        public bool Ocultar
        {
            get { return ocultar; }
            set { ocultar = value; }
        }

        [Category("Custom")]
        [Description("Mostrar/Ocultar Filtro")]
        public bool MostrarFiltro
        {
            get { return filtro; }
            set
            {
                filtro = value;
                tsp_action.Visible = filtro;
            }
        }

        [Category("Custom")]
        [Description("Mostrar Filtro Parcial")]
        public bool MostrarFiltroParcial
        {
            get { return filtroParcial; }
            set
            {
                filtroParcial = value;
                this.toolStripSeparator1.Visible = filtroParcial;
                this.lbl_busca.Visible = filtroParcial;
                this.tcb_action.Visible = filtroParcial;
                this.ttb_action.Visible = filtroParcial;
            }
        }

        [Category("Custom")]
        [Description("Tamanho de combo de consulta")]
        [DefaultValue(190)]
        public int TamanhoCombo
        {
            get
            {
                return tcb_action.Size.Width;
            }

            set
            {
                tcb_action.Size = new System.Drawing.Size(value, 25);
            }
        }

        [Category("Custom")]
        [Description("Tamanho de texto de consulta")]
        [DefaultValue(190)]
        public int TamanhoTexto
        {
            get
            {
                return ttb_action.Size.Width;
            }

            set
            {
                ttb_action.Size = new System.Drawing.Size(value, 25);
            }
        }

        [Category("Custom")]
        [Description("Mostra rodape")]
        public bool MostrarRodape
        {
            get { return rodape; }
            set
            {
                rodape = value;
                if (!rodape)
                    sst_action.Visible = false;
                else
                    sst_action.Visible = true;
            }
        }

        [Category("Custom")]
        [Description("Cor de coluna editavel")]
        public System.Drawing.Color ColunaEditavel
        {
            get { return colEditavel; }
            set { colEditavel = value; }
        }

        [Category("Custom")]
        [Description("MasterDetail control")]
        public Enums.EscolhaBooleana Master
        {
            get { return master; }
            set { master = value; }
        }

        [Category("Custom")]
        public Control[] Details
        {
            get { return details; }
            set { details = value; }
        }

        [Category("Custom")]
        [Description("Consultas details")]
        public string[] Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }

        [Category("Custom")]
        [Description("Cor do cabecalho")]
        public System.Drawing.Color CorCabecalho
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Texto Cabecalho")]
        public string Cabecalho
        {
            get { return lbl_cabecalho.Text; }
            set { lbl_cabecalho.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do texto cabeçalho")]
        public System.Drawing.Color CorTextoCabecalho
        {
            get { return lbl_cabecalho.ForeColor; }
            set { lbl_cabecalho.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Mostra cabeçalho")]
        public bool MostrarCabecalho
        {
            get { return cabecalho; }
            set
            {
                cabecalho = value;
                if (cabecalho)
                    this.pnl_action.Visible = true;
                else
                    this.pnl_action.Visible = false;
            }
        }

        [Category("Custom")]
        [Description("Verificar caminho padrao de exportacao")]
        public Enums.ExportaExcel ExportaPadrao
        {
            get { return exportarPadrao; }
            set { exportarPadrao = value; }
        }

        [Category("Custom")]
        public float Fonte
        {
            get { return this.dgv_consulta.Font.Size; }
            set { this.dgv_consulta.Font = new Font("Microsoft Sans Serif", value, FontStyle.Regular); }
        }

        [Category("Custom")]
        [Description("DataSource do controle")]
        public object Dados
        {
            get { return dgv_consulta.DataSource; }
            set { dgv_consulta.DataSource = value; }
        }

        #endregion

        #region Metodos

        #region metodos privados

        private void inicializar()
        {
            cont = 0;
            tss_action.Text = mensageiro(cont);

            foreach (DataGridViewColumn column in dgv_consulta.Columns)
            {
                if (column.Index != 0)
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void carregarDados(String consulta = "")
        {
            DataTable dtDados = new DataTable();
            String dados = string.Empty;

            if (!string.IsNullOrEmpty(consulta))
                dados = consulta;
            else
                dados = query;

            if (String.IsNullOrEmpty(Ordenacao))
                dtDados = DB.ExecutaReader(dados);
            else
            {
                dados += " order by " + ordenacao;
                dtDados = DB.ExecutaReader(dados);
            }

            dgv_consulta.DataSource = dtDados;
            inicializar();
        }

        private bool validarDados()
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(query))
                retorno = true;
            else
                retorno = false;
            return retorno;
        }

        private void montaQuery()
        {
            String qry = String.Empty;
            String nome_canonico = String.Empty;
            if (tcb_action.SelectedIndex == -1)
            {
                tcb_action.SelectedItem = 0;
                tcb_action.SelectedIndex = 0;
            }
            criteria = tcb_action.SelectedItem.ToString();

            tsb_action.Image = CoreFramework.Properties.Resources.uncheck;

            if (!string.IsNullOrEmpty(criteria))
            {
                if (validarDados())
                {
                    if (canonico)
                    {
                        if (!subconsulta)
                        {
                            if (query.Contains("where"))
                                qry = query + " and " + criteria + " like '%" + ttb_action.Text + "%'";
                            else
                                qry = query + " where " + criteria + " like '%" + ttb_action.Text + "%'";
                        }
                        else
                            if (query.Contains("as q where"))
                                qry = query + " and " + criteria + " like '%" + ttb_action.Text + "%'";
                            else
                                qry = query + " where " + criteria + " like '%" + ttb_action.Text + "%'";

                        carregarDados(qry);
                    }
                    else
                    {
                        nome_canonico = colecao[criteria].ToString();
                        criteria = nome_canonico;
                        if (query.Contains("where"))
                            qry = query + " and " + criteria + " like '%" + ttb_action.Text + "%'";
                        else
                            qry = query + " where " + criteria + " like '%" + ttb_action.Text + "%'";

                        carregarDados(qry);
                    }
                }
            }
        }

        private void montaMasterDetail(DataGridViewCellEventArgs e)
        {
            string consulta = string.Empty;
            string tipo = string.Empty;
            string QuerySecundaria = string.Empty;

            if (master == Enums.EscolhaBooleana.Sim)
            {
                var selecionado = this.dgv_consulta.Rows[e.RowIndex].Cells[1].Value;

                for (int indice = 0; indice < this.Details.Length; indice++)
                {
                    QuerySecundaria = consultas[indice];
                    consulta = QuerySecundaria + " WHERE " + chave + " = " + selecionado;
                    if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.CheckGridExtends")
                    {
                        CheckGridExtends ctl = (CheckGridExtends)this.details[indice];
                        ctl.AtualizarGrid(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.GridViewExtends")
                    {
                        GridViewExtends gvw = (GridViewExtends)this.details[indice];
                        gvw.CarregarDados(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.SimpleGridExtends")
                    {
                        SimpleGridExtends sgd = (SimpleGridExtends)this.details[indice];
                        sgd.AtualizarGrid(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.SelectGridExtends")
                    {
                        SelectGridExtends slg = (SelectGridExtends)this.details[indice];
                        slg.AtualizarGrid(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.CaptionGridExtend")
                    {
                        CaptionGridExtends std = (CaptionGridExtends)this.details[indice];
                        std.AtualizarGrid(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.ImageGridExtends")
                    {
                        ImageGridExtends igd = (ImageGridExtends)this.details[indice];
                        igd.AtualizarGrid(consulta);
                    }
                }
            }
        }

        #endregion

        #region metodos publicos

        #region Diversos

        public void AtualizarGrid(string consulta = "")
        {
            inicializar();
            ttb_action.Text = String.Empty;
            if (validarDados())
            {
                if (!string.IsNullOrEmpty(consulta))
                    carregarDados(consulta);
                else
                    carregarDados();

                listarCabecalho();
            }
        }

        public string Valor(int linha, int coluna)
        {
            string retorno = string.Empty;
            if (coluna <= dgv_consulta.Columns.Count)
                if (linha <= dgv_consulta.Rows.Count)
                {
                    retorno = dgv_consulta.Rows[linha].Cells[coluna].Value.ToString();
                }
            return retorno;
        }

        public string Valor(int linha, string coluna)
        {
            string retorno = string.Empty;
            if (linha <= dgv_consulta.Rows.Count)
            {
                retorno = dgv_consulta.Rows[linha].Cells[coluna].Value.ToString();
            }
            return retorno;
        }

        public int LinhaSelecionada()
        {
            return this.dgv_consulta.CurrentCell.RowIndex;
        }

        public int ColunaSelecionada()
        {
            return this.dgv_consulta.CurrentCell.ColumnIndex;
        }

        public string CelulaSelecionada()
        {
            return this.dgv_consulta.Rows[this.dgv_consulta.CurrentCell.RowIndex].Cells[this.dgv_consulta.CurrentCell.ColumnIndex].Value.ToString();
        }

        public string CabecalhoColuna()
        {
            return this.dgv_consulta.Columns[this.dgv_consulta.CurrentCell.ColumnIndex].HeaderText.ToString();
        }

        public int Quantidade()
        {
            return this.dgv_consulta.Rows.Count;
        }

        public int QuantidadeColunas()
        {
            return dgv_consulta.Columns.Count;
        }

        public DataTable RetornaSelecionados()
        {
            bool valor = true;
            int qtd = dgv_consulta.Columns.Count - 1;

            DataTable dtSelecionado = new DataTable();

            for (int indice = 1; indice < qtd + 1; indice++)
            {
                String nome_coluna = Convert.ToString(dgv_consulta.Columns[indice].Name);
                dtSelecionado.Columns.Add(nome_coluna, dgv_consulta.Columns[indice].ValueType);
            }

            for (int indice = 0; indice < dgv_consulta.Rows.Count; indice++)
            {

                valor = Convert.ToBoolean(dgv_consulta.Rows[indice].Cells[0].Value);

                if (valor)
                {
                    DataRow linha = dtSelecionado.NewRow();
                    for (int idx = 1; idx <= qtd; idx++)
                    {
                        linha[idx - 1] = dgv_consulta.Rows[indice].Cells[idx].Value;
                    }
                    dtSelecionado.Rows.Add(linha);
                }
            }

            return dtSelecionado;
        }

        public DataTable RetornaSelecionados(bool distinto, string[] coluna)
        {
            bool valor = true;
            DataTable dtSelect = new DataTable();
            DataTable dtCopia = new DataTable();

            dtSelect.Columns.Add("Chave", typeof(bool));

            for (int indice = 1; indice < dgv_consulta.Columns.Count; indice++)
            {
                String nome_coluna = Convert.ToString(dgv_consulta.Columns[indice].Name);
                dtSelect.Columns.Add(nome_coluna, dgv_consulta.Columns[indice].ValueType);
            }

            for (int indice = 0; indice < dgv_consulta.Rows.Count; indice++)
            {
                valor = Convert.ToBoolean(dgv_consulta.Rows[indice].Cells[0].Value);
                if (valor)
                {
                    DataRow linha = dtSelect.NewRow();
                    linha[0] = true;
                    for (int idx = 1; idx <= dtSelect.Columns.Count - 1; idx++)
                    {
                        linha[idx] = dgv_consulta.Rows[indice].Cells[idx].Value;
                    }
                    dtSelect.Rows.Add(linha);
                }
            }

            if (coluna[0] == "*")
            {
                string[] colName = new string[dgv_consulta.Columns.Count];
                colName[0] = "Chave";
                for (int indice = 1; indice < dgv_consulta.Columns.Count; indice++)
                {
                    colName[indice] = dgv_consulta.Columns[indice].HeaderText;
                }
                dtCopia = dtSelect.DefaultView.ToTable("Distintos", distinto, colName);
            }
            else
                dtCopia = dtSelect.DefaultView.ToTable("Distintos", distinto, coluna);

            return dtCopia;
        }

        public int ContarSelecionados()
        {
            dgv_consulta.EndEdit();

            bool valor = true;

            cont = 0;
            for (int indice = 0; indice < dgv_consulta.Rows.Count; indice++)
            {
                valor = Convert.ToBoolean(dgv_consulta.Rows[indice].Cells[0].Value);
                if (valor)
                    cont = cont + 1;
            }
            return cont;
        }

        #endregion

        #region Busca e Retorno

        public bool ExisteColuna(int coluna, string criteria)
        {
            bool retorno = false;
            for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
            {
                string compare = this.dgv_consulta.Rows[indice].Cells[coluna].Value.ToString();
                if (compare == criteria)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public int FindColuna(int colunaBusca, string criteria)
        {
            int retorno = 0;
            for (int indice = 0; indice < this.dgv_consulta.Columns.Count; indice++)
            {
                string compare = this.dgv_consulta.Rows[indice].Cells[colunaBusca].Value.ToString();
                if (compare == criteria)
                {
                    retorno = indice;
                    break;
                }
            }
            return retorno;
        }

        public int FindLinha(int colunaBusca, string criteria)
        {
            int retorno = 0;
            for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
            {
                string compare = this.dgv_consulta.Rows[indice].Cells[colunaBusca].Value.ToString();
                if (compare == criteria)
                {
                    retorno = indice;
                    break;
                }
            }
            return retorno;
        }

        public bool FindLinha(string colunaBusca, string criteria)
        {
            bool retorno = false;
            for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
            {
                string compare = this.dgv_consulta.Rows[indice].Cells[colunaBusca].Value.ToString();
                if (compare == criteria)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public List<int> FindListaLinhas(string colunaBusca, string criteria)
        {
            List<int> retorno = new List<int>();
            for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
            {
                string compare = this.dgv_consulta.Rows[indice].Cells[colunaBusca].Value.ToString();
                if (compare == criteria)
                    retorno.Add(indice);
            }
            return retorno;
        }

        public List<int> FindListaLinhas(Condition condicao)
        {
            List<int> retorno = new List<int>();
            for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
            {
                string tipo = condicao.Valor1.GetType().Name.ToString();
                var valorColuna = this.dgv_consulta.Rows[indice].Cells[condicao.Nome].Value;
                var valorCondicao = condicao.Valor1;

                if (tipo == "String")
                {
                    if (condicao.Operador == Operadores.ConditionOperator.Igual)
                    {
                        if (valorColuna.ToString() == valorCondicao.ToString())
                        {
                            retorno.Add(indice);
                        }
                    }
                }
                else if (tipo == "DateTime")
                {
                    if (condicao.Operador == Operadores.ConditionOperator.Igual)
                    {
                        if (Convert.ToDateTime(valorColuna) == Convert.ToDateTime(valorCondicao))
                        {
                            retorno.Add(indice);
                        }
                    }
                    else if (condicao.Operador == Operadores.ConditionOperator.Maior)
                    {
                        if (Convert.ToDateTime(valorColuna) > Convert.ToDateTime(valorCondicao))
                        {
                            retorno.Add(indice);
                        }
                    }
                    else if (condicao.Operador == Operadores.ConditionOperator.MaiorIgual)
                    {
                        if (Convert.ToDateTime(valorColuna) >= Convert.ToDateTime(valorCondicao))
                        {
                            retorno.Add(indice);
                        }
                    }
                    else if (condicao.Operador == Operadores.ConditionOperator.Menor)
                    {
                        if (Convert.ToDateTime(valorColuna) < Convert.ToDateTime(valorCondicao))
                        {
                            retorno.Add(indice);
                        }
                    }
                    else if (condicao.Operador == Operadores.ConditionOperator.MenorIgual)
                    {
                        if (Convert.ToDateTime(valorColuna) <= Convert.ToDateTime(valorCondicao))
                        {
                            retorno.Add(indice);
                        }
                    }
                }
                else if (tipo == "Int")
                {
                    if (condicao.Operador == Operadores.ConditionOperator.Igual)
                    {
                        if (valorColuna == valorCondicao)
                        {
                            retorno.Add(indice);
                        }
                    }
                }
            }
            return retorno;
        }

        public Decimal SomaLinhas(int coluna)
        {
            Decimal retorno = 0;
            if (this.dgv_consulta.Columns.Count >= coluna)
            {
                if (this.dgv_consulta.Rows.Count > 0)
                {
                    for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
                    {
                        retorno += Convert.ToDecimal(this.dgv_consulta.Rows[indice].Cells[coluna].Value);
                    }
                }
            }
            return retorno;
        }

        public Decimal SomaLinhas(int colunaSoma, int colunaBusca, string criteria)
        {
            Decimal retorno = 0;
            if (this.dgv_consulta.Columns.Count >= colunaBusca)
            {
                if (this.dgv_consulta.Rows.Count > 0)
                {
                    for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
                    {
                        if (this.dgv_consulta.Rows[indice].Cells[colunaBusca].Value.ToString() == criteria)
                            retorno += Convert.ToDecimal(this.dgv_consulta.Rows[indice].Cells[colunaSoma].Value);
                    }
                }
            }
            return retorno;
        }

        public Decimal SomaLinhas(string colunaSoma, string colunaBusca, string criteria)
        {
            Decimal retorno = 0;

            if (this.dgv_consulta.Rows.Count > 0)
            {
                for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
                {
                    if (this.dgv_consulta.Rows[indice].Cells[colunaBusca].Value.ToString() == criteria)
                        retorno += Convert.ToDecimal(this.dgv_consulta.Rows[indice].Cells[colunaSoma].Value);
                }
            }
            return retorno;
        }

        public Decimal SomaLinhas(string coluna)
        {
            Decimal retorno = 0;
            if (this.dgv_consulta.Rows.Count > 0)
            {
                for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
                {
                    retorno += Convert.ToDecimal(this.dgv_consulta.Rows[indice].Cells[coluna].Value);
                }
            }
            return retorno;
        }

        public int PosicaoColuna(string nomeColuna)
        {
            int retorno = -1;
            for (int indice = 0; indice < dgv_consulta.Columns.Count; indice++)
            {
                if (dgv_consulta.Columns[indice].HeaderText == nomeColuna)
                {
                    retorno = indice;
                    break;
                }
            }
            return retorno;
        }

        #endregion

        #region Edicao

        public void AdicionarLinha(object[] linha, string[] coluna = null)
        {
            DataTable dtTabela = new DataTable();

            if (this.dgv_consulta.DataSource == null)
            {
                for (int indice = 0; indice < coluna.Length; indice++)
                {
                    dtTabela.Columns.Add(coluna[indice].ToString());
                }

                DataRow dtToAdd = dtTabela.NewRow();
                dtTabela.Rows.Add(linha);
                dtTabela.AcceptChanges();
                this.dgv_consulta.DataSource = dtTabela;
            }
            else
            {
                dtTabela = (DataTable)this.dgv_consulta.DataSource;
                DataRow dtToAdd = dtTabela.NewRow();
                dtTabela.Rows.Add(linha);
                dtTabela.AcceptChanges();
            }
        }

        public void EditarGrid(bool valor)
        {
            this.dgv_consulta.ReadOnly = !valor;
        }

        public void EditarColunas(string coluna, bool valor)
        {
            this.dgv_consulta.Columns[coluna].ReadOnly = !valor;
            this.dgv_consulta.Columns[coluna].DefaultCellStyle.ForeColor = colEditavel;
        }

        public void EditarColunas(List<string> coluna)
        {
            int col = 0;
            EditarGrid(true);
            for (int indice = 0; indice < this.dgv_consulta.Columns.Count; indice++)
            {
                if (col < coluna.Count)
                {
                    if (this.dgv_consulta.Columns[indice].Name == coluna[col])
                    {
                        this.dgv_consulta.Columns[coluna[col]].ReadOnly = false;
                        //this.Columns[coluna[col]].DefaultCellStyle.ForeColor = colEditavel;
                        col += 1;
                    }
                    else
                        this.dgv_consulta.Columns[indice].ReadOnly = true;
                }
                else
                    this.dgv_consulta.Columns[indice].ReadOnly = true;
            }
        }

        public void EditarLinhas(List<int> linha)
        {
            int lin = 0;
            EditarGrid(true);
            for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
            {
                if (lin < linha.Count)
                {
                    if (indice == linha[lin])
                    {
                        this.dgv_consulta.Rows[linha[lin]].ReadOnly = false;
                        //this.Rows[linha[lin]].DefaultCellStyle.ForeColor = colEditavel;
                        lin += 1;
                    }
                    else
                        this.dgv_consulta.Rows[indice].ReadOnly = true;
                }
                else
                    this.dgv_consulta.Rows[indice].ReadOnly = true;
            }
        }

        public void DestacarLista()
        {
            List<int> colunas = new List<int>();
            List<int> linhas = new List<int>();
            int indiceColuna = 0;
            int indiceLinha = 0;

            for (int indice = 0; indice < this.dgv_consulta.Columns.Count; indice++)
            {
                if (this.dgv_consulta.Columns[indice].ReadOnly == false)
                    colunas.Add(indice);
            }

            for (int indice = 0; indice < this.dgv_consulta.Rows.Count; indice++)
            {
                if (this.dgv_consulta.Rows[indice].ReadOnly == false)
                    linhas.Add(indice);
            }

            for (int indice1 = 0; indice1 < this.dgv_consulta.Columns.Count; indice1++)
            {
                if (indiceColuna < colunas.Count)
                {
                    if (indice1 == colunas[indiceColuna])
                    {
                        indiceLinha = 0;
                        for (int indice2 = 0; indice2 < this.dgv_consulta.Rows.Count; indice2++)
                        {
                            if (indiceLinha < linhas.Count)
                            {
                                if (indice2 == linhas[indiceLinha])
                                {
                                    this.dgv_consulta.Rows[indice2].Cells[indice1].Style = new DataGridViewCellStyle { ForeColor = colEditavel, Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold) };
                                    indiceLinha += 1;
                                }
                            }
                            else
                                break;
                        }
                        indiceColuna += 1;
                    }
                }
                else
                    break;
            }
        }

        public void DestacarLinha(List<int> linha, System.Drawing.Color cor, Enums.Imagens tipo)
        {
            for (int indice = 0; indice < linha.Count; indice++)
            {
                int linhaSelecionada = linha[indice];
                this.dgv_consulta.Rows[linhaSelecionada].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                this.dgv_consulta.Rows[linhaSelecionada].DefaultCellStyle.ForeColor = cor;
            }
        }

        public void DestacarLinha(int linha, System.Drawing.Color cor)
        {
            this.dgv_consulta.Rows[linha].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.dgv_consulta.Rows[linha].DefaultCellStyle.ForeColor = cor;
        }
        
        public void EditarValor(int linha, int coluna, string valor)
        {
            dgv_consulta.Rows[linha].Cells[coluna].Value = valor;
        }

        public void LimparGrid()
        {
            this.dgv_consulta.DataSource = null;
            this.dgv_consulta.Rows.Clear();
            this.dgv_consulta.Refresh();
        }

        public void ApagarColuna(int indice_coluna)
        {
            if (ContarDados(Enums.GridView.Colunas) >= indice_coluna)
                dgv_consulta.Columns.Remove(dgv_consulta.Columns[indice_coluna]);
        }

        public void ApagarLinha(int indice_linha)
        {
            if (ContarDados(Enums.GridView.Linhas) >= indice_linha)
                dgv_consulta.Rows.Remove(dgv_consulta.Rows[indice_linha]);
        }

        #endregion
        
        #endregion

        #region metodos Nativos
                
        private string mensageiro(int linhas_retornadas)
        {
            String retorno = String.Empty;

            if (linhas_retornadas == 0)
                retorno = "Nenhuma linha selecionada";
            else if (linhas_retornadas == 1)
                retorno = cont.ToString() + " Linha selecionada";
            else
                retorno = cont.ToString() + " Linhas selecionadas";

            return retorno;
        }

        private void listarCabecalho()
        {
            tcb_action.Items.Clear();
            if (dgv_consulta.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in this.dgv_consulta.Columns)
                {
                    if (col.Name != "Column1")
                        tcb_action.Items.Add(col.Name);
                }
            }
        }

        public void Itens(String alias, String canonico)
        {
            colecao.Add(alias, canonico);
        }

        public int ContarDados(Enums.GridView criterio_busca)
        {
            int retorno = 0;
            if (criterio_busca == Enums.GridView.Linhas)
                retorno = dgv_consulta.Rows.Count - 1;
            else
                retorno = dgv_consulta.Columns.Count - 1;
            return retorno;
        }

        public void SelecionarTodos(bool status)
        {
            foreach (DataGridViewRow row in this.dgv_consulta.Rows)
            {
                row.Cells[0].Value = status;
            }
            cont = ContarSelecionados();
            tss_action.Text = mensageiro(cont);
        }

        public void SelecionarCriterioItem(string valor)
        {
            string busca = valor;
            int indice = tcb_action.FindStringExact(busca);
            tcb_action.SelectedIndex = indice;
            ttb_action.Focus();
        }

        #endregion     
  
        #region metodos customizados 

        #region especifica exportacao

        private void processarInfo()
        {
            string mensagem = string.Empty;
            mensagem = executarExcel(mensagem);
            this.Invoke(new FechaPopUP(this.fecharPopUp));
            MessageBox.Show(mensagem);
        }

        private void fecharPopUp()
        {
            alerta.Close();
        }

        private string executarExcel(string mensagem)
        {
            string caminho = string.Empty;
            DataTable dtExportacao = CoreService.GridToDataTable(this.dgv_consulta, true);
            if (exportarPadrao == Enums.ExportaExcel.Excel2007)
                mensagem = Exportador.Excel.geraExcel("Export", dtExportacao, "Export");
            else if (exportarPadrao == Enums.ExportaExcel.Excel2007comCaminho)
            {
                FolderBrowserDialog fld = new FolderBrowserDialog();
                if (fld.ShowDialog() == DialogResult.OK)
                {
                    caminho = fld.SelectedPath;
                    mensagem = Exportador.Excel.geraExcel(caminho, "Export", dtExportacao, "Export");
                }
            }
            else if (exportarPadrao == Enums.ExportaExcel.Excel2010)
                mensagem = Exportador.Excel.geraExcelNovo("Export", dtExportacao, "Export");
            else if (exportarPadrao == Enums.ExportaExcel.Excel2010comCaminho)
            {
                FolderBrowserDialog fld = new FolderBrowserDialog();
                if (fld.ShowDialog() == DialogResult.OK)
                {
                    caminho = fld.SelectedPath;
                    mensagem = Exportador.Excel.geraExcelNovo(caminho, "Export", dtExportacao, "Export");
                }
            }
            return mensagem;
        }

        #endregion

        #endregion

        #endregion

        #region Eventos
        protected override void OnCreateControl()
        {
            base.InicializarTipo(Enums.TipoControle.Dados);
        }

        private void CaptionGridExtends_Load(object sender, EventArgs e)
        {
            if (validarDados())
            {
                carregarDados(query);
                listarCabecalho();
            }
        }

        private void tsb_action_Click(object sender, EventArgs e)
        {
            if (selecionados)
            {
                SelecionarTodos(false);
                selecionados = false;
                tsb_action.Image = CoreFramework.Properties.Resources.uncheck;
            }
            else
            {
                SelecionarTodos(true);
                selecionados = true;
                tsb_action.Image = CoreFramework.Properties.Resources.check;
            }
        }

        private void tcb_action_TextChanged(object sender, EventArgs e)
        {
            ttb_action.Text = String.Empty;
        }

        private void tcb_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            ttb_action.Text = String.Empty;
        }

        private void ttb_action_TextChanged(object sender, EventArgs e)
        {
            montaQuery();
        }

        private void tbs_refresh_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dgv_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_consulta.Columns[0].Index)
            {
                cont = ContarSelecionados();
                tss_action.Text = mensageiro(cont);
            }
        }

        private void dgv_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            montaMasterDetail(e);

            if (this.AoClique != null)
            {
                this.AoClique(this, e);
            }
        }

        private void dgv_consulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.AoDuploClique != null)
            {
                this.AoDuploClique(this, e);
            }
        }

        private void dgv_consulta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.AoAlterarCelula != null)
            {
                this.AoAlterarCelula(this, e);
            }
        }

        private void dgv_consulta_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (this.AoValidar != null)
            {
                this.AoValidar(this, e);
            }
        }

        private void tsb_excel_Click(object sender, EventArgs e)
        {
            Thread thProcessa = new Thread(new ThreadStart(processarInfo));
            thProcessa.Start();
            alerta = new Forms.ProcessForm("Gerando Arquivo!");
            alerta.Show();
        }

        #endregion
    }
}
