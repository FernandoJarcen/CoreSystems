using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using odb = CoreSDK.ODB.DataBase;

namespace CoreFramework.Forms
{
    public partial class LookupForm : Form
    {
        private string query;
        private string nova_consulta;
        private String ret_principal = String.Empty;
        private string ret_secundaria = string.Empty;
        private TextBox display;
        private Label associado;
        private string criteria = String.Empty;
        private List<String> cabecalho = new List<string>();
        private bool controleOculto = false;

        #region Propriedades

        #endregion

        #region Metodos

        public void Carrega_Dados(String consulta)
        {
            DataTable dt = new DataTable();
            String query = consulta;

            dt = odb.DB.ExecutaReader(consulta);

            gvw_dados.DataSource = dt;

            if (gvw_dados.Columns.Count > 0)
            {
                if (controleOculto)
                    gvw_dados.Columns[0].Visible = false;
                else
                    gvw_dados.Columns[0].Visible = true;
            }
        }

        private int indice_procura(String campo)
        {
            int cont = gvw_dados.Columns.Count;
            int valor = 0;
            string procurado = campo;


            for (int i = 0; i < cont; i++)
            {
                if (gvw_dados.Columns[i].HeaderText == campo)
                {
                    valor = i;
                    break;
                }
            }
            return valor;
        }

        private void carrega_combo()
        {
            if (gvw_dados.Columns.Count > 0)
            {
                if (controleOculto)
                    this.gvw_dados.Columns[0].Visible = false;
                else
                    this.gvw_dados.Columns[0].Visible = true;

                foreach (DataGridViewColumn col in this.gvw_dados.Columns)
                {
                    if (col.Visible)
                    {
                        cabecalho.Add(col.HeaderText);
                    }
                }
            }

            if (cabecalho.Count > 0)
            {
                tcb_action.Items.Clear();
                foreach (var item in cabecalho)
                {
                    tcb_action.Items.Add(item.ToString());
                }

                tcb_action.SelectedIndex = 0;
            }
        }

        #endregion

        #region eventos

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(query))
            Carrega_Dados(query);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvw_dados_DoubleClick(object sender, EventArgs e)
        {
            String id = Convert.ToString(gvw_dados.Rows[gvw_dados.CurrentRow.Index].Cells[0].Value);
            String valor = Convert.ToString(gvw_dados.Rows[gvw_dados.CurrentRow.Index].Cells[indice_procura(ret_secundaria)].Value);

            display.Text = id;
            if (associado != null)
                associado.Text = valor;

            this.Close();
        }

        private void lookup_form_Shown(object sender, EventArgs e)
        {
            carrega_combo();
        }

        private void ttb_action_TextChanged(object sender, EventArgs e)
        {
            String qry = String.Empty;
            String nome_canonico = String.Empty;
            criteria = tcb_action.SelectedItem.ToString();

            qry = query + " where " + criteria + " like '%" + ttb_action.Text + "%'";
            Carrega_Dados(qry);
        }

        #endregion

        public LookupForm(string consulta, TextBox chamador, string campoPrincipal, Label controleAssociado = null, bool ocultar = false)
        {
            InitializeComponent();
            query = consulta;
            nova_consulta = consulta;
            display = chamador;
            ret_principal = campoPrincipal;
            associado = controleAssociado;
            ret_secundaria = campoPrincipal;
            gvw_dados.Query = consulta;
            gvw_dados.Ocultar = ocultar;
            controleOculto = ocultar;
            ttb_action.Focus();
        }
    }
}
