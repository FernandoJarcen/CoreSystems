using CoreKonnector.Model;
using CoreSDK.Entities.Base;
using CoreSDK.Specific;
using System;
using System.Data;

namespace CoreKonnector.Services
{
    public class ModuloService
    {
        private static string montarChave(string chave)
        {
            string P1 = chave.Substring(0, 12);
            string P2 = chave.Substring(12, 1);
            string P3 = chave.Substring(13, 2);
            string P4 = chave.Substring(15, 2);
            string P5 = chave.Substring(18, 20);
            string fmt1 = P1.Substring(0, 8) + "-" + P1.Substring(8, 4);
            string fmt2 = P5.Substring(0, 4) + "-" + P5.Substring(4, 4) + "-" + P5.Substring(8, 12);
            string frm = fmt1 + "-" + fmt2;
            return frm;
        }

        private static DateTime montarData(string chave)
        {
            string P2 = chave.Substring(12, 1);
            string P3 = chave.Substring(13, 2);
            string P4 = chave.Substring(15, 2);
            string mes = Datador.MesCorrente(P2);
            string ano = Datador.AnoCorrente(P4);
            string strDate = P3 + "/" + mes + "/" + ano;
            DateTime date = Convert.ToDateTime(strDate);
            return date.Date;
        }

        private static bool validarChave(string modulo, string chave)
        {
            bool retorno = true;
            string chaveBase = chave;
            DateTime dataBase = DateTime.Today;

            if (retorno)
                retorno = validaReferencia(modulo, chaveBase);

            return retorno;
        }

        private static bool validaData(DateTime data)
        {
            bool retorno = true;
            //if (DateTime.Now.Date <= data.Date)
            //    retorno = true;
            return retorno;
        }

        private static bool validaReferencia(string modulo, string chave)
        {
            bool retorno = false;

            DataTable dtchave = Acao<ModuloCore>.SelecionarTodos(new string[] { "*" }, "Submodulo = '" + modulo + "'");
            if (dtchave != null)
            {
                string chavebusca = dtchave.Rows[0]["ChaveBase"].ToString();
                string modulobusca = dtchave.Rows[0]["Submodulo"].ToString();
                string databusca = dtchave.Rows[0]["DataValidade"].ToString();
                if (chavebusca.ToUpper() == chave)
                    if (modulobusca == modulo)                        
                        retorno = true;
            }

            return retorno;
        }

        public static bool validarModulo(string modulo, string chave, int instancia)
        {
            bool retorno = false;
            try
            {
                CoreSDK.Utils.Util.Executar(instancia);
                retorno = validarChave(modulo, chave);
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
