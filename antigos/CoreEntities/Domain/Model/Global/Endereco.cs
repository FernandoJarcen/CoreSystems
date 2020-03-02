using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Endereco : CustomDispose
    {
        public static string _restricao = "EnderecoID";
        public static string _tabela = "dbo.Endereco";

        #region Campos

        [Mapa("EnderecoID")]
        public int EnderecoID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("Ordem")]
        public int Ordem { get; set; }
        [Mapa("TipoEndereco")]
        public string TipoEndereco { get; set; }
        [Mapa("TipoLogradouro")]
        public string TipoLogradouro { get; set; }
        [Mapa("Logradouro")]
        public string Logradouro { get; set; }
        [Mapa("Numero")]
        public string Numero { get; set; }
        [Mapa("Bairro")]
        public string Bairro { get; set; }
        [Mapa("MunicipioID")]
        public int MunicipioID { get; set; }
        [Mapa("CEP")]
        public string CEP { get; set; }
        [Mapa("Referencia")]
        public string Referencia { get; set; }
        [Mapa("Complemento")]
        public string Complemento { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }
        [Mapa("NomeContato")]
        public string NomeContato { get; set; }
        [Mapa("TelefoneContato")]
        public string TelefoneContato { get; set; }
        [Mapa("OcupacaoContato")]
        public string OcupacaoContato { get; set; }
        [Mapa("DepartamentoContato")]
        public string DepartamentoContato { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
