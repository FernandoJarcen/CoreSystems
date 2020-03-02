using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle.Itens
{
    public class InfoItem
    {
        public int codigo { get; set; }
        public Enums.Imagens imagem { get; set; }
        public string mensagem { get; set; }

        public InfoItem(int pcodigo, Enums.Imagens pImagem, string pmensagem)
        {
            codigo = pcodigo;
            imagem = pImagem;
            mensagem = pmensagem;
        }
    }
}
