using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class OrcamentoSolicitacao : CustomDispose
    {
        public static string _restricao = "OrcamentoSolicitacaoID";
        public static string _tabela = "dbo.OrcamentoSolicitacao";

        #region Campos

        [Mapa("OrcamentoSolicitacaoID")]
        public int OrcamentoSolicitacaoID { get; set; }
        [Mapa("SolicitacaoCompraID")]
        public int SolicitacaoCompraID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("OrdemID")]
        public int OrdemID { get; set; }
        [Mapa("OrcamentoID")]
        public int OrcamentoID { get; set; }

        #endregion

    }
}
