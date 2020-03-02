using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class MovimentoFinanceiro : CustomDispose
    {
        public static string _restricao = "MovimentoFinanceiroID";
        public static string _tabela = "dbo.MovimentoFinanceiro";

        #region Campos

        [Mapa("MovimentoFinanceiroID")]
        public int MovimentoFinanceiroID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("ContaFinanceiraID")]
        public int ContaFinanceiraID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Conta")]
        public int Conta { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("TipoOperacao")]
        public string TipoOperacao { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("ValorAnterior")]
        public decimal ValorAnterior { get; set; }
        [Mapa("ValorMovimentado")]
        public decimal ValorMovimentado { get; set; }
        [Mapa("ValorAtual")]
        public decimal ValorAtual { get; set; }

        #endregion

    }
}
