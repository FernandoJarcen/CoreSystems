using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.Enums
{
    public class Global
    {
        public enum Controles
        {
            Nenhum = 0,
            Label
        }

        public enum Datas
        {
            DataCurta,
            DataExtensa
        }

        public enum Formatos
        {
            Padrao,
            Moeda
        }

        public enum TipoDataExtensa
        {
            Local,
            DiaDaSemana,
            Dia
        }
    }
}
