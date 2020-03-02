using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Entities.Sistema
{
    public static class Entidades
    {
        public static List<string> ListarEntidades()
        {
            List<string> retorno = new List<string>();
            retorno = CoreEntities.Domain.Model.Sistema.Entidade.ListarEntidades();
            return retorno;                
        }

        public static string RetornarTabela(string descricao)
        {
            string retorno = string.Empty;
            retorno = CoreEntities.Domain.Model.Sistema.Entidade.RetornaTabela(descricao);
            return retorno;
        }
    }
}
