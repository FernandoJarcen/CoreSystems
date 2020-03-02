

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Estoque
{
    public class ServicoProduto:CustomDispose
    {
        public static string _restricao = "ServicoProdutoID";
        public static string _tabela = "dbo.ServicoProduto";

        #region campos

        [Mapa("ServicoProdutoID")]
        public int ServicoProdutoID { get; set; }
        [Mapa("ServicoID")]
        public int ServicoID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("Quantidade")]
        public Decimal Quantidade { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion
              
    }
}
