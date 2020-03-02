

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreModel.Domain.Model.Global
{
    public class Conexao : CustomDispose
    {
        public static string _restricao = "ConexaoID";
        public static string _tabela = "dbo.Conexao";

        #region Campos

        [Mapa("ConexaoID")]
        public int ConexaoID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("ContaRelacionadaID")]
        public int ContaRelacionadaID { get; set; }
        [Mapa("TipoContaRelacionada")]
        public string TipoContaRelacionada { get; set; }
        [Mapa("TipoConexaoID")]
        public int TipoConexaoID { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }

        #endregion

    }
}
