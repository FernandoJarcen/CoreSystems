

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class Categoria : CustomDispose
    {
        public static string _restricao = "CategoriaID";
        public static string _tabela = "dbo.Categoria";
        #region Campos

        [Mapa("CategoriaID")]
        public int CategoriaID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        #endregion

    }
}