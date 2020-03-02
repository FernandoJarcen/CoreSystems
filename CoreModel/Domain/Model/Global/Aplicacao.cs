

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class Aplicacao:CustomDispose
    {
        public static string _restricao = "AplicacaoID";
        public static string _tabela = "dbo.Aplicacao";
        #region campos

        [Mapa("AplicacaoID")]
        public int AplicacaoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
