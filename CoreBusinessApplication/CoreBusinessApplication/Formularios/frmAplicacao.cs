using CoreSDK.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreBusinessApplication.Formularios
{
    public partial class frmAplicacao : Form
    {
        public frmAplicacao()
        {
            InitializeComponent();
        }

        private void frmAplicacao_Load(object sender, EventArgs e)
        {
            string servico = string.Empty;

            try
            {
                //bool ativo = false;
                //string idProduto = Xml.BuscaTAG("instancia");

                //AutenticacaoModulos.InicializarInstancia(Convert.ToInt16(idProduto));
                //bool validade = AutenticacaoParametros.Schlüsselvalidierer(Util.Parametros[Prm.Chave].ToString());
                //if (validade)
                //{
                //    servico = Util.Parametros[Prm.Servico].ToString();
                //    ativo = AutenticacaoSistema.TestarConexao(servico);

                //    frmSplash splash = new frmSplash(ativo);

                //    this.Hide();
                //    splash.Closed += (s, args) => this.Close();
                //    splash.ShowDialog();
                //}
                //else
                //{
                //    MessageBox.Show("Não foi possível executar o Sistema!");
                //    Application.Exit();
                //}
                Util.Formularios.AbreFormulario(new Formularios.frmLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
