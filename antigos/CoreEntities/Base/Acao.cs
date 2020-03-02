using CoreEntities.Domain.Services;
using CoreSDK.ODB.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Base
{
    public class Acao<T> : IAcaoBase<T> where T : class,new()
    {

        #region propriedades publicas

        public static string Selecionar(string campo, string criteria = "")
        {
            T entidade = new T();
            string retorno = string.Empty;
            try
            {
                if (!String.IsNullOrEmpty(criteria))
                    retorno = IServiceBase<T>.SelecionarPor(campo, criteria);
                else
                    retorno = IServiceBase<T>.SelecionarPor(campo);
                if (string.IsNullOrEmpty(retorno))
                    retorno = string.Empty;
            }
            catch (Exception)
            {
                retorno = string.Empty;
            }
            return retorno;
        }
        public static DataTable SelecionarTodos(string[] campo, string criteria = "")
        {
            DataTable retorno;
            T entidade = new T();
            try
            {
                if (!string.IsNullOrEmpty(criteria))
                    retorno = IServiceBase<T>.SelecionarTodos(campo, criteria);
                else
                    retorno = IServiceBase<T>.SelecionarTodos(campo);
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }
        public static string Inserir(T entidade)
        {
            string retorno = string.Empty;
            string resposta = string.Empty;
            resposta = IServiceBase<T>.Insert(entidade);
            if (resposta == "Inserido com sucesso!")
                retorno = "Registro Incluido com sucesso!";
            else
                retorno = "Registro não incluido por inconsistências! Verifique!";
            return retorno;
        }
        public static int InserirChave(T entidade)
        {
            int retorno = -1;
            int resposta = -1;
            resposta = IServiceBase<T>.InsertIndice(entidade);
            if (resposta > -1)
                retorno = resposta;
            else
                retorno = -1;
            return retorno;
        }
        public static string Atualizar(Dictionary<string, object> campo, string criteria)
        {
            T entidade = new T();
            string retorno = string.Empty;
            int resposta = -1;
            resposta = IServiceBase<T>.Update(campo, criteria);
            if (resposta > 0)
                retorno = "Registro Atualizado com sucesso!";
            else
                retorno = "Registro não Atualizado por inconsistências! Verifique!";
            return retorno;
        }
        public static string Excluir(string criteria)
        {
            T entidade = new T();
            string retorno = string.Empty;
            int resposta = -1;
            resposta = IServiceBase<T>.Delete(criteria);
            if (resposta > 0)
                retorno = "Registro Excluído com sucesso!";
            else
                retorno = "Registro não Excluído por inconsistências! Verifique!";
            return retorno;
        }
        public static int Contar(string criteria)
        {
            T entidade = new T();
            int retorno = -1;
            retorno = IServiceBase<T>.Count(criteria);
            return retorno;
        }
        public static DataTable Executar(string comando)
        {
            DataTable retorno = new DataTable();
            try
            {
                retorno = IServiceBase<T>.Execute(comando);
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }
        public static int GUID()
        {
            T entidade = new T();
            int retorno = -1;
            retorno = IServiceBase<T>.GUID();
            return retorno;
        }
        public static int Max(string campo,string criteria = "")
        {
            T entidade = new T();
            int retorno = -1;
            retorno = IServiceBase<T>.Max(campo, criteria);
            return retorno;
        }
        public static int Procedure(string nome)
        {
            T entidade = new T();
            int retorno = -1;
            retorno = IServiceBase<T>.Procedure(nome);
            return retorno;
        }
        public static DataTable Procedure(string nome, List<Parametros> parametros)
        {
            T entidade = new T();
            DataTable retorno = new DataTable();
            retorno = IServiceBase<T>.Procedure(nome,parametros);
            return retorno;
        }
        
        #endregion

        #region propriedades particulares

        public string SelecionarBase(string campo, string criteria = "")
        {
            return Acao<T>.Selecionar(campo, criteria);
        }

        public DataTable SelecionarTodosBase(string[] campo, string criteria = "")
        {
            return Acao<T>.SelecionarTodos(campo, criteria);
        }

        public string InserirBase(T entidade)
        {
            return Acao<T>.Inserir(entidade);
        }

        public int InserirChaveBase(T entidade)
        {
            return Acao<T>.InserirChave(entidade);
        }

        public string AtualizarBase(Dictionary<string, object> campo, string criteria)
        {
            return Acao<T>.Atualizar(campo, criteria);
        }

        public string ExcluirBase(String criteria)
        {
            return Acao<T>.Excluir(criteria);
        }

        public int ContarBase(string criteria)
        {
            return Acao<T>.Contar(criteria);
        }

        public DataTable ExecutarBase(string comando)
        {
            return Acao<T>.Executar(comando);
        }

        public int GUIDBase()
        {
            return Acao<T>.GUID();
        }

        public int MaxBase(string campo, string criteria = "")
        {
            return Acao<T>.Max(campo, criteria);
        }

        public int ProcedureBase(string nome)
        {
            return Acao<T>.Procedure(nome);
        }

        public DataTable ProcedureBase(string nome, List<Parametros> parametros)
        {
            return Acao<T>.Procedure(nome, parametros);
        }

        #endregion
    }
}
