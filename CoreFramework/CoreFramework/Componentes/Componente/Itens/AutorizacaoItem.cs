using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.Componentes.Componente.Itens
{
    public class AutorizacaoItem
    {
        public string Aplicacao { get; set; }
        public string Modulo { get; set; }
        public string Rotina { get; set; }
        public string Nivel { get; set; }
        public AutorizacaoItem()
        {

        }

        public AutorizacaoItem(string aplicacao, string modulo, string rotina, string nivel)
        {
            this.Aplicacao = aplicacao;
            this.Modulo = modulo;
            this.Rotina = rotina;
            this.Nivel = nivel;
        }
    }
}
