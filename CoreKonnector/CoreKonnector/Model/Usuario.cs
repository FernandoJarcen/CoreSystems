using CoreSDK.Objetos;
using CoreSDK.ODB.Domain;

namespace CoreKonnector.Model
{
    public class Usuario:CustomDispose
    {
        public static string _restricao = "UsuarioID";
        public static string _tabela = "dbo.Usuario";
        //public static Usuario entidade = new Usuario();

        #region campos
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Login")]
        public string Login { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("Sobrenome")]
        public string Sobrenome { get; set; }
        [Mapa("PWD")]
        public string Senha { get; set; }
        [Mapa("CPF")]
        public string CPF { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }

        [Mapa("Expira")]
        public string Expira { get; set; }
        [Mapa("AlteraSenha")]
        public string AlteraSenha { get; set; }
        [Mapa("Email")]
        public string Email { get; set; }
        [Mapa("Lembrete")]
        public string Lembrete { get; set; }
        [Mapa("Privilegio")]
        public string Privilegio { get; set; }
        [Mapa("DataCadastro")]
        public string DataCadastro { get; set; }
        [Mapa("DataAlteracao")]
        public string DataAlteracao { get; set; }
        [Mapa("DataExpiracao")]
        public string DataExpiracao { get; set; }
        [Mapa("UsuarioAlteracao")]
        public int UsuarioAlteracao { get; set; }
        #endregion
        public Usuario(){}
    }
}
