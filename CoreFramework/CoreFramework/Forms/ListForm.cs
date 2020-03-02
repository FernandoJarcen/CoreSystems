using CoreFramework.Controles.Controle;
using System;
using System.Windows.Forms;

namespace CoreFramework.Forms
{
    public partial class ListForm : Form
    {
        SpeedButtonExtends ent_consulta = new SpeedButtonExtends();
        Label lbl_associado = new Label();
        TextBox tbx_chamador = new TextBox();

        public ListForm(SpeedButtonExtends consulta, TextBox chamador, Label associado)
        {
            InitializeComponent();
            ent_consulta = consulta;
            lbl_associado = associado;
            tbx_chamador = chamador;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_form_Shown(object sender, EventArgs e)
        {
            carrega_combo();
        }

        private void carrega_combo()
        {
            for (int indice = 0; indice < ent_consulta.Items.Count; indice++)
            {
                gvd_dados.Rows.Add(ent_consulta.Items[indice].Display, ent_consulta.Items[indice].Valor);
            }
        }

        private void gvd_dados_DoubleClick(object sender, EventArgs e)
        {
            String id = Convert.ToString(gvd_dados.Rows[gvd_dados.CurrentRow.Index].Cells[0].Value);
            String valor = Convert.ToString(gvd_dados.Rows[gvd_dados.CurrentRow.Index].Cells[1].Value);

            tbx_chamador.Text = id;
            if (lbl_associado != null)
                lbl_associado.Text = valor;

            this.Close();

        }
    }
}
