using System;
using System.ServiceProcess;
using System.Collections;
using CoreSDK.Objetos;

namespace CoreSDK.Services
{
    [Descricao("Classe de Processos do windows", "01/06/2019")]
    public static class ProcessService
    {
        public static bool StartService(string serviceName, int timeoutMilliseconds)
        {
            bool retorno = false;
            var service = new ServiceController(serviceName);
            try
            {
                var timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool StopService(string serviceName, int timeoutMilliseconds)
        {
            bool retorno = false;
            var service = new ServiceController(serviceName);
            try
            {
                var timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool RestartService(string serviceName, int timeoutMilliseconds)
        {
            bool retorno = false;
            var service = new ServiceController(serviceName);
            try
            {
                var millisec1 = Environment.TickCount;
                var timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                var millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public static string StatusServico(System.ServiceProcess.ServiceController servico)
        {
            string retorno = string.Empty;
            if (servico.Status == ServiceControllerStatus.Running)
                retorno = "Inicializado";
            else if (servico.Status == ServiceControllerStatus.Stopped)
                retorno = "Parado";
            else if (servico.Status == ServiceControllerStatus.Paused)
                retorno = "Pausado";
            else
                retorno = "Outros";

            return retorno;
        }

        public static bool VerificarInstancia(String busca)
        {
            bool retorno = false;
            System.Diagnostics.Process[] processos;
            processos = System.Diagnostics.Process.GetProcesses();

            for (int i = 0; i < processos.Length; i++)
            {
                if (processos[i].ProcessName == busca)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}
