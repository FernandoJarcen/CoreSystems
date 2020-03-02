

using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Global
{
    public class Projeto : CustomDispose
    {
        public static string _restricao = "ProjetoID";
        public static string _tabela = "dbo.Projeto";

        #region Campos

        [Mapa("ProjetoID")]
        public int ProjetoID { get; set; }
        [Mapa("UnidadeNegocioID")]
        public int UnidadeNegocioID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
