using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CoreFramework.Controles.Controle.Itens;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public partial class ProcessExtends : UserControl
    {
        List<ProcessoItem> colecao = new List<ProcessoItem>();
        Enums.Processo processo = Enums.Processo.Executar;
        public event EventHandler AoClicar;

        public ProcessExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Processo")]
        public Enums.Processo Processo
        {
            get { return processo; }
            set
            {
                processo = value;
                retornaProcesso(processo);
            }
        }

        [Category("Custom")]
        [Description("Texto da coluna")]
        public string Caption
        {
            get { return this.dgv_consulta.Columns[1].HeaderText; }
            set { this.dgv_consulta.Columns[1].HeaderText = value; }
        }

        [Category("Custom")]
        [Description("Texto do mensageiro")]
        public string Mensageiro
        {
            get { return this.lkl_mensagem.Text; }
            set { lkl_mensagem.Text = value; }
        }

        [Category("Custom")]
        [Description("Texto do Status")]
        public string Status
        {
            get { return this.lbl_action.Text; }
            set { lbl_action.Text = value; }
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
        public void ApagarColuna(int indice_coluna)
        {
            if (ContarDados(Enums.GridView.Colunas) >= indice_coluna)
                dgv_consulta.Columns.Remove(dgv_consulta.Columns[indice_coluna]);
        }

        [Browsable(false)]
        public void ApagarLinha(int indice_linha)
        {
            if (ContarDados(Enums.GridView.Linhas) >= indice_linha)
                dgv_consulta.Rows.Remove(dgv_consulta.Rows[indice_linha]);
        }

        public void Limpar()
        {
            dgv_consulta.Rows.Clear();
        }

        public void Atualizar(int indice, Enums.Processo processo, string mensagem)
        {
            int tamanho = colecao.Count - 1;
            if (indice - 1 <= tamanho)
            {
                this.dgv_consulta.Rows[indice - 1].Cells[0].Value = reverteFigura(processo);
                this.dgv_consulta.Rows[indice - 1].Cells[1].Value = mensagem;
            }
        }

        private void inicializar()
        {
            //cont = 0;

            foreach (DataGridViewColumn column in dgv_consulta.Columns)
            {
                if (column.Index != 0)
                {
                    column.ReadOnly = true;
                }
            }

            lkl_mensagem.LinkClicked += lkl_mensagem_LinkClicked;
        }

        public void Item(Enums.Processo processo, string mensagem)
        {
            int codigo = 0;
            for (int indice = 0; indice < colecao.Count - 1; indice++)
            {
                codigo = colecao[indice].codigo;
            }

            colecao.Add(new ProcessoItem(codigo + 1, processo, mensagem));
            this.dgv_consulta.Rows.Add(reverteFigura(processo), mensagem);
        }

        private System.Drawing.Image reverteFigura(Enums.Processo codigo)
        {
            System.Drawing.Image retorno = null;
            switch (codigo)
            {
                case Enums.Processo.Erro:
                    retorno = CoreFramework.Properties.Resources.erros; break;
                case Enums.Processo.Sucesso:
                    retorno = CoreFramework.Properties.Resources.executado; break;
                case Enums.Processo.Atencao:
                    retorno = CoreFramework.Properties.Resources.informacao; break;
                case Enums.Processo.Executar:
                    retorno = CoreFramework.Properties.Resources.executar; break;

            }
            return retorno;
        }

        private void retornaProcesso(Enums.Processo processo)
        {
            switch (processo)
            {
                case CoreFramework.Objetos.Enums.Processo.Sucesso:
                    lbl_action.Text = "Sucesso";
                    lbl_action.Image = CoreFramework.Properties.Resources.executado;
                    break;
                case CoreFramework.Objetos.Enums.Processo.Erro:
                    lbl_action.Text = "Erro";
                    lbl_action.Image = CoreFramework.Properties.Resources.erros;
                    break;
                case CoreFramework.Objetos.Enums.Processo.Atencao:
                    lbl_action.Text = "Atenção";
                    lbl_action.Image = CoreFramework.Properties.Resources.informacao;
                    break;
                case CoreFramework.Objetos.Enums.Processo.Executar:
                    lbl_action.Text = "A Executar";
                    lbl_action.Image = CoreFramework.Properties.Resources.executar;
                    break;
                default:
                    lbl_action.Text = "A Executar";
                    lbl_action.Image = CoreFramework.Properties.Resources.executar;
                    break;
            }
        }

        #endregion

        #region eventos

        private void lkl_mensagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.AoClicar != null)
            {
                this.AoClicar(this, e);
            }
        }

        #endregion


    }
}
