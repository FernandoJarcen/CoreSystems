using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistematica.application.Objetos
{
    public class Tabela
    {
        public string Nome { get; set; }
        public int Ordem { get; set; }
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public string Padrao { get; set; }
        public string AceitaNulo { get; set; }
        public string Comentario { get; set; }

        public Tabela(int ordem, string nome, string tipo, string aceita, string comentario = "", string tamanho = "", string padrao = "")
        {
            Ordem = ordem;
            Nome = nome;
            Tipo = tipo;
            AceitaNulo = aceita;
            if (!String.IsNullOrEmpty(tamanho))
                Tamanho = tamanho;
            if (!String.IsNullOrEmpty(padrao))
                Padrao = padrao;
            if (!String.IsNullOrEmpty(comentario))
                Comentario = comentario;
        }

        public Tabela()
        {
            // TODO: Complete member initialization
        }
    }
}
