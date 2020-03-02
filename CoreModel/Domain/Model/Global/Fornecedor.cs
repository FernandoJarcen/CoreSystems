

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class Fornecedor : CustomDispose
    {
        public static string _restricao = "FornecedorID";
        public static string _tabela = "dbo.Fornecedor";

        #region Campos

        [Mapa("FornecedorID")]
        public int FornecedorID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoContaID")]
        public string TipoContaID { get; set; }
        [Mapa("CodigoAlternativo")]
        public string CodigoAlternativo { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("AvaliacaoOperacionalID")]
        public int AvaliacaoOperacionalID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }

        #endregion

    }
}
