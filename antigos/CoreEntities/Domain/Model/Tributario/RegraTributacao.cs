using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Tributario
{
    public class RegraTributacao:CustomDispose
    {
        public static string _restricao = "RegraTributacaoID";
        public static string _tabela = "dbo.RegraTributacao";

        #region campos

        [Mapa("RegraTributacaoID")]
        public int RegraID { get; set; }

        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Complemento")]
        public string Complemento { get; set; }
        [Mapa("SituacaoTributariaID")]
        public int SituacaoTributariaID { get; set; }
        [Mapa("Aliquota")]
        public string Aliquota { get; set; }
        [Mapa("Reducao")]
        public string Reducao { get; set; }
        [Mapa("PercentualLucro")]
        public string PercLucro { get; set; }
        [Mapa("Pauta")]
        public string Pauta { get; set; }
        [Mapa("PVV")]
        public string PVV { get; set; }
        [Mapa("TpPauta")]
        public string TipoPauta { get; set; }
        [Mapa("TpRegra")]
        public string TipoRegra { get; set; }

        #endregion

    }
}
