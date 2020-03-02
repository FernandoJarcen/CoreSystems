using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Tributario
{
    public class ConfiguracaoTributaria : CustomDispose
    {
        public static string _restricao = "ConfiguracaoTributariaID";
        public static string _tabela = "dbo.ConfiguracaoTributaria";

        #region Campos

        [Mapa("ConfiguracaoTributariaID")]
        public int ConfiguracaoTributariaID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("DataValidade")]
        public string DataValidade { get; set; }
        [Mapa("TipoJuros")]
        public string TipoJuros { get; set; }
        [Mapa("ValorJuros")]
        public decimal ValorJuros { get; set; }
        [Mapa("TipoMora")]
        public string TipoMora { get; set; }
        [Mapa("ValorMora")]
        public decimal ValorMora { get; set; }
        [Mapa("PeriodoMora")]
        public string PeriodoMora { get; set; }
        [Mapa("TipoMulta")]
        public string TipoMulta { get; set; }
        [Mapa("ValorMulta")]
        public decimal ValorMulta { get; set; }

        #endregion

    }
}
