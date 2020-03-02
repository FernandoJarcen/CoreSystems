using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMDK.Query
{
    public class Join
    {
        public string Tabela1 { get; set; }
        public string Tabela2 { get; set; }
        public string Chave { get; set; }
        public string Alias1 { get; set; }
        public string Alias2 { get; set; }

        public Join(string p_tabela1, string p_alias, string p_campo)
        {
            Tabela1 = p_tabela1;
            Alias1 = p_alias;
            Chave = p_campo;
        }

        public Join(string p_tabela1, string p_alias1, string p_tabela2, string p_alias2, string p_campo)
        {
            Tabela1 = p_tabela1;
            Alias1 = p_alias1;
            Tabela2 = p_tabela2;
            Alias2 = p_alias2;
            Chave = p_campo;
        }
    }
}
