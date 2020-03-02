

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Global
{
    public class Contato :CustomDispose
    {
        public static string _restricao = "ContatoID";
        public static string _tabela = "dbo.Contato";

        #region campos
        [Mapa("ContatoID")]
        public int ContatoID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("Sobrenome")]
        public string Sobrenome { get; set; }
        [Mapa("Apelido")]
        public string Apelido { get; set; }
        [Mapa("DataNascimento")]
        public string DtNascimento { get; set; }
        [Mapa("EstadoCivil")]
        public string EstadoCivil { get; set; }
        [Mapa("RG")]
        public string RG { get; set; }
        [Mapa("CPF")]
        public string CPF { get; set; }
        [Mapa("Reservista")]
        public string Reservista { get; set; }
        [Mapa("Titulo")]
        public string Titulo { get; set; }
        [Mapa("CTPS")]
        public string CTPS { get; set; }
        [Mapa("CNH")]
        public string CNH { get; set; }
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
        [Mapa("OcupacaoID")]
        public int OcupacaoID { get; set; }
        [Mapa("Email")]
        public string Email { get; set; }
        [Mapa("Site")]
        public string Site { get; set; }
        [Mapa("Sexo")]
        public string Sexo { get; set; }
        [Mapa("Status")]
        public char Status { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCadastro")]
        public String DtCadastro { get; set; }

        #endregion

    }
}
