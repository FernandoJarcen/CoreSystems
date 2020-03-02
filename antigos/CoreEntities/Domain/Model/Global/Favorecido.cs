using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreEntities.Domain.Model.Global
{
    public class Favorecido : CustomDispose
    {
        public static string _restricao = "FavorecidoID";
        public static string _tabela = "dbo.Favorecido";

        #region Campos

        [Mapa("FavorecidoID")]
        public int FavorecidoID { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
