

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Financeiro
{
    public class ContasPagar : CustomDispose
    {
        public static string _restricao = "ContasPagarID";
        public static string _tabela = "dbo.ContasPagar";

        #region campos

        [Mapa("ContasPagarID")]
        public int ContasPagarID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("ContaFinanceiraID")]
        public int ContaFinanceiraID { get; set; }
        [Mapa("NumeroParcela")]
        public int NumeroParcela { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("DataCalculo")]
        public string DataCalculo { get; set; }
        [Mapa("DataVencimento")]
        public string DataVencimento { get; set; }
        [Mapa("DataProrrogado")]
        public string DataProrrogado { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("ValorGerado")]
        public Decimal ValorGerado { get; set; }
        [Mapa("ValorOriginal")]
        public Decimal ValorOriginal { get; set; }
        [Mapa("ValorTotal")]
        public Decimal ValorTotal { get; set; }
        [Mapa("ValorAcrescimo")]
        public Decimal ValorAcrescimo { get; set; }
        [Mapa("ValorDesconto")]
        public Decimal ValorDesconto { get; set; }
        [Mapa("ValorJuros")]
        public Decimal ValorJuros { get; set; }
        [Mapa("ValorMora")]
        public Decimal ValorMora { get; set; }
        [Mapa("ValorMulta")]
        public Decimal ValorMulta { get; set; }
        [Mapa("ValorImposto")]
        public Decimal ValorImposto { get; set; }
        [Mapa("Referencia")]
        public string Referencia { get; set; }
        [Mapa("Motivo")]
        public string Motivo { get; set; }
        [Mapa("InstrucaoDocumentoID")]
        public int InstrucaoDocumentoID { get; set; }

        #endregion

    }
}