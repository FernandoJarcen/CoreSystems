using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Padrao : CustomDispose
    {
        public static string _restricao = "PadraoID";
        public static string _tabela = "dbo.Padrao";

        #region Campos

        [Mapa("PadraoID")]
        public int PadraoID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }

        #endregion

    }
}
