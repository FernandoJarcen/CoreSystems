using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Estoque
{
    public class AlmoxarifadoTransferencia : CustomDispose
    {
        public static string _restricao = "AlmoxarifadoTransferenciaID";
        public static string _tabela = "dbo.AlmoxarifadoTransferencia";

        #region Campos

        [Mapa("AlmoxarifadoTransferenciaID")]
        public int AlmoxarifadoTransferenciaID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCadastro")]
        public String DataCadastro { get; set; }
        [Mapa("AlmoxarifadoAntigoID")]
        public int AlmoxarifadoAntigoID { get; set; }
        [Mapa("AlmoxarifadoNovoID")]
        public int AlmoxarifadoNovoID { get; set; }
        [Mapa("MotivoTransferencia")]
        public string MotivoTransferencia { get; set; }

        #endregion

    }
}
