using System;
using System.Windows.Forms;

namespace CoreBusinessApplication.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string mensagem = CoreKonnector.Services.ModuloApp.ValidarAppBusiness(tbx_user.Valor, tbx_pwd.Valor);
            if (mensagem == "Sucesso!")            
                CoreSDK.Utils.Util.Formularios.AbreFormulario(new Formularios.modulo());            
            else
            {
                MessageBox.Show("Não foi possível autenticar a aplicação!");
                limpar();
            }
        }

        private void limpar()
        {
            tbx_user.Valor = string.Empty;
            tbx_pwd.Valor = string.Empty;
            tbx_user.Focus();
        }
    }
}
