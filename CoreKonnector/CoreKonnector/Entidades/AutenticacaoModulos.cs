using System;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using DevComponents.DotNetBar;
using CoreSDK.Utils;
using CoreSDK.Enums;
using CoreSDK.Entities.Base;
using CoreKonnector.Model;
using CoreSDK.Objetos;

namespace CoreKonnector.Entidades
{
    [Descricao("Classe de autenticação de módulos","01/06/2019")]
    public static class AutenticacaoModulos
    {
        public static string CarregarBotoes(int codigo, string modulo, DevComponents.DotNetBar.RibbonControl control)
        {
            string retorno = string.Empty;
            DataTable dtAplicacao = AutenticacaoSistema.BuscarAplicacao(codigo, modulo);
            DataTable dtModulo = AutenticacaoSistema.BuscarModulo(codigo, modulo);
            DataTable dtRotina = AutenticacaoSistema.BuscarRotina(codigo, modulo);

            bool existePerfil = AutenticacaoSistema.ValidarComponentes(dtAplicacao, dtModulo, dtRotina);

            if (existePerfil)
            {
                foreach (BaseItem item in control.Items)
                {
                    RibbonTabItem Tab = item as RibbonTabItem;
                    for (int indice1 = 0; indice1 < dtAplicacao.Rows.Count; indice1++)
                    {
                        if (Tab.Name.ToString() == dtAplicacao.Rows[indice1][0].ToString())
                        {
                            Tab.Visible = true;
                            if (Tab != null)
                            {
                                RibbonPanel Pnl = Tab.Panel;

                                foreach (Control panelControl in Pnl.Controls)
                                {
                                    RibbonBar Bar = panelControl as RibbonBar;
                                    if (Bar.Name.ToString() != "rba_modulo")
                                    {
                                        if (Bar != null)
                                        {
                                            for (int indice2 = 0; indice2 < dtModulo.Rows.Count; indice2++)
                                            {
                                                if (Bar.Name.ToString() == dtModulo.Rows[indice2][0].ToString())
                                                {
                                                    Bar.Visible = true;
                                                    foreach (BaseItem Btn in Bar.Items)
                                                        for (int indice3 = 0; indice3 < dtRotina.Rows.Count; indice3++)
                                                        {
                                                            if (Btn.Name.ToString() == dtRotina.Rows[indice3][0].ToString())
                                                            {
                                                                Btn.Visible = true;
                                                                break;
                                                            }
                                                        }
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                retorno = "Não existe perfil definido para esse módulo";
            }
            return retorno;
        }

        public static void ValidarFormulario(DevComponents.DotNetBar.RibbonControl control, bool status)
        {
            foreach (BaseItem item in control.Items)
            {
                RibbonTabItem Tab = item as RibbonTabItem;
                if (Tab != null)
                {
                    RibbonPanel Pnl = Tab.Panel;

                    foreach (Control panelControl in Pnl.Controls)
                    {
                        RibbonBar Bar = panelControl as RibbonBar;
                        if (Bar.Name.ToString() != "rba_modulo")
                        {
                            if (Bar != null)
                            {
                                Bar.Visible = status;
                                foreach (BaseItem Btn in Bar.Items)
                                    Btn.Visible = status;
                            }
                        }
                    }

                    if (Tab.Name != "rtb_modulo")
                        Tab.Visible = status;
                }
            }
        }

        public static void InicializarInstancia(int codigoInstancia)
        {
            try
            {
                Util.Executar(codigoInstancia);
                //if (!string.IsNullOrEmpty(nomeInstancia))
                //    Util.Parametros[Prm.NomeInstancia] = nomeInstancia;
            }
            catch (Exception ex)
            {
                LOG.Escrever("003.InicializarInstancia", ex.Message.ToString());
            }
            
        }

        public static void CarregarModulo(String executavel, String nomeAmigavel)
        {
            String codigoFilial = Util.Parametros[Prm.CodigoFilial].ToString();
            String nomeFilial = Util.Parametros[Prm.FilialAtiva].ToString();
            int usuarioId = Convert.ToInt32(Util.Parametros[Prm.CodigoUsuario].ToString());
            String usuario = Util.Parametros[Prm.NomeUsuario].ToString();
            int instancia = Convert.ToInt32(Util.Parametros[Prm.CodigoInstancia].ToString());

            string mensagem = string.Empty;
            try
            {
                if (CoreSDK.Services.FileService.VerificarArquivo(executavel))
                {
                    string caminho = Util.Parametros[Prm.CaminhoExecutavel].ToString() + executavel + ".exe";

                    ProcessStartInfo startInfo = new ProcessStartInfo(caminho);
                    startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    string parametros = string.Format("{0} {1} {2} {3} {4}", codigoFilial, nomeFilial.Replace(" ", "?"), usuarioId, usuario.Replace(" ", "?"), instancia);

                    try
                    {
                        startInfo.Arguments = parametros;
                        startInfo.UseShellExecute = false;
                        Process.Start(startInfo);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                    MessageBox.Show(nomeAmigavel.PriMaiuscula() + " não encontrado!", "Sistemática", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CarregarModulo(String executavel, String nomeAmigavel,bool atualizacao = false)
        {
            String codigoFilial = "1";
            String nomeFilial = "Desenvolvimento";
            int usuarioId = 1;
            String usuario = "Administrador";
            int instancia = 1;

            string mensagem = string.Empty;
            try
            {
                string caminho = "c:\\Sistematica\\" + executavel + ".exe";
                if (CoreSDK.Services.FileService.VerificarArquivoEspecifico(caminho))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(caminho);
                    startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    string parametros = string.Format("{0} {1} {2} {3} {4}", codigoFilial, nomeFilial.Replace(" ", "?"), usuarioId, usuario.Replace(" ", "?"), instancia);

                    try
                    {
                        startInfo.Arguments = parametros;
                        startInfo.UseShellExecute = false;
                        Process.Start(startInfo);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                    MessageBox.Show(nomeAmigavel.PriMaiuscula() + " não encontrado!", "Sistemática", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Modularizacao> ModulosAutenticacao()
        {
            List<Modularizacao> listaModulos = new List<Modularizacao>();
            DataTable dtModulos = Acao<ModuloSistema>.SelecionarTodos(new string[] { "CodigoModulo", "Descricao", "Executavel" });
            if (dtModulos.Rows.Count > 0)
            {
                for (int indice = 0; indice < dtModulos.Rows.Count; indice++)
                {
                    int codigo = Convert.ToInt32(dtModulos.Rows[indice]["CodigoModulo"].ToString());
                    string descricao = dtModulos.Rows[indice]["Descricao"].ToString();
                    string executavel = dtModulos.Rows[indice]["Executavel"].ToString();
                    listaModulos.Add(new Modularizacao(codigo, descricao, executavel));
                }
            }
            return listaModulos;
        }

        public static bool VerificarAlteraSenha(int usuario)
        {
            bool retorno = false;
            int habilitar = Acao<Usuario>.Contar("UsuarioID = " + usuario + " and AlteraSenha = 'S'");
            if (habilitar > 0)
                retorno = true;
            else
                retorno = false;
            return retorno;
        }

        public static string[] ConverterParametros(string[] parametro)
        {
            string[] retorno = new string[5];
            for (int indice = 0; indice < parametro.Length; indice++)
            {
                retorno[indice] = parametro[indice].Replace("?", " ");
                if (indice == 4)
                    retorno[indice] = parametro[indice].Replace(" ", "");
            }
            return retorno;
        }
    }
}
