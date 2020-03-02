using CoreFramework.Controles.Controle.Itens;
using CoreFramework.Controles.Controle.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public partial class InfoGridExtends : DesignControlBase
    {
        int cont = 0;
        List<InfoItem> colecao = new List<InfoItem>();
        bool cabecalho = true;
        bool rodape = true;

        public InfoGridExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Mostrar/Ocultar cabecalho")]
        public bool MostrarCabecalho
        {
            get { return this.pnl_action.Visible; }
            set
            {
                cabecalho = value;
                this.pnl_action.Visible = cabecalho;
            }
        }

        [Category("Custom")]
        [Description("Titulo do cabeçalho")]
        public string Titulo
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do painel")]
        public System.Drawing.Color Cor
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Cor do texto")]
        public System.Drawing.Color CorTexto
        {
            get { return lbl_action.ForeColor; }
            set { lbl_action.ForeColor = value; }
        }

        [Category("Custom")]
        [Description("Mostra/Oculta rodape")]
        public bool MostrarRodape
        {
            get { return rodape; }
            set
            {
                rodape = value;
                sst_action.Visible = rodape;
            }
        }

        [Category("Custom")]
        [Description("Texto da mensagem")]
        public string Mensagem
        {
            get { return tss_action.Text; }
            set { tss_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Texto da coluna")]
        public string Caption
        {
            get { return this.dgv_consulta.Columns[1].HeaderText; }
            set { this.dgv_consulta.Columns[1].HeaderText = value; }
        }

        #endregion

        #region Metodos

        public int ContarDados(Enums.GridView criterio_busca)
        {
            int retorno = 0;
            if (criterio_busca == Enums.GridView.Linhas)
                retorno = dgv_consulta.Rows.Count - 1;
            else
                retorno = dgv_consulta.Columns.Count - 1;
            return retorno;
        }
        [Browsable(false)]
        public void ApagaColuna(int indice_coluna)
        {
            if (ContarDados(Enums.GridView.Colunas) >= indice_coluna)
                dgv_consulta.Columns.Remove(dgv_consulta.Columns[indice_coluna]);
        }
        [Browsable(false)]
        public void ApagaLinha(int indice_linha)
        {
            if (ContarDados(Enums.GridView.Linhas) >= indice_linha)
                dgv_consulta.Rows.Remove(dgv_consulta.Rows[indice_linha]);
        }
        public void Limpar()
        {
            dgv_consulta.Rows.Clear();
        }
        public void Atualizar(int indice, Enums.Imagens imagem, string mensagem)
        {
            int tamanho = colecao.Count - 1;
            if (indice - 1 <= tamanho)
            {
                this.dgv_consulta.Rows[indice - 1].Cells[0].Value = reverteFigura(imagem);
                this.dgv_consulta.Rows[indice - 1].Cells[1].Value = mensagem;
            }
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
        public void Item(Enums.Imagens imagem, string mensagem)
        {
            int codigo = 0;
            for (int indice = 0; indice < colecao.Count - 1; indice++)
            {
                codigo = colecao[indice].codigo;
            }

            colecao.Add(new InfoItem(codigo + 1, imagem, mensagem));
            this.dgv_consulta.Rows.Add(reverteFigura(imagem), mensagem);

        }
        private System.Drawing.Image reverteFigura(Enums.Imagens codigo)
        {
            System.Drawing.Image retorno = null;
            switch (codigo)
            {
                case Enums.Imagens.acrescimo:
                    retorno = CoreFramework.Properties.Resources.acrescimo; break;
                case Enums.Imagens.checado:
                    retorno = CoreFramework.Properties.Resources.check; break;
                case Enums.Imagens.deschecado:
                    retorno = CoreFramework.Properties.Resources.uncheck; break;
                case Enums.Imagens.fechar:
                    retorno = CoreFramework.Properties.Resources.close; break;
                case Enums.Imagens.erros:
                    retorno = CoreFramework.Properties.Resources.erros; break;
                case Enums.Imagens.executar:
                    retorno = CoreFramework.Properties.Resources.executar; break;
                case Enums.Imagens.executado:
                    retorno = CoreFramework.Properties.Resources.executado; break;
                case Enums.Imagens.informacao:
                    retorno = CoreFramework.Properties.Resources.informacao; break;
                case Enums.Imagens.naoexecutado:
                    retorno = CoreFramework.Properties.Resources.nao_executado; break;
                case Enums.Imagens.pronto:
                    retorno = CoreFramework.Properties.Resources.pronto; break;
                case Enums.Imagens.carregar:
                    retorno = CoreFramework.Properties.Resources.tarefa; break;

            }
            return retorno;
        }

        #endregion

        #region eventos

        private void InfoGridExtends_Load(object sender, EventArgs e)
        {
            inicializar();
        }

        #endregion
    }
}
