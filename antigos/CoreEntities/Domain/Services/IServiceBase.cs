using CoreSDK.Objetos;
using CoreSDK.ODB.DataBase;
using CoreSDK.ODB.Domain;
using CoreSDK.Enums;
using System;
using System.Collections.Generic;
using System.Data;

namespace CoreEntities.Domain.Services
{
    public class IServiceBase<T> where T : class
    {

        public static string SelecionarPor(string campo, string criteria = "")
        {
            string comando = string.Empty;
            DataTable operacao;
            string retorno = string.Empty;
            string tabela = string.Empty;
            Type entidade = typeof(T);
            try
            {
                //tabela = FactoryBase<T>.RetornaChave(Entidade._tabela);
                tabela = FactoryBase<T>.RetornaChave(Entidade.CampoEntidade._tabela);

                if (!string.IsNullOrEmpty(criteria))
                    comando = FactoryBase<T>.SelectPor(campo, criteria);
                else
                    comando = FactoryBase<T>.SelectPor(campo);

                operacao = DB.ExecutaReader(comando);
                if (operacao != null)
                    retorno = operacao.Rows[0][0].ToString();
                else
                    retorno = null;
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }
            return retorno;
        }

        public static DataTable SelecionarTodos(string[] campo, string criteria = "")
        {
            string comando = string.Empty;
            DataTable operacao;
            string tabela = string.Empty;
            try
            {
                tabela = FactoryBase<T>.RetornaChave(Entidade.CampoEntidade._tabela);

                if (!string.IsNullOrEmpty(criteria))
                    comando = FactoryBase<T>.SelectTodos(campo, criteria);
                else
                    comando = FactoryBase<T>.SelectTodos(campo);

                operacao = DB.ExecutaReader(comando);
                if (operacao == null)
                    operacao = null;
            }
            catch (Exception)
            {
                operacao = null;
            }
            return operacao;
        }

        public static string Insert(T entidade)
        {
            string comando = string.Empty;
            int operacao = -1;
            string retorno = string.Empty;
            try
            {
                comando = FactoryBase<T>.Insert(entidade);
                operacao = DB.ExecutaNonQuery(comando);
                if (operacao > -1)
                    retorno = "Inserido com sucesso!";
                else
                    retorno = "Operação não executada!";
            }
            catch (Exception)
            {
                operacao = -1;
                retorno = "Operação não executada!";
            }
            return retorno;
        }

        public static int InsertIndice(T entidade)
        {
            string comando = string.Empty;
            int operacao = -1;
            int retorno = -1;
            try
            {
                comando = FactoryBase<T>.Insert(entidade);
                operacao = DB.ExecutaNonQuery(comando);
                if (operacao > -1)
                {
                    retorno = FactoryBase<T>.Max();
                }
                else
                    retorno = -1;
            }
            catch (Exception)
            {
                operacao = -1;
                retorno = -1;
            }
            return retorno;
        }

        public static int Update(Dictionary<string, object> dados, string criteria)
        {
            int processo = -1;
            string comando = string.Empty;
            comando = FactoryBase<T>.Update(dados, criteria);
            try
            {
                processo = DB.ExecutaNonQuery(comando);
            }
            catch (Exception)
            {
                processo = -1;
            }

            return processo;
        }

        public static int Delete(String criteria)
        {
            string comando = string.Empty;
            string tabela = string.Empty;
            int operacao = -1;
            int retorno = -1;
            try
            {
                tabela = FactoryBase<T>.RetornaChave(Entidade.CampoEntidade._tabela);
                comando = FactoryBase<T>.Delete(criteria);

                operacao = DB.ExecutaNonQuery(comando);
                if (operacao > -1)
                    retorno = 100;
                else
                    retorno = 1;
            }
            catch (Exception)
            {
                operacao = -1;
                retorno = -1;
            }
            return retorno;
        }

        public static int Count(string criteria)
        {
            string comando = string.Empty;
            string tabela = string.Empty;
            int resposta = -1;
            tabela = FactoryBase<T>.RetornaChave(Entidade.CampoEntidade._tabela);
            if (!string.IsNullOrEmpty(criteria))
                comando = FactoryBase<T>.Count(criteria);
            else
                comando = FactoryBase<T>.Count();

            try
            {
                resposta = DB.ExecutaScalar(comando);
            }
            catch (Exception)
            {
                resposta = -1;
            }
            return resposta;
        }

        public static DataTable Execute(string comando)
        {
            DataTable retorno = new DataTable();
            try
            {
                retorno = DB.ExecutaReader(comando);
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }

        public static int GUID()
        {
            int retorno = -1;
            try
            {
                retorno = FactoryBase<T>.Guid();
            }
            catch (Exception)
            {
                retorno = -1;
            }
            return retorno;
        }

        public static int Max(string campo, string criteria = "")
        {
            string comando = string.Empty;
            string tabela = string.Empty;
            int resposta = -1;
            tabela = FactoryBase<T>.RetornaChave(Entidade.CampoEntidade._tabela);

            try
            {
                if (!string.IsNullOrEmpty(criteria))
                    resposta = FactoryBase<T>.Max(campo, criteria);
                else
                    resposta = FactoryBase<T>.Max(campo);
            }
            catch (Exception)
            {
                resposta = -1;
            }
            return resposta;
        }

        public static int Procedure(string nome)
        {
            int retorno = DB.ExecutaProcedure(nome);
            return retorno;
        }

        public static DataTable Procedure(string nome, List<CoreSDK.ODB.Domain.Parametros> parametros)
        {
            DataTable retorno = DB.ExecutaProcedure(nome, parametros);
            return retorno;
        }

    }
}
