

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreModel.Domain.Model.Financeiro
{
    public class ContaFinanceira : CustomDispose
    {
        public static string _restricao = "ContaFinanceiraID";
        public static string _tabela = "dbo.ContaFinanceira";

        #region Campos

        [Mapa("ContaFinanceiraID")]
        public int ContaFinanceiraID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("AgenciaBancariaID")]
        public int? AgenciaBancariaID { get; set; }
        [Mapa("Conta")]
        public string Conta { get; set; }
        [Mapa("SaldoInicial")]
        public decimal SaldoInicial { get; set; }
        [Mapa("SaldoAtual")]
        public decimal SaldoAtual { get; set; }
        [Mapa("TipoOperacao")]
        public string TipoOperacao { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }

        #endregion

    }
}
