using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CoreSDK.Utils;
using System.Globalization;

namespace CoreSDK.ODB.Domain.DataSet
{
    public static class Field
    {
        public static object Set(string nome, List<object> entidade)
        {
            object _retorno = null;
            string _tabela = obtemTabela(nome);
            string _campo = obtemCampo(nome);
            object entity = retornaEntidade(entidade, _tabela);

            _retorno = (entity != null ? retornaCampo(entity, _campo) : null);
            return _retorno;
        }
        
        #region metodos privados

        private static object retornaCampo(object entity, string nome)
        {
            Type entidade = entity.GetType();
            PropertyInfo[] propriedades = entidade.GetProperties();

            object valor = new object();

            var ValorDaPropriedade = from item in propriedades
                                     where item.Name == nome
                                     select item.GetValue(entity, null);
            List<object> c = ValorDaPropriedade.ToList();
            if (c.Count > 0)
                valor = c[0];

            return valor;
        }

        private static object retornaEntidade(List<object> entidades, string nome)
        {
            var retorno = entidades.Find(x => x.GetType().Name == nome);
            return retorno;
        }

        private static string obtemTabela(string nome)
        {
            string campo = string.Empty;
            string procura = nome;
            var palavras = procura.Split('.');
            campo = palavras[0];
            return campo;
        }

        private static string obtemCampo(string nome)
        {
            string campo = string.Empty;
            string procura = nome;
            var palavras = procura.Split('.');
            campo = palavras[1];
            return campo;
        }

        #endregion

    }
}
