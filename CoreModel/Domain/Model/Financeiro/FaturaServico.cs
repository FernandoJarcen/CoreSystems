

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Financeiro
{
    public class FaturaServico : CustomDispose
    {
        public static string _restricao = "FaturaServicoID";
        public static string _tabela = "dbo.FaturaServico";

        #region Campos

        [Mapa("FaturaServicoID")]
        public int FaturaServicoID { get; set; }
        [Mapa("FaturaID")]
        public int FaturaID { get; set; }
        [Mapa("ProdutividadeID")]
        public int ProdutividadeID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("DataCancelamento")]
        public string DataCancelamento { get; set; }
        [Mapa("ValorTotal")]
        public decimal ValorTotal { get; set; }
        [Mapa("ValorTotalOrdem")]
        public decimal ValorTotalOrdem { get; set; }
        [Mapa("ValorTotalOrcamento")]
        public decimal ValorTotalOrcamento { get; set; }
        [Mapa("ValorDiferenca")]
        public decimal ValorDiferenca { get; set; }
        [Mapa("ValorAcrescimo")]
        public decimal ValorAcrescimo { get; set; }
        [Mapa("ValorDesconto")]
        public decimal ValorDesconto { get; set; }
        [Mapa("ValorTotalPecas")]
        public decimal ValorTotalPecas { get; set; }
        [Mapa("ValorTotalServicos")]
        public decimal ValorTotalServicos { get; set; }
        [Mapa("MotivoCancelamento")]
        public string MotivoCancelamento { get; set; }

        #endregion
    }
}
