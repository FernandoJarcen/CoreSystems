using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class EquipeUnidade : CustomDispose
    {
        public static string _restricao = "EquipeUnidadeID";
        public static string _tabela = "dbo.EquipeUnidade";

        #region Campos

        [Mapa("EquipeUnidadeID")]
        public int EquipeUnidadeID { get; set; }
        [Mapa("EquipeID")]
        public int EquipeID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }

        #endregion

        public EquipeUnidade()
        {

        }
    }
}
