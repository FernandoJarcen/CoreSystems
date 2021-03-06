﻿

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Tributario
{
    public class NCM : CustomDispose
    {
        public static string _restricao = "NcmID";
        public static string _tabela = "dbo.Ncm";

        #region campos

        [Mapa("NcmID")]
        public int NCMID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }

        #endregion

    }
}
