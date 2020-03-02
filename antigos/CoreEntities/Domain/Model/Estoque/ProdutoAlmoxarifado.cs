using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class ProdutoAlmoxarifado :CustomDispose
    {
        public static string _restricao = "ProdutoAlmoxarifadoID";
        public static string _tabela = "dbo.ProdutoAlmoxarifado";

        #region campos

        [Mapa("ProdutoAlmoxarifadoID")]
        public int ProdutoAlmoxarifadoID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("AlmoxarifadoID")]
        public int AlmoxarifadoID { get; set; }

        #endregion

    }
}
