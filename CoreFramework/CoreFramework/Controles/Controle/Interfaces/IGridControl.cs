
namespace CoreFramework.Controles.Controle.Interfaces
{
    public interface IGridControl
    {
        //DIVERSOS
         void AtualizarGrid(string consulta = "");
         void RecarregarDados();
         string Valor(int linha, int coluna);
         string Valor(int linha, string coluna);
         int LinhaSelecionada();
         int ColunaSelecionada();
         string CelulaSelecionada();
         string CabecalhoColuna();
         int Quantidade();
         int QuantidadeColunas();
    }
}
