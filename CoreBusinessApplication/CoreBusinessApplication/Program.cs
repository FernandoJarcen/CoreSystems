using System;
using System.Windows.Forms;
using CoreSDK.Utils;
using System.Diagnostics;
using CoreSDK.Specific;
using CoreKonnector.Services;
using CoreSDK.Enums;
using CoreKonnector.Entidades;

namespace CoreBusinessApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// "8 UNIDADE?SAO?JOSE 1 Administrador? 0"
        /// </summary>
        [STAThread]
        static void Main(string[] param)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pluggin global = new pluggin("CoreBusinessApplication", "CoreBusinessApplication", PlugginStatus.Normal);

            //string chave = "0000000000000000000000000000000000000";

            try
            {
                int qtdInstancias = Modulo.ContarInstancia("sistematica." + global.Modulo.ToLower());

                if (qtdInstancias > 1)
                    Application.Exit();
                else
                {
                    Application.Run(new CoreBusinessApplication.Formularios.frmAplicacao());
                    //if (global.Valida == PlugginStatus.Parametro)
                    //{
                    //    param = AutenticacaoParametros.Validierungsparameter();
                    //    global = AutenticacaoParametros.Instanzvalidierung(global.Modulo, global.NomeFisico, global.Valida);
                    //    Application.Run(new CoreBusinessApplication.Formularios.modulo(global));
                    //}
                    //else if (global.Valida == PlugginStatus.Desenvolvimento)
                    //{
                    //    param = AutenticacaoParametros.Validierungsparameter();
                    //    global = AutenticacaoParametros.Instanzvalidierung(global.Modulo, global.NomeFisico, global.Valida);
                    //    Application.Run(new CoreBusinessApplication.Formularios.modulo(global));
                    //}
                    //else
                    //{
                    //    /*parametro deve ser habilitado para simular o modulo quando chamado */
                    //    param = CoreKonnector.Entidades.AutenticacaoParametros.Validierungsparameter();
                    //    param = AutenticacaoModulos.ConverterParametros(param);

                    //    if (param.Length <= 0)
                    //    {
                    //        Msg.Information("Parâmetros do módulo não encontrados", MessageBoxButtons.OK);
                    //        Application.Exit();
                    //    }
                    //    else
                    //    {
                    //        global = AutenticacaoParametros.Instanzvalidierung(global.Modulo, global.NomeFisico, global.Valida, param);

                    //        if (ModuloService.validarModulo(global.Modulo, chave, global.CodigoInstancia) == false)
                    //        {
                    //            Msg.Exclamation("Módulo não autenticado", MessageBoxButtons.OK);
                    //            Application.Exit();
                    //        }
                    //        else
                    //        {
                    //            if (Modulo.VerificarModulo("sistematica.principal") == false)
                    //            {
                    //                Msg.Information("Módulo Principal não carregado", MessageBoxButtons.OK);
                    //                Application.Exit();
                    //            }
                    //            else
                    //                Application.Run(new CoreBusinessApplication.Formularios.modulo(global));
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LOG.Escrever("Modulo", ex.Message);
                Application.Exit();
            }
        }
    }
}
