using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreModel.Domain.Model.Estoque
{
    public class AlmoxarifadoUsuario : CustomDispose
    {
        public static string _restricao = "AlmoxarifadoUsuarioID";
        public static string _tabela = "dbo.AlmoxarifadoUsuario";

        #region Campos

        [Mapa("AlmoxarifadoUsuarioID")]
        public int AlmoxarifadoUsuarioID { get; set; }
        [Mapa("AlmoxarifadoID")]
        public int AlmoxarifadoID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("TipoUsuario")]
        public string TipoUsuario { get; set; }

        #endregion

    }
}
