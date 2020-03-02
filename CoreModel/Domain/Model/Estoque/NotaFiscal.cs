using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;
namespace CoreModel.Domain.Model.Estoque
{
    public class NotaFiscal:CustomDispose
    {
        public static string _restricao = "NotaFiscalID";
        public static string _tabela = "dbo.NotaFiscal";

        #region campos

        [Mapa("NotaFiscalID")]
        public int NotaFiscalID { get; set; }
        [Mapa("ContaID")]
        public int? ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Numero")]
        public String Numero { get; set; }
        [Mapa("Chave")]
        public String Chave { get; set; }
        [Mapa("EstadoID")]
        public int EstadoID { get; set; }
        [Mapa("NaturezaOperacao")]
        public String NaturezaOperacao { get; set; }
        [Mapa("Modelo")]
        public int Modelo { get; set; }
        [Mapa("Serie")]
        public String Serie { get; set; }
        [Mapa("TipoNota")]
        public String TipoNota { get; set; }
        [Mapa("TipoFrete")]
        public String TipoFrete { get; set; }
        [Mapa("QtdItens")]
        public int QuantidadeItens { get; set; }
        [Mapa("Status")]
        public String Status { get; set; }
        [Mapa("DataEntrada")]
        public String DataEntrada { get; set; }
        [Mapa("BaseCalculoImposto")]
        public Decimal BaseCalculo { get; set; }
        [Mapa("ValorTotal")]
        public Decimal ValorTotal { get; set; }
        [Mapa("ValorTotalTributos")]
        public Decimal ValorTotalTributos { get; set; }
        [Mapa("ValorAcrescimo")]
        public Decimal ValorAcrescimo { get; set; }
        [Mapa("ValorDesconto")]
        public Decimal ValorDesconto { get; set; }
        [Mapa("ValorSeguro")]
        public Decimal ValorSeguro { get; set; }
        [Mapa("ValorICMS")]
        public Decimal ValorICMS { get; set; }
        [Mapa("ValorPIS")]
        public Decimal ValorPIS { get; set; }
        [Mapa("ValorCOFINS")]
        public Decimal ValorCOFINS { get; set; }
        [Mapa("ValorOutros")]
        public Decimal ValorOutros { get; set; }
        [Mapa("ValorFrete")]
        public Decimal ValorFrete { get; set; }
        [Mapa("ValorLiquido")]
        public Decimal ValorLiquido { get; set; }
        [Mapa("TipoEntrada")]
        public string TipoEntrada { get; set; }

        #endregion

    }
}
