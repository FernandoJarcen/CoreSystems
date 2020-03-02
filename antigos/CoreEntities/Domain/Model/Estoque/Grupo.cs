using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class Grupo : CustomDispose
    {
        public static string _restricao = "GrupoID";
        public static string _tabela = "dbo.Grupo";

        #region campos

        [Mapa("GrupoID")]
        public int GrupoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }

        #endregion
 
    }
}
