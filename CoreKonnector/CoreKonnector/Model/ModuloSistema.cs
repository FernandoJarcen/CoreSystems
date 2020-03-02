using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class ModuloSistema:CustomDispose
    {
        public static string _restricao = "ModuloSistemaID";
        public static string _tabela = "dbo.ModuloSistema";

        #region Campos

        [Mapa("ModuloSistemaID")]
        public int ModuloSistemaID { get; set; }
        [Mapa("CodigoModulo")]
        public int CodigoModulo { get; set; }
        [Mapa("Aplicacao")]
        public string Aplicacao { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Executavel")]
        public string Executavel { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }

        #endregion

        public ModuloSistema()
        {

        }
    }
}
