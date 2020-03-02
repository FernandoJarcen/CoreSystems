using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Unidade:CustomDispose
    {
        public static string _restricao = "UnidadeID";
        public static string _tabela = "dbo.Unidade";
        
        #region campos

        [Mapa("UnidadeID")]
        public int UnidadeID { get; set; }
        [Mapa("UnidadeFiscalID")]
        public int UnidadeFiscalID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        #endregion

    }
}
