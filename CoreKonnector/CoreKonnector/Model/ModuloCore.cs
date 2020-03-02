using System;
using CoreSDK.ODB.Domain;
using CoreSDK.Objetos;

namespace CoreKonnector.Model
{
    public class ModuloCore : CustomDispose
    {
        public static string _restricao = "ModuloCoreID";
        public static string _tabela = "dbo.ModuloCore";

        #region Campos

        [Mapa("ModuloCoreID")]
        private int ModuloCoreID { get; set; }
        [Mapa("ModuloBase")]
        private string ModuloBase { get; set; }
        [Mapa("Documentacao")]
        private string Documentacao { get; set; }
        [Mapa("ChaveBase")]
        private string ChaveBase { get; set; }
        [Mapa("ChaveProduto")]
        private string ChaveProduto { get; set; }
        [Mapa("Produto")]
        private string Produto { get; set; }
        [Mapa("Modulo")]
        private string Modulo { get; set; }
        [Mapa("Submodulo")]
        private string Submodulo { get; set; }
        [Mapa("Versao")]
        private string Versao { get; set; }
        [Mapa("DataEntrada")]
        private string DataEntrada { get; set; }
        [Mapa("DataValidade")]
        private string DataValidade { get; set; }
        [Mapa("Status")]
        private string Status { get; set; }

        #endregion

        public ModuloCore()
        {
        }
    }
}
