using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoreKonnector.Model
{
    public static class Entidade
    {
        public static List<string> ListarEntidades()
        {
            List<string> retorno = new List<string>();
            string conn = "SELECT Descricao FROM EntidadeSistema where Tipo != 'PROTEGIDO'";
            DataTable dtRetorno = CoreSDK.ODB.DataBase.DB.ExecutaReader(conn);
            if (dtRetorno != null)
            {
                for (int indice = 0; indice < dtRetorno.Rows.Count; indice++)
                {
                    retorno.Add(dtRetorno.Rows[indice][0].ToString());
                }
            }
            return retorno;
        }

        public static string RetornaTabela(string descricao)
        {
            string retorno = string.Empty;
            string conn = "select Tabela from EntidadeSistema where Descricao = '" + descricao + "'";
            DataTable dtRetorno = CoreSDK.ODB.DataBase.DB.ExecutaReader(conn);
            if (dtRetorno != null)
                retorno = dtRetorno.Rows[0][0].ToString();
            return retorno;
        }
    }
}
