using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class EntidadeSistema:CustomDispose
    {
        public static string _restricao = "EntidadeSistemaID";
        public static string _tabela = "dbo.EntidadeSistema";

        #region Campos

        [Mapa("EntidadeSistemaID")]
        public int EntidadeSistemaID { get; set; }
        [Mapa("Catalogo")]
        public string Catalogo { get; set; }
        [Mapa("Proprietario")]
        public string Proprietario { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("Apelido")]
        public string Apelido { get; set; }
        [Mapa("Tipo")]
        public string Tipo { get; set; }
        [Mapa("TipoBanco")]
        public string TipoBanco { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("Escopo")]
        public string Escopo { get; set; }
        [Mapa("Display")]
        public string Display { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }

        #endregion

    }
}
