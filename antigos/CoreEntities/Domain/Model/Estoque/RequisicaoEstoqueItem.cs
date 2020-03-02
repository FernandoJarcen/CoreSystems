using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreEntities.Domain.Model.Estoque
{
    public class RequisicaoEstoqueItem : CustomDispose
    {
        public static string _restricao = "RequisicaoEstoqueItemID";
        public static string _tabela = "dbo.RequisicaoEstoqueItem";

        #region Campos

        [Mapa("RequisicaoEstoqueItemID")]
        public int RequisicaoEstoqueItemID { get; set; }
        [Mapa("RequisicaoEstoqueID")]
        public int RequisicaoEstoqueID { get; set; }
        [Mapa("OrigemOperacaoID")]
        public int OrigemOperacaoID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("UnidadeID")]
        public int UnidadeID { get; set; }
        [Mapa("Documento")]
        public int Documento { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("Quantidade")]
        public decimal Quantidade { get; set; }
        [Mapa("ValorUnitario")]
        public decimal ValorUnitario { get; set; }

        #endregion

    }
}
