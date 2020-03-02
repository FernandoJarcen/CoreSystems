

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;
namespace CoreModel.Domain.Model.Global
{
    public class Conta:CustomDispose
    {
        public static string _restricao = "ContaID";
        public static string _tabela = "dbo.Conta";

        #region campos

        [Mapa("ContaID")]
        public int ContaId { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("RazaoSocial")]
        public string RazaoSocial { get; set; }
        [Mapa("Fantasia")]
        public string Fantasia { get; set; }
        [Mapa("CNPJ")]
        public string CNPJ { get; set; }
        [Mapa("InscricaoEstadual")]
        public string InscricaoEstadual { get; set; }
        [Mapa("InscricaoMunicipal")]
        public string InscricaoMunicipal { get; set; }
        [Mapa("TipoLogradouro")]
        public string TipoLogradouro { get; set; }
        [Mapa("Logradouro")]
        public string Logradouro { get; set; }
        [Mapa("Numero")]
        public string Numero { get; set; }
        [Mapa("Bairro")]
        public string Bairro { get; set; }
        [Mapa("MunicipioID")]
        public int Municipio { get; set; }
        [Mapa("CEP")]
        public string CEP { get; set; }
        [Mapa("Referencia")]
        public string Referencia { get; set; }
        [Mapa("Complemento")]
        public string Complemento { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }
        [Mapa("Email")]
        public string Email { get; set; }
        [Mapa("Site")]
        public string Site { get; set; }
        [Mapa("Status")]
        public char Status { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCadastro")]
        public String DtCadastro { get; set; }

        #endregion

    }
}
