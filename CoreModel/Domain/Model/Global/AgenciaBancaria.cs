

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class AgenciaBancaria : CustomDispose
    {
        public static string _restricao = "AgenciaBancariaID";
        public static string _tabela = "dbo.AgenciaBancaria";

        #region Campos

        [Mapa("AgenciaBancariaID")]
        public int AgenciaBancariaID { get; set; }
        [Mapa("BancoID")]
        public int BancoID { get; set; }
        [Mapa("Agencia")]
        public string Agencia { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("TpLogradouro")]
        public string TpLogradouro { get; set; }
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

        #endregion

    }
}
