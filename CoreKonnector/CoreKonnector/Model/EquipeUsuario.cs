using CoreSDK.Objetos;
//using CoreEntities.Base;
//using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class EquipeUsuario:CustomDispose
    {
        public static string _restricao = "EquipeUsuarioID";
        public static string _tabela = "dbo.EquipeUsuario";

        #region Campos

        [Mapa("EquipeUsuarioID")]
        public int EquipeUsuarioID { get; set; }
        [Mapa("EquipeID")]
        public int EquipeID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }

        #endregion

        public EquipeUsuario()
        {

        }
    }
}
