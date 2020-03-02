using CoreSDK.Utils;
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using excel = Microsoft.Office.Interop.Excel;

namespace CoreSDK.Specific
{
    public static class Exportador
    {
        public static class Excel
        {
            static string caminhoPadrao = Xml.BuscaTAG("padrao");
            static string arquivo = string.Empty;
            public static String[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                                          "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

            private static bool verificaPasta()
            {
                bool retorno = true;
                string caminhoPadrao = string.Empty;
                caminhoPadrao = Xml.BuscaTAG("exportador");

                if (Directory.Exists(caminhoPadrao))
                    retorno = true;
                return retorno;
            }

            public static string geraExcel(string nomeArquivo, System.Data.DataTable dtDados, string titulo)
            {
                string retorno = string.Empty;
                if (verificaPasta())
                {
                    arquivo = caminhoPadrao + nomeArquivo + ".xls";

                    object missing = Missing.Value;
                    excel.Application app = new excel.Application();
                    excel.Workbook wbk = app.Workbooks.Add(missing);

                    try
                    {
                        gerarLinhas(dtDados, titulo, app, wbk);

                        wbk.SaveAs(arquivo,
                        excel.XlFileFormat.xlWorkbookNormal, missing, missing, missing, missing,
                        excel.XlSaveAsAccessMode.xlShared, missing, missing,
                        missing, missing, missing);
                        retorno = "Gerado com sucesso!";
                    }
                    catch (Exception exc)
                    {
                        retorno = exc.Message;
                    }
                    finally
                    {
                        app.Quit();
                        Marshal.ReleaseComObject(app);
                    }
                }
                else
                    retorno = "Diretorio não existe, verifique!";
                return retorno;
            }

            public static string geraExcel(string caminho, string nomeArquivo, System.Data.DataTable dtDados, string titulo)
            {
                string retorno = string.Empty;
                try
                {
                    arquivo = caminho + "\\" + nomeArquivo + ".xls";

                    object missing = Missing.Value;
                    excel.Application app = new excel.Application();
                    excel.Workbook wbk = app.Workbooks.Add(missing);

                    try
                    {
                        gerarLinhas(dtDados, titulo, app, wbk);

                        wbk.SaveAs(arquivo,
                        excel.XlFileFormat.xlWorkbookNormal, missing, missing, missing, missing,
                        excel.XlSaveAsAccessMode.xlShared, missing, missing,
                        missing, missing, missing);
                        retorno = "Gerado com sucesso!";
                    }
                    catch (Exception exc)
                    {
                        retorno = exc.Message;
                    }
                    finally
                    {
                        app.Quit();
                        Marshal.ReleaseComObject(app);
                    }
                }
                catch (Exception ex)
                {
                    retorno = ex.Message;
                }
                return retorno;
            }

            public static string geraExcelNovo(string nomeArquivo, System.Data.DataTable dtDados, string titulo)
            {
                string retorno = string.Empty;

                if (verificaPasta())
                {
                    arquivo = caminhoPadrao + nomeArquivo + ".xlsx";

                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wbk = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Worksheet ws = (Worksheet)wbk.Worksheets.get_Item(1);

                    ws.Name = "Relatorio";
                    try
                    {
                        gerarLinhas(dtDados, titulo, app, wbk);

                        wbk.SaveAs(arquivo, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        app.Quit();

                        retorno = "Gerado com sucesso!";
                    }
                    catch (Exception exc)
                    {
                        retorno = exc.Message;
                    }
                }
                else
                    retorno = "Diretorio não existe, verifique!";
                return retorno;
            }

            public static string geraExcelNovo(string caminho, string nomeArquivo, System.Data.DataTable dtDados, string titulo)
            {
                string retorno = string.Empty;
                try
                {
                    arquivo = caminho + "\\" + nomeArquivo + ".xlsx";

                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wbk = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Worksheet ws = (Worksheet)wbk.Worksheets.get_Item(1);

                    ws.Name = "Relatorio";
                    try
                    {
                        gerarLinhas(dtDados, titulo, app, wbk);
                        wbk.SaveAs(arquivo, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        app.Quit();
                        retorno = "Gerado com sucesso!";
                    }
                    catch (Exception exc)
                    {
                        retorno = exc.Message;
                    }
                }
                catch (Exception ex)
                {
                    retorno = ex.Message;
                }
                return retorno;
            }

            private static string GetExcelColumnName(int columnNumber)
            {
                int dividend = columnNumber;
                string columnName = String.Empty;
                int modulo;

                while (dividend > 0)
                {
                    modulo = (dividend - 1) % 26;
                    columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                    dividend = (int)((dividend - modulo) / 26);
                }

                return columnName;
            }

            public static String RetornaLetraPorIndice(Int32 col)
            {
                String celula = "";

                if (col > 26)
                {
                    Int32 idxPrimeiraLetra = Math.Abs(col / 26);
                    Int32 idxSegundaLetra = col - (Math.Abs(col / 26) * 26);
                    if (idxSegundaLetra == 0)
                        celula = String.Concat(letras[idxPrimeiraLetra - 2], letras[25]);
                    else
                        celula = String.Concat(letras[idxPrimeiraLetra - 1], letras[idxSegundaLetra - 1]);
                }
                else
                    celula = letras[col - 1];

                return celula;
            }

            public static String RetornaCelulaPorIndice(Int32 col, Int32 row)
            {
                String celula = RetornaLetraPorIndice(col);
                return String.Concat(celula, row.ToString());
            }  

            public static void gerarLinhas(System.Data.DataTable dtDados, string titulo, excel.Application app, excel.Workbook wbk) 
            {
                Worksheet sht = (Worksheet)wbk.Worksheets.get_Item(1);
                Range rng;

                int qtdColunaAtiva = dtDados.Columns.Count - 1;
                int linhaAtiva = 3;
                int colunaAtiva = 1;
                DateTime valorData;

                app.DisplayAlerts = false;
                app.Visible = false;
                sht = wbk.Worksheets.get_Item(1) as excel.Worksheet;

                sht = (excel.Worksheet)wbk.Worksheets.get_Item(1);

                string coluna = RetornaLetraPorIndice(qtdColunaAtiva + 1);

                rng = sht.get_Range("A1", coluna + "1");
                rng.Font.Bold = true;
                rng.Font.Name = "Verdana";
                rng.Font.Size = 11;
                rng.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                rng.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                rng.Merge();
                rng.Font.Color = ColorTranslator.ToOle(Color.White);
                rng.Interior.Color = ColorTranslator.ToOle(Color.SteelBlue);
                sht.Cells[1, 1] = titulo.ToUpper();

                rng = sht.get_Range("A2", coluna + 2);
                rng.Font.Color = ColorTranslator.ToOle(Color.Black);
                rng.Interior.Color = ColorTranslator.ToOle(Color.AliceBlue);

                for (int indice = 0; indice < dtDados.Columns.Count; indice++)
                {
                    int linha = indice + 1;
                    sht.Cells[2, linha] = dtDados.Columns[indice].Caption.ToString();
                }

                for (int indice2 = 0; indice2 < dtDados.Rows.Count; indice2++)
                {
                    colunaAtiva = 1;
                    for (int indice3 = 0; indice3 < dtDados.Columns.Count; indice3++)
                    {
                        string tipo = dtDados.Rows[indice2][indice3].GetType().Name.ToString();
                        if (tipo == "DBNull")
                            sht.Cells[linhaAtiva, colunaAtiva] = dtDados.Rows[indice2][indice3].ToString();
                        else if (tipo == "String")
                            sht.Cells[linhaAtiva, colunaAtiva] = dtDados.Rows[indice2][indice3].ToString();
                        else if ((tipo == "Int16") || (tipo == "Int32"))
                            sht.Cells[linhaAtiva, colunaAtiva] = Convert.ToInt32(dtDados.Rows[indice2][indice3].ToString());
                        else if (tipo == "Decimal")
                            sht.Cells[linhaAtiva, colunaAtiva] = Convert.ToDecimal(dtDados.Rows[indice2][indice3].ToString());
                        else if (tipo == "DateTime")
                        {
                            valorData = Convert.ToDateTime(dtDados.Rows[indice2][indice3].ToString());
                            sht.Cells[linhaAtiva, colunaAtiva].NumberFormat = "dd/MM/aaaa";
                            sht.Cells[linhaAtiva, colunaAtiva] = valorData;
                        }
                        colunaAtiva += 1;
                    }
                    linhaAtiva += 1;
                }
            }
        }
    }
}
