using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Estoque
{
    public class AlmoxarifadoUnidade : CustomDispose
    {
        public static string _restricao = "AlmoxarifadoUnidadeID";
        public static string _tabela = "dbo.AlmoxarifadoUnidade";

        #region campos

        [Mapa("AlmoxarifadoUnidadeID")]
        public int AlmoxarifadoUnidadeID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("AlmoxarifadoID")]
        public int AlmoxarifadoID { get; set; }
        [Mapa("UnidadeID")]
        public int UnidadeID { get; set; }
        [Mapa("Locacao")]
        public string Locacao { get; set; }
        [Mapa("QtdDisponivel")]
        public Decimal QtdDisponivel { get; set; }
        [Mapa("QtdReservada")]
        public Decimal QtdReservada { get; set; }
        [Mapa("QtdCalculada")]
        public Decimal QtdCalculada { get; set; }
        [Mapa("EstoqueMinimo")]
        public Decimal EstoqueMinimo { get; set; }
        [Mapa("Preco")]
        public Decimal Preco { get; set; }
        [Mapa("UltimaAlteracao")]
        public String UltimaAlteracao { get; set; }
        [Mapa("Unitizacao")]
        public string Unitizacao { get; set; }

        #endregion

    }
}
