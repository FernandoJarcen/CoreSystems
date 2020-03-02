using CoreSDK.ODB.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMDK.Model
{
    public class Usuario : CoreSDK.Objetos.CustomDispose
    {
        public static string _restricao = "UsuarioID";
        public static string _tabela = "dbo.Usuario";

        #region campos
        [Mapa("UsuarioID")]
        public int UsuarioID { get; set; }
        [Mapa("Login")]
        public string Login { get; set; }
        [Mapa("Nome")]
        public string Nome { get; set; }
        [Mapa("Sobrenome")]
        public string Sobrenome { get; set; }
        [Mapa("Status")]
        public string Status { get; set; }
        [Mapa("PWD")]
        public string Senha { get; set; }
        [Mapa("CPF")]
        public string CPF { get; set; }
        [Mapa("Email")]
        public string Email { get; set; }
        [Mapa("Expira")]
        public string Expira { get; set; }
        [Mapa("AlteraSenha")]
        public string AlteraSenha { get; set; }
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
        public Usuario() { }
    }
}
