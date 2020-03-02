using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Cliente : CustomDispose
    {
        public static string _restricao = "ClienteID";
        public static string _tabela = "dbo.Cliente";

        #region Campos

        [Mapa("ClienteID")]
        public int ClienteID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoContaID")]
        public string TipoContaID { get; set; }
        [Mapa("CodigoAlternativo")]
        public string CodigoAlternativo { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("AvaliacaoOperacionalID")]
        public int AvaliacaoOperacionalID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }

        #endregion

    }
}