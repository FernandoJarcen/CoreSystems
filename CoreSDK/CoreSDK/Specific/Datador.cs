using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.Specific
{
    public static class Datador
    {
        public static String MesCorrente(string mes)
        {
            string retorno = string.Empty;
            switch (mes)
            {
                case "A": retorno = "01"; break;
                case "B": retorno = "02"; break;
                case "C": retorno = "03"; break;
                case "D": retorno = "04"; break;
                case "E": retorno = "05"; break;
                case "F": retorno = "06"; break;
                case "G": retorno = "07"; break;
                case "H": retorno = "08"; break;
                case "I": retorno = "09"; break;
                case "J": retorno = "10"; break;
                case "L": retorno = "11"; break;
                case "M": retorno = "12"; break;
                default: retorno = "00";
                    break;
            }
            return retorno;
        }

        public static String MesConvertido(string mes)
        {
            string retorno = string.Empty;
            switch (mes)
            {
                case "01": retorno = "A"; break;
                case "02": retorno = "B"; break;
                case "03": retorno = "C"; break;
                case "04": retorno = "D"; break;
                case "05": retorno = "E"; break;
                case "06": retorno = "F"; break;
                case "07": retorno = "G"; break;
                case "08": retorno = "H"; break;
                case "09": retorno = "I"; break;
                case "10": retorno = "J"; break;
                case "11": retorno = "L"; break;
                case "12": retorno = "M"; break;
                default: retorno = "A";
                    break;
            }
            return retorno;
        }

        public static String AnoCorrente(string ano)
        {
            string retorno = "20";
            string decena = ano.Substring(0, 1);
            string unidade = ano.Substring(1, 1);

            switch (decena)
            {
                case "X": retorno += "1"; break;
                case "Y": retorno += "2"; break;
                case "Z": retorno += "3"; break;
                case "A": retorno += "4"; break;
                case "B": retorno += "5"; break;
                case "C": retorno += "6"; break;
                case "D": retorno += "7"; break;
                case "E": retorno += "8"; break;
                case "F": retorno += "9"; break;
                default: retorno += "1";
                    break;
            }

            switch (unidade)
            {
                case "A": retorno += "0"; break;
                case "B": retorno += "1"; break;
                case "C": retorno += "2"; break;
                case "D": retorno += "3"; break;
                case "E": retorno += "4"; break;
                case "F": retorno += "5"; break;
                case "G": retorno += "6"; break;
                case "H": retorno += "7"; break;
                case "I": retorno += "8"; break;
                case "J": retorno += "9"; break;
                default: retorno += "0";
                    break;
            }
            return retorno;
        }

        public static String AnoConvertido(string ano)
        {
            string retorno = "20";
            string decena = ano.Substring(0, 1);
            string unidade = ano.Substring(1, 1);

            switch (decena)
            {
                case "1": retorno += "X"; break;
                case "2": retorno += "Y"; break;
                case "3": retorno += "Z"; break;
                case "4": retorno += "A"; break;
                case "5": retorno += "B"; break;
                case "6": retorno += "C"; break;
                case "7": retorno += "D"; break;
                case "8": retorno += "E"; break;
                case "9": retorno += "F"; break;
                default: retorno += "X";
                    break;
            }

            switch (unidade)
            {
                case "0": retorno += "A"; break;
                case "1": retorno += "B"; break;
                case "2": retorno += "C"; break;
                case "3": retorno += "D"; break;
                case "4": retorno += "E"; break;
                case "5": retorno += "F"; break;
                case "6": retorno += "G"; break;
                case "7": retorno += "H"; break;
                case "8": retorno += "I"; break;
                case "9": retorno += "J"; break;
                default: retorno += "A";
                    break;
            }
            return retorno;
        }
    }
}
