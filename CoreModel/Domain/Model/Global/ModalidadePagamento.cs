

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class ModalidadePagamento:CustomDispose
    {
        public static string _restricao = "ModalidadePagamentoID";
        public static string _tabela = "dbo.ModalidadePagamento";

        #region campos

        [Mapa("ModalidadePagamentoID")]
        public int ModalidadePagamentoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Tipo")]
        public string Tipo { get; set; }
        [Mapa("Narrativa")]
        public string Narrativa { get; set; }
        [Mapa("Obrigatoriedade")]
        public string Obrigatoriedade { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
