using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreEntities.Domain.Model.Financeiro
{
    public class DocumentoSubstituido : CustomDispose
    {
        public static string _restricao = "DocumentoSubstituidoID";
        public static string _tabela = "dbo.DocumentoSubstituido";

        #region Campos

        [Mapa("DocumentoSubstituidoID")]
        public int DocumentoSubstituidoID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("ContaMovimento")]
        public int ContaMovimento { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }        
        [Mapa("ValorAntigo")]
        public decimal ValorAntigo { get; set; }
        [Mapa("ValorAtual")]
        public decimal ValorAtual { get; set; }

        #endregion

    }
}
