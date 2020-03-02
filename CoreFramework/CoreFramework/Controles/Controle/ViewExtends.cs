using CoreFramework.Controles.Controle.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CoreFramework.Objetos;
using CoreSDK.ODB.DataBase;
using CoreFramework.Controles.Base;

namespace CoreFramework.Controles.Controle
{
    public partial class ViewExtends : CommonGridExtends
    {
        int cont = 0;
        bool rodape = true;
        bool filtro = true;
        bool filtroParcial = true;
        private string criteria = String.Empty;
        Dictionary<String, String> colecao = new Dictionary<string, string>();
        string[] consultas = null;

        #region propriedades

        [Category("Custom")]
        [Description("Texto da mensagem")]
        public string Mensagem
        {
            get { return tss_action.Text; }
            set { tss_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Modo de apresentação das colunas")]
        public DataGridViewAutoSizeColumnsMode Modo
        {
            get { return (DataGridViewAutoSizeColumnsMode)this.dgv_consulta.AutoSizeColumnsMode; }
            set { this.dgv_consulta.AutoSizeColumnsMode = value; }
        }

        [Category("Custom")]
        [Description("Mostrar/Ocultar Filtro")]
        public bool MostrarFiltro
        {
            get { return filtro; }
            set
            {
                filtro = value;
                toolStrip1.Visible = filtro;
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

        #endregion
        public ViewExtends()
        {
            InitializeComponent();
        }

        #region Metodos

        #region metodos privados

        private bool validarDados()
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(this.Query))
                retorno = true;
            else
                retorno = false;
            return retorno;
        }

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
                dados = this.Query;

            if (String.IsNullOrEmpty(Ordenacao))
                dtDados = DB.ExecutaReader(consulta);
            else
            {
                dados += " order by " + this.Ordenacao;
                dtDados = DB.ExecutaReader(dados);
            }

            dgv_consulta.DataSource = dtDados;
            inicializar();
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
                    if (this.Canonico)
                    {
                        if (!Subconsulta)
                        {
                            if (Query.Contains("where"))
                                qry = Query + " and " + criteria + " like '%" + ttb_action.Text + "%'";
                            else
                                qry = Query + " where " + criteria + " like '%" + ttb_action.Text + "%'";
                        }
                        else
                            if (Query.Contains("as q where"))
                                qry = Query + " and " + criteria + " like '%" + ttb_action.Text + "%'";
                            else
                                qry = Query + " where " + criteria + " like '%" + ttb_action.Text + "%'";

                        carregarDados(qry);
                    }
                    else
                    {
                        nome_canonico = colecao[criteria].ToString();
                        criteria = nome_canonico;
                        if (Query.Contains("where"))
                            qry = Query + " and " + criteria + " like '%" + ttb_action.Text + "%'";
                        else
                            qry = Query + " where " + criteria + " like '%" + ttb_action.Text + "%'";

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

            if (Master == Enums.EscolhaBooleana.Sim)
            {
                var selecionado = this.dgv_consulta.Rows[e.RowIndex].Cells[1].Value;

                for (int indice = 0; indice < this.Details.Length; indice++)
                {
                    QuerySecundaria = consultas[indice];
                    consulta = QuerySecundaria + " WHERE " + Chave + " = " + selecionado;
                    if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.CheckGridExtends")
                    {
                        CheckGridExtends ctl = (CheckGridExtends)this.Details[indice];
                        ctl.AtualizarGrid(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.GridViewExtends")
                    {
                        GridViewExtends gvw = (GridViewExtends)this.Details[indice];
                        gvw.CarregarDados(consulta);
                        //gvw.carregarDados(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.SimpleGridExtends")
                    {
                        SimpleGridExtends sgd = (SimpleGridExtends)this.Details[indice];
                        sgd.AtualizarGrid(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.SelectGridExtends")
                    {
                        SelectGridExtends slg = (SelectGridExtends)this.Details[indice];
                        slg.AtualizarGrid(consulta);
                    }
                    else if (this.Details[indice].GetType().ToString() == "CoreFramework.Controles.controle.CaptionGridExtend")
                    {
                        CaptionGridExtends std = (CaptionGridExtends)this.Details[indice];
                        std.AtualizarGrid(consulta);
                    }
                }
            }
        }

        #endregion

        #region metodos publicos

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

        public bool BuscaColuna(int coluna, string criteria)
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

        public void EditarGrid(bool valor)
        {
            this.dgv_consulta.ReadOnly = !valor;
        }

        public void EditarColunas(string coluna, bool valor)
        {
            this.dgv_consulta.Columns[coluna].ReadOnly = !valor;
            this.dgv_consulta.Columns[coluna].DefaultCellStyle.ForeColor = ColunaEditavel;
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
                                    this.dgv_consulta.Rows[indice2].Cells[indice1].Style = new DataGridViewCellStyle { ForeColor = ColunaEditavel, Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold) };
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

        #endregion

        #region metodos customizados

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

        public void SelecionarTodos(bool status)
        {
            foreach (DataGridViewRow row in this.dgv_consulta.Rows)
            {
                row.Cells[0].Value = status;
            }
            cont = ContarSelecionados();
            tss_action.Text = mensageiro(cont);
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

    }
}
