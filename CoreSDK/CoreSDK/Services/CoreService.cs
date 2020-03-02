using System.Collections.Generic;
using System.Linq;
using CoreSDK.ODB.DataBase;
using System.Reflection;
using System.Data;
using System.Windows.Forms;
using CoreSDK.Objetos;
using System;
using System.Data.Sql;

namespace CoreSDK.Services
{
    [Descricao("Classe de transformação e propriedades", "30/07/2019")]
    public static class CoreService<T> where T : class,new()
    {
        public enum Parametro
        {
            Nenhum,
            ClassePropriedade
        }

        public static object[] ArrayPropriedades(Parametro parametro)
        {
            var entidade = new T();
            var propriedades = entidade.GetType().GetProperties();
            int indice = 0;
            string nomeEntidade = entidade.GetType().Name;
            var retorno = new object[QtdPropriedades()];

            foreach (PropertyInfo prop in propriedades)
            {
                var valor = prop.GetValue(entidade, null);
                if (parametro == Parametro.Nenhum)
                    retorno[indice] = prop.Name.ToString();
                else if (parametro == Parametro.ClassePropriedade)
                    retorno[indice] = nomeEntidade + "." + prop.Name.ToString();
                indice += 1;
            }

            return retorno;
        }

        public static int QtdPropriedades()
        {
            var entidade = new T();
            var propriedades = entidade.GetType().GetProperties();
            return propriedades.Count();
        }

        public static int QtdMetodos()
        {
            var entidade = new T();
            var metodos = entidade.GetType().GetMethods();
            return metodos.Count();
        }

        public static int QtdCampos()
        {
            var entidade = new T();
            var campos = entidade.GetType().GetFields();
            return campos.Count();
        }

        public static Dictionary<string, object> ClassToDictionary(T entidade)
        {
            Dictionary<string, object> retorno = new Dictionary<string, object>();
            var p = entidade.GetType().GetProperties();
            var chave = string.Empty;

            chave = Fabrica<T>.RetornaChave("_restricao", entidade);
            foreach (PropertyInfo pop in p)
            {
                if (pop.Name != chave)
                {
                    var valor = pop.GetValue(entidade, null);
                    if (valor == null)
                        retorno.Add(pop.Name.ToString(), string.Empty);
                    else
                        retorno.Add(pop.Name.ToString(), valor);
                }
            }

            return retorno;
        }

        public static Dictionary<string, object> ClassToDictionary(T entidade, List<string> mapa)
        {
            Dictionary<string, object> retorno = new Dictionary<string, object>();

            var prop = getProperties(entidade, mapa);

            foreach (PropertyInfo pop in prop)
            {
                var valor = pop.GetValue(entidade, null);
                if (valor == null)
                    retorno.Add(pop.Name.ToString(), string.Empty);
                else
                    retorno.Add(pop.Name.ToString(), valor);
            }

            return retorno;
        }

        public static List<string> DictionaryToList(ICollection<string> dados)
        {
            List<string> retorno = new List<string>();
            foreach (string item in dados)
            {
                retorno.Add(item);
            }
            return retorno;
        }

        public static List<object> DictionaryToList(ICollection<object> dados)
        {
            List<object> retorno = new List<object>();
            foreach (string item in dados)
            {
                retorno.Add(item);
            }
            return retorno;
        }

        private static PropertyInfo[] getProperties(T entidade, List<string> mapa)
        {
            List<string> allowed = mapa;
            PropertyInfo[] retorno = new PropertyInfo[mapa.Count];
            var p = entidade.GetType().GetProperties();

            for (int linha = 0; linha < mapa.Count; linha++)
            {
                for (int item = 0; item < p.Count(); item++)
                {
                    if (p[item].Name == allowed[linha])
                    {
                        retorno[linha] = p[item];
                        //indice += 1;
                        break;
                    }
                }
            }
            return retorno;
        }

    }

    public static class CoreService
    {
        public static DataTable GridToDataTable(DataGridView grid)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn coluna in grid.Columns)
            {
                if (coluna.Visible)
                {
                    Type tipo = coluna.ValueType;

                    if (tipo == null)
                        tipo = typeof(String);

                    dt.Columns.Add(coluna.HeaderText, tipo);
                }
            }
            var cell = new object[grid.Columns.Count];
            foreach (DataGridViewRow dataGridViewRow in grid.Rows)
            {
                for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                {
                    cell[i] = dataGridViewRow.Cells[i].Value;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }

        public static DataTable GridToDataTable(DataGridView grid, bool checkGrid)
        {
            DataTable DtExport = new DataTable();

            if (grid.Rows.Count > 0)
            {
                for (int indice = 0; indice < grid.Columns.Count; indice++)
                {
                    DataColumn dtColuna;
                    dtColuna = new DataColumn();
                    string tipo = "System." + grid.Rows[0].Cells[indice].ValueType.Name.ToString();

                    dtColuna.DataType = Type.GetType(tipo);
                    if (checkGrid)
                    {
                        if (indice == 0)
                            dtColuna.ColumnName = "chk";
                        else
                            dtColuna.ColumnName = grid.Columns[indice].HeaderText;
                    }
                    else
                        dtColuna.ColumnName = grid.Columns[indice].HeaderText;
                    DtExport.Columns.Add(dtColuna);
                }

                foreach (DataGridViewRow dataGridViewRow in grid.Rows)
                {
                    DataRow linha;
                    int inicioIndice = -1;
                    linha = DtExport.NewRow();
                    if (!checkGrid)
                        inicioIndice = 0;
                    else
                        inicioIndice = 1;

                    for (int indice2 = inicioIndice; indice2 < grid.Columns.Count; indice2++)
                    {
                        string nome = grid.Columns[indice2].HeaderText;
                        object valor = dataGridViewRow.Cells[nome].Value;
                        string tipo = grid.Rows[0].Cells[indice2].ValueType.Name;

                        if (valor.ToString() == "")
                        {
                            if ((tipo == "Int16") || (tipo == "Int32") || (tipo == "Decimal"))
                                linha[nome] = 0;
                            else if (tipo == "DateTime")
                                linha[nome] = DBNull.Value;
                            else
                                linha[nome] = "";
                        }
                        else if (tipo == "Int16")
                            linha[nome] = Convert.ToInt16(valor);
                        else if (tipo == "Int32")
                            linha[nome] = Convert.ToInt32(valor);
                        else if (tipo == "String")
                            linha[nome] = valor.ToString();
                        else if (tipo == "Decimal")
                            linha[nome] = Convert.ToDecimal(valor);
                        else if (tipo == "DateTime")
                            linha[nome] = Convert.ToDateTime(valor);
                        else if (tipo == "Boolean")
                            linha[nome] = Convert.ToBoolean(valor);
                    }
                    DtExport.Rows.Add(linha);
                }
            }
            return DtExport;

        }

        public static void ExecutarPropriedade(object objeto, string nomePropriedade, object valor)
        {
            Type type = objeto.GetType();
            var instance = objeto;

            PropertyInfo prop = type.GetProperty(nomePropriedade);
            if (prop != null)
            {
                if (prop.PropertyType.Name == "Int32")
                    prop.SetValue(instance, Convert.ToInt32(valor, null));
                else
                    prop.SetValue(instance, valor, null);
            }
        }

        public static object RetornarPropriedade(object objeto, string nomePropriedade)
        {
            object retorno = null;
            try
            {
                var valor = objeto.GetType().GetProperty(nomePropriedade).GetValue(objeto, null);
                if (valor == null)
                    retorno = string.Empty;
                else
                    retorno = valor;
            }
            catch (Exception)
            {
                retorno = string.Empty;
            }
            return retorno;
        }

        public static class Listas
        {
            public static string RetornaValor(Dictionary<string, object> objeto, string chave)
            {
                string retorno = string.Empty;

                if ((objeto.Count > 0) && (!String.IsNullOrEmpty(chave)))
                {
                    foreach (KeyValuePair<string, object> pair in objeto)
                    {
                        string busca = pair.Key;
                        if (busca == chave)
                        {
                            retorno = pair.Value.ToString();
                            break;
                        }
                    }
                }
                else
                    retorno = string.Empty;
                return retorno;
            }
        }

        public static DataTable InstanciaServidor()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
    }
}
