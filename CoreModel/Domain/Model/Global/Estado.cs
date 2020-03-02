using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class Estado : CustomDispose
    {
        public static string _restricao = "EstadoID";
        public static string _tabela = "dbo.Estado";

        #region Campos

        [Mapa("EstadoID")]
        public int EstadoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Sigla")]
        public string Sigla { get; set; }
        [Mapa("Capital")]
        public string Capital { get; set; }
        [Mapa("DDD")]
        public short DDD { get; set; }
        [Mapa("Regiao")]
        public int Regiao { get; set; }
        [Mapa("CEPInicio")]
        public string CEPInicio { get; set; }
        [Mapa("CEPFinal")]
        public string CEPFinal { get; set; }
        [Mapa("PaisID")]
        public int PaisID { get; set; }
        [Mapa("AliquotaICMS")]
        public decimal AliquotaICMS { get; set; }
        [Mapa("AliquotaST")]
        public decimal AliquotaST { get; set; }
        [Mapa("IBGE")]
        public string IBGE { get; set; }

        #endregion
    }
}
