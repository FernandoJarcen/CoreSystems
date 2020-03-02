using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class RequisicaoProdutividade : CustomDispose
    {
        public static string _restricao = "RequisicaoProdutividadeID";
        public static string _tabela = "dbo.RequisicaoProdutividade";

        #region Campos

        [Mapa("RequisicaoProdutividadeID")]
        public int RequisicaoProdutividadeID { get; set; }
        [Mapa("RequisicaoEstoqueID")]
        public int RequisicaoEstoqueID { get; set; }
        [Mapa("ProdutividadeID")]
        public int ProdutividadeID { get; set; }
        [Mapa("OrcamentoID")]
        public int OrcamentoID { get; set; }
        [Mapa("OrdemID")]
        public int OrdemID { get; set; }

        #endregion

    }
}
