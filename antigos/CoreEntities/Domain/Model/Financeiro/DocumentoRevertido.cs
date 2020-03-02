using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class DocumentoRevertido : CustomDispose
    {
        public static string _restricao = "DocumentoRevertidoID";
        public static string _tabela = "dbo.DocumentoRevertido";

        #region Campos

        [Mapa("DocumentoRevertidoID")]
        public int DocumentoRevertidoID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("DataReversao")]
        public DateTime DataReversao { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("MotivoReversao")]
        public string MotivoReversao { get; set; }
        [Mapa("ValorTotal")]
        public decimal ValorTotal { get; set; }
        [Mapa("ValorAbatido")]
        public decimal ValorAbatido { get; set; }

        #endregion

   }
}
