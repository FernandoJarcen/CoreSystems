using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreSDK.Utils
{
    public static class LOG
    {

        public static void Escrever(string chamador, string mensagemPadrao)
        {
            string log = @"c:\sistematica\log\log.txt";
            string msg = string.Empty;

            if (!string.IsNullOrEmpty(mensagemPadrao))
            {
                msg = chamador + " - ";
                msg += DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + " " + DateTime.Now.ToShortTimeString();
                msg += " - " + mensagemPadrao;

                if (System.IO.File.Exists(log))
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(log, true))
                        {
                            writer.WriteLine(msg);
                        }
                    }
                    catch (System.IO.IOException e)
                    {
                        MessageBox.Show(e.Message);
                        return;
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(log, true))
                    {
                        writer.WriteLine("LOG DO SISTEMA");
                    }
                }
            }
        }

        public static void Apagar()
        {
            string log = @"c:\Sistematica\Log\log.txt";

            if (System.IO.File.Exists(log))
            {
                try
                {
                    System.IO.File.Delete(log);
                    using (StreamWriter writer = new StreamWriter(log, true))
                    {
                        writer.WriteLine("LOG DO SISTEMA");
                    }
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(log, true))
                {
                    writer.WriteLine("LOG DO SISTEMA");
                }
            }
        }

    }
}
