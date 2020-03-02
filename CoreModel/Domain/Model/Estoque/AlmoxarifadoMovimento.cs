
using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Estoque
{
    public class AlmoxarifadoMovimento : CustomDispose
    {
        public static string _restricao = "AlmoxarifadoMovimentoID";
        public static string _tabela = "dbo.AlmoxarifadoMovimento";

        #region Campos

        [Mapa("AlmoxarifadoMovimentoID")]
        public int AlmoxarifadoMovimentoID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("AlmoxarifadoID")]
        public int AlmoxarifadoID { get; set; }
        [Mapa("UnidadeID")]
        public int UnidadeID { get; set; }
        [Mapa("DocumentoMovimento")]
        public int DocumentoMovimento { get; set; }
        [Mapa("OrigemMovimento")]
        public string OrigemMovimento { get; set; }
        [Mapa("DataMovimentacao")]
        public string DataMovimentacao { get; set; }
        [Mapa("TipoOperacao")]
        public string TipoOperacao { get; set; }
        [Mapa("QuantidadeAnterior")]
        public decimal QuantidadeAnterior { get; set; }
        [Mapa("QuantidadeMovimentado")]
        public decimal QuantidadeMovimentado { get; set; }
        [Mapa("QuantidadeAtual")]
        public decimal QuantidadeAtual { get; set; }

        #endregion

    }
}
