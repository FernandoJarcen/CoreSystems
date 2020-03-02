using System;
using System.Windows.Forms;
using CoreSDK.Utils;
using CoreSDK.Enums;
using CoreSDK.Specific;
using CoreKonnector.Entidades;
using DevComponents.DotNetBar;

namespace CoreBusinessApplication.Formularios
{
    public partial class modulo : Form
    {
        #region parametros

        private string[] p_args = Environment.GetCommandLineArgs();
        pluggin global;

        #endregion

        public modulo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            global.NomeCompleto = "Administrador";
            global.CodigoFilial = 1;
            global.NomeFilial = "Template";
            global.CodigoUsuario = 1;
            global.NomeUsuario = "";
            carregarComponentes();
        }

        #region procedimentos

        private void carregarComponentes()
        {
            rct_modulo.SelectedRibbonTabItem = rtb_modulo;
            rba_modulo.Text = global.NomeCompleto;
            this.Text = global.NomeCompleto;
            rtb_modulo.Text = global.NomeCompleto; //nome do modulo;

            sst_modulo.Items[1].Text = DateTime.Now.ToShortDateString();    //data corrente
            sst_modulo.Items[3].Text = global.NomeCompleto;                 //nome do modulo;             
            sst_modulo.Items[4].Text = global.CodigoFilial.ToString();      //codigo filial;
            sst_modulo.Items[5].Text = global.NomeFilial;                   // nome filial;
            sst_modulo.Items[7].Text = global.CodigoUsuario.ToString();     //id usuario;
            //sst_modulo.Items[8].Text = global.NomeUsuario;                  //nome usuario;
        }

        #endregion

        #region eventos

        private void tmr_principal_Tick(object sender, EventArgs e)
        {
            sst_modulo.Items[2].Text = DateTime.Now.ToLongTimeString();
        }

        private void rotina_click(object sender, EventArgs e)
        {
            String nome = sender.ToString();
            switch (nome)
            {
                case "&Sair":
                    if (MessageBox.Show("Deseja sair?", global.NomeCompleto, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        Application.Exit(); break;
                case "&Minimizar":
                    this.WindowState = FormWindowState.Minimized; break;
                case "&Studio":
                    AutenticacaoModulos.CarregarModulo("sistematica.studio", "Studio", true); break;
                default:
                    break;
            }
        }

        #endregion
    }
}
