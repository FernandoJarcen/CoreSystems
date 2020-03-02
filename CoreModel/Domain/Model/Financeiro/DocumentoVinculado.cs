

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Financeiro
{
    public class DocumentoVinculado : CustomDispose
    {
        public static string _restricao = "DocumentoVinculadoID";
        public static string _tabela = "dbo.DocumentoVinculado";

        #region Campos

        [Mapa("DocumentoVinculadoID")]
        public int DocumentoVinculadoID { get; set; }
        [Mapa("TipoDocumento")]
        public string TipoDocumento { get; set; }
        [Mapa("NumeroDocumento")]
        public string NumeroDocumento { get; set; }
        [Mapa("Favorecido")]
        public string Favorecido { get; set; }
        [Mapa("Banco")]
        public string Banco { get; set; }
        [Mapa("Agencia")]
        public string Agencia { get; set; }
        [Mapa("Conta")]
        public string Conta { get; set; }
        [Mapa("NossoNumero")]
        public string NossoNumero { get; set; }
        [Mapa("CodigoAlternativo")]
        public string CodigoAlternativo { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }

        #endregion

    }
}
