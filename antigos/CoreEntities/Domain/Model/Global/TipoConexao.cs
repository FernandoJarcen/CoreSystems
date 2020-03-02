using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class TipoConexao : CustomDispose
    {
        public static string _restricao = "TipoConexaoID";
        public static string _tabela = "dbo.TipoConexao";

        #region Campos

        [Mapa("TipoConexaoID")]
        public int TipoConexaoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }

        #endregion

    }
}
