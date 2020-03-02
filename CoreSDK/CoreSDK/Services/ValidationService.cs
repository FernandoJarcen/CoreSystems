using CoreSDK.Objetos;
using System;
using System.Text.RegularExpressions;

namespace CoreSDK.Services
{
    [Descricao("Classe de validação", "01/06/2019")]
    public static class ValidationService
    {

        public static bool ValidarCPF(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)
                return false;

            TempCPF = CPF.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = Digito + resto.ToString();

            return CPF.EndsWith(Digito);
        }

        public static bool ValidarEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                if (Email.IndexOf("@", indexArr + 1) > 0)
                {
                    return ValidEmail;
                }

                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }

        public static bool ValidarEmailRegEx(string email)
        {

            Regex regExpEmail = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");
            Match match = regExpEmail.Match(email);

            if (match.Success)
                return true;
            else
                return false;
        }

        public static bool ValidarCNPJ(string cnpj)
        {

            int[] mt1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma; int resto; string digito; string TempCNPJ;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            if (cnpj == "00000000000000" || cnpj == "11111111111111" ||
             cnpj == "22222222222222" || cnpj == "33333333333333" ||
             cnpj == "44444444444444" || cnpj == "55555555555555" ||
             cnpj == "66666666666666" || cnpj == "77777777777777" ||
             cnpj == "88888888888888" || cnpj == "99999999999999")
                return false;

            TempCNPJ = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(TempCNPJ[i].ToString()) * mt1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            TempCNPJ = TempCNPJ + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(TempCNPJ[i].ToString()) * mt2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool ValidarChaveNFE(string chave)
        {
            bool retorno = false;
            string digitoChave = chave.Substring(43, 1);
            string digitoGerado = string.Empty;
            string chavetestar = chave.Substring(0, 43);
            int tamanho = chave.Length;
            if (tamanho == 44)
            {

                digitoGerado = GerarDigitoVerificadorNFe(chavetestar).ToString();
                if (digitoChave == digitoGerado)
                    retorno = true;
            }
            return retorno;
        }

        private static int GerarDigitoVerificadorNFe(string chave)
        {
            int retorno = -1;
            int resto = -1;
            int[] pesos = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9 };
            int soma = 0;
            int indice = 0;

            for (int intPos = chave.Length - 1; intPos >= 0; intPos--)
            {
                soma += Convert.ToInt32(chave[intPos].ToString()) * pesos[indice];
                if (indice == 9)
                {
                    indice = 2;
                }
                else
                {
                    indice++;
                }
            }

            resto = (soma * 10) % 11;
            retorno = resto;
            if (retorno >= 10)
                retorno = 0;

            return retorno;
        }

    }
}
