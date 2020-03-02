using System;
using System.Data;
using System.Data.SqlClient;
using CoreSDK.Utils;
using CoreSDK.Enums;
using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreSDK.ODB.DataBase
{
    public class SqlServer:DB
    {
        #region propriedades

        public override bool AbrirConexao(string p_conexao)
        {
            string conn = "";
            bool retorno = false;

            conn = p_conexao;

            try
            {
                conexao = new SqlConnection(conn);
                conexao.Open();
                retorno = true;
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }

            return retorno;
        }

        public override DataTable ObterDados(string vtexto, CommandType vtipo)
        {
            DataTable retorno = null;
            IDbCommand vcomando = obterComando();

            vcomando.CommandText = vtexto;
            vcomando.CommandType = vtipo;

            if (conexao.State == ConnectionState.Open)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable tabela = new DataTable();

                vcomando.Connection = conexao;
                adapter.SelectCommand = (System.Data.SqlClient.SqlCommand)vcomando;
                try
                {
                    adapter.Fill(tabela);
                    retorno = tabela;
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
                adapter = null;
            }
            else
            {
                mensagem = "Conexão com a base de dados foi perdida";
            }
            return retorno;
        }

        public override IDbCommand ObterComando()
        {
            return new SqlCommand();
        }
        
        public override int ExecutarProcedure(string nome)
        {
            int retorno = -1;
            SqlCommand vcomando = new SqlCommand(nome, (SqlConnection)conexao);
            vcomando.CommandType = CommandType.StoredProcedure;

            if (conexao.State == ConnectionState.Open)
            {
                try
                {
                    vcomando.ExecuteNonQuery();
                    retorno = 0;
                }
                catch (Exception)
                {
                    retorno = -1;
                }
            }
            else
            {
                mensagem = "Conexão com a base de dados foi perdida";
            }
            return retorno;
        }

        public override DataTable ExecutarProcedure(string nome, System.Collections.Generic.List<Parametros> parametros)
        {
            DataTable retorno = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter();
            DataSet DS = new DataSet();

            SqlCommand vcomando = new SqlCommand(nome, (SqlConnection)conexao);
            vcomando.CommandType = CommandType.StoredProcedure;

            if (conexao.State == ConnectionState.Open)
            {
                try
                {
                    for (int indice = 0; indice < parametros.Count; indice++)
                    {
                        adicionarParametro(vcomando, parametros[indice].nome, parametros[indice].valor, parametros[indice].tipo, parametros[indice].direcao);
                    }

                    DA = new SqlDataAdapter(vcomando);
                    DA.Fill(DS);

                    retorno = DS.Tables[0];
                }
                catch (Exception)
                {
                    retorno = null;
                }
            }
            else
            {
                mensagem = "Conexão com a base de dados foi perdida";
                retorno = null;
            }
            return retorno;
        }

        public override string ExecutarMensagem(string nome, System.Collections.Generic.List<Parametros> parametros)
        {
            string retorno = string.Empty;
            int campo_retorno = -1;
            SqlCommand vcomando = new SqlCommand(nome, (SqlConnection)conexao);
            vcomando.CommandType = CommandType.StoredProcedure;

            if (conexao.State == ConnectionState.Open)
            {

                for (int indice = 0; indice < parametros.Count; indice++)
                {
                    adicionarParametro(vcomando, parametros[indice].nome, parametros[indice].valor, parametros[indice].tipo, parametros[indice].direcao);
                    if (campo_retorno == -1)
                        if (parametros[indice].direcao == ParameterDirection.Output)
                            campo_retorno = indice;
                }

                try
                {
                    if (campo_retorno == -1)
                    {
                        vcomando.ExecuteNonQuery();
                        retorno = "sucesso!";
                    }
                    else
                    {
                        vcomando.ExecuteNonQuery();
                        retorno = vcomando.Parameters[campo_retorno].Value.ToString();
                    }
                }
                catch (Exception e)
                {
                    retorno = e.Message;
                    FecharConexao();
                }
            }
            else
            {
                mensagem = "Conexão com a base de dados foi perdida";
            }
            return retorno;
        }

        public override bool FecharConexao()
        {
            String msg = String.Empty;
            bool retorno = true;
            try
            {
                conexao.Close();
                conexao = null;
            }
            catch (Exception e)
            {
                msg = e.Message;
                retorno = false;
            }
            return retorno;
        }

        public override bool VisualizarConexao()
        {
            bool retorno = false;
            try
            {
                IDbCommand vcomando = obterComando();

                if (conexao.State == ConnectionState.Open)
                    retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        #endregion

        #region metodos

        private void adicionarParametro(IDbCommand pcomando, string pnome, object pvalor, BancoDados.TipoDados ptipo = BancoDados.TipoDados.Nenhum, ParameterDirection pdirecao = System.Data.ParameterDirection.Input, int ptamanho = 0, string psourcecolumn = "")
        {
            SqlParameter pparametro = new SqlParameter();

            switch (ptipo)
            {
                case BancoDados.TipoDados.Nenhum:
                    break;
                case BancoDados.TipoDados.Data:
                    pparametro.DbType = DbType.Date;
                    break;
                case BancoDados.TipoDados.DataHora:
                    pparametro.DbType = DbType.DateTime2;
                    break;
                case BancoDados.TipoDados.Hora:
                    pparametro.DbType = DbType.Time;
                    break;
                case BancoDados.TipoDados.Inteiro:
                    pparametro.DbType = DbType.Int32;
                    break;
                case BancoDados.TipoDados.Longo:
                    pparametro.DbType = DbType.Int64;
                    break;
                case BancoDados.TipoDados.Real:
                    pparametro.DbType = DbType.Decimal;
                    break;
                case BancoDados.TipoDados.Moeda:
                    pparametro.DbType = DbType.Currency;
                    break;
                case BancoDados.TipoDados.Booleano:
                    pparametro.DbType = DbType.Boolean;
                    break;
                case BancoDados.TipoDados.Texto:
                    pparametro.DbType = DbType.String;
                    pparametro.Size = ptamanho;
                    break;
                case BancoDados.TipoDados.Caracter:
                    pparametro.DbType = DbType.String;
                    pparametro.Size = ptamanho;
                    break;
                case BancoDados.TipoDados.TextoLongo:
                    pparametro.DbType = DbType.String;
                    break;
                case BancoDados.TipoDados.Imagem:
                    pparametro.DbType = DbType.Object;
                    break;
            }
            pparametro.Direction = pdirecao;
            pparametro.ParameterName = pnome;
            pparametro.Value = pvalor;
            pparametro.SourceColumn = psourcecolumn;
            pcomando.Parameters.Add(pparametro);
        }

        #endregion
    }
}
