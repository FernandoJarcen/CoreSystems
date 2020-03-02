using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Municipio:CustomDispose
    {
        public static string _restricao = "MunicipioID";
        public static string _tabela = "dbo.Municipio";

        #region campos

        [Mapa("MunicipioID")]
        public int MunicipioID { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("CEP")]
        public string CEP { get; set; }
        [Mapa("TpMunicipio")]
        public string Tp_Municipio { get; set; }
        [Mapa("EstadoID")]
        public int UFID { get; set; }
        [Mapa("IBGE")]
        public string Ibge { get; set; }
        [Mapa("GIA")]
        public string Gia { get; set; }
        [Mapa("RAIS")]
        public string Rais { get; set; }
        [Mapa("ECT")]
        public string Ect { get; set; }
        [Mapa("CepGenerico")]
        public string Cep_Generico { get; set; }
        [Mapa("PaisID")]
        public int PaisID { get; set; }

        #endregion

        public Municipio()
        {

        }
    }
}
