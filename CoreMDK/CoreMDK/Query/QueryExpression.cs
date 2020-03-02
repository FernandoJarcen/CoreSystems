using CoreSDK.Enums;
using CoreSDK.ODB.DataBase;
using CoreSDK.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoreMDK.Query
{
    public class QueryExpression
    {
        private List<string> colunas = new List<string>();
        private List<Condition> condicoes = new List<Condition>();
        private List<Join> joins = new List<Join>();
        private List<Union> unario = new List<Union>();
        private List<Order> ordenacoes = new List<Order>();

        string tabelaPrincipal = string.Empty;
        string aliasPrincipal = string.Empty;

        public QueryExpression(string tabela, string alias = "")
        {
            tabelaPrincipal = tabela;
            if (!String.IsNullOrEmpty(alias))
                aliasPrincipal = alias;
        }

        #region metodos construtores

        public void AddColumns(string coluna)
        {
            colunas.Add(coluna);
        }

        public void AddColumns(string[] coluna)
        {
            for (int i = 0; i < coluna.Count(); i++)
            {
                colunas.Add(coluna[i]);
            }
        }

        public void AddCondicao(Condition condicao)
        {
            condicoes.Add(condicao);
        }

        public void AddCondicoes(List<Condition> p_condicoes)
        {
            foreach (var item in p_condicoes)
            {
                condicoes.Add(item);
            }
        }

        public void AddCondicoes(List<Condition> p_condicoes, List<Union> p_unario)
        {
            foreach (var item in p_condicoes)
            {
                condicoes.Add(item);
            }

            foreach (var item in p_unario)
            {
                unario.Add(item);
            }
        }

        public void AddJoin(Join join)
        {
            joins.Add(join);
        }

        public void AddJoin(List<Join> p_joins)
        {
            foreach (var item in p_joins)
            {
                joins.Add(item);
            }
        }

        public void AddOrderBy(string campo, Operadores.OrderByOperator orderBy = Operadores.OrderByOperator.Nenhum)
        {
            if (orderBy == Operadores.OrderByOperator.Nenhum)
                ordenacoes.Add(new Order(campo));
            else
                ordenacoes.Add(new Order(campo, orderBy));
        }

        public void AddOrderBy(List<Order> p_ordenacoes)
        {
            foreach (var item in p_ordenacoes)
            {
                ordenacoes.Add(item);
            }
        }

        #endregion

        #region metodos

        private string montarOrdenacoes()
        {
            string retorno = string.Empty;

            for (int indice = 0; indice < ordenacoes.Count; indice++)
            {
                if (ordenacoes[indice].OrderBy != Operadores.OrderByOperator.Nenhum)
                {
                    if (indice == 0)
                        retorno += " ORDER BY " + ordenacoes[indice].Campo + " " + Ordenador(ordenacoes[indice].OrderBy);
                    else
                        retorno += " , " + ordenacoes[indice].Campo + " " + Ordenador(ordenacoes[indice].OrderBy);
                }
                else
                {
                    if (indice == 0)
                        retorno += " ORDER BY " + ordenacoes[indice].Campo;
                    else
                        retorno += " , " + ordenacoes[indice].Campo;
                }
            }
            return retorno;
        }

        private string montarWhere()
        {
            string retorno = string.Empty;

            retorno += " WHERE ";
            for (int indice = 0; indice < condicoes.Count; indice++)
            {
                var valor1 = condicoes[indice].Valor1;
                var valor2 = condicoes[indice].Valor2;

                if ((valor1 == null) && (valor2 == null))
                    retorno += condicoes[indice].Nome + " IS NULL ";
                else
                {
                    if (condicoes[indice].Valor2 != null)
                        if (valor1.GetType().Name == "String")
                            retorno += condicoes[indice].Nome + Operador(condicoes[indice].Operador) + "'" + condicoes[indice].Valor1 + "' and '" + condicoes[indice].Valor2 + "'";
                        else if (valor1.GetType().Name == "DateTime")
                            retorno += condicoes[indice].Nome + Operador(condicoes[indice].Operador) + "'" + condicoes[indice].Valor1.ToString().ToInput() + "' and '" + condicoes[indice].Valor2.ToString().ToInput() + "'";
                        else
                            retorno += condicoes[indice].Nome + Operador(condicoes[indice].Operador) + condicoes[indice].Valor1 + " and " + condicoes[indice].Valor2;
                    else
                        if (valor1.GetType().Name == "String")
                            retorno += condicoes[indice].Nome + Operador(condicoes[indice].Operador) + "'" + condicoes[indice].Valor1 + "'";
                        else if (valor1.GetType().Name == "DateTime")
                            retorno += condicoes[indice].Nome + Operador(condicoes[indice].Operador) + "'" + condicoes[indice].Valor1.ToString().ToInput() + "'";
                        else
                            retorno += condicoes[indice].Nome + Operador(condicoes[indice].Operador) + condicoes[indice].Valor1;
                }

                if (unario.Count > 0)
                {
                    if (indice < unario.Count)
                        retorno += " " + Unario(unario[indice].Unario);
                }
            }
            return retorno;
        }

        private string montarJoins()
        {
            string retorno = string.Empty;
            if (joins.Count > 0)
            {
                for (int indice = 0; indice < joins.Count; indice++)
                {
                    retorno += " JOIN ";
                    retorno += joins[indice].Tabela1 + " " + joins[indice].Alias1;
                    retorno += " ON " + joins[indice].Alias1 + "." + joins[indice].Chave + " = ";
                    if (joins[indice].Alias1 == "")
                        retorno += aliasPrincipal + "." + joins[indice].Chave;
                    else
                        if (indice == 0)
                            retorno += aliasPrincipal + "." + joins[indice].Chave;
                        else
                            retorno += joins[indice - 1].Alias1 + "." + joins[indice].Chave;
                }
            }
            return retorno;
        }

        private string montarSelect()
        {
            string retorno = string.Empty;

            retorno = "SELECT ";
            for (int indice = 0; indice < colunas.Count; indice++)
            {
                if (indice < colunas.Count - 1)
                    retorno += colunas[indice] + ", ";
                else
                    retorno += colunas[indice];
            }

            retorno += " FROM ";
            if (!string.IsNullOrEmpty(aliasPrincipal))
                retorno += tabelaPrincipal + " " + aliasPrincipal;
            else
                retorno += tabelaPrincipal;
            return retorno;
        }

        #endregion

        public DataTable Execute()       
        {
            string comando = string.Empty;
            DataTable operacao;
            DataTable retorno;
            try
            {
                comando += montarSelect();
                comando += montarJoins();

                if (condicoes.Count > 0)                
                    comando += montarWhere();                

                if (ordenacoes.Count > 0)                
                    comando += montarOrdenacoes();                

                operacao = DB.ExecutaReader(comando);
                if (operacao != null)
                    retorno = operacao;
                else
                    retorno = null;

            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }

        #region metodos operacionais

        private string Operador(Operadores.ConditionOperator conditionOperator)
        {
            string retorno = string.Empty;
            switch (conditionOperator)
            {
                case Operadores.ConditionOperator.Igual: retorno = " = ";
                    break;
                case Operadores.ConditionOperator.Diferente: retorno = " <> ";
                    break;
                case Operadores.ConditionOperator.Maior: retorno = " > ";
                    break;
                case Operadores.ConditionOperator.MaiorIgual: retorno = " >= ";
                    break;
                case Operadores.ConditionOperator.Menor: retorno = " < ";
                    break;
                case Operadores.ConditionOperator.MenorIgual: retorno = " <= ";
                    break;
                case Operadores.ConditionOperator.Entre: retorno = " BETWEEN ";
                    break;
                default: retorno = " = ";
                    break;
            }
            return retorno;
        }

        private string Unario(Operadores.QueryOperator p_unario)
        {
            string retorno = string.Empty;

            switch (p_unario)
            {
                case Operadores.QueryOperator.E: retorno = " AND "; break;
                case Operadores.QueryOperator.Ou: retorno = " OR "; break;
                case Operadores.QueryOperator.Not: retorno = " NOT "; break;
                case Operadores.QueryOperator.NotIn: retorno = " NOT IN "; break;
                case Operadores.QueryOperator.IN: retorno = " IN "; break;
                default: retorno = " AND "; break;
            }
            return retorno;
        }

        private string Ordenador(Operadores.OrderByOperator ordenadorOperator)
        {
            string retorno = string.Empty;
            switch (ordenadorOperator)
            {
                case Operadores.OrderByOperator.Nenhum: retorno = ""; break;
                case Operadores.OrderByOperator.Ascendente: retorno = "ASC"; break;
                case Operadores.OrderByOperator.Descendente: retorno = "DESC"; break;
            }
            return retorno;
        }

        #endregion
    }
}
