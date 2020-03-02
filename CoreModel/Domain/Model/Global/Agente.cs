

using CoreSDK.Entities.Base;
using CoreSDK.ODB.Domain;
using System;

namespace CoreModel.Domain.Model.Global
{
    public static class Agente
    {
        public static String SelecionarPor(string tipoConta, int criteria)
        {
            string retorno = string.Empty;
            if (tipoConta == "Conta")
                retorno = Acao<Conta>.Selecionar("RazaoSocial", "ContaID = " + criteria);
            else if (tipoConta == "CON")
                retorno = Acao<Conta>.Selecionar("RazaoSocial", "ContaID = " + criteria);
            else
                retorno = Acao<Contato>.Selecionar("Nome", "ContatoID = " + criteria);
            return retorno;
        }

        public static int SelecionarIndice(string nome)
        {
            string retorno = string.Empty;
            int quantidade = -1;
            
            using (Conta conta = new Conta())
            {
                quantidade = Acao<Conta>.Contar("RazaoSocial = '" + nome + "'");
                if (quantidade > 0)
                    retorno = Acao<Conta>.Selecionar("ContaID", "RazaoSocial = '" + nome + "'");
            }
            if (quantidade == 0)            
                    retorno = Acao<Contato>.Selecionar("ContatoID", "Nome = '" + nome + "'");
            return Convert.ToInt32(retorno);
        }

        public static string SelecionarTipoConta(string nome)
        {
            string retorno = string.Empty;
            int quantidade = -1;
            using (Conta conta = new Conta())
            {
                quantidade = Acao<Conta>.Contar("RazaoSocial = '" + nome + "'");
                if (quantidade > 0)
                    retorno = "CON";
            }
            if (quantidade == 0)            
                retorno = "CTT";
            
            return retorno;
        }

    }
}
