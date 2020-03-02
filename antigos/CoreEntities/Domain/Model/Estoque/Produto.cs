using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Estoque
{
    public class Produto : CustomDispose
    {
        public static string _restricao = "ProdutoID";
        public static string _tabela = "dbo.Produto";

        #region campos

        [Mapa("ProdutoID")]
        public int ProdutoID { get; set; }
        [Mapa("GrupoID")]
        public int GrupoID { get; set; }
        [Mapa("CodigoServicoID")]
        public int CodServicoID { get; set; }
        [Mapa("AplicacaoID")]
        public int AplicacaoID { get; set; }
        [Mapa("CategoriaProdutoID")]
        public int CategoriaProdutoID { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("Tipo")]
        public string Tipo { get; set; }
        [Mapa("CodigoAlternativo")]
        public string CodAlternativo { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("Abreviada")]
        public string Abreviada { get; set; }
        [Mapa("Generico")]
        public string Generico { get; set; }
        [Mapa("CopiaGrupo")]
        public string CopiarGrupo { get; set; }
        [Mapa("PrecoUnico")]
        public string PrecoUnico { get; set; }
        [Mapa("NCM")]
        public string NCM { get; set; }


        #endregion

    }
}
