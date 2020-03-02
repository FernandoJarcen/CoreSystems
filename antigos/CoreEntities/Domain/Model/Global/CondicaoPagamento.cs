using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class CondicaoPagamento:CustomDispose
    {
        public static string _restricao = "CondicaoPagamentoID";
        public static string _tabela = "dbo.CondicaoPagamento";

        #region campos

        [Mapa("CondicaoPagamentoID")]
        public int CondicaoPagamentoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("TpCondicao")]
        public string TipoCondicao { get; set; }
        [Mapa("DiasUteis")]
        public string DiasUteis { get; set; }
        [Mapa("ParcelaFixa")]
        public string ParcelasFixas { get; set; }
        [Mapa("VencimentoFixo")]
        public string VencimentoFixo { get; set; }
        [Mapa("JurosVencimento")]
        public string JurosVencimento { get; set; }
        [Mapa("LiquidacaoAutomatica")]
        public string LiquidacaoAutomatica { get; set; }
        [Mapa("AntecipacaoAutomatica")]
        public string AntecipacaoAutomatica { get; set; }
        [Mapa("DataVencimentoFixo")]
        public string DataVencimentoFixo { get; set; }
        [Mapa("ValorJurosVencimento")]
        public string ValorJurosVencimento { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("QtdParcelas")]
        public int QtdParcelas { get; set; }
        [Mapa("QtdDias")]
        public int QtdDias { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }

        #endregion
       
    }
}
