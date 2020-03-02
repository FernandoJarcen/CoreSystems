using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKonnector.Entidades
{
    public class Consolidadora
    {
        public Consolidadora()
        {
        }

        public int chave { get; set; }
        public string descricao { get; set; }

        public Consolidadora(int id, string descricao)
        {
            this.chave = id;
            this.descricao = descricao;
        }
    }
}
