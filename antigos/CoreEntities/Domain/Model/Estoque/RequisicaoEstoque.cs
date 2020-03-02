using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class RequisicaoEstoque : CustomDispose
    {
        public static string _restricao = "RequisicaoEstoqueID";
        public static string _tabela = "dbo.RequisicaoEstoque";

        #region Campos

        [Mapa("RequisicaoEstoqueID")]
        public int RequisicaoEstoqueID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("SolicitacaoCompraID")]
        public int SolicitacaoCompraID { get; set; }
        [Mapa("ModuloSistemaID")]
        public int ModuloSistemaID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataRequisicao")]
        public string DataRequisicao { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("DataCancelamento")]
        public string DataCancelamento { get; set; }
        [Mapa("TipoRequisicao")]
        public string TipoRequisicao { get; set; }
        [Mapa("TipoOperacao")]
        public string TipoOperacao { get; set; }
        [Mapa("MotivoCancelamento")]
        public string MotivoCancelamento { get; set; }

        #endregion

    }
}
