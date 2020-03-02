using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using CoreSDK.ODB.DataBase;
using CoreFramework.Objetos;
using System.Threading;
using CoreSDK.Enums;
using CoreMDK.Query;
using CoreSDK.Specific;
using CoreSDK.Services;

namespace CoreFramework.Controles.Controle
{
    public class GridViewExtends : DataGridView
    {
        public event EventHandler AoAlterarCelula;
        private string query = String.Empty;
        private string chave = String.Empty;
        private List<String> cabecalhos = new List<string>();
        Enums.EscolhaBooleana master = Enums.EscolhaBooleana.Não;
        string[] consultas;
        Control[] details;
        private bool ocultar = false;
        System.Drawing.Color colEditavel = System.Drawing.Color.Red;
        Enums.ExportaExcel exportarPadrao = Enums.ExportaExcel.Excel2007;
        Forms.ProcessForm alerta;
        ContextMenuStrip menuContexto = new System.Windows.Forms.ContextMenuStrip();
        private delegate void FechaPopUP();
        int linhaSelecionada = 0;

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewExtends
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewExtends_CellClick);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #region propriedades

        [Category("Custom")]
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
        [Description("Consulta a ser executada no controle")]
        public string Query
        {
            get
            {
                return query;
            }

            set
            {
                query = value;
            }
        }

        [Category("Custom")]
        [Description("Consultas details")]
        public string[] Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }

        [Category("Custom")]
        public Control[] Details
        {
            get { return details; }
            set { details = value; }
        }

        [Category("Custom")]
        [Description("MasterDetail control")]
        public Enums.EscolhaBooleana Master
        {
            get { return master; }
            set { master = value; }
        }

        [Category("Custom")]
        [Description("Ocultar Campo Chave")]
        public bool Ocultar
        {
            get { return ocultar; }
            set { ocultar = value; }
        }

        [Category("Custom")]
        [Description("Cor de coluna editavel")]
        public System.Drawing.Color ColunaEditavel
        {
            get { return colEditavel; }
            set { colEditavel = value; }
        }

        [Category("Custom")]
        [Description("Verificar caminho padrao de exportacao")]
        public Enums.ExportaExcel ExportaPadrao
        {
            get { return exportarPadrao; }
            set { exportarPadrao = value; }
        }

        [Category("Custom")]
        [Description("Menu de Contexto")]
        public ContextMenuStrip Contexto
        {
            get { return menuContexto; }
            set { menuContexto = value; }
        }

        #endregion

        #region metodos

        #region metodos privados

        private void limpar()
        {
            if (this.DataSource != null)
            {
                this.DataSource = null;
                this.Rows.Clear();
                this.Columns.Clear();
            }
            else
            {
                this.Rows.Clear();
                this.Columns.Clear();
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

        private void carregarDados()
        {
            DataTable dt = default(DataTable);

            if (validarDados())
            {
                dt = DB.ExecutaReader(Query);
                this.DataSource = dt;
            }
        }

        private void estilo()
        {
            this.BackgroundColor = SystemColors.ActiveCaption;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            this.DefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
            this.RowHeadersVisible = false;
            this.EnableHeadersVisualStyles = false;
            this.AllowUserToAddRows = false;
            //this.ReadOnly = true;
        }

        private void montaMasterDetail(DataGridViewCellEventArgs e)
        {
            string consulta = string.Empty;
            string tipo = string.Empty;
            string QuerySecundaria = string.Empty;
            if (master == Enums.EscolhaBooleana.Sim)
            {
                var selecionado = this.Rows[e.RowIndex].Cells[0].Value;

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

        private List<String> Cabecalhos()
        {
            foreach (DataGridViewColumn col in this.Columns)
            {
                if (col.Visible)
                    cabecalhos.Add(col.Name);
            }
            return cabecalhos;
        }

        #endregion

        #region metodos publicos

        #region Diversos

        public void CarregarDados(string consulta)
        {
            DataTable dtDados = default(DataTable);

            query = consulta;

            limpar();
            if (validarDados())
            {
                dtDados = DB.ExecutaReader(Query);
                this.DataSource = dtDados;
                if (ocultar)
                    this.Columns[0].Visible = true;
                else
                    this.Columns[0].Visible = false;
            }
        }

        public void AtualizarGrid(string consulta = "")
        {
            if (!string.IsNullOrEmpty(consulta))
                CarregarDados(consulta);
            else
                carregarDados();
        }

        public void RecarregarDados()
        {
            DataTable dtdados = new DataTable();
            dtdados = CoreService.GridToDataTable(this);
            this.DataSource = null;
            dtdados.Columns.Remove("Column1");
            for (int indice = 0; indice < this.Columns.Count; indice++)
            {
                if (indice > 0)
                    this.Columns.RemoveAt(indice);
            }
            this.DataSource = dtdados;
        }

        public int LinhaSelecionada()
        {
            linhaSelecionada = this.CurrentCell.RowIndex;
            return linhaSelecionada;
        }

        public int ColunaSelecionada()
        {
            return this.CurrentCell.ColumnIndex;
        }

        public string CelulaSelecionada()
        {
            return this.Rows[this.CurrentCell.RowIndex].Cells[this.CurrentCell.ColumnIndex].Value.ToString();
        }

        public string CabecalhoColuna()
        {
            return this.Columns[this.CurrentCell.ColumnIndex].HeaderText.ToString();
        }

        public int Quantidade()
        {
            return this.Rows.Count;
        }

        public int QuantidadeColunas()
        {
            return this.Columns.Count;
        }

        #endregion

        #region Busca e Retorno

        public bool ExisteColuna(int coluna, string criteria)
        {
            bool retorno = false;
            for (int indice = 0; indice < this.Rows.Count; indice++)
            {
                string compare = this.Rows[indice].Cells[coluna].Value.ToString();
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
            for (int indice = 0; indice < this.Columns.Count; indice++)
            {
                string compare = this.Rows[indice].Cells[colunaBusca].Value.ToString();
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
            for (int indice = 0; indice < this.Rows.Count; indice++)
            {
                string compare = this.Rows[indice].Cells[colunaBusca].Value.ToString();
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
            for (int indice = 0; indice < this.Rows.Count; indice++)
            {
                string compare = this.Rows[indice].Cells[colunaBusca].Value.ToString();
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
            for (int indice = 0; indice < this.Rows.Count; indice++)
            {
                string compare = this.Rows[indice].Cells[colunaBusca].Value.ToString();
                if (compare == criteria)
                    retorno.Add(indice);
            }
            return retorno;
        }

        public List<int> FindListaLinhas(Condition condicao)
        {
            List<int> retorno = new List<int>();
            for (int indice = 0; indice < this.Rows.Count; indice++)
            {
                string tipo = condicao.Valor1.GetType().Name.ToString();
                var valorColuna = this.Rows[indice].Cells[condicao.Nome].Value;
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
            if (this.Columns.Count >= coluna)
            {
                if (this.Rows.Count > 0)
                {
                    for (int indice = 0; indice < this.Rows.Count; indice++)
                    {
                        retorno += Convert.ToDecimal(this.Rows[indice].Cells[coluna].Value);
                    }
                }
            }
            return retorno;
        }

        public Decimal SomaLinhas(int colunaSoma, int colunaBusca, string criteria)
        {
            Decimal retorno = 0;
            if (this.Columns.Count >= colunaBusca)
            {
                if (this.Rows.Count > 0)
                {
                    for (int indice = 0; indice < this.Rows.Count; indice++)
                    {
                        if (this.Rows[indice].Cells[colunaBusca].Value.ToString() == criteria)
                            retorno += Convert.ToDecimal(this.Rows[indice].Cells[colunaSoma].Value);
                    }
                }
            }
            return retorno;
        }

        public Decimal SomaLinhas(string colunaSoma, string colunaBusca, string criteria)
        {
            Decimal retorno = 0;

            if (this.Rows.Count > 0)
            {
                for (int indice = 0; indice < this.Rows.Count; indice++)
                {
                    if (this.Rows[indice].Cells[colunaBusca].Value.ToString() == criteria)
                        retorno += Convert.ToDecimal(this.Rows[indice].Cells[colunaSoma].Value);
                }
            }
            return retorno;
        }

        #endregion

        #region Edicao

        public string Valor(int linha, int coluna)
        {
            string retorno = string.Empty;
            if (coluna <= this.Columns.Count)
                if (linha <= this.Rows.Count)
                {
                    retorno = this.Rows[linha].Cells[coluna].Value.ToString();
                }
            return retorno;
        }

        public string Valor(int linha, string coluna)
        {
            string retorno = string.Empty;
            if (linha <= this.Rows.Count)
            {
                retorno = this.Rows[linha].Cells[coluna].Value.ToString();
            }
            return retorno;
        }

        public void EditarGrid(bool valor)
        {
            this.ReadOnly = !valor;
        }

        public void EditarColunas(string coluna, bool valor)
        {
            this.Columns[coluna].ReadOnly = !valor;
            this.Columns[coluna].DefaultCellStyle.ForeColor = colEditavel;
        }

        public void EditarColunas(List<string> coluna)
        {
            int col = 0;
            EditarGrid(true);
            for (int indice = 0; indice < this.Columns.Count; indice++)
            {
                if (col < coluna.Count)
                {
                    if (this.Columns[indice].Name == coluna[col])
                    {
                        this.Columns[coluna[col]].ReadOnly = false;
                        col += 1;
                    }
                    else
                        this.Columns[indice].ReadOnly = true;
                }
                else
                    this.Columns[indice].ReadOnly = true;
            }
        }

        public void EditarLinhas(List<int> linha)
        {
            int lin = 0;
            EditarGrid(true);
            for (int indice = 0; indice < this.Rows.Count; indice++)
            {
                if (lin < linha.Count)
                {
                    if (indice == linha[lin])
                    {
                        this.Rows[linha[lin]].ReadOnly = false;
                        //this.Rows[linha[lin]].DefaultCellStyle.ForeColor = colEditavel;
                        lin += 1;
                    }
                    else
                        this.Rows[indice].ReadOnly = true;
                }
                else
                    this.Rows[indice].ReadOnly = true;
            }
        }
        
        public void DestacarLista()
        {
            List<int> colunas = new List<int>();
            List<int> linhas = new List<int>();
            int indiceColuna = 0;
            int indiceLinha = 0;

            for (int indice = 0; indice < this.Columns.Count; indice++)
            {
                if (this.Columns[indice].ReadOnly == false)
                    colunas.Add(indice);
            }

            for (int indice = 0; indice < this.Rows.Count; indice++)
            {
                if (this.Rows[indice].ReadOnly == false)
                    linhas.Add(indice);
            }

            for (int indice1 = 0; indice1 < this.Columns.Count; indice1++)
            {
                if (indiceColuna < colunas.Count)
                {
                    if (indice1 == colunas[indiceColuna])
                    {
                        indiceLinha = 0;
                        for (int indice2 = 0; indice2 < this.Rows.Count; indice2++)
                        {
                            if (indiceLinha < linhas.Count)
                            {
                                if (indice2 == linhas[indiceLinha])
                                {
                                    this.Rows[indice2].Cells[indice1].Style = new DataGridViewCellStyle { ForeColor = colEditavel, Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold) };
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
                this.Rows[linhaSelecionada].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                this.Rows[linhaSelecionada].DefaultCellStyle.ForeColor = cor;
            }
        }

        public void DestacarLinha(int linha, System.Drawing.Color cor)
        {
            this.Rows[linha].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.Rows[linha].DefaultCellStyle.ForeColor = cor;
        }
        
        public void LimparGrid()
        {
            if (this.Rows.Count > 0)
            {
                this.DataSource = null;
                this.Rows.Clear();
                this.Refresh();
            }
        }
        
        #endregion

        #endregion

        #region metodos nativos

        public void ContextoPadrao()
        {
            menuContexto.Items.Clear();
            menuContexto.Items.Add("Gerar Excel", CoreFramework.Properties.Resources.exceloficial, menuItem_Click);
        }

        #endregion

        #region metodos customizados

        #region especificos exportacao

        private void processarInfo()
        {
            string mensagem = string.Empty;
            mensagem = executarExcel(mensagem);
            this.Invoke(new FechaPopUP(this.fecharPopUp));
            MessageBox.Show(mensagem);
        }

        private string executarExcel(string mensagem)
        {
            string caminho = string.Empty;
            DataTable dtExportacao =  CoreService.GridToDataTable(this, false);
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

        private void fecharPopUp()
        {
            alerta.Close();
        }

        #endregion

        #endregion

        #endregion

        #region eventos

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            estilo();
            carregarDados();
            this.CellClick += GridViewExtends_CellClick;
            this.CellValueChanged += GridViewExtends_CellValueChanged;
            this.CellMouseDown += GridViewExtends_CellMouseDown;
            this.MouseClick += GridViewExtends_MouseClick;
        }

        private void GridViewExtends_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.CurrentCell = this.Rows[e.RowIndex].Cells[e.ColumnIndex];
            linhaSelecionada = e.RowIndex;
        }

        private void GridViewExtends_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            montaMasterDetail(e);
        }

        private void GridViewExtends_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuContexto.Show(this, new Point(e.X, e.Y));
            }
        }

        private void GridViewExtends_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.AoAlterarCelula != null)
            {
                this.AoAlterarCelula(this, e);
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            if (this.Rows.Count == 0)
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
