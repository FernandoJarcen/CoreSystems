using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Telefone:CustomDispose
    {
        public static string _restricao = "TelefoneID";
        public static string _tabela = "dbo.Telefone";        

        #region campos

        [Mapa("TelefoneID")]
        public int TelefoneID { get; set; }
        [Mapa("ContaID")]
        public int? ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("Telefone")]
        public string Numero { get; set; }
        [Mapa("Tipo")]
        public string Tipo { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
