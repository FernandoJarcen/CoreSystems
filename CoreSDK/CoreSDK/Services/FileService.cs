using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CoreSDK.Utils;
using CoreSDK.Enums;
using CoreSDK.Objetos;

namespace CoreSDK.Services
{
    [Descricao("Classe de arquivos", "01/06/2019")]
    public static class FileService
    {
        public static bool copiarArquivo(string arquivo, string origem, string destino)
        {
            bool retorno = false;
            string sourceFile = System.IO.Path.Combine(origem, arquivo);
            string destFile = System.IO.Path.Combine(destino, arquivo);

            try
            {
                if (!Directory.Exists(destino))
                    Directory.CreateDirectory(destino);

                if (File.Exists(sourceFile))
                {
                    File.Copy(sourceFile, destFile, true);
                    retorno = true;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool VerificarArquivo(string nome)
        {
            bool retorno = false;
            String caminho = string.Empty;            
            caminho = Util.Parametros[Prm.CaminhoExecutavel].ToString();

            if (System.IO.File.Exists(caminho + nome + ".exe"))
                retorno = true;
            return retorno;
        }

        public static bool VerificarArquivoEspecifico(string nome)
        {
            bool retorno = false;

            if (System.IO.File.Exists(nome)) retorno = true;
            return retorno;
        }

        public static bool VerificarCaminho(string caminho)
        {
            bool retorno = false;
            if (System.IO.Directory.Exists(caminho)) retorno = true;
            return retorno;
        }
    
    }
}
