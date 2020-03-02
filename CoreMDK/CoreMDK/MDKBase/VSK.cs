using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMDK.MDKBase
{
    /*Validation Studio Kit*/
    public static class VSK
    {
        #region private

        private static string produto(string chave)
        {
            string retorno = string.Empty;
            retorno = chave.Substring(0, 5);
            return retorno;
        }

        private static string aquisicao(string chave)
        {
            string retorno = string.Empty;
            retorno = chave.Substring(10, 5);
            return retorno;
        }

        private static string cliente(string chave)
        {
            string retorno = string.Empty;
            retorno = chave.Substring(15, 5);
            return retorno;
        }

        private static string versao(string chave)
        {
            string retorno = string.Empty;
            retorno = chave.Substring(20, 5);
            return retorno;
        }

        private static string validador(string chave)
        {
            string retorno = string.Empty;
            retorno = chave.Substring(20, 5);
            return retorno;
        }

        #endregion

        #region public

        public static string validade(string chave)
        {
            string retorno = "20";
            string dia = string.Empty;
            string mes = string.Empty;
            string ano = string.Empty;

            ano = chave.Substring(5, 1);
            if (ano == "J") retorno += "1";
            else if (ano == "K") retorno += "2";
            else if (ano == "L") retorno += "3";
            else if (ano == "M") retorno += "4";
            else if (ano == "N") retorno += "5";
            else if (ano == "O") retorno += "6";
            else if (ano == "P") retorno += "7";
            else if (ano == "R") retorno += "8";
            else if (ano == "S") retorno += "9";
            else if (ano == "T") retorno += "0";

            ano = chave.Substring(6, 1);
            if (ano == "S") retorno += "1";
            else if (ano == "T") retorno += "2";
            else if (ano == "U") retorno += "3";
            else if (ano == "V") retorno += "4";
            else if (ano == "X") retorno += "5";
            else if (ano == "Z") retorno += "6";
            else if (ano == "A") retorno += "7";
            else if (ano == "B") retorno += "8";
            else if (ano == "C") retorno += "9";
            else if (ano == "D") retorno += "0";

            retorno += "-";

            mes = chave.Substring(9, 1);
            if (mes == "F") retorno += "01";
            else if (mes == "G") retorno += "02";
            else if (mes == "H") retorno += "03";
            else if (mes == "I") retorno += "04";
            else if (mes == "J") retorno += "05";
            else if (mes == "K") retorno += "06";
            else if (mes == "L") retorno += "07";
            else if (mes == "M") retorno += "08";
            else if (mes == "N") retorno += "09";
            else if (mes == "O") retorno += "10";
            else if (mes == "P") retorno += "11";
            else if (mes == "R") retorno += "12";

            retorno += "-";

            retorno += chave.Substring(7, 2);
            return retorno;
        }

        public static string validadePorChave(string chave)
        {
            string retorno = "";
            string dia = string.Empty;
            string mes = string.Empty;
            string ano = string.Empty;

            ano = chave.Substring(8, 1);
            if (ano == "1") retorno += "J";
            else if (ano == "2") retorno += "K";
            else if (ano == "3") retorno += "L";
            else if (ano == "4") retorno += "M";
            else if (ano == "5") retorno += "N";
            else if (ano == "6") retorno += "O";
            else if (ano == "7") retorno += "P";
            else if (ano == "8") retorno += "R";
            else if (ano == "9") retorno += "S";
            else if (ano == "0") retorno += "T";

            ano = chave.Substring(9, 1);
            if (ano == "1") retorno += "S";
            else if (ano == "2") retorno += "T";
            else if (ano == "3") retorno += "U";
            else if (ano == "4") retorno += "V";
            else if (ano == "5") retorno += "X";
            else if (ano == "6") retorno += "Z";
            else if (ano == "7") retorno += "A";
            else if (ano == "8") retorno += "B";
            else if (ano == "9") retorno += "C";
            else if (ano == "0") retorno += "D";

            retorno += chave.Substring(0, 2);

            mes = chave.Substring(3, 2);
            if (mes == "01") retorno += "F";
            else if (mes == "02") retorno += "G";
            else if (mes == "03") retorno += "H";
            else if (mes == "04") retorno += "I";
            else if (mes == "05") retorno += "J";
            else if (mes == "06") retorno += "K";
            else if (mes == "07") retorno += "L";
            else if (mes == "08") retorno += "M";
            else if (mes == "09") retorno += "N";
            else if (mes == "10") retorno += "O";
            else if (mes == "11") retorno += "P";
            else if (mes == "12") retorno += "R";

            return retorno;
        }

        #endregion
    }
}
