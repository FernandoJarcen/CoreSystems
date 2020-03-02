using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class DevolucaoEstoque : CustomDispose
    {
        public static string _restricao = "DevolucaoEstoqueID";
        public static string _tabela = "dbo.DevolucaoEstoque";

        #region Campos

        [Mapa("DevolucaoEstoqueID")]
        public int DevolucaoEstoqueID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataDevolucao")]
        public string DataDevolucao { get; set; }
        [Mapa("OrigemMovimento")]
        public string OrigemMovimento { get; set; }
        [Mapa("ValorDevolucao")]
        public decimal ValorDevolucao { get; set; }

        #endregion

    }
}
