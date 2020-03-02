using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Tributario
{
    public class SituacaoTributaria:CustomDispose
    {
        public static string _restricao = "SituacaoTributariaID";
        public static string _tabela = "dbo.SituacaoTributaria";

        #region campos

        [Mapa("SituacaoTributariaID")]
        public int SituacaoID { get; set; }
        [Mapa ("Codigo")]
        public int codigo { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }

        #endregion

    }
}
