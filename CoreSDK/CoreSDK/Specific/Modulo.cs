using CoreSDK.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.Specific
{
    public static class Modulo
    {
        public static string AbrirModulos(string nomeModulo, string codigoFilial, string nomeFilial, int id, string usuario, int codigoInstancia)
        {
            string retorno = string.Empty;
            String caminho = Xml.BuscaTAG("padrao");
            try
            {
                if (VerificarModulo(nomeModulo) == false)
                {
                    System.Diagnostics.Process.Start(caminho + nomeModulo + ".exe", codigoFilial + "?" + nomeFilial + "?" + id.ToString() + "?" + usuario + "?" + codigoInstancia);
                    retorno = "";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
                //throw;
            }
            return retorno;
        }

        public static void FecharModulos(List<string> pmod)
        {
            string executavel = string.Empty;
            int t = pmod.Count;
            for (int indice = 0; indice < pmod.Count; indice++)
            {
                executavel = pmod[indice].ToString();
                EncerrarProcesso(executavel);
            }
        }

        public static void EncerrarProcesso(String busca)
        {
            Process[] processos = Process.GetProcessesByName(busca);
            foreach (Process processo in processos)
            {
                if (processo.ProcessName == busca)
                {
                    processo.Kill();
                    processo.WaitForExit();
                }
            }
        }

        public static bool VerificarModulo(String busca)
        {
            return VerificarInstancia(busca);
        }

        private static bool VerificarInstancia(String busca)
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

        public static int ContarInstancia(String busca)
        {
            int qtd = 0;
            System.Diagnostics.Process[] processos;
            processos = System.Diagnostics.Process.GetProcesses();

            for (int i = 0; i < processos.Length; i++)
            {
                if (processos[i].ProcessName == busca)
                {
                    qtd = qtd + 1;
                }
            }
            return qtd;
        }

        public static string RetornarParametro(string parametro, int ocorrencia)
        {
            char[] par = parametro.ToCharArray();
            int oc = 1;
            int pos = 0;
            int fim = 0;
            string p1 = String.Empty;

            if (ocorrencia == 0)
            {
                for (int i = 0; i < par.Length; i++)
                {
                    if (par[i].ToString() == "?")
                        break;
                    else
                    {
                        p1 = p1 + par[i].ToString();
                    }
                }
                return p1;
            }
            else
            {
                for (int i = 0; i < par.Length; i++)
                {
                    if (par[i].ToString() == "?")
                    {
                        if (oc == ocorrencia)
                        {
                            pos = i;
                        }
                        else if (oc == ocorrencia + 1)
                        {
                            fim = i;
                        }
                        oc = oc + 1;
                    }
                }
                if (fim == 0)
                    return parametro.Substring(pos + 1);
                else
                    return parametro.Substring(pos + 1, fim - (pos + 1));
            }
        }

    }
}
