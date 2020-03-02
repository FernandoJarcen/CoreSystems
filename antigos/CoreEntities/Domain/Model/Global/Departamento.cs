using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Global
{
    public class Departamento : CustomDispose
    {
        public static string _restricao = "DepartamentoID";
        public static string _tabela = "dbo.Departamento";

        #region Campos

        [Mapa("DepartamentoID")]
        public int DepartamentoID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
