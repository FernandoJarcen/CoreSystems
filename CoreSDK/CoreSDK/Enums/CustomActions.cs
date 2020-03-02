using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.Enums
{
    public class CustomAction
    {
        public enum ActionForms
        {
            Acao = 0,
            Formulario,
            Site,
            SemAcao
        }

        public enum ModoFormulario
        {
            Cadastro,
            Alteracao,
            Consulta,
            Nenhum
        }
    }
}
