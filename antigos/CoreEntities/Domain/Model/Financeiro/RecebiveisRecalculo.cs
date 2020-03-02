using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class RecebiveisRecalculo : CustomDispose
    {
        public static string _restricao = "RecebiveisRecalculoID";
        public static string _tabela = "dbo.RecebiveisRecalculo";

        #region Campos

        [Mapa("RecebiveisRecalculoID")]
        public int RecebiveisRecalculoID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("Conta")]
        public int Conta { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("ValorAnterior")]
        public decimal ValorAnterior { get; set; }
        [Mapa("ValorJuros")]
        public decimal ValorJuros { get; set; }
        [Mapa("ValorMora")]
        public decimal ValorMora { get; set; }
        [Mapa("ValorMulta")]
        public decimal ValorMulta { get; set; }
        [Mapa("ValorAtual")]
        public decimal ValorAtual { get; set; }

        #endregion

    }
}
