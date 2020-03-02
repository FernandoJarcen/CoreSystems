

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;
namespace CoreModel.Domain.Model.Estoque
{
    public class ProdutoUnidade:CustomDispose
    {
        public static string _restricao = "ProdutoUnidadeID";
        public static string _tabela = "dbo.ProdutoUnidade";

        #region campos

        [Mapa("ProdutoUnidadeID")]
        public int ProdutoUnidadeID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("UnidadeID")]
        public int UnidadeID { get; set; }
        [Mapa("AlmoxarifadoID")]
        public int AlmoxarifadoID { get; set; }
        [Mapa("Quantidade")]
        public Decimal Quantidade { get; set; }
        [Mapa("PesoBruto")]
        public Decimal PesoBruto { get; set; }
        [Mapa("PesoLiquido")]
        public Decimal PesoLiquido { get; set; }
        [Mapa("PrecoUnico")]
        public string PrecoUnico { get; set; }
        [Mapa("Locacao")]
        public string Locacao { get; set; }

        #endregion

    }
}
