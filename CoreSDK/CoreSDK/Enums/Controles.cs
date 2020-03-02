using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.Enums
{
    public class Controles
    {
        public enum KeyBase
        {
            Produto,
            Validade,
            Aquisicao,
            Cliente,
            Versao,
            Validador
        }

        public enum TipoFormulario
        {
            Normal = 0
            , Dialogo
        }

        public enum NivelAcesso
        {
            Nenhum = 0,
            Consulta,
            Insercao,
            Alteracao,
            Exclusao,
            Total
        }
    }
}
