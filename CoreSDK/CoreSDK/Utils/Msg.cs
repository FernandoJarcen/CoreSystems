using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreSDK.Utils
{
    public static class Msg
    {
        public static string Aplicacao { get; set; }

        public static DialogResult Asterisk(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Error(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Error);
        }

        public static DialogResult Exclamation(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Exclamation);
        }

        public static DialogResult Hand(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Hand);
        }

        public static DialogResult Information(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Information);
        }

        public static DialogResult Message(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.None);
        }

        public static DialogResult Question(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Question);
        }

        public static DialogResult Stop(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Stop);
        }

        public static DialogResult Warning(string mensagem, MessageBoxButtons botao)
        {
            return MessageBox.Show(mensagem, Aplicacao, botao, MessageBoxIcon.Warning);
        }
    }
}
