using System;
using System.ComponentModel;

namespace CoreFramework.Controles.Controle.Itens
{
    public class HideItem
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public HideItem()
        { }

        public HideItem(String pNome, String pValor)
        {
            this.Nome = pNome;
            this.Valor = pValor;
        }
    }
}
