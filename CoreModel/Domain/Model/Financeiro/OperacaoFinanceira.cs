

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Financeiro
{
    public class OperacaoFinanceira : CustomDispose
    {
        public static string _restricao = "OperacaoFinanceiraID";
        public static string _tabela = "dbo.OperacaoFinanceira";

        #region Campos

        [Mapa("OperacaoFinanceiraID")]
        public int OperacaoFinanceiraID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Conta")]
        public int? Conta { get; set; }
        [Mapa("TipoOperacao")]
        public string TipoOperacao { get; set; }
        [Mapa("ContaFinanceiraOrigem")]
        public int ContaFinanceiraOrigem { get; set; }
        [Mapa("ContaFinanceiraDestino")]
        public int ContaFinanceiraDestino { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("ValorAnterior")]
        public decimal ValorAnterior { get; set; }
        [Mapa("ValorOperacao")]
        public decimal ValorOperacao { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }

        #endregion

    }
}

