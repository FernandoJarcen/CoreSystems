using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreSDK.Enums
{
    public class Arquivos
    {
        public enum TipoArquivo
        {
            Padrao,
            Executaveis,
            Audit,
            Resources,
            Custom
        }

        public enum Criptografia
        {
            Criptografado,
            Descriptografado,
            NaoDefinido
        }
    }
}
