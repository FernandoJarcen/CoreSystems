using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class UnidadeNegocio :CustomDispose
    {
        public static string _restricao = "UnidadeNegocioID";
        public static string _tabela = "dbo.UnidadeNegocio";

        #region campos
        //public CustomLookUp <CodigoServico> CodigoServicoID { get; set; }

        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("ConsolidadoraID")]
        public int ConsolidadoraID { get; set; }
        [Mapa("NegocioID")]
        public int NegocioID { get; set; }
        [Mapa("UnidadeRelacionadaID")]
        public int UnidadeRelacionadaID { get; set; }
        [Mapa("PadraoID")]
        public int PadraoID { get; set; }
        [Mapa("MunicipioID")]
        public int MunicipioID { get; set; }
        //public CustomLookUp<Municipio> MunicipioID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("UnidadePadrao")]
        public string UnidadePadrao { get; set; }
        [Mapa("TipoUnidade")]
        public string TipoUnidade { get; set; }
        [Mapa("DataInicio")]
        public string DataInicio { get; set; }
        [Mapa("DataEncerramento")]
        public string DataEncerramento { get; set; }
        
        #endregion

        public UnidadeNegocio(){}
    }
}
