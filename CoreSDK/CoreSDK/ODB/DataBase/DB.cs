using System;
using System.Data;
using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using CoreSDK.Utils;
using CoreSDK.Services;
using CoreSDK.Enums;

namespace CoreSDK.ODB.DataBase
{
    public abstract class DB
    {
        protected static string servico;
        protected static BancoDados.TipoBaseDados banco;
        protected static IDbConnection conexao;
        protected static IDbTransaction transacao;
        protected static string mensagem = string.Empty;
        private static DB instanciaBanco;

        #region abstratas

        public abstract bool AbrirConexao(string p_conexao);
        public abstract DataTable ObterDados(String vtexto, CommandType vtipo);
        public abstract IDbCommand ObterComando();
        public abstract int ExecutarProcedure(string nome);
        public abstract DataTable ExecutarProcedure(string nome, System.Collections.Generic.List<Parametros> parametros);
        public abstract string ExecutarMensagem(string nome, System.Collections.Generic.List<Parametros> parametros);
        public abstract bool FecharConexao();
        public abstract bool VisualizarConexao();

        #endregion

        #region privadas

        private static BancoDados.TipoBaseDados bancodeDados
        {
            get { return banco; }
            set { banco = value; }
        }

        private static void iniciarPropriedades()
        {
            string caminhoPadrao = string.Empty;

            try
            {
                caminhoPadrao = (!string.IsNullOrEmpty(caminhoPadrao) ? caminhoPadrao : "C:\\sistematica\\CFG\\mcapl.xml");
                //if (XmlCryptoService.VerificarCriptografado(caminhoPadrao) == Arquivos.Criptografia.Criptografado)
                //XmlCryptoService.Descriptografar(caminhoPadrao);

                //if (String.IsNullOrEmpty(Util.Parametros[Prm.Servico].ToString()))
                //    servico = Xml.BuscaAtributo("Temp", "datasource");//Xml.BuscaXml("aplicacao");
                //else
                    servico = Util.Servico;//Util.Parametros[Prm.Servico].ToString();
                //if (string.IsNullOrEmpty(Util.Parametros[Prm.Banco].ToString()))
                //    banco = BancoDados.TipoBaseDados.SqlServer;
                //else
                //{
                    switch (Util.Banco)
                    {
                        case "SQL": banco = BancoDados.TipoBaseDados.SqlServer; break;
                        case "ORA": banco = BancoDados.TipoBaseDados.Oracle; break;
                        case "MYS": banco = BancoDados.TipoBaseDados.MySQL; break;
                        case "FBD": banco = BancoDados.TipoBaseDados.Firebird; break;
                        default: banco = BancoDados.TipoBaseDados.SqlServer;
                            break;
                    }
                //}

                //XmlCryptoService.Criptografar(caminhoPadrao, "GlobalDefinitions");
            }
            catch (Exception ex)
            {
                LOG.Escrever("iniciarPropriedades01", ex.Message);
            }
        }

        private static void iniciarPropriedades(string instancia, string caminho)
        {
            string caminhoPadrao = string.Empty;

            try
            {
                caminhoPadrao = (!string.IsNullOrEmpty(caminho) ? caminho : "C:\\sistematica\\CFG\\mcapl.xml");
                //XmlCryptoService.Descriptografar(caminhoPadrao);

                servico = Xml.BuscaAtributo(instancia, "datasource", caminhoPadrao);

                if (string.IsNullOrEmpty(Util.Parametros[Prm.Banco].ToString()))
                    banco = BancoDados.TipoBaseDados.SqlServer;
                else
                {
                    switch (Util.Parametros[Prm.Banco].ToString())
                    {
                        case "SQL": banco = BancoDados.TipoBaseDados.SqlServer; break;
                        case "ORA": banco = BancoDados.TipoBaseDados.Oracle; break;
                        case "MYS": banco = BancoDados.TipoBaseDados.MySQL; break;
                        case "FBD": banco = BancoDados.TipoBaseDados.Firebird; break;
                        default: banco = BancoDados.TipoBaseDados.SqlServer;
                            break;
                    }
                }

                //XmlCryptoService.Criptografar(caminhoPadrao, "GlobalDefinitions");
            }
            catch (Exception ex)
            {
                LOG.Escrever("iniciarPropriedade02", ex.Message);
            }
        }

        private static void iniciarConfiguracoes(BancoDados.TipoBaseDados p_banco, string p_servico)
        {
            banco = p_banco;
            servico = p_servico;

            try
            {
                switch (p_banco)
                {
                    case BancoDados.TipoBaseDados.SqlServer:
                        instanciaBanco = new SqlServer();
                        break;
                    case BancoDados.TipoBaseDados.Oracle:
                        instanciaBanco = new OracleBase();
                        break;
                    case BancoDados.TipoBaseDados.MySQL:
                        instanciaBanco = new MySql();
                        break;
                    case BancoDados.TipoBaseDados.Firebird:
                        instanciaBanco = new Firebird();
                        break;
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("IniciarConfiguracoes", ex.Message);
            }
        }

        private static bool abrirConexao(string conexao)
        {
            return instanciaBanco.AbrirConexao(conexao);
        }

        private static DataTable obterDados(String vtexto, CommandType vtipo)
        {
            return instanciaBanco.ObterDados(vtexto, vtipo);
        }

        private static int executarProcedure(string nome)
        {
            return instanciaBanco.ExecutarProcedure(nome);
        }

        private static DataTable executarProcedure(string nome, System.Collections.Generic.List<Parametros> parametros)
        {
            return instanciaBanco.ExecutarProcedure(nome, parametros);
        }

        private static string executarMensagem(string nome, System.Collections.Generic.List<Parametros> parametros)
        {
            return instanciaBanco.ExecutarMensagem(nome, parametros);
        }

        private static int executarNoquery(String vcomando)
        {
            int retorno = 0;
            bool continua = true;
            IDbCommand pcomando = obterComando();

            pcomando.CommandText = vcomando;
            pcomando.CommandType = CommandType.Text;

            try
            {
                if (continua)
                {
                    pcomando.Connection = conexao;
                    try
                    {
                        retorno = (int)pcomando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        mensagem = ex.Message;
                        LOG.Escrever("executarNONQuery", mensagem);
                        retorno = -1;
                    }
                }
                else
                {                    
                    mensagem = "Conexão com a base de dados foi perdida";
                    LOG.Escrever("executarNONQuery", mensagem);
                    retorno = -1;
                }

            }
            catch (Exception ex)
            {
                LOG.Escrever("executarNONQuery", ex.Message);
            }
            return retorno;
        }

        private static int executarComando(String vcomando)
        {
            int retorno = 0;
            bool continua = true;
            IDbCommand pcomando = obterComando();

            pcomando.CommandText = vcomando;
            pcomando.CommandType = CommandType.Text;

            try
            {
                if (continua)
                {
                    pcomando.Connection = conexao;
                    try
                    {
                        retorno = (int)pcomando.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        mensagem = ex.Message;
                        LOG.Escrever("executarComando", ex.Message);
                        retorno = -1;
                    }
                }
                else
                {
                    mensagem = "Conexão com a base de dados foi perdida";
                    LOG.Escrever("executarComando", mensagem);
                    retorno = -1;
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("executarComando", ex.Message);
            }
            return retorno;
        }

        private static bool fecharConexao()
        {
            return instanciaBanco.FecharConexao();
        }

        private static bool visualizarConexao()
        {
            return instanciaBanco.VisualizarConexao();
        }

        #endregion

        #region publicas

        public static DataTable ExecutaReader(string query)
        {
            DataTable tabela = default(DataTable);

            try
            {
                iniciarPropriedades();
                iniciarConfiguracoes(banco, servico);
                abrirConexao(servico);
                tabela = obterDados(query, CommandType.Text);
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("ExecutaReader01", ex.Message);
            }
            return tabela;
        }

        public static DataTable ExecutaReader(string query, string instancia, string caminho)
        {
            DataTable tabela = default(DataTable);

            try
            {
                iniciarPropriedades(instancia, caminho);
                iniciarConfiguracoes(banco, servico);
                abrirConexao(servico);
                tabela = obterDados(query, CommandType.Text);
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("ExecutaReader02", ex.Message);
            }

            return tabela;
        }

        public static int ExecutaScalar(string query)
        {
            int valor = 0;

            try
            {
                iniciarPropriedades();
                iniciarConfiguracoes(banco, servico);

                abrirConexao(servico);
                valor = executarComando(query);
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("ExecutaScalar", ex.Message);
            }

            return valor;
        }

        public static int ExecutaNonQuery(string comando)
        {
            int valor = 0;

            try
            {
                iniciarPropriedades();
                iniciarConfiguracoes(banco, servico);

                abrirConexao(servico);
                valor = executarNoquery(comando);
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("ExecutaNONQuery", ex.Message);
            }

            return valor;
        }

        public static int ExecutaProcedure(string nome)
        {
            int retorno = -1;
            try
            {
                iniciarPropriedades();
                iniciarConfiguracoes(banco, servico);

                abrirConexao(servico);
                retorno = executarProcedure(nome);
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("ExecutaProcedure01", ex.Message);
                retorno = -1;
            }

            return retorno;
        }

        public static DataTable ExecutaProcedure(string nome, System.Collections.Generic.List<Parametros> parametros)
        {
            DataTable retorno = new DataTable();
            try
            {
                iniciarPropriedades();
                iniciarConfiguracoes(banco, servico);

                abrirConexao(servico);
                retorno = executarProcedure(nome, parametros);
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("ExecutaProcedure02", ex.Message);
                retorno = null;
            }

            return retorno;
        }

        public static string ExecutaMensagem(string nome, System.Collections.Generic.List<Parametros> parametros)
        {
            string valor = string.Empty;
            try
            {
                iniciarPropriedades();
                iniciarConfiguracoes(banco, servico);

                abrirConexao(servico);
                valor = executarMensagem(nome, parametros);
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("ExecutaMensagem", ex.Message);
                valor = ex.Message;
            }

            return valor;
        }

        public static IDbCommand obterComando()
        {
            return instanciaBanco.ObterComando();
        }

        public static bool TestarConexao(string query)
        {
            bool retorno = false;
            try
            {
                iniciarPropriedades();
                iniciarConfiguracoes(banco, servico);
                abrirConexao(servico);
                retorno = visualizarConexao();
                fecharConexao();
            }
            catch (Exception ex)
            {
                LOG.Escrever("TestarConexao", ex.Message);
            }
            return retorno;
        }
        #endregion
    }
}
