using CoreSDK.Objetos;
using System;
using System.Net;
using System.Net.Mail;
using cst = CoreSDK.Objetos.Constantes;

namespace CoreSDK.Services
{
    [Descricao("Classe de e-mail", "01/06/2019")]
    public class EmailService
    {
        public string SMTP { get; set; }
        public int Porta { get; set; }
        public string EmailAtivo { get; set; }
        public string Password { get; set; }

        public EmailService(string smtp, int porta, string email, string password)
        {
            SMTP = smtp;
            Porta = porta;
            EmailAtivo = email;
            Password = password;
        }

        public class Email
        {
            private bool validarDados(String para, String nome, String assunto, String email)
            {
                bool retorno = false;
                if (!string.IsNullOrEmpty(para))
                    if (!string.IsNullOrEmpty(nome))
                        if (!string.IsNullOrEmpty(assunto))
                            if (!string.IsNullOrEmpty(email))
                                retorno = true;
                return retorno;
            }

            public bool Enviar()
            {
                if (validarDados(Mensageiro.De, Mensageiro.Para, Mensageiro.Assunto, Mensageiro.Contexto))
                {
                    try
                    {
                        SmtpClient client = new SmtpClient(cst.smtp, cst.porta);

                        client.Credentials = new NetworkCredential(cst.nome, cst.pwd);
                        client.EnableSsl = true;

                        MailMessage message = new MailMessage();
                        message.Sender = new MailAddress(cst.nome, Mensageiro.Autor);
                        message.From = new MailAddress(cst.nome, Mensageiro.Autor);
                        message.To.Add(new MailAddress(Mensageiro.Para, Mensageiro.Autor));
                        message.Subject = Mensageiro.Assunto;
                        message.Body = Mensageiro.Contexto;
                        message.IsBodyHtml = true;

                        client.Send(message);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else return false;
            }

            public String Enviar(String para, String nome, String assunto, String email)
            {
                string mensagem = string.Empty;
                if (validarDados(para, nome, assunto, email))
                {
                    try
                    {
                        SmtpClient client = new SmtpClient(cst.smtp, cst.porta);

                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(cst.nome, cst.pwd);
                        client.EnableSsl = true;

                        MailMessage message = new MailMessage();
                        message.Sender = new MailAddress(cst.nome, Mensageiro.Autor);
                        message.From = new MailAddress(cst.nome, Mensageiro.Autor);
                        message.To.Add(new MailAddress(para, nome));
                        message.Subject = assunto;
                        message.Body = email;
                        message.IsBodyHtml = true;

                        client.Send(message);
                        mensagem = "Enviada";
                    }
                    catch (Exception ex)
                    {
                        mensagem = ex.Message.ToString();
                    }
                }
                else mensagem = "Dados insuficientes para enviar";
                return mensagem;
            }

        }

        public static class Mensageiro
        {
            public static string Autor { get; set; }
            public static string Contexto { get; set; }
            public static string De { get; set; }
            public static string Para { get; set; }
            public static string Assunto { get; set; }
        }
    }
}
