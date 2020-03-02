using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
using System;
namespace CoreEntities.Domain.Model.Estoque
{
    public class NotaFiscalItem:CustomDispose
    {
        public static string _restricao = "NotaFiscalItemID";
        public static string _tabela = "dbo.NotaFiscalItem";

        #region campos

        [Mapa("NotaItemID")]
        public int NotaFiscalItemID { get; set; }
        [Mapa("NotaFiscalID")]
        public int NotaFiscalID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("UnidadeID")]
        public int UnidadeID { get; set; }
        [Mapa("Ordem")]
        public int Ordem { get; set; }
        [Mapa("CFOP")]
        public String CFOP { get; set; }
        [Mapa("CST")]
        public String CST { get; set; }
        [Mapa("Quantidade")]
        public Decimal Quantidade { get; set; }
        [Mapa("ValorUnitario")]
        public Decimal ValorUnitario { get; set; }
        [Mapa("ValorTotal")]
        public Decimal ValorTotal { get; set; }
        [Mapa("ValorAcrescimo")]
        public Decimal ValorAcrescimo { get; set; }
        [Mapa("ValorDesconto")]
        public Decimal ValorDesconto { get; set; }
        [Mapa("ValorImposto")]
        public Decimal ValorImposto { get; set; }
        [Mapa("PIS")]
        public String PIS { get; set; }
        [Mapa("COFINS")]
        public String COFINS { get; set; }
        [Mapa("ValorPIS")]
        public Decimal ValorPIS { get; set; }
        [Mapa("ValorCOFINS")]
        public Decimal ValorCOFINS { get; set; }
        [Mapa("ValorOutros")]
        public Decimal ValorOutros { get; set; }
        [Mapa("AlmoxarifadoID")]
        public int AlmoxarifadoID { get; set; }

        #endregion

    }
}
