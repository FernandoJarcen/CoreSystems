using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class BaixaContasReceber : CustomDispose
    {
        public static string _restricao = "BaixaReceberID";
        public static string _tabela = "dbo.BaixaReceber";

        #region campos

        [Mapa("BaixaReceberID")]
        public int BaixaReceberID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("ContasReceberID")]
        public int ContasReceberID { get; set; }        
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("TransacaoID")]
        public int TransacaoID { get; set; }
        [Mapa("DocumentoVinculadoID")]
        public int DocumentoVinculadoID { get; set; }
        [Mapa("ContaFinanceiraID")]
        public int ContaFinanceiraID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataPagamento")]
        public string DataPagamento { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("NumeroParcela")]
        public int NumeroParcela { get; set; }
        [Mapa("FormaPagamento")]
        public string FormaPagamento { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("ValorPago")]
        public Decimal ValorPago { get; set; }
        [Mapa("Referencia")]
        public string Referencia { get; set; }
        [Mapa("Processo")]
        public string Processo { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }

        #endregion

    }
}
