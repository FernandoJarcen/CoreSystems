using CoreSDK.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sistematica.application.Formularios
{
    public partial class frmEditorXml : Form
    {
        public frmEditorXml()
        {
            InitializeComponent();
        }

        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_executar_AoClicar(object sender, EventArgs e)
        {
            limparCampos();
            if (!String.IsNullOrEmpty(fld_arquivo.Valor))
            {
                string caminho = fld_arquivo.Valor;
                if (System.IO.File.Exists(caminho))
                {
                    Xml.Descriptografar(caminho);
                    string teste = Xml.BuscaTAG("padrao");
                    if (!string.IsNullOrEmpty(teste))
                        preencherCaminhos(caminho);
                    else
                    {
                        MessageBox.Show("Não existe configuração aceitável nesse arquivo!");
                        limparCampos();
                    }
                    Xml.Criptografar(caminho);
                }
                else
                    MessageBox.Show("O arquivo não existe!");
            }

        }

        private void limparCampos()
        {
            fld_padrao.Valor = string.Empty;
            fld_log.Valor = string.Empty;
            fld_instancia.Valor = string.Empty;
            fld_executaveis.Valor = string.Empty;
            fld_configuracoes.Valor = string.Empty;
            fld_customizacao.Valor = string.Empty;
            fld_exportador.Valor = string.Empty;
            fld_formatos.Valor = string.Empty;
            simpleGridExtends1.LimparGrid();
        }
        private void preencherCaminhos(string caminho)
        {
            try
            {
                //Xml.Descriptografar(caminho);
                fld_padrao.Valor = Xml.BuscaTAG("padrao");
                fld_log.Valor = Xml.BuscaTAG("log");
                fld_instancia.Valor = Xml.BuscaTAG("instancia");
                fld_executaveis.Valor = Xml.BuscaTAG("executaveis");
                fld_configuracoes.Valor = Xml.BuscaTAG("cfg");
                fld_customizacao.Valor = Xml.BuscaTAG("customizacao");
                fld_exportador.Valor = Xml.BuscaTAG("exportador");
                fld_formatos.Valor = Xml.BuscaTAG("formatos");
                msk_versao.Valor = Xml.BuscaTAG("versao");
                dte_data.Valor = Xml.BuscaTAG("data");
                cbo_expansivel.Valor = Xml.BuscaTAG("expansivel");
                
                List<string> lista = Xml.BuscaListaTAGS(caminho, "conectividade");
                string[] coluna = new string[] {"Codigo", "Instância", "Source","Autenticação","Banco" };
                if (lista != null)
                {
                    for (int indice = 0; indice < lista.Count; indice++)
                    {
                        string nomeInstancia = lista[indice].ToString();
                        int codigoInstancia = Convert.ToInt16(Xml.BuscaAtributo(nomeInstancia, "id"));
                        string source = Xml.BuscaAtributo(nomeInstancia, "datasource");
                        string autenticacao = Xml.BuscaAtributo(nomeInstancia, "autenticacao");
                        string banco = Xml.BuscaAtributo(nomeInstancia, "banco"); ;
                        simpleGridExtends1.AdicionarLinha(new object[] { codigoInstancia, nomeInstancia, source, autenticacao, banco }, coluna);
                    }
                }

                //Xml.Criptografar(caminho);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void simpleGridExtends1_AoClique(object sender, EventArgs e)
        {
            fld_id.Valor = simpleGridExtends1.Valor(simpleGridExtends1.LinhaSelecionada(), simpleGridExtends1.PosicaoColuna("Codigo"));
            fld_source.Valor = simpleGridExtends1.Valor(simpleGridExtends1.LinhaSelecionada(), simpleGridExtends1.PosicaoColuna("Source"));
            cbo_autenticacao.Valor = simpleGridExtends1.Valor(simpleGridExtends1.LinhaSelecionada(), simpleGridExtends1.PosicaoColuna("Autenticação"));
            cbo_banco.Valor = simpleGridExtends1.Valor(simpleGridExtends1.LinhaSelecionada(), simpleGridExtends1.PosicaoColuna("Banco"));
        }


    }
}
