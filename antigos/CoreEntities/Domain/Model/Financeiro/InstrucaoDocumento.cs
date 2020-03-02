using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class InstrucaoDocumento : CustomDispose
    {
        public static string _restricao = "InstrucaoDocumentoID";
        public static string _tabela = "dbo.InstrucaoDocumento";

        #region Campos

        [Mapa("InstrucaoDocumentoID")]
        public int InstrucaoDocumentoID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("Vencimento")]
        public string Vencimento { get; set; }
        [Mapa("Atraso")]
        public int Atraso { get; set; }
        [Mapa("ValorAntigo")]
        public decimal ValorAntigo { get; set; }
        [Mapa("ValorLiquido")]
        public decimal ValorLiquido { get; set; }

        #endregion

    }
}
