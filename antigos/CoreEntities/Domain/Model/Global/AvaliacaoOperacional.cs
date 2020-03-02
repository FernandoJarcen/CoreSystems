using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreEntities.Domain.Model.Global
{
    public class AvaliacaoOperacional : CustomDispose
    {
        public static string _restricao = "AvaliacaoOperacionalID";
        public static string _tabela = "dbo.AvaliacaoOperacional";

        #region Campos

        [Mapa("AvaliacaoOperacionalID")]
        public int AvaliacaoOperacionalID { get; set; }
        [Mapa("Sigla")]
        public string Sigla { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Modulo")]
        public string Modulo { get; set; }
        [Mapa("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        #endregion

    }
}

