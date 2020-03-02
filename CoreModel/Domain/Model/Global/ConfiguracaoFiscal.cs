

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;
namespace CoreModel.Domain.Model.Global
{
    public class ConfiguracaoFiscal : CustomDispose
    {
        public static string _restricao = "ConfiguracaoFiscalID";
        public static string _tabela = "dbo.ConfiguracaoFiscal";

        #region Campos

        [Mapa("ConfiguracaoFiscalID")]
        public int ConfiguracaoFiscalID { get; set; }
        [Mapa("ContaID")]
        public int ContaID { get; set; }
        [Mapa("TipoConta")]
        public string TipoConta { get; set; }
        [Mapa("DataInicio")]
        public DateTime DataInicio { get; set; }
        [Mapa("DataEncerramento")]
        public DateTime DataEncerramento { get; set; }
        [Mapa("EnquadradoIPI")]
        public string EnquadradoIPI { get; set; }
        [Mapa("EnquadradoICMS")]
        public string EnquadradoICMS { get; set; }
        [Mapa("EnquadradoISS")]
        public string EnquadradoISS { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCadastro")]
        public DateTime DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public DateTime DataAlteracao { get; set; }

        #endregion

    }
}
