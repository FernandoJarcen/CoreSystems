

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreModel.Domain.Model.Financeiro
{
    public class InstrucaoHistorico : CustomDispose
    {
        public static string _restricao = "InstrucaoHistoricoID";
        public static string _tabela = "dbo.InstrucaoHistorico";

        #region Campos

        [Mapa("InstrucaoHistoricoID")]
        public int InstrucaoHistoricoID { get; set; }
        [Mapa("InstrucaoDocumentoID")]
        public int InstrucaoDocumentoID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Ordem")]
        public int Ordem { get; set; }
        [Mapa("DataInstrucao")]
        public string DataInstrucao { get; set; }
        [Mapa("DataMensagem")]
        public string DataMensagem { get; set; }
        [Mapa("TipoInstrucao")]
        public string TipoInstrucao { get; set; }
        [Mapa("NomeContato")]
        public string NomeContato { get; set; }
        [Mapa("TelefoneContato")]
        public string TelefoneContato { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }

        #endregion

    }
}
