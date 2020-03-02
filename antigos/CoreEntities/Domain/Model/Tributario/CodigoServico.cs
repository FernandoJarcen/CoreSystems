using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Tributario
{
    public class CodigoServico : CustomDispose
    {
        public static string _restricao = "CodigoServicoID";
        public static string _tabela = "dbo.CodigoServico";

        #region campos

        [Mapa("CodigoServicoID")]
        public int CodigoServicoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("PercentualIRRF")]
        public string PercIRFF { get; set; }
        [Mapa("PercentualISS")]
        public string PercISS { get; set; }
        [Mapa("CodigoReceitaID")]
        public int CodigoReceitaID { get; set; }

        #endregion

    }
}
