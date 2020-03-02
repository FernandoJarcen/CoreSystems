using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
namespace CoreEntities.Domain.Model.Financeiro
{
    public class Recebiveis : CustomDispose
    {
        public static string _restricao = "RecebiveisID";
        public static string _tabela = "dbo.Recebiveis";

        #region Campos

        [Mapa("RecebiveisID")]
        public int RecebiveisID { get; set; }
        [Mapa("Documento")]
        public int Documento { get; set; }
        [Mapa("Conta")]
        public int Conta { get; set; }
        [Mapa("Tipo")]
        public string Tipo { get; set; }
        [Mapa("Cliente")]
        public string Cliente { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("Vencimento")]
        public string Vencimento { get; set; }
        [Mapa("Atraso")]
        public int Atraso { get; set; }
        [Mapa("ValorLiquido")]
        public decimal ValorLiquido { get; set; }
        [Mapa("Juros")]
        public decimal Juros { get; set; }
        [Mapa("Mora")]
        public decimal Mora { get; set; }
        [Mapa("Multa")]
        public decimal Multa { get; set; }
        [Mapa("ValorTotal")]
        public decimal ValorTotal { get; set; }

        #endregion

    }
}
