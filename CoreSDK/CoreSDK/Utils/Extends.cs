using CoreSDK.Enums;
using CoreSDK.Objetos;
using System;
using System.Globalization;

namespace CoreSDK.Utils
{
    [Descricao("Metodo de extensão", "12/08/2019")]
    public static class Extends
    {
        
        #region para strings

        public static string Hoje()
        {
            return DateTime.Now.ToShortDateString().ToInput();
        }

        public static string DataExtenso(CoreSDK.Enums.Global.TipoDataExtensa tipo, string local = "")
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            string retorno = string.Empty;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            switch (tipo)
            {
                case Global.TipoDataExtensa.Local: retorno = local + ", " + dia + " de " + mes + " de " + ano;
                    break;
                case Global.TipoDataExtensa.DiaDaSemana: retorno = diasemana + ", " + dia + " de " + mes + " de " + ano;
                    break;
                case Global.TipoDataExtensa.Dia: retorno = dia + " de " + mes + " de " + ano;
                    break;
                default: retorno = dia + " de " + mes + " de " + ano;
                    break;
            }
            return retorno;
        }

        public static string EmBranco(this string palavra)
        {
            string retorno = palavra;
            retorno = retorno.Replace(" ", "");
            return retorno;
        }
        
        public static String Hoje(this string valor)
        {
            string texto = string.Empty;
            string retorno = string.Empty;
            texto = DateTime.Now.ToShortDateString();
            retorno = texto.Substring(6, 4) + "-" + texto.Substring(3, 2) + "-" + texto.Substring(0, 2);
            return retorno;
        }
        
        public static String LimparNulo(this string valor)
        {
            string retorno = string.Empty;
            retorno = valor == "NULL" ? string.Empty : valor;
            return retorno;
        }

        public static string PriMaiuscula(this String nome)
        {
            string frase = nome;

            char primeira = char.ToUpper(frase[0]);
            frase = primeira + frase.Substring(1);
            return frase;
        }

        public static String SemAcentuacao(this string texto)
        {
            string retorno = texto;
            const string StrComAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç'";
            const string StrSemAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc ";
            int i = 0;

            foreach (Char c in StrComAcentos)
            {
                retorno = retorno.Replace(c.ToString().Trim(), StrSemAcentos[i].ToString().Trim());
                i++;
            }
            return retorno;
        }

        public static string SemCaracteres(this string palavra)
        {
            string retorno = string.Empty;

            retorno = palavra.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "");
            return retorno;
        }

        public static String SemMascaras(this string palavra)
        {
            string retorno = string.Empty;
            retorno = palavra;
            retorno = retorno.Replace(".", "");
            retorno = retorno.Replace("-", "");
            retorno = retorno.Replace("/", "");
            retorno = retorno.Replace(",", "");
            retorno = retorno.Replace("(", "");
            retorno = retorno.Replace(")", "");
            retorno = retorno.Replace(":", "");
            retorno = retorno.Replace("_", "");
            return retorno;
        }

        public static String ToData(this DateTime dia)
        {
            DateTime valor = dia;
            string data = string.Empty;
            string hora = string.Empty;
            string retorno = string.Empty;

            data = valor.ToShortDateString();
            hora = valor.ToShortTimeString();
            retorno = data.Substring(6, 4) + "-" + data.Substring(3, 2) + "-" + data.Substring(0, 2) + " " + hora;
            return retorno;
        }

        public static String ToData(this string data)
        {
            string texto = string.Empty;
            string retorno = string.Empty;
            if (!String.IsNullOrEmpty(data))
            {
                texto = data;
                retorno = texto.Substring(6, 4) + "-" + texto.Substring(3, 2) + "-" + texto.Substring(0, 2);
            }
            else
                retorno = string.Empty;
            return retorno;
        }

        public static String ToData(this string data, CoreSDK.Enums.Global.Datas tipo)
        {
            string retorno = string.Empty;
            DateTime dia = Convert.ToDateTime(data);
            if (tipo == CoreSDK.Enums.Global.Datas.DataCurta)
                retorno = dia.ToShortDateString();
            else
                retorno = dia.ToLongDateString();
            return retorno;
        }

        public static String ToMoeda(this string valor)
        {
            string texto = string.Empty;
            string retorno = string.Empty;
            texto = valor;
            retorno = texto.Replace(",", ".");

            return retorno;
        }

        public static String ToMoeda(this string valor, CoreSDK.Enums.Global.Formatos formato)
        {
            string retorno = string.Empty;
            if (formato == CoreSDK.Enums.Global.Formatos.Padrao)
                retorno = String.Format("{0:0.##}", valor);
            else
                retorno = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);
            return retorno;
        }

        #endregion

        #region diversos

        #region extensions methods

        public static bool ToBoolean(this object _result)
        {
            bool retorno = false;
            if (_result != null)
                retorno = Convert.ToBoolean(_result);
            return retorno;
        }

        public static byte ToByte(this object _result)
        {
            byte retorno = new byte();
            if (_result != null)
                retorno = Convert.ToByte(_result);
            return retorno;
        }

        public static char ToChar(this object _result)
        {
            char retorno = new char();
            if (_result.ToString() != "\0")
                retorno = Convert.ToChar(_result);
            return retorno;
        }

        public static DateTime ToDate(this object _result)
        {
            DateTime retorno = DateTime.Now;
            if (_result != null)
                retorno = Convert.ToDateTime(_result);
            return retorno;
        }

        public static Decimal ToDecimal(this object _result)
        {
            Decimal retorno = 0;
            if (_result != null)
                retorno = Convert.ToDecimal(_result);
            return retorno;
        }

        public static Double ToDouble(this object _result)
        {
            Double retorno = -1;
            if (_result != null)
                retorno = Convert.ToDouble(_result);
            return retorno;
        }

        public static int ToInt(this object _result)
        {
            int retorno = -1;
            if (_result != null)
                retorno = Convert.ToInt32(_result);
            return retorno;
        }

        public static string ToText(this object _result)
        {
            string retorno = String.Empty;
            retorno = (_result != null ? _result.ToString() : string.Empty);
            return retorno;
        }

        public static string ToInput(this object _result)
        {
            string retorno = string.Empty;
            retorno = (_result != null ? _result.ToString().ToData() : string.Empty);
            return retorno;
        }

        #endregion

        #endregion
    }
}
