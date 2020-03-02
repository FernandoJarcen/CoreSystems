using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CoreSDK.Objetos;
using CoreSDK.ODB.DataBase;
using CoreSDK.ODB.Domain;

namespace CoreSDK.ODB.DataBase
{
    public static class Fabrica<T> where T : class
    {
        #region variaveis

        static List<String> lista = new List<string>();
        private static int qtd = 0;
        private static string comando = "";
        private static string chave = "";
        private static string act = "'";
        private static string parte1 = "";
        private static string parte2 = "";

        #endregion

        #region propriedades privadas

        private static void defaultVariaveis()
        {
            qtd = 0;
            comando = "";
            chave = "";
            parte1 = "";
            parte2 = "";
        }

        private static string cPonto(String valor)
        {
            valor = valor.Replace(",", ".");
            return valor;
        }

        private static string cData(String data)
        {
            DateTime dt = Convert.ToDateTime(data);
            String retorno = String.Empty;
            String dia = dt.Day.ToString();
            String mes = dt.Month.ToString();
            String ano = dt.Year.ToString();
            retorno = dia + "/" + mes + "/" + ano;
            return retorno;
        }

        private static string retornaCampo(string nome, T entidade)
        {
            Type tipoentidade = typeof(T);
            PropertyInfo[] propriedades = tipoentidade.GetProperties();
            StringBuilder sb = new StringBuilder();
            object ValorDaPropriedade = null;

            foreach (PropertyInfo propriedade in propriedades)
            {
                ValorDaPropriedade = propriedade.GetValue(entidade, null);
                if (propriedade.Name == nome)
                {
                    ValorDaPropriedade = ValorDaPropriedade == null ? "NULL" : ValorDaPropriedade;
                    sb.Append(ValorDaPropriedade);
                    break;
                }
            }
            return sb.ToString();
        }

        private static List<string> carregarAttributos(T entidade)
        {
            Type tipoentidade = typeof(T);
            MemberInfo[] p = tipoentidade.GetProperties();
            lista.Clear();

            for (int indice = 0; indice < p.Count(); indice++)
            {
                Object[] mapa = p[indice].GetCustomAttributes(true);
                if (mapa.Length > 0)
                {
                    lista.Add(((Mapa)(mapa[0])).Name);
                }
            }
            qtd = 0;
            qtd = lista.Count();
            return lista;
        }

        private static void carregarElementos(T entidade)
        {
            Type tipoentidade = typeof(T);
            PropertyInfo[] propriedades = tipoentidade.GetProperties();
            qtd = propriedades.Count();

            foreach (PropertyInfo propriedade in propriedades)
            {
                lista.Add(propriedade.Name);
            }
            qtd = lista.Count();
        }

        private static string verificarDados(string tabela, string criteria)
        {
            comando = string.Format("SELECT COUNT(*) FROM {0} where {1}", tabela, criteria);
            return comando;
        }

        #endregion

        #region propriedades publicas

        public static string RetornaChave(string nome, T entidade)
        {
            Type tipoentidade = typeof(T);
            FieldInfo[] propriedades = tipoentidade.GetFields();
            object valor = null;
            foreach (FieldInfo propriedade in propriedades)
            {
                if (propriedade.Name == nome)
                {
                    valor = propriedade.GetValue(entidade);
                    break;
                }
            }
            return valor.ToString();
        }

        public static string Select(string tabela, string criteria)
        {

            defaultVariaveis();

            if (string.IsNullOrEmpty(criteria))
                comando = string.Format("SELECT * FROM {0}", tabela);
            else
                comando = string.Format("SELECT * FROM {0} WHERE {1}", tabela, criteria);
            return comando;
        }

        public static string Select(T entidade, string criteria = "")
        {
            string tabela = string.Empty;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);

            if (string.IsNullOrEmpty(criteria))
                comando = string.Format("SELECT * FROM {0}", tabela);
            else
                comando = string.Format("SELECT * FROM {0} WHERE {1}", tabela, criteria);
            return comando;
        }

        public static string SelectPor(T entidade, string campo, string criteria = "")
        {
            string tabela = string.Empty;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);
            if (!string.IsNullOrEmpty(criteria))
                comando = string.Format("SELECT {0} FROM {1} WHERE {2}", campo, tabela, criteria);
            else
                comando = string.Format("SELECT {0} FROM {1}", campo, tabela);
            return comando;
        }

        public static string SelectArray(T entidade, string[] dados, string criteria = "")
        {
            string tabela = string.Empty;
            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);
            string comando = "SELECT ";

            if (dados[0] != "*")
            {
                if (dados.Length > 1)
                {
                    for (int i = 0; i < dados.Length; i++)
                    {
                        if (i == 0)
                            comando = comando + dados[i] + ", ";
                        else if (i == dados.Count() - 1)
                            comando = comando + dados[i];
                        else
                            comando = comando + dados[i] + ", ";
                    }
                }
                else
                    comando += dados[0];
            }
            else
            {
                comando += "*";
            }

            if (string.IsNullOrEmpty(criteria))
                comando = comando + " FROM " + tabela;
            else
                comando = comando + " FROM " + tabela + " WHERE " + criteria;
            return comando;
        }

        public static string SelectList(T entidade, List<string> dados, string criteria = "")
        {
            string tabela = string.Empty;
            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);
            string comando = "SELECT ";
            for (int i = 0; i < dados.Count; i++)
            {
                if (i == 0)
                    comando = comando + dados[i] + ", ";
                else if (i == dados.Count() - 1)
                    comando = comando + dados[i];
                else
                    comando = comando + dados[i] + ", ";
            }

            if (string.IsNullOrEmpty(criteria))
                comando = comando + " FROM " + tabela;
            else
                comando = comando + " FROM " + tabela + " WHERE " + criteria;
            return comando;
        }

        public static string Insert(T entidade)
        {
            int lim = 0;
            int pchave = 0;
            int indice = 0;
            string tabela = string.Empty;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);

            comando = "INSERT INTO " + tabela + " (";
            chave = RetornaChave("_restricao", entidade);
            carregarAttributos(entidade);

            lim = qtd - 1;

            for (int i = 0; i < qtd; i++)
            {
                if (lista[i] == chave)
                {
                    pchave = i;
                    break;
                }
            }

            for (int i = 0; i < qtd; i++)
            {
                if (pchave != lim)
                {
                    if (i != pchave)
                    {
                        if (i == 0)
                            parte1 = lista[i].ToString() + ",";
                        else if (i == lim)
                            parte1 = parte1 + lista[i].ToString();
                        else
                            parte1 = parte1 + lista[i].ToString() + ",";
                    }
                }
                else
                {
                    if (i != pchave)
                    {
                        if (i == 0)
                            parte1 = lista[i].ToString() + ",";
                        else if (i == lim - 1)
                            parte1 = parte1 + lista[i].ToString();
                        else
                            parte1 = parte1 + lista[i].ToString() + ",";
                    }
                }
            }

            comando = comando + parte1 + ") VALUES (";

            Type tipoentidade = typeof(T);
            PropertyInfo[] propriedades = tipoentidade.GetProperties();
            object valor = null;

            foreach (PropertyInfo propriedade in propriedades)
            {
                valor = propriedade.GetValue(entidade, null);
                if ((valor == null) || (valor.ToString() == "\0"))
                {
                    if (indice == lim)
                        parte2 = parte2 + "null";
                    else
                        parte2 = parte2 + "null,";
                    indice += 1;
                }
                else
                {
                    if (pchave != indice)
                    {
                        if (valor.GetType().ToString() == "System.Boolean")
                            parte2 = (bool)valor == true ? parte2 + 0 : parte2 + 1;
                        else if (valor.GetType().ToString() == "System.String")
                            parte2 = parte2 + act + valor + act;
                        else if ((valor.GetType().ToString() == "System.Byte") || (valor.GetType().ToString() == "System.SByte"))
                            parte2 = parte2 + valor.ToString();
                        else if (valor.GetType().ToString() == "System.Char")
                            parte2 = parte2 + act + valor + act;
                        else if (valor.GetType().ToString() == "System.DateTime")
                        {
                            if (valor == null)
                                parte2 += "NULL";
                            else if (valor.ToString() != "01/01/0001 00:00:00")
                                parte2 = parte2 + act + cData(valor.ToString()) + act;
                            else
                                parte2 = parte2 + act + cData(DateTime.Now.Date.ToString()) + act;
                        }
                        else if (valor.GetType().ToString() == "System.Decimal")
                            parte2 = parte2 + cPonto(valor.ToString());
                        else if ((valor.GetType().ToString() == "System.Double") || (valor.GetType().ToString() == "System.Single"))
                            parte2 = parte2 + cPonto(valor.ToString());
                        else if (valor.GetType().ToString() == "System.Int")
                            parte2 = parte2 + valor;
                        else if (valor.GetType().ToString() == "System.Int32")
                            parte2 = parte2 + valor;
                        else if (valor.GetType().ToString() == "System.UInt32")
                            parte2 = parte2 + valor;
                        else if (valor.GetType().ToString() == "System.UInt64")
                            parte2 = parte2 + valor;
                        else if (valor.GetType().ToString() == "System.Int16")
                            parte2 = parte2 + valor;
                        else if (valor.GetType().ToString() == "System.UInt16")
                            parte2 = parte2 + valor;
                    }

                    if (pchave != lim)
                    {
                        if (indice != pchave)
                        {
                            if (indice == 0)
                                parte2 = parte2 + ",";
                            else if (indice == lim)
                                parte2 = parte2 + "";
                            else
                                parte2 = parte2 + ",";
                        }
                    }
                    else
                    {
                        if (indice != pchave)
                        {
                            if (indice == 0)
                                parte2 = parte2 + ",";
                            else if (indice == lim - 1)
                                parte2 = parte2 + "";
                            else
                                parte2 = parte2 + ",";
                        }
                    }
                    indice += 1;
                }
            }
            comando = comando + parte2 + ")";

            return comando;
        }

        public static string Update(T entidade, string criteria = "")
        {
            int limite = 0;
            int parametroChave = 0;
            int indice = 0;

            string tabela = string.Empty;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);
            chave = RetornaChave("_restricao", entidade);
            comando = "UPDATE " + tabela + " SET ";
            carregarAttributos(entidade);
            limite = qtd - 1;

            for (int i = 0; i < qtd; i++)
            {
                if (lista[i] == chave)
                {
                    parametroChave = i;
                    break;
                }
            }

            Type tipoentidade = typeof(T);
            PropertyInfo[] propriedades = tipoentidade.GetProperties();
            object valor = null;
            string nome = "";

            foreach (PropertyInfo propriedade in propriedades)
            {
                valor = propriedade.GetValue(entidade, null);
                nome = lista[indice];
                if ((valor == null) || (valor.ToString() == "\0"))
                {
                    if (indice != limite)
                        parte1 += nome + " = null,";
                    else
                        parte1 += nome + " = null";
                    indice += 1;
                }
                else
                {
                    if (parametroChave != indice)
                    {
                        if (valor.GetType().ToString() == "System.Boolean")
                            parte1 = ((bool)valor == true) ? parte1 + nome + " = " + 0 : parte1 + nome + " = " + 1;
                        else if (valor.GetType().ToString() == "System.String")
                            parte1 = parte1 + nome + " = " + act + valor + act;
                        else if ((valor.GetType().ToString() == "System.Byte") || (valor.GetType().ToString() == "System.SByte"))
                            parte1 = parte1 + nome + " = " + valor;
                        else if (valor.GetType().ToString() == "System.Char")
                            parte1 = parte1 + nome + " = " + act + valor + act;
                        else if (valor.GetType().ToString() == "System.DateTime")
                        {
                            if (valor.ToString() != "01/01/0001 00:00:00")
                                parte1 = parte1 + nome + " = " + act + cData(valor.ToString()) + act;
                            else
                                parte1 = parte1 + nome + " = " + act + cData(DateTime.Now.Date.ToString()) + act;
                        }
                        else if (valor.GetType().ToString() == "System.Decimal")
                            parte1 = parte1 + nome + " = " + cPonto(valor.ToString());
                        else if ((valor.GetType().ToString() == "System.Double") || (valor.GetType().ToString() == "System.Single"))
                            parte1 = parte1 + nome + " = " + cPonto(valor.ToString());
                        else if (valor.GetType().ToString() == "System.Int")
                            parte1 = parte1 + nome + " = " + valor;
                        else if (valor.GetType().ToString() == "System.Int32")
                            parte1 = parte1 + nome + " = " + valor;
                        else if (valor.GetType().ToString() == "System.UInt32")
                            parte1 = parte1 + nome + " = " + valor;
                        else if (valor.GetType().ToString() == "System.UInt64")
                            parte1 = parte1 + nome + " = " + valor;
                        else if (valor.GetType().ToString() == "System.Int16")
                            parte1 = parte1 + nome + " = " + valor;
                        else if (valor.GetType().ToString() == "System.UInt16")
                            parte1 = parte1 + nome + " = " + valor;
                    }

                    if (parametroChave != limite)
                    {
                        if (indice != parametroChave)
                        {
                            if (indice == 0)
                                parte1 = parte1 + ",";
                            else if (indice == limite)
                                parte1 = parte1 + "";
                            else
                                parte1 = parte1 + ",";
                        }
                    }
                    else
                    {
                        if (indice != parametroChave)
                        {
                            if (indice == 0)
                                parte1 = parte1 + ",";
                            else if (indice == limite - 1)
                                parte1 = parte1 + "";
                            else
                                parte1 = parte1 + ",";
                        }
                    }
                    indice += 1;
                }
            }
            if (string.IsNullOrEmpty(criteria))
                comando = comando + parte1;
            else
                comando = comando + parte1 + " WHERE " + criteria;

            return comando;
        }

        public static string UpdateList(T entidade, Dictionary<string, object> dados, string criteria = "")
        {
            string tabela = string.Empty;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);
            comando = "UPDATE " + tabela + " SET ";
            string chave;
            object valor;
            for (int indice = 0; indice < dados.Count; indice++)
            {
                chave = dados.ElementAt(indice).Key;
                valor = dados.ElementAt(indice).Value;

                if (dados.ElementAt(indice).Value.GetType().ToString() == "System.DateTime")
                    valor = cData(dados.ElementAt(indice).Value.ToString());
                else if ((dados.ElementAt(indice).Value.GetType().ToString() == "System.Decimal") || (dados.ElementAt(indice).Value.GetType().ToString() == "System.Double") || (dados.ElementAt(indice).Value.GetType().ToString() == "System.Single"))
                    valor = cPonto(dados.ElementAt(indice).Value.ToString());
                else if ((dados.ElementAt(indice).Value.GetType().ToString() == "System.String") || (dados.ElementAt(indice).Value.GetType().ToString() == "System.Char"))
                    if ((valor.ToString() == "EntityNull") || (valor.ToString() == ""))
                        valor = "null";
                    else
                        valor = act + dados.ElementAt(indice).Value.ToString() + act;
                else if (dados.ElementAt(indice).Value.GetType().ToString() == "System.Boolean")
                    valor = (bool)valor == true ? 0 : 1;

                if (dados.Count == 1)
                    comando = comando + chave + " = " + valor;
                else
                {
                    if (indice == 0)
                        comando = comando + chave + " = " + valor + ", ";
                    else if (indice == dados.Count - 1)
                        comando = comando + chave + " = " + valor;
                    else
                        comando = comando + chave + " = " + valor + ", ";
                }
            }

            if (!string.IsNullOrEmpty(criteria))
                comando = comando + " WHERE " + criteria;

            return comando;
        }

        public static string Count(T entidade, string criteria = "")
        {
            comando = string.Empty;
            string tabela = string.Empty;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);

            if (string.IsNullOrEmpty(criteria))
                comando = string.Format("SELECT COUNT(*) FROM {0}", tabela);
            else
                comando = string.Format("SELECT COUNT(*) FROM {0} WHERE {1}", tabela, criteria);
            return comando;
        }

        public static string Delete(T entidade, string criteria)
        {
            string tabela = string.Empty;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);
            comando = String.Format("DELETE {0} WHERE {1}", tabela, criteria);
            return comando;
        }

        public static bool Busca(T entidade, string campo, string criteria = "")
        {
            string tabela = string.Empty;
            Int32 retorno = -1;
            bool resposta = false;

            defaultVariaveis();
            tabela = RetornaChave("_tabela", entidade);
            comando = String.Format("SELECT COUNT({0}) FROM {1} WHERE {2}", campo, tabela, criteria);

            try
            {
                retorno = DB.ExecutaScalar(comando);
                if (retorno == 0)
                    resposta = false;
                else
                    resposta = true;
            }
            catch (Exception)
            {
                resposta = false;
            }
            return resposta;
        }

        public static int Max(string tabela, string campo, string criteria = "")
        {
            string comando = string.Empty;
            int retorno = -1;
            //defaultVariaveis();
            if (string.IsNullOrEmpty(criteria))
                comando = string.Format("SELECT Max({0}) FROM {1}", campo, tabela);
            else
                comando = string.Format("SELECT Max({0}) FROM {1} WHERE {2}", campo, tabela, criteria);

            try
            {
                retorno = DB.ExecutaScalar(comando);
            }
            catch (Exception)
            {
                retorno = -1;
            }
            return retorno;
        }

        public static int Max(T entidade, string campo = "", string criteria = "")
        {
            int retorno = -1;
            string restricao = RetornaChave("_restricao", entidade);
            string tabela = RetornaChave("_tabela", entidade);

            if ((String.IsNullOrEmpty(campo)) && (String.IsNullOrEmpty(criteria)))
                comando = String.Format("SELECT MAX({0}) FROM {1}", restricao, tabela);
            else if (String.IsNullOrEmpty(criteria))
                comando = String.Format("SELECT MAX({0}) FROM {1}", campo, tabela);
            else
                comando = String.Format("SELECT MAX({0}) FROM {1} WHERE {2}", restricao, tabela, criteria);

            try
            {
                retorno = DB.ExecutaScalar(comando);
            }
            catch (Exception)
            {
                retorno = -1;
            }
            return retorno;
        }

        public static bool TabelaVazia(T entidade)
        {
            bool retorno = false;
            int qtd = 0;
            string tabela = RetornaChave("_tabela", entidade);
            comando = String.Format("SELECT COUNT(*) FROM {0}", tabela);
            try
            {
                qtd = DB.ExecutaScalar(comando);
                if (qtd == 0)
                    retorno = true;
                else
                    retorno = false;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        public static int Guid(T entidade)
        {
            int retorno = -1;
            string restricao = RetornaChave("_restricao", entidade);
            string tabela = RetornaChave("_tabela", entidade);

            if (!TabelaVazia(entidade))
            {
                comando = "SELECT MAX(" + restricao + ") FROM " + tabela;
                try
                {
                    retorno = ODB.DataBase.DB.ExecutaScalar(comando);
                    retorno = retorno + 1;
                }
                catch (Exception)
                {
                    retorno = -1;
                }
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }

        #endregion


    }
}