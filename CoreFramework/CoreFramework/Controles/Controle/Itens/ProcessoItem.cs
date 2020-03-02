using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle.Itens
{
    class ProcessoItem
    {
        public int codigo { get; set; }
        public Enums.Processo processo { get; set; }
        public string mensagem { get; set; }

        public ProcessoItem(int pcodigo, Enums.Processo pprocesso, string pmensagem)
        {
            codigo = pcodigo;
            processo = pprocesso;
            mensagem = pmensagem;
        }
    }
}
