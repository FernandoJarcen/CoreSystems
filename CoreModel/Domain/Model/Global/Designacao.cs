

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreModel.Domain.Model.Global
{
    public class Designacao:CustomDispose
    {
        public static string _restricao = "Designacao";
        public static string _tabela = "dbo.Designacao";

        #region campos

        [Mapa("DesignacaoID")]
        public int DesignacaoID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("Cliente")]
        public string Cliente { get; set; }
        [Mapa("Colaborador")]
        public string Colaborador { get; set; }
        [Mapa("Fornecedor")]
        public string Fornecedor { get; set; }
        [Mapa("Outros")]
        public string Outros { get; set; }
        [Mapa("Representante")]
        public string Representante { get; set; }
        [Mapa("Transportadora")]
        public string Transportadora { get; set; }
        #endregion

    }
}
