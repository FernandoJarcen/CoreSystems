using System;
using System.Collections.Generic;
using System.Data;
using CoreMDK.Query;
using CoreSDK.Utils;
using CoreSDK.Enums;

namespace CoreKonnector.Entidades
{
    public class UnidadeNegocio
    {
        public static DataTable dtDados = new DataTable();

        public static DataTable consulta(List<string> equipe)
        {
            DataTable retorno = default(DataTable);

            QueryExpression q = new QueryExpression("UnidadeNegocio", "uni");
            string[] campos = new string[] { "uni.UnidadeNegocioID", "uni.UnidadeRelacionadaID", "uni.Descricao", "uni.TipoUnidade" };
            Join j1 = new Join("EquipeUnidade", "eqp", "UnidadeNegocioID");
            List<Condition> c1 = new List<Condition>(){
                new Condition("uni.DataEncerramento", Operadores.ConditionOperator.MaiorIgual, DateTime.Now.ToShortDateString().ToInput()),
                new Condition("uni.DataEncerramento", Operadores.ConditionOperator.ENulo),
                new Condition("uni.Status", Operadores.ConditionOperator.Igual, "A"),
                new Condition("eqp.EquipeID", Operadores.ConditionOperator.Igual, Convert.ToInt32(equipe[0].ToString()))
                };
            List<Union> u1 = new List<Union>()
                {
                    new Union(Operadores.QueryOperator.Ou),
                    new Union(Operadores.QueryOperator.E),
                    new Union(Operadores.QueryOperator.E)
                };
            q.AddColumns(campos);
            q.AddJoin(j1);

            q.AddCondicoes(c1, u1);
            retorno = q.Execute();
            return retorno;
        }

        public static DataTable consultaMapa()
        {
            DataTable retorno = default(DataTable);

            QueryExpression q = new QueryExpression("UnidadeNegocio", "uni");
            string[] campos = new string[] { "uni.UnidadeNegocioID", "uni.UnidadeRelacionadaID", "uni.Descricao", "uni.TipoUnidade" };
            List<Condition> c1 = new List<Condition>(){
                new Condition("uni.DataEncerramento", Operadores.ConditionOperator.MaiorIgual, DateTime.Now.ToShortDateString().ToInput()),
                new Condition("uni.DataEncerramento", Operadores.ConditionOperator.ENulo),
                new Condition("uni.Status", Operadores.ConditionOperator.Igual, "A")
                };

            List<Union> u1 = new List<Union>()
                {
                    new Union(Operadores.QueryOperator.Ou),
                    new Union(Operadores.QueryOperator.E)
                };

            q.AddColumns(campos);
            q.AddCondicoes(c1, u1);
            retorno = q.Execute();
            return retorno;
        }

        public static List<Consolidadora> ConsolidadoraMapa()
        {
            List<Consolidadora> lista = new List<Consolidadora>() { };

            dtDados = null;
            dtDados = consultaMapa();
            DataView dvDados = dtDados.DefaultView;
            EnumerableRowCollection<DataRow> query = from o in dtDados.AsEnumerable()
                                                     where o.Field<string>("TipoUnidade") == "C"
                                                     select o;
            dvDados = query.AsDataView();

            for (int indice = 0; indice < dvDados.Count; indice++)
            {
                int codigo = Convert.ToInt32(dvDados[indice].Row.ItemArray[0].ToString());
                string consolidadora = dvDados[indice].Row.ItemArray[2].ToString();
                lista.Add(new Consolidadora(codigo, consolidadora));
            }

            return lista;
        }

        public static List<Consolidadora> ConsolidadoraAtiva()
        {
            List<Consolidadora> lista = new List<Consolidadora>() { };

            dtDados = null;
            dtDados = consulta(Util.Equipe);
            DataView dvDados = dtDados.DefaultView;
            EnumerableRowCollection<DataRow> query = from o in dtDados.AsEnumerable()
                                                     where o.Field<string>("TipoUnidade") == "C"
                                                     select o;
            dvDados = query.AsDataView();

            for (int indice = 0; indice < dvDados.Count; indice++)
            {
                int codigo = Convert.ToInt32(dvDados[indice].Row.ItemArray[0].ToString());
                string consolidadora = dvDados[indice].Row.ItemArray[2].ToString();
                lista.Add(new Consolidadora(codigo, consolidadora));
            }

            return lista;
        }

        public static List<Negocio> NegociosAtivos()
        {
            List<Negocio> lista2 = new List<Negocio>() { };
            DataView dvDados = dtDados.DefaultView;
            EnumerableRowCollection<DataRow> query = from o in dtDados.AsEnumerable()
                                                     where o.Field<string>("TipoUnidade") == "N"
                                                     select o;
            dvDados = query.AsDataView();

            for (int indice = 0; indice < dvDados.Count; indice++)
            {
                int codigo = Convert.ToInt32(dvDados[indice].Row.ItemArray[0].ToString());
                int relacionada = Convert.ToInt32(dvDados[indice].Row.ItemArray[1].ToString());
                string consolidadora = dvDados[indice].Row.ItemArray[2].ToString();
                lista2.Add(new Negocio(relacionada, codigo, consolidadora));
            }
            return lista2;
        }

        public static List<Filial> FiliaisAtivas()
        {
            List<Filial> lista3 = new List<Filial>() { };
            DataView dvDados = dtDados.DefaultView;
            EnumerableRowCollection<DataRow> query = from o in dtDados.AsEnumerable()
                                                     where o.Field<string>("TipoUnidade") == "F"
                                                     select o;
            dvDados = query.AsDataView();

            for (int indice = 0; indice < dvDados.Count; indice++)
            {
                int codigo = Convert.ToInt32(dvDados[indice].Row.ItemArray[0].ToString());
                int relacionada = Convert.ToInt32(dvDados[indice].Row.ItemArray[1].ToString());
                string consolidadora = dvDados[indice].Row.ItemArray[2].ToString();
                lista3.Add(new Filial(relacionada, codigo, consolidadora));
            }
            return lista3;
        }

    }
}
