using System;
using System.Windows.Forms;
using CoreSDK.Utils;
//using CoreEntities.Domain.Services;
using System.Diagnostics;
using CoreSDK.Specific;
using CoreSDK.Enums;

namespace sistematica.application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// "8 UNIDADE?SAO?JOSE 1 Administrador? 0"
        /// </summary>
        [STAThread]
        static void Main(string[] parametros)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pluggin global = new pluggin("Modulo", "sistematica.application", PlugginStatus.Desenvolvimento);
            //pluggin global = new pluggin("Modulo", "sistematica.application", false);

            //try
            //{
                Application.Run(new sistematica.application.Formularios.modulo(global));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
    }
}
