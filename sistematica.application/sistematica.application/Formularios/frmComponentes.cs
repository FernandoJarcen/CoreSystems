using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CoreSDK.Utils;
using CoreSDK.Entities.Base;
using CoreKonnector.Model;

namespace sistematica.application.Formularios
{
    public partial class frmComponentes : Form
    {
        public frmComponentes(int instancia)
        {
            InitializeComponent();
            Util.Executar(instancia);            
            inicializar();
        }

        private void inicializar()
        {
            string qry = queryExtends1.Query[0].ToString();
            sgd_modulos.Query = qry + " where q.Unidade = 'Global'";
            sgd_modulos.AtualizarGrid();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string abreviacao = string.Empty;
            string processo = string.Empty;

            if (validarDados())
            {
                abreviacao = Acao<ModuloSistema>.Selecionar("Aplicacao", "Descricao = '" + cbo_modulo.Valor + "'");

                if (validarExistente(abreviacao, fld_modulo.Valor, fld_rotina.Valor))
                {
                    using (Componente cpn = new Componente())
                    {
                        cpn.Unidade = cbo_modulo.Valor;
                        cpn.Aplicacao = fld_aplicacao.Valor;
                        cpn.Modulo = fld_modulo.Valor;
                        cpn.Rotina = fld_rotina.Valor;
                        cpn.Funcao = fld_funcao.Valor;
                        processo = Acao<Componente>.Inserir(cpn);
                    }
                }
                else
                    MessageBox.Show("Componente já existente!");

                if (processo == "Registro Incluido com sucesso!")
                {
                    MessageBox.Show("Componente " + fld_funcao.Valor + " criado com sucesso!");
                    fld_funcao.Valor = string.Empty;
                    fld_rotina.Valor = string.Empty;
                    fld_modulo.Valor = string.Empty;
                    fld_aplicacao.Valor = string.Empty;
                    cbo_modulo.Indice = 0;
                    inicializar();
                }
            }
            else
                MessageBox.Show("Não foi possível criar o componente");
        }

        private bool validarExistente(string abreviacao, string modulo, string rotina)
        {
            bool retorno = false;
            DataTable dtComponente = Acao<Componente>.SelecionarTodos(new string[] { "ItemAplicacao", "ItemModulo", "ItemRotina" }, "Aplicacao = '" + abreviacao + "'");
            if ((dtComponente != null) && (dtComponente.Rows.Count > 0))
            {
                var distinctAplicacao = (from DataRow dAplicacao in dtComponente.Rows
                                         select dAplicacao["ItemAplicacao"]).Distinct();
                if (distinctAplicacao.Count() > 0)
                {
                    if (distinctAplicacao.Contains(abreviacao))
                    {
                        var distinctModulo = (from DataRow dRow in dtComponente.Rows
                                              select dRow["ItemModulo"]).Distinct();
                        if (distinctModulo.Count() > 0)
                        {
                            if (distinctModulo.Contains(modulo))
                            {
                                var distinctRotinas = (from DataRow dRotina in dtComponente.Rows
                                                       select dRotina["ItemRotina"]).Distinct();
                                if (distinctRotinas.Count() > 0)
                                {
                                    if (distinctRotinas.Contains(rotina))
                                        retorno = false;
                                    else
                                        retorno = true;
                                }
                                else
                                    retorno = true;
                            }
                            else
                            {
                                var distinctRotinas = (from DataRow dRotina in dtComponente.Rows
                                                       select dRotina["ItemRotina"]).Distinct();
                                if (distinctRotinas.Count() > 0)
                                {
                                    if (distinctRotinas.Contains(rotina))
                                        retorno = false;
                                    else
                                        retorno = true;
                                }
                                else
                                    retorno = true;
                            }
                        }
                        else
                            retorno = false;
                    }
                    else
                        retorno = false;
                }
                else
                    retorno = false;
            }
            else
                retorno = true;
            return retorno;
        }

        private bool validarDados()
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(fld_aplicacao.Valor))
                if (!string.IsNullOrEmpty(fld_modulo.Valor))
                    if (!string.IsNullOrEmpty(fld_rotina.Valor))
                        if (!string.IsNullOrEmpty(fld_funcao.Valor))
                            retorno = true;
            return retorno;
        }

        private void cbo_modulo_AoMudarIndice(object sender, EventArgs e)
        {
            limpar();
            string qry = queryExtends1.Query[0].ToString();
            qry += " where q.Unidade = '" + cbo_modulo.Valor + "'";
            sgd_modulos.Query = qry;
            sgd_modulos.AtualizarGrid();
        }

        private void limpar()
        {
            fld_aplicacao.Valor = string.Empty;
            fld_modulo.Valor = string.Empty;
            fld_rotina.Valor = string.Empty;
            fld_funcao.Valor = string.Empty;
            fld_aplicacao.Focus();
        }
    }
}
