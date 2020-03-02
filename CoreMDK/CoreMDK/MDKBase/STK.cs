using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSDK.Specific;
using CoreSDK.Enums;

namespace CoreMDK.MDKBase
{
    public static class STK
    {

        public static bool ChaveValida(string chave)
        {
            bool retorno = false;            
            DateTime data = Convert.ToDateTime(VSK.validade(chave));
            DateTime hoje = DateTime.Now;
            if (data >= hoje)
                retorno = true;
            return retorno;
        }

        public static pluggin ChaveInstancia(string modulo, string nomefisico, PlugginStatus validacao, string[] param = null)
        {
            pluggin global = new pluggin();
            string[] parametros = new string[5];

            try
            {
                if ((param == null) || (param.Length == 0))
                    parametros = ChaveParametros();
                else
                    parametros = param;

                global.CodigoFilial = Convert.ToInt32(parametros[0]);
                global.NomeFilial = parametros[1];
                global.CodigoUsuario = Convert.ToInt32(parametros[2]);
                global.NomeUsuario = parametros[3];
                global.CodigoInstancia = Convert.ToInt32(parametros[4]);

                global.Modulo = modulo;
                global.NomeCompleto = modulo;
                global.NomeFisico = nomefisico;
                global.Valida = validacao;
            }
            catch (Exception)
            {
                //global = null;                
            }

            return global;
        }

        public static string[] ChaveParametros()
        {
            string[] parametros = new string[5] { "5", "UNIDADE SALVADOR", "1", "Administrador", "100" };
            return parametros;
        }
    }
}
