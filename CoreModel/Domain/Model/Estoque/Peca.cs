

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Estoque
{
    public class Peca:CustomDispose
    {
        public static string _restricao = "PecaID";
        public static string _tabela = "dbo.Peca";

        #region campos

        [Mapa("PecaID")]
        public int PecaID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("TabelaPrecoID")]
        public int TabelaPrecoID { get; set; }
        [Mapa("CodigoBarra")]
        public string CodigoBarra { get; set; }
        [Mapa("CodigoFabricante")]
        public string CodigoFabricante { get; set; }
        [Mapa("Caracteristica")]
        public string Caracteristica { get; set; }
        [Mapa("EstoqueMinimo")]
        public Decimal EstoqueMinimo { get; set; }
        [Mapa("PrecoSugerido")]
        public Decimal PrecoSugerido { get; set; }

        #endregion

    }
}
