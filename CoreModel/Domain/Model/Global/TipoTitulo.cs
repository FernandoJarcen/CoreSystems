

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class TipoTitulo:CustomDispose
    {
        public static string _restricao = "TipoTituloID";
        public static string _tabela = "dbo.TipoTitulo";

        #region campos

        [Mapa("TipoTituloID")]
        public int TipoTituloID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Tipo")]
        public string Tipo { get; set; }
        #endregion

    }
}
