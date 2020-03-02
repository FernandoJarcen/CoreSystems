using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.Controles.Controle.Itens
{
    public class ContextItem
    {
        List<ContextItem> lista = new List<ContextItem>();
        public string Nome { get; set; }
        public Image Imagem { get; set; }
        public Action Acao { get; set; }
        public ContextItem()
        {

        }

        public ContextItem(string nome, Image imagem, Action acao)
        {
            this.Nome = nome;
            this.Imagem = imagem;
            this.Acao = acao;            
        }

        public void Add(string nome, Image imagem, Action acao)
        {
            lista.Add(new ContextItem(nome,imagem,acao));
        }

        public int Count()
        {
            return lista.Count;
        }

        public List<ContextItem> Lista()
        {
            return lista;
        }

    }
}
