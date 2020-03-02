//using CoreEntities.Base;
//using CoreEntities.Objetos;
using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class Equipe : CustomDispose
    {
        public static string _restricao = "EquipeID";
        public static string _tabela = "dbo.Equipe";

        #region campos

        [Mapa("EquipeID")]
        public int EquipeID { get; set; }
        [Mapa("Descricao")]
        public string Descricao { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataExpiracao")]
        public string DataExpiracao { get; set; }
        [Mapa("Expira")]
        public string Expira { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("Membros")]
        public int Membros { get; set; }

        #endregion

        public Equipe(){}
    }
}
