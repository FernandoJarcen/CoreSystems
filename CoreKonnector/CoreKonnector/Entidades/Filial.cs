using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKonnector.Entidades
{
    public class Filial
    {
        public Filial()
        {
        }
        public int negocio { get; set; }
        public int chave { get; set; }
        public string descricao { get; set; }
        public Filial(int negocio, int chave, string descricao)
        {
            this.negocio = negocio;
            this.chave = chave;
            this.descricao = descricao;
        }
    }
}
