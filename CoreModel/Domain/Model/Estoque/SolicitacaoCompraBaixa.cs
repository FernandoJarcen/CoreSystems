

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Estoque
{
    public class SolicitacaoCompraBaixa : CustomDispose
    {
        public static string _restricao = "SolicitacaoCompraBaixaID";
        public static string _tabela = "dbo.SolicitacaoCompraBaixa";

        #region Campos

        [Mapa("SolicitacaoCompraBaixaID")]
        public int SolicitacaoCompraBaixaID { get; set; }
        [Mapa("SolicitacaoCompraID")]
        public int SolicitacaoCompraID { get; set; }
        [Mapa("SolicitacaoCompraProdutoID")]
        public int SolicitacaoCompraProdutoID { get; set; }
        [Mapa("OrigemOperacaoID")]
        public int OrigemOperacaoID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataBaixa")]
        public string DataBaixa { get; set; }
        [Mapa("Quantidade")]
        public decimal Quantidade { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }

        #endregion

    }
}
