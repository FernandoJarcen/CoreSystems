

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreModel.Domain.Model.Global
{
    public class CentroCusto : CustomDispose
    {
        public static string _restricao = "CentroCustoID";
        public static string _tabela = "dbo.CentroCusto";

        #region Campos

        [Mapa("CentroCustoID")]
        public int CentroCustoID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
