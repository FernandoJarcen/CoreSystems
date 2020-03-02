using CoreMDK.Model;
using CoreSDK.Entities.Base;
using CoreSDK.Services;
using CoreSDK.Utils;
using System;
using System.Collections.Generic;

namespace CoreMDK.Security
{
    public static class CIF
    {
        #region metodos privados

        private static string AssinarSenha(string senha)
        {
            string retorno = string.Empty;
            retorno = "<$" + senha;
            return retorno;
        }

        private static string RetirarSenha(string senha)
        {
            string retorno = string.Empty;
            retorno = senha.Substring(2);
            return retorno;
        }
        
        #endregion

        #region metodos publicos

        public static bool VerificarSenha(string nomeUsuario, string senha)
        {
            bool retorno = false;
            string senhaEncontrada = string.Empty;

            try
            {
                senhaEncontrada = Acao<Usuario>.Selecionar("PWD", "Login = '" + nomeUsuario + "'");
                if (!String.IsNullOrEmpty(senhaEncontrada))
                    if (senhaEncontrada != "Não há linha na posição 0.")
                    {
                        if (VerificarCriptografado(senhaEncontrada))
                            senhaEncontrada = Seguranca.MD5Crypt.Descriptografar(senhaEncontrada);

                        senhaEncontrada = RetirarSenha(senhaEncontrada);
                        if (senhaEncontrada == senha)
                            retorno = true;
                    }
                    else
                        retorno = false;
                else
                    retorno = false;
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public static string AlterarSenha(string nomeUsuario, string senha, string lembrete = "", bool criptografado = true)
        {
            string retorno = string.Empty;
            string senhaEncontrada = string.Empty;

            try
            {
                senhaEncontrada = AssinarSenha(senha);
                if (criptografado)
                    senhaEncontrada = Seguranca.MD5Crypt.Criptografar(senhaEncontrada);

                Dictionary<string, object> pwd = new Dictionary<string, object>();
                pwd.Add("PWD", senhaEncontrada);
                pwd.Add("Lembrete", lembrete);
                pwd.Add("DataAlteracao", DateTime.Now.ToString().ToInput());
                retorno = Acao<Usuario>.Atualizar(pwd, "Login = '" + nomeUsuario + "'");
            }
            catch (Exception)
            {
                retorno = "Não foi possível alterar a senha!";
            }

            return retorno;
        }

        public static string AlterarSenha(int codigoUsuario, string senha, string lembrete = "", bool criptografado = true)
        {
            string retorno = string.Empty;
            string senhaEncontrada = string.Empty;

            try
            {
                senhaEncontrada = AssinarSenha(senha);
                if (criptografado)
                    senhaEncontrada = Seguranca.MD5Crypt.Criptografar(senhaEncontrada);

                Dictionary<string, object> pwd = new Dictionary<string, object>();
                pwd.Add("PWD", senhaEncontrada);
                pwd.Add("Lembrete", lembrete);
                pwd.Add("DataAlteracao", DateTime.Now.ToString().ToInput());
                retorno = Acao<Usuario>.Atualizar(pwd, "UsuarioID = " + codigoUsuario);
            }
            catch (Exception)
            {
                retorno = "Não foi possível alterar a senha!";
            }

            return retorno;
        }

        public static string ResetarSenha(string nomeUsuario, string lembrete)
        {
            string retorno = string.Empty;
            string lembreteEncontrado = string.Empty;

            try
            {
                lembreteEncontrado = Acao<Usuario>.Selecionar("Lembrete", "Nome = '" + nomeUsuario + "'");

                if (!string.IsNullOrEmpty(lembreteEncontrado))
                {
                    if (lembrete == lembreteEncontrado)
                    {
                        lembreteEncontrado = AssinarSenha(lembreteEncontrado);
                        Dictionary<string, object> pwd = new Dictionary<string, object>();
                        pwd.Add("Pwd", lembreteEncontrado);
                        retorno = Acao<Usuario>.Atualizar(pwd, "Nome = '" + nomeUsuario + "'");
                    }
                    else
                        retorno = "Senha não pode ser resetada";
                }
                else
                    retorno = "Senha não pode ser resetada";
            }
            catch (Exception)
            {
                retorno = "Senha não pode ser resetada";
            }

            return retorno;
        }

        public static bool VerificarCriptografado(string senha)
        {
            bool retorno = false;
            if (senha.Substring(0, 2) != "<$")
                retorno = true;
            return retorno;
        }

        public static string InserirSenha(string senha, bool criptografado)
        {
            string retorno = string.Empty;

            senha = AssinarSenha(senha);
            if (criptografado)
                senha =  Seguranca.MD5Crypt.Criptografar(senha);
            retorno = senha;
            
            return retorno;
        }
        
        #endregion
    }
}
