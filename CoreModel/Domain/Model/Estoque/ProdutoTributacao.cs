

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreModel.Domain.Model.Estoque
{
    public class ProdutoTributacao:CustomDispose
    {
        public static string _restricao = "ProdutoTributacaoID";
        public static string _tabela = "dbo.ProdutoTributacao";

        #region campos

        [Mapa("ProdutoTributacaoID")]
        public int ProdutoTributacaoID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("SituacaoTributariaID")]
        public int SituacaoTributariaID { get; set; }
        [Mapa("RegraTributacaoID")]
        public int RegraTributacaoID { get; set; }
        [Mapa("IcmsDefinido")]
        public string IcmsDefinido { get; set; }
        [Mapa("TributacaoDefinida")]
        public string TributacaoDefinida { get; set; }

        #endregion
                
    }
}
