using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class ModalidadeContaFinanceira : CustomDispose
    {
        public static string _restricao = "ModalidadeContaFinanceiraID";
        public static string _tabela = "dbo.ModalidadeContaFinanceira";

        #region Campos

        [Mapa("ModalidadeContaFinanceiraID")]
        public int ModalidadeContaFinanceiraID { get; set; }
        [Mapa("ModalidadePagamentoID")]
        public int ModalidadePagamentoID { get; set; }
        [Mapa("ContaFinanceiraID")]
        public int ContaFinanceiraID { get; set; }
        [Mapa("ContaPadrao")]
        public string ContaPadrao { get; set; }

        #endregion

    }
}
