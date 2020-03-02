using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Estoque
{
    public class FollowUPCompra : CustomDispose
    {
        public static string _restricao = "FollowUPCompraID";
        public static string _tabela = "dbo.FollowUPCompra";

        #region Campos

        [Mapa("FollowUPCompraID")]
        public int FollowUPCompraID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("SolicitacaoCompraID")]
        public int SolicitacaoCompraID { get; set; }
        [Mapa("CotacaoID")]
        public int CotacaoID { get; set; }
        [Mapa("PedidoCompraID")]
        public int PedidoCompraID { get; set; }
        [Mapa("NotaFiscalID")]
        public int NotaFiscalID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("AlmoxarifadoUnidadeID")]
        public int AlmoxarifadoUnidadeID { get; set; }
        [Mapa("OcorrenciaSistemaID")]
        public int OcorrenciaSistemaID { get; set; }
        [Mapa("NotaFiscalDevolucaoID")]
        public int NotaFiscalDevolucaoID { get; set; }
        [Mapa("DataEntradaSolicitacao")]
        public String DataEntradaSolicitacao { get; set; }
        [Mapa("DataAlteracaoSolicitacao")]
        public String DataAlteracaoSolicitacao { get; set; }
        [Mapa("DataEntradaCotacao")]
        public String DataEntradaCotacao { get; set; }
        [Mapa("DataAlteracaoCotacao")]
        public String DataAlteracaoCotacao { get; set; }
        [Mapa("DataEntradaPedido")]
        public String DataEntradaPedido { get; set; }
        [Mapa("DataAlteracaoPedido")]
        public String DataAlteracaoPedido { get; set; }
        [Mapa("DataEntradaExpedicao")]
        public String DataEntradaExpedicao { get; set; }
        [Mapa("DataAlteracaoExpedicao")]
        public String DataAlteracaoExpedicao { get; set; }
        [Mapa("DataOcorrenciaSistema")]
        public String DataOcorrenciaSistema { get; set; }
        [Mapa("DetalheOcorrencia")]
        public string DetalheOcorrencia { get; set; }
        [Mapa("StatusSolicitacao")]
        public string StatusSolicitacao { get; set; }
        [Mapa("StatusCotacao")]
        public string StatusCotacao { get; set; }
        [Mapa("StatusPedido")]
        public string StatusPedido { get; set; }
        [Mapa("StatusExpedicao")]
        public string StatusExpedicao { get; set; }
        [Mapa("StatusFollowUP")]
        public string StatusFollowUP { get; set; }

        #endregion

    }
}
