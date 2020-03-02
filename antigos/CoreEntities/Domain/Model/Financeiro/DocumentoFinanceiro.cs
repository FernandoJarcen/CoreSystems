using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class DocumentoFinanceiro : CustomDispose
    {
        public static string _restricao = "DocumentoFinanceiroID";
        public static string _tabela = "dbo.DocumentoFinanceiro";

        #region campos

        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("OrigemOperacaoID")]
        public int OrigemOperacaoID { get; set; }
        [Mapa("ModalidadePagamentoID")]
        public int ModalidadePagamentoID { get; set; }
        [Mapa("CondicaoPagamentoID")]
        public int CondicaoPagamentoID { get; set; }
        [Mapa("TipoTituloID")]
        public int TipoTituloID { get; set; }
        [Mapa("MensagemPadraoID")]
        public int MensagemPadraoID { get; set; }
        [Mapa("Numero")]
        public String Numero { get; set; }
        [Mapa("Referencia")]
        public String Referencia { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataEmissao")]
        public string DataEmissao { get; set; }
        [Mapa("DataCalculo")]
        public string DataCalculo { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("DataCancelamento")]
        public string DataCancelamento { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }        
        [Mapa("QuantidadeParcela")]
        public int QuantidadeParcela { get; set; }
        [Mapa("ValorGerado")]
        public decimal ValorGerado { get; set; }
        [Mapa("ValorTotal")]
        public decimal ValorTotal { get; set; }
        [Mapa("ValorAbatido")]
        public decimal ValorAbatido { get; set; }
        [Mapa("ValorJuros")]
        public decimal ValorJuros { get; set; }
        [Mapa("ValorDesconto")]
        public decimal ValorDesconto { get; set; }
        [Mapa("ValorMulta")]
        public decimal ValorMulta { get; set; }
        [Mapa("ValorIRRF")]
        public decimal ValorIRRF { get; set; }
        [Mapa("ValorPIS")]
        public decimal ValorPIS { get; set; }
        [Mapa("ValorCOFINS")]
        public decimal ValorCOFINS { get; set; }
        [Mapa("ValorCSLL")]
        public decimal ValorCSLL { get; set; }
        [Mapa("ValorICMS")]
        public decimal ValorICMS { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }
        [Mapa("Motivo")]
        public string Motivo { get; set; }

        #endregion

    }
}
