using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreEntities.Domain.Model.Global
{
    public class Transportadora : CustomDispose
    {
        public static string _restricao = "TransportadoraID";
        public static string _tabela = "dbo.Transportadora";

        #region Campos

        [Mapa("TransportadoraID")]
        public int TransportadoraID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
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
