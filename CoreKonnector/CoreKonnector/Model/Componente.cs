using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class Componente:CustomDispose
    {
        public static string _restricao = "ComponenteID";
        public static string _tabela = "dbo.Componente";

        #region Campos

        [Mapa("ComponenteID")]
        public int ComponenteID { get; set; }
        [Mapa("Unidade")]
        public string Unidade { get; set; }
        [Mapa("Aplicacao")]
        public string Aplicacao { get; set; }
        [Mapa("Modulo")]
        public string Modulo { get; set; }
        [Mapa("Rotina")]
        public string Rotina { get; set; }
        [Mapa("Funcao")]
        public string Funcao { get; set; }

        #endregion

        public Componente()
        {

        }
    }
}
