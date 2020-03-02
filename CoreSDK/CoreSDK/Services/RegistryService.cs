using Microsoft.Win32;
using System;
using System.Collections.Generic;
using CoreSDK.Objetos;
using CoreSDK.Enums;

namespace CoreSDK.Services
{
    [Descricao("Classe de registros do windows", "01/06/2019")]
    public static class RegistryService
    {
        #region metodos privados

        private static String converteData(string data)
        {
            string retorno = string.Empty;
            string mesCorrente = string.Empty;
            string anoCorrente = string.Empty;
            string diaCorrente = string.Empty;
            string dia = data.Substring(2, 2);
            string mes = data.Substring(4, 1);
            string ano1 = data.Substring(0, 1);
            string ano2 = data.Substring(1, 1);

            mesCorrente = obterMes(mes).ToString();
            int anoalterado = obterAno1(ano1) + obterAno2(ano2);
            anoCorrente = anoalterado.ToString();            
            retorno = String.Format("{0}/{1}/{2}", dia, mesCorrente, anoCorrente);
            return retorno;
        }

        private static int obterMes(string mes)
        {
            int retorno = 0;
            var mesCorrente = new Dictionary<string, int>()
            {
                {"F",1},{"G",2},{"H",3},{"I",4},{"J",5},{"K",6},{"L",7},{"M",8},{"N",9},{"O",10},{"P",11},{"R",12}
            };
            retorno = mesCorrente[mes];
            return retorno;
        }

        private static int obterAno1(string ano1)
        {
            int retorno = 0;
            var anoCorrente1 = new Dictionary<string, int>()
            {
                {"J", 2010}, {"K", 2020}, {"L", 2030}, {"M", 2040}, {"N", 2050}, {"O", 2060}, {"P", 2070}, {"R", 2080}, {"S", 2090}, {"T", 2100}
            };
            retorno = anoCorrente1[ano1];
            return retorno;
        }

        private static int obterAno2(string ano2)
        {
            int retorno = 0;
            var anoCorrente2 = new Dictionary<string, int>()
            {
                { "S",1},{ "T",2},{ "U",3},{ "V",4},{ "X",5},{ "Z",6},{ "A",7},{ "B",8},{ "C",9},{ "D",0}
            };
            retorno = anoCorrente2[ano2];
            return retorno;
        }


        #endregion

        #region metodos publicos

        public static int CriarRegistro(string _caminho, string _campo, object _valor, RegistryValueKind _tipo = RegistryValueKind.Unknown)
        {
            string keyName = _campo;
            int retorno = -1;

            try
            {
                if (_tipo == RegistryValueKind.Unknown)
                    Registry.SetValue(keyName, _campo, _valor);
                else
                    Registry.SetValue(keyName, _campo, _valor, _tipo);
                retorno = 1;
            }
            catch (Exception)
            {
                retorno = 0;
            }
            return retorno;
        }

        public static int CriarRegistroEspecífico(string _campo, object _valor, RegistryValueKind _tipo = RegistryValueKind.Unknown)
        {
            string keyName = "HKEY_CURRENT_USER\\Software\\Sistematica";
            int retorno = -1;

            try
            {
                if (_tipo == RegistryValueKind.Unknown)
                    Registry.SetValue(keyName, _campo, _valor);
                else
                    Registry.SetValue(keyName, _campo, _valor, _tipo);
                retorno = 1;
            }
            catch (Exception)
            {
                retorno = 0;
            }
            return retorno;
        }

        public static string RetornaRegistro(string _campo)
        {
            string registro = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Sistematica", _campo, "");
            return registro;
        }

        public static object RetornaRegistroEspecifico(Controles.KeyBase Tipo)
        {
            object retorno = null;
            switch (Tipo)
            {
                case Controles.KeyBase.Produto: retorno = RetornaRegistro("Key").Substring(0, 5);
                    break;
                case Controles.KeyBase.Validade: retorno = converteData(RetornaRegistro("Key").Substring(5, 5));
                    break;
                case Controles.KeyBase.Aquisicao: retorno = converteData(RetornaRegistro("Key").Substring(10, 5));
                    break;
                case Controles.KeyBase.Cliente: retorno = RetornaRegistro("Key").Substring(15, 5);
                    break;
                case Controles.KeyBase.Versao: retorno = RetornaRegistro("Key").Substring(20, 5);
                    break;
                case Controles.KeyBase.Validador: retorno = RetornaRegistro("Key").Substring(25, 5);
                    break;
                default: retorno = null;
                    break;
            }
            return retorno;
        }

        public static bool ValidarChaveEspecifica(string key)
        {
            bool resposta = false;
            string retorno = string.Empty;
            string comparativo = string.Empty;
            if (key.Length != 30)
                resposta = false;
            else
            {
                retorno = key.Substring(5, 1) + key.Substring(15, 1) + key.Substring(0, 1) + key.Substring(10, 1) + key.Substring(20, 1);
                comparativo = RetornaRegistro("Key");
                if (comparativo.Substring(25, 5) == retorno)
                    resposta = true;
            }
            return resposta;
        }

        public static bool CompararChave(string key)
        {
            bool resposta = false;
            string comparativo = RetornaRegistro("Key");
            if (key.Length != 30)
                resposta = false;
            else
            {
                if (key == comparativo)
                    resposta = true;
            }
            return resposta;
        }

        public static bool ValidarRegistro(string key)
        {
            bool retorno = false;
            string comparativo = key.Substring(25, 5);
            string[] chave = new string[5];
            if (key.Length == 30)
            {
                chave[0] = key.Substring(0, 1);
                chave[1] = key.Substring(5, 1);
                chave[2] = key.Substring(10, 1);
                chave[3] = key.Substring(15, 1);
                chave[4] = key.Substring(20, 1);

                if (comparativo.Substring(0, 1) == chave[1])
                    if (comparativo.Substring(1, 1) == chave[3])
                        if (comparativo.Substring(2, 1) == chave[0])
                            if (comparativo.Substring(3, 1) == chave[2])
                                if (comparativo.Substring(4, 1) == chave[4])
                                    retorno = true;

            }
            return retorno;
        }

        #endregion
    }
}
