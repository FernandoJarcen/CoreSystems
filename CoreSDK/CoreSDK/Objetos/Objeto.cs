using System.Windows.Forms;
using frm = System.Windows.Forms;

namespace CoreSDK.Objetos
{
    public class Objeto
    {
        public static class Grid
        {
            public static void ExcluirEmBranco(DataGridView controle)
            {
                int aux = controle.Rows.Count - 1;
                for (int i = 0; i <= controle.Rows.Count - 1; i++)
                {
                    if (i != aux)
                    {
                        if (controle.Rows[i].Cells[0].Value == null)
                        {
                            controle.Rows.RemoveAt(i);
                            controle.Refresh();
                            i -= 1;
                            aux = aux - 1;
                        }
                    }
                    else
                    {
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
                controle.Refresh();
            }

            public static void ExcluirLinha(DataGridView controle, int linha)
            {
                controle.Rows.RemoveAt(linha);
                controle.Refresh();
            }

            public static string RetornarCelula(DataGridView controle, int linha, int coluna)
            {
                string retorno = string.Empty;
                retorno = controle.Rows[linha].Cells[coluna].Value.ToString();
                return retorno;
            }
        }

    }
}
