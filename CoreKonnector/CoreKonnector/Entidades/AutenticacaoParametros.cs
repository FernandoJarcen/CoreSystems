using CoreMDK.MDKBase;
using CoreSDK.Objetos;
using CoreSDK.Specific;
using System;

namespace CoreKonnector.Entidades
{
    [Descricao("Classe de autenticação de módulos", "01/06/2019")]
    public static class AutenticacaoParametros
    {
        public static bool Schlüsselvalidierer(string Sch)
        {
            bool retorno = false;
            if (!String.IsNullOrEmpty(Sch))
                retorno = CoreMDK.MDKBase.STK.ChaveValida(Sch);
            return retorno;
        }

        public static pluggin Instanzvalidierung(string modulo, string nomefisico, CoreSDK.Enums.PlugginStatus validacao, string[] param = null)
        {
            pluggin retorno;
            if ((param == null) || (param.Length == 0))
                retorno = STK.ChaveInstancia(modulo, nomefisico, validacao);
            else
                retorno = STK.ChaveInstancia(modulo, nomefisico, validacao, param);
            return retorno;
        }

        public static string[] Validierungsparameter()
        {
            string[] retorno;
            retorno = STK.ChaveParametros();
            return retorno;
        }

    }
}
