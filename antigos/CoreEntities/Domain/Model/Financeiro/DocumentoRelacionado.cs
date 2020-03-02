using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class DocumentoRelacionado : CustomDispose
    {
        public static string _restricao = "DocumentoRelacionadoID";        
        public static string _tabela = "dbo.DocumentoRelacionado";
        
        #region Campos

        [Mapa("DocumentoRelacionadoID")]
        public int DocumentoRelacionadoID { get; set; }
        [Mapa("DocumentoFinanceiroID")]
        public int DocumentoFinanceiroID { get; set; }
        [Mapa("TipoDocumento")]
        public string TipoDocumento { get; set; }
        [Mapa("NumeroDocumento")]
        public string NumeroDocumento { get; set; }
        [Mapa("DataDocumento")]
        public DateTime DataDocumento { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("ValorDocumento")]
        public decimal ValorDocumento { get; set; }
        [Mapa("Observacoes")]
        public string Observacoes { get; set; }
        
        #endregion

    }
}
