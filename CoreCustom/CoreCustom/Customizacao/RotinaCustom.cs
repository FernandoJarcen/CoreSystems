using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCustom.Customizacao
{
    public class RotinaCustom
    {
        public string nome;
        public string icone;
        public string aplicacao;
        public string modulo;
        public string formulario;
        public RotinaCustom(string pAplicacao, string pModulo, string pNome, string pIcone, string pFormulario = "")
        {
            aplicacao = pAplicacao;
            modulo = pModulo;
            nome = pNome;
            icone = pIcone;
            if (!String.IsNullOrEmpty(pFormulario))
                formulario = pFormulario;
        }
    }
}
