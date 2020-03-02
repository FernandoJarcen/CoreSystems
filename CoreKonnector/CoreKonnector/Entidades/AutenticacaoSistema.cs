// classe de acesso a dados - versão 2.00.001
// criada por fcj em 29/01/2016
// alterada por fcj em 27/03/2018 -- versão 2.0
// alterada por fcj em 24/04/2019 -- versão 3.0
// alterada por fcj em 01/06/2019 -- versão 3.1

using System;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Data;
using System.Collections.Generic;
using CoreSDK.Entities.Base;
using CoreSDK.Utils;
using CoreSDK.Services;
using CoreKonnector.Model;
using CoreMDK.Query;
using CoreMDK.Security;
using CoreSDK.Enums;
using CoreSDK.Specific;
using CoreMDK.MDKBase;
using CoreSDK.Objetos;

namespace CoreKonnector.Entidades
{

    [Descricao("Classe de autenticação de usuário", "01/06/2019")]
    public class AutenticacaoSistema
    {
        private static bool _validado = false;
        public static int _Banco = -1;
        public static string _Mensageiro = String.Empty;
        public static string _Service = String.Empty;

        #region metodos privados

        private static bool UsuarioExiste(string usuario, string senha)
        {
            bool retorno = false;
            int dados = -1;
            string senhaCript = string.Empty;

            dados = Acao<Usuario>.Contar("Login = '" + usuario + "' and Status = 'A'");

            if (dados > 0)
            {
                senhaCript = Acao<Usuario>.Selecionar("PWD", "Login = '" + usuario + "'");
                senhaCript = Seguranca.MD5Crypt.Descriptografar(senhaCript);
                if (senhaCript == senha)
                    retorno = true;
            }

            return retorno;
        }

        private static int CodigoUsuario(string usuario)
        {
            int retorno = -1;

            try
            {
                int dados = Acao<Usuario>.Contar("Login = '" + usuario + "' and Status = 'A'");

                if (dados > 0)
                    retorno = Convert.ToInt32(Acao<Usuario>.Selecionar("UsuarioID", "Login = '" + usuario + "'"));
                return retorno;
            }
            catch (Exception)
            {
                retorno = -1;
            }
            return retorno;
        }

        private static bool parametroAtivo(int codigo)
        {
            int expira = 0;
            int parametro = 0;
            bool retorno = false;

            expira = Acao<Usuario>.Contar("Expira = 'S' and UsuarioID = " + codigo);

            if (expira > 0)
            {
                parametro = Acao<Usuario>.Contar("UsuarioID = " + codigo + " and DataExpiracao <= cast(GETDATE() as date)");

                if (parametro > 0)
                    retorno = false;
                else
                    retorno = true;
            }
            else
                retorno = true;
            return retorno;
        }

        private static bool validarUsuarioLDAP(String usuario, String senha)
        {
            validarAcessoAD(usuario, senha);
            if (_validado)
            {
                Util.Parametros[Prm.NomeUsuario].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void validarAcessoAD(string usuario, string senha)
        {
            using (DirectoryEntry entry = new DirectoryEntry())
            {
                entry.Username = usuario;
                entry.Password = senha;

                DirectorySearcher buscar = new DirectorySearcher(entry);

                buscar.Filter = "(objectclass=user)";

                try
                {
                    buscar.FindOne();
                    _validado = true;
                }
                catch (COMException ex)
                {
                    if (ex.ErrorCode == -2147023570)
                        _validado = false;
                }
            }
        }

        #endregion

        #region metodos publicos

        public static bool IniciarAutenticacao(String usuario, String senha)
        {
            BancoDados.TipoAutenticacao tipoAutenticacao = Util.TipoAutenticacao;
            bool autentica = false;

            if (tipoAutenticacao == BancoDados.TipoAutenticacao.Banco)
                autentica = ValidarUsuarioBanco(usuario, senha);
            else if (tipoAutenticacao == BancoDados.TipoAutenticacao.AD)
                autentica = validarUsuarioLDAP(usuario, senha);
            return autentica;
        }

        public static bool TestarConexao(string conexao)
        {
            bool retorno = false;
            try
            {
                retorno = CoreSDK.ODB.DataBase.DB.TestarConexao(conexao);
            }
            catch (Exception)
            {
                retorno = false;
            }
            
            return retorno;
        }
        
        public static bool ValidarUsuarioBanco(String usuario, String senha)
        {
            bool retorno = false;
            int codigo = -1;

            try
            {
                if (CIF.VerificarSenha(usuario,senha))
                {
                    codigo = CodigoUsuario(usuario);
                    bool ativo = parametroAtivo(codigo);

                    if (codigo > -1)
                        retorno = ativo ? true : false;
                }                
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public static DataTable BuscarUsuario(string usuario, bool validarStatus = false)
        {
            DataTable retorno = new DataTable();
            try
            {
                if (!validarStatus)
                    retorno = Acao<Usuario>.SelecionarTodos(new string[] { "UsuarioID", "Login", "NomeCompleto" }, "Login = '" + usuario + "'");
                else
                    Acao<Usuario>.SelecionarTodos(new string[] { "UsuarioID", "Login", "NomeCompleto" }, "Login = '" + usuario + "' and Status = 'A'");
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }

        public static DataTable BuscarUsuario(String usuario, String senha)
        {
            DataTable retorno = new DataTable();
            try
            {
                using (DataTable dtUsuario = Acao<Usuario>.SelecionarTodos(new string[] { "UsuarioID", "Login", "NomeCompleto" }, "Login = '" + usuario + "' and PWD = '" + senha + "' and Status = 'A'"))
                {
                    retorno = Acao<Usuario>.SelecionarTodos(new string[] { "UsuarioID", "Login", "NomeCompleto" }, "Login = '" + usuario + "' and PWD = '" + senha + "' and Status = 'A'");
                }
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }

        public static DataTable BuscarEquipe(int usuario)
        {
            DataTable retorno = default(DataTable);

            QueryExpression query = new QueryExpression("Usuario", "usu");
            string[] campos = new string[] { "equ.EquipeID", "usu.UsuarioID" };
            Join join = new Join("EquipeUsuario", "equ", "UsuarioID");

            List<Condition> condicoes = new List<Condition>()
            {                
                new Condition("usu.UsuarioID",Operadores.ConditionOperator.Igual,usuario)
            };

            query.AddColumns(campos);
            query.AddJoin(join);
            query.AddCondicoes(condicoes);
            retorno = query.Execute();

            return retorno;
        }

        public static DataTable BuscarRotina(Int32 usuario, String modulo)
        {
            DataTable retorno = default(DataTable);

            QueryExpression query = new QueryExpression("Usuario", "usu");
            string[] campos = new string[] { "distinct cpn.ItemRotina" };

            List<Join> join = new List<Join>()
            { 
                new Join("EquipeUsuario","eqp","UsuarioID"),
                new Join("ComponenteEquipe","equ","EquipeID"),
                new Join("Componente","cpn","Aplicacao"),
            };

            List<Condition> condicoes = new List<Condition>()
            {
            new Condition("usu.UsuarioID", Operadores.ConditionOperator.Igual, usuario),
            new Condition("cpn.Unidade", Operadores.ConditionOperator.Igual, modulo)
            };

            List<Union> union = new List<Union>() { new CoreMDK.Query.Union(Operadores.QueryOperator.E) };

            query.AddColumns(campos);
            query.AddJoin(join);
            query.AddCondicoes(condicoes, union);
            retorno = query.Execute();

            return retorno;
        }

        public static DataTable BuscarModulo(Int32 usuario, String modulo)
        {
            DataTable retorno = default(DataTable);

            QueryExpression query = new QueryExpression("Usuario", "usu");
            string[] campos = new string[] { "distinct cpn.ItemModulo" };

            List<Join> join = new List<Join>()
            {
                new Join("EquipeUsuario", "eqp", "UsuarioID"),
                new Join("ComponenteEquipe", "equ", "EquipeID"),
                new Join("Componente", "cpn", "Aplicacao")
            };

            List<Condition> condicoes = new List<Condition>(){
            new Condition("usu.UsuarioID", Operadores.ConditionOperator.Igual, usuario),
            new Condition("cpn.Unidade", Operadores.ConditionOperator.Igual, modulo)
            };

            List<Union> union = new List<Union>() { new Union(Operadores.QueryOperator.E) };

            query.AddColumns(campos);
            query.AddJoin(join);
            query.AddCondicoes(condicoes, union);
            retorno = query.Execute();

            return retorno;
        }

        public static DataTable BuscarAplicacao(Int32 usuario, String modulo)
        {
            DataTable retorno = default(DataTable);

            QueryExpression query = new QueryExpression("Usuario", "usu");
            string[] campos = new string[] { "distinct cpn.ItemAplicacao" };

            List<Join> join = new List<Join>()
            {
                new Join("EquipeUsuario", "eqp", "UsuarioID"),
                new Join("ComponenteEquipe", "equ", "EquipeID"),
                new Join("Componente", "cpn", "Aplicacao")
            };

            List<Condition> condicoes = new List<Condition>(){
            new Condition("usu.UsuarioID", Operadores.ConditionOperator.Igual, usuario),
            new Condition("cpn.Unidade", Operadores.ConditionOperator.Igual, modulo)
            };

            List<Union> union = new List<Union>() { new Union(Operadores.QueryOperator.E) };

            query.AddColumns(campos);
            query.AddJoin(join);
            query.AddCondicoes(condicoes, union);
            retorno = query.Execute();

            return retorno;
        }

        public static String AlterarSenha(string usuario, string senha, string lembrete = "")
        {
            string processo = string.Empty;            
            Int32 usuarioAtivo = Convert.ToInt32(Acao<Usuario>.Selecionar("UsuarioID", "Login = '" + usuario + "'"));

            string criptografado = Xml.BuscaTAG("criptografado");
            if (criptografado == "NAO")
            {
                if (!String.IsNullOrEmpty(lembrete))
                    processo = CIF.AlterarSenha(usuario, senha, lembrete, false);
                else
                    processo = CIF.AlterarSenha(usuario, senha, String.Empty, false);
            }
            else
            {
                if (!String.IsNullOrEmpty(lembrete))
                    processo = CIF.AlterarSenha(usuario, senha, lembrete);
                else
                    processo = CIF.AlterarSenha(usuario, senha);
            }
                

            if (processo == "Registro Atualizado com sucesso!")
                processo = "Senha alterada";
            else
                processo = "Senha não alterada";
            return processo;
        }
        
        public static bool ValidarComponentes(DataTable aplicacao, DataTable modulo, DataTable rotina)
        {
            bool retorno = false;
            if (aplicacao.Rows.Count > 0)
                if (modulo.Rows.Count > 0)
                    if (rotina.Rows.Count > 0)
                        retorno = true;
            return retorno;
        }

        public static string InserirUsuario(Usuario usuario, int equipe)
        {
            string retorno = string.Empty;
            string criptografado = string.Empty;
            int codigoUsuario = -1;
            try
            {
                criptografado = Util.Parametros[CoreSDK.Enums.Prm.Criptografado].ToString();
                if (criptografado == "SIM")
                    usuario.Senha = CoreMDK.Security.CIF.InserirSenha(usuario.Senha, true);
                else
                    usuario.Senha = CoreMDK.Security.CIF.InserirSenha(usuario.Senha, false);
                codigoUsuario = Acao<Usuario>.InserirChave(usuario);

                if (codigoUsuario >= 0)
                {
                    EquipeUsuario eqp = new EquipeUsuario();
                    eqp.EquipeID = equipe;
                    eqp.UsuarioID = codigoUsuario;
                    retorno = Acao<EquipeUsuario>.Inserir(eqp);
                }
                else
                    retorno = "não foi possivel inserir a equipe para o usuário!";
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }
            return retorno;
        }

        public static bool VerificarLoginExistente(string login)
        {
            bool retorno = false;
            int qtdUsuario = Acao<Usuario>.Contar("Login = '" + login + "'");
            if (qtdUsuario > 0)
                retorno = true;
            return retorno;
        }
        
        #endregion
                
    }
}