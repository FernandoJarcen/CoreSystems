using CoreSDK.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.ODB.Domain
{
    public static class DBUtilities
    {
        public static bool ExisteTabela(string nomeTabela)
        {
            bool retorno = false;
            string script = String.Format("select count(*) from sys.tables where name = '{0}'", nomeTabela);
            int tabela = ODB.DataBase.DB.ExecutaScalar(script);
            if (tabela > 0)
                retorno = true;
            return retorno;
        }

        public static bool TestarConexao(CoreSDK.Enums.BancoDados.TipoBaseDados banco, string node)
        {
            bool conexaoAtivo = false;
            string mensagem = string.Empty;
            try
            {
                String tpconexao = Xml.BuscaAtributo(node, "datasource");

                string strConn = tpconexao;
                                

                //if (banco == sdk.BancoDados.TipoBaseDados.SqlServer)
                //{
                //    using (SqlConnection conn = new SqlConnection(strConn))
                //    {
                //        conn.Open();
                //        conexaoAtivo = true;
                //    };
                //}
                //else if (banco == sdk.BancoDados.TipoBaseDados.Oracle)
                //{
                //    OracleConnection conn = new OracleConnection(strConn);
                //    conn.Open();
                //    conexaoAtivo = true;
                //    conn.Close();
                //}
            }
            //catch (SqlException ex)
            //{
            //    conexaoAtivo = false;
            //    LOG.Escrever("AutenticacaoSistema.TestarConexao", ex.Message);
            //}
            catch (Exception ex)
            {
                conexaoAtivo = false;
                mensagem = ex.Message;
            }
            return conexaoAtivo;
        }
    }
}
