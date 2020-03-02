

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Estoque
{
    public class SolicitacaoCompra : CustomDispose
    {
        public static string _restricao = "SolicitacaoCompraID";
        public static string _tabela = "dbo.SolicitacaoCompra";

        #region Campos

        [Mapa("SolicitacaoCompraID")]
        public int SolicitacaoCompraID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DepartamentoID")]
        public int DepartamentoID { get; set; }
        [Mapa("OrigemOperacaoID")]
        public int OrigemOperacaoID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("DataEncerramento")]
        public string DataEncerramento { get; set; }
        [Mapa("DataCancelamento")]
        public string DataCancelamento { get; set; }
        [Mapa("TipoSolicitacao")]
        public string TipoSolicitacao { get; set; }
        [Mapa("Solicitante")]
        public string Solicitante { get; set; }
        [Mapa("Prioridade")]
        public string Prioridade { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("MotivoCancelamento")]
        public string MotivoCancelamento { get; set; }

        #endregion

    }
}
