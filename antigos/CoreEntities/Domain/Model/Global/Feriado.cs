using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Feriado : CustomDispose
    {
        public static string _restricao = "FeriadoID";
        public static string _tabela = "dbo.Feriado";

        #region Campos

        [Mapa("FeriadoID")]
        public int FeriadoID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("DataFixada")]
        public string DataFixada { get; set; }
        [Mapa("DataFixaFeriado")]
        public string DataFixaFeriado { get; set; }
        [Mapa("DataMovelFeriado")]
        public string DataMovelFeriado { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
