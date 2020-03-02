using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class SolicitacaoCompraProduto : CustomDispose
    {
        public static string _restricao = "SolicitacaoCompraProdutoID";
        public static string _tabela = "dbo.SolicitacaoCompraProduto";

        #region Campos

        [Mapa("SolicitacaoCompraProdutoID")]
        public int SolicitacaoCompraProdutoID { get; set; }
        [Mapa("SolicitacaoCompraID")]
        public int SolicitacaoCompraID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Quantidade")]
        public decimal Quantidade { get; set; }
        [Mapa("Atendida")]
        public string Atendida { get; set; }

        #endregion

    }
}
