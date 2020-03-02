using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKonnector.Entidades
{
    public class Negocio
    {
        public Negocio()
        {
        }

        public int consolidadora { get; set; }
        public int chave { get; set; }
        public string descricao { get; set; }

        public Negocio(int consolidadora, int id, string descricao)
        {
            this.consolidadora = consolidadora;
            this.chave = id;
            this.descricao = descricao;
        }
    }
}
