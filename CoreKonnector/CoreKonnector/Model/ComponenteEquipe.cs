using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class ComponenteEquipe : CustomDispose
    {
        public static string _restricao = "ComponenteEquipeID";
        public static string _tabela = "dbo.ComponenteEquipe";

        #region Campos

        [Mapa("ComponenteEquipeID")]
        public int ComponenteEquipeID { get; set; }
        [Mapa("EquipeID")]
        public int EquipeID { get; set; }
        [Mapa("ComponenteID")]
        public int ComponenteID { get; set; }

        #endregion

        public ComponenteEquipe()
        {

        }
    }
}
