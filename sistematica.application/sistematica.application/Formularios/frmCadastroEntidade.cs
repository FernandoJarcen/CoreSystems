//using CoreEntities.Base;
using CoreKonnector.Model;
using CoreSDK.Entities.Base;
using CoreSDK.Enums;
using CoreSDK.ODB.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace sistematica.application.Formularios
{
    public partial class frmCadastroEntidade : Form
    {
        string entidadeAtiva = string.Empty;
        string parenteAtiva = string.Empty;
        public frmCadastroEntidade(string entidade, string parente)
        {
            InitializeComponent();
            entidadeAtiva = entidade;
            parenteAtiva = parente;
            inicializar(entidadeAtiva, parenteAtiva);
        }

        private void inicializar(string entidadeAtiva, string parenteAtiva)
        {
            camposInformacoes();
            camposEntidade();
            this.captionExtends1.Titulo = "Entidade " + entidadeAtiva;
        }

        private void camposInformacoes()
        {
            lbl_entidadeAtiva.Valor = entidadeAtiva;
            lbl_entidadeRelacionada.Valor = parenteAtiva;
        }

        private void camposEntidade()
        {
            string tabela = string.Empty;
            tabela = Acao<EntidadeSistema>.Selecionar("Nome", "Apelido = '" + entidadeAtiva + "'");
            lbl_entidade.Valor = entidadeAtiva;
            lbl_apelido.Valor = tabela;
            DataTable dtTabela = new DataTable();
            dtTabela = ObterColunas(tabela);
            sgd_camposEntidade.Dados = dtTabela;
            sgd_camposEntidade.AtualizarGrid();
        }

        public DataTable ObterColunas(string tabela)
        {
            DataTable retorno = new DataTable();
            List<Parametros> parametro = new List<Parametros>();

            try
            {
                parametro.Add(new Parametros("p_tabela", tabela, BancoDados.TipoDados.Texto, ParameterDirection.Input));
                retorno = Acao<EntidadeSistema>.Procedure("sis.prc_retorna_campos", parametro);
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }
        
        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
