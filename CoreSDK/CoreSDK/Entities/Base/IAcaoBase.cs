using CoreSDK.Objetos;
using System.Collections.Generic;
using System.Data;

namespace CoreSDK.Entities.Base
{
    public interface IAcaoBase<T> where T : class,new()
    {
        string SelecionarBase(string campo, string criteria = "");
        DataTable SelecionarTodosBase(string[] campo, string criteria = "");
        string InserirBase(T entidade);
        int InserirChaveBase(T entidade);
        string AtualizarBase(Dictionary<string, object> campo, string criteria);
        string ExcluirBase(string criteria);
        int ContarBase(string criteria);
        DataTable ExecutarBase(string comando);
        int GUIDBase();
        int MaxBase(string campo, string criteria = "");
        int ProcedureBase(string nome);
        DataTable ProcedureBase(string nome, List<CoreSDK.ODB.Domain.Parametros> parametros);
    }
}
