using CoreEntities.Base;
using CoreEntities.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreEntities.Domain.Model.Financeiro
{
    public class Fatura : CustomDispose
    {
        public static string _restricao = "FaturaID";
        public static string _tabela = "dbo.Fatura";

        #region Campos

        [Mapa("FaturaID")]
        public int FaturaID { get; set; }
        [Mapa("OrigemOperacaoID")]
        public int OrigemOperacaoID { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("DataCriacao")]
        public string DataCriacao { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("DataCancelamento")]
        public string DataCancelamento { get; set; }
        [Mapa("ValorTotal")]
        public decimal ValorTotal { get; set; }
        [Mapa("MotivoCancelamento")]
        public string MotivoCancelamento { get; set; }

        #endregion

    }
}
