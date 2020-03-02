using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreModel.Domain.Model.Estoque
{
    public class CategoriaProduto : CustomDispose
    {
        public static string _restricao = "CategoriaProdutoID";
        public static string _tabela = "dbo.CategoriaProduto";

        #region Campos

        [Mapa("CategoriaProdutoID")]
        public int CategoriaProdutoID { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("Nivel")]
        public int Nivel { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Detalhes")]
        public string Detalhes { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        #endregion

    }
}
