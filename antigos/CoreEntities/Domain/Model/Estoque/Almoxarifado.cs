using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class Almoxarifado:CustomDispose
    {
        public static string _restricao = "AlmoxarifadoID";
        public static string _tabela = "dbo.Almoxarifado";

        #region campos

        [Mapa("AlmoxarifadoID")]
        public int AlmoxarifadoID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("CentroCustoID")]
        public int CentroCustoID { get; set; }
        [Mapa("ProjetoID")]
        public int ProjetoID { get; set; }
        [Mapa("PlantaID")]
        public int PlantaID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Destinacao")]
        public string Destinacao { get; set; }
        [Mapa("PermiteSaldoNegativo")]
        public string PermiteSaldoNegativo { get; set; }
        [Mapa("AlmoxarifadoFisico")]
        public string AlmoxarifadoFisico { get; set; }
        [Mapa("AlmoxarifadoContabil")]
        public string AlmoxarifadoContabil { get; set; }
        [Mapa("AlmoxarifadoDisponivel")]
        public string AlmoxarifadoDisponivel { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }

        #endregion

    }
}
