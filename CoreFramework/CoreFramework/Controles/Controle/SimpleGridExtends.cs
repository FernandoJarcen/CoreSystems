using CoreFramework.Controles.Controle.Base;
using CoreMDK.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CoreSDK.Enums;
using CoreSDK.ODB.DataBase;
using CoreFramework.Objetos;
using CoreSDK.Services;
using CoreSDK.Specific;

namespace CoreFramework.Controles.Controle
{
    public partial class SimpleGridExtends : DesignControlBase
    {
        public event EventHandler AoClique;
        public event EventHandler AoDuploClique;
        public event EventHandler AoAlterarCelula;
        public event EventHandler AoValidar;

        int cont = 0;
        bool canonico = true;
        bool subconsulta = false;
        bool rodape = true;
        private bool ocultar = false;
        private String mensagem = String.Empty;
        private String chave = string.Empty;
        private string query = String.Empty;
        string ordenacao = string.Empty;
        Dictionary<String, String> colecao = new Dictionary<string, string>();
        Enums.EscolhaBooleana master = Enums.EscolhaBooleana.Não;
        System.Drawing.Color colEditavel = System.Drawing.Color.Red;
        string[] consultas;
        Control[] details;
        Enums.ExportaExcel exportarPadrao = Enums.ExportaExcel.Excel2007;
        Forms.ProcessForm alerta;
        private delegate void FechaPopUP();

        public SimpleGridExtends()
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
        [Description("Mostra rodape")]
        public bool MostrarRodape
        {
            get { return rodape; }
            set
            {
                rodape = value;
                sts_action.Visible = rodape;
            }
        }

        [Category("Custom")]
        [Description("Cor do Titulo")]
        public System.Drawing.Color CorTitulo
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
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
        [Description("texto do cabeçalho")]
        public string Cabecalho
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
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

        #region metodos

        #region metodos privados

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

        private void inicializar()
        {
            cont = ContarDados(Enums.GridView.Linhas) + 1;
            tss_action.Text = mensageiro(cont);

            foreach (DataGridViewColumn column in dgv_consulta.Columns)
            {
                column.ReadOnly = true;
            }
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

        private void alterarImagem(int linha, Enums.Imagens imagem)
        {
            switch (imagem)
            {
                case Enums.Imagens.acrescimo: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.acrescimo; break;
                case Enums.Imagens.carregar: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.cadastro; break;
                case Enums.Imagens.checado: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.check; break;
                case Enums.Imagens.deschecado: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.uncheck; break;
                case Enums.Imagens.erros: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.erros; break;
                case Enums.Imagens.executado: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.executado; break;
                case Enums.Imagens.informacao: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.informacao; break;
                case Enums.Imagens.naoexecutado: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.nao_executado; break;
                default: this.dgv_consulta.Rows[linha].Cells[0].Value = CoreFramework.Properties.Resources.erro_execucao; break;
            }
        }

        #endregion

        #region metodos publicos

        #region Diversos

        public void AtualizarGrid(string consulta = "")
        {
            inicializar();
            //ttb_action.Text = String.Empty;
            if (validarDados())
            {
                if (!string.IsNullOrEmpty(consulta))
                    carregarDados(consulta);
                else
                    carregarDados();

                //listarCabecalho();
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

        public int FindLinha(string colunaBusca, string criteria)
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

        #region metodos nativos

        private string mensageiro(int linhas_retornadas)
        {
            String retorno = String.Empty;

            if (linhas_retornadas == 0)
                retorno = "Nenhuma linha encontrada";
            else if (linhas_retornadas == 1)
                retorno = cont.ToString() + " Linha encontrada";
            else
                retorno = cont.ToString() + " Linhas encontradas";

            return retorno;
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

        #endregion

        #region metodos customizados

        #region especifico exportacao

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

            FolderBrowserDialog fld = new FolderBrowserDialog();
            DataTable dtExportacao = new DataTable();
            dtExportacao = CoreService.GridToDataTable(this.dgv_consulta, false);

            if (exportarPadrao == Enums.ExportaExcel.Excel2007)
                mensagem = Exportador.Excel.geraExcel("Export", dtExportacao, "Export");
            else if (exportarPadrao == Enums.ExportaExcel.Excel2007comCaminho)
            {
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

        #region eventos
        protected override void OnCreateControl()
        {
            base.InicializarTipo(Enums.TipoControle.Dados);
        }
        private void SimpleGridExtends_Load(object sender, EventArgs e)
        {
            if (validarDados())
                carregarDados(query);
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

        private void tsi_excel_Click(object sender, EventArgs e)
        {
            if (dgv_consulta.Rows.Count == 0)
                MessageBox.Show("Não existem dados para Exportar!");
            else
            {
                Thread thProcessa = new Thread(new ThreadStart(processarInfo));
                thProcessa.Start();
                alerta = new Forms.ProcessForm("Gerando Arquivo!");
                alerta.Show();
            }
        }

        #endregion

    }
}
