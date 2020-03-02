using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreEntities.Domain.Model.Estoque
{
    public class Servico : CustomDispose
    {
        public static string _restricao = "ServicoID";
        public static string _tabela = "dbo.Servico";

        #region campos

        [Mapa("ServicoID")]
        public int ServicoID { get; set; }
        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("Valor")]
        public Decimal Valor { get; set; }

        #endregion

    }
}
