

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class OrigemOperacao:CustomDispose
    {
        public static string _restricao = "OrigemOperacaoID";
        public static string _tabela = "dbo.OrigemOperacao";

        #region campos

        [Mapa("OrigemOperacaoID")]
        public int OrigemOperacaoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Global")]
        public string Global { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("Operacao")]
        public string Operacao { get; set; }

        #endregion

    }
}
