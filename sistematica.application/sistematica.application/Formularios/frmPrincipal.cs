using System;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using CoreSDK.Utils;
using CoreSDK.Enums;
using CoreSDK.Specific;
using CoreKonnector.Entidades;

namespace sistematica.application.Formularios
{
    public partial class modulo : Form
    {
        #region parametros

        private string[] p_args = Environment.GetCommandLineArgs();
        pluggin global;

        #endregion
        public modulo(pluggin argumento)
        {
            InitializeComponent();
            global = argumento;
            inicializar();
            this.WindowState = FormWindowState.Maximized;
        }

        #region procedimentos

        private void inicializar()
        {
            string caminho = @"C:\Sistematica\CFG\mcapl.xml";
            try
            {
                Objetos.Utilidades.caminhoPadrao = caminho;
                carregarFilial();
                Xml.Descriptografar(caminho);
                int codigoProduto = Convert.ToInt32(Xml.BuscaTAG(caminho, "instancia"));
                string nomeInstancia = Xml.BuscaNomeInstancia(codigoProduto);
                Util.Executar(codigoProduto);
                Util.Parametros[Prm.NomeInstancia] = global.Modulo;
                carregarComponentes(codigoProduto.ToString(),nomeInstancia);
                Xml.Criptografar(caminho);
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message, MessageBoxButtons.OK);
            }
        }

        private void carregarFilial()
        {
            if (p_args.Length > 1)
            {
                global.CodigoFilial = Convert.ToInt32(p_args[1]);
                global.NomeFilial = p_args[2].Replace("?", " ");
                global.CodigoUsuario = Convert.ToInt32(p_args[3]);
                global.NomeUsuario = p_args[4].Replace("?", " ");
                global.CodigoInstancia = Convert.ToInt32(p_args[5]);
            }
            else
            {
                global.CodigoFilial = 0;
                global.NomeFilial = "Desenvolvimento Teste";
                global.CodigoUsuario = 1;
                global.NomeUsuario = "Desenvolvedor";
                global.CodigoInstancia = 0;
            }
        }

        private void montarFormulario()
        {
            DevComponents.DotNetBar.RibbonPanel panel = null;
            DevComponents.DotNetBar.ButtonItem itn = null;
            DevComponents.DotNetBar.RibbonBar bar = null;

            for (int indice = 0; indice < this.rct_modulo.Controls.Count; indice++)
            {
                if (this.rct_modulo.Controls[indice].GetType().ToString() == "DevComponents.DotNetBar.RibbonPanel")
                {
                    panel = (DevComponents.DotNetBar.RibbonPanel)this.rct_modulo.Controls[indice];
                    for (int indice2 = 0; indice2 < panel.Controls.Count; indice2++)
                    {
                        if (panel.Controls[indice2].Name != "rba_modulo")
                        {
                            bar = (DevComponents.DotNetBar.RibbonBar)panel.Controls[indice2];
                            for (int indice3 = 0; indice3 < bar.Items.Count; indice3++)
                            {
                                itn = (DevComponents.DotNetBar.ButtonItem)bar.Items[indice3];
                                Util.Formularios.ControleVisivel(itn, false);
                            }
                            Util.Formularios.ControleVisivel(bar, false);
                        }
                    }
                }
            }

            DevComponents.DotNetBar.RibbonTabItem tab = null;
            for (int indice = 1; indice < rct_modulo.Items.Count; indice++)
            {
                tab = (DevComponents.DotNetBar.RibbonTabItem)this.rct_modulo.Items[indice];
                Util.Formularios.ControleVisivel(tab, false);
            }
        }

        private void carregarComponentes(string codigoInstancia, string nomeInstancia)
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
            sst_modulo.Items[8].Text = global.NomeUsuario;                  //nome usuario;
            //apenas para esse módulo
            sst_modulo.Items[9].Text = codigoInstancia.ToString();          //codigo instancia padrao   
            sst_modulo.Items[10].Text = nomeInstancia;                      //nome instancia padrao  
            Objetos.Utilidades.instanciaAtiva = nomeInstancia;
        }

        private void carregarBotoes(int codigo)
        {
            DataTable dtAplicacao = AutenticacaoSistema.BuscarAplicacao(codigo, global.Modulo);
            DataTable dtModulo = AutenticacaoSistema.BuscarModulo(codigo, global.Modulo);
            DataTable dtRotina = AutenticacaoSistema.BuscarRotina(codigo, global.Modulo);

            foreach (BaseItem item in rct_modulo.Items)
            {
                RibbonTabItem Tab = item as RibbonTabItem;
                for (int indice1 = 0; indice1 < dtAplicacao.Rows.Count; indice1++)
                {
                    if (Tab.Name.ToString() == dtAplicacao.Rows[indice1][0].ToString())
                    {
                        Tab.Visible = true;
                        if (Tab != null)
                        {
                            RibbonPanel Pnl = Tab.Panel;

                            foreach (Control panelControl in Pnl.Controls)
                            {
                                RibbonBar Bar = panelControl as RibbonBar;
                                if (Bar.Name.ToString() != "rba_modulo")
                                {
                                    if (Bar != null)
                                    {
                                        for (int indice2 = 0; indice2 < dtModulo.Rows.Count; indice2++)
                                        {
                                            if (Bar.Name.ToString() == dtModulo.Rows[indice2][0].ToString())
                                            {
                                                Bar.Visible = true;
                                                foreach (BaseItem Btn in Bar.Items)
                                                    for (int indice3 = 0; indice3 < dtRotina.Rows.Count; indice3++)
                                                    {
                                                        if (Btn.Name.ToString() == dtRotina.Rows[indice3][0].ToString())
                                                        {
                                                            Btn.Visible = true;
                                                            break;
                                                        }
                                                    }
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
                }
            }
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
                case "Instâncias":
                    Util.Formularios.AbreFormulario(new Formularios.frmInstanciaAtiva(sst_modulo));break;
                case "Teste\r\nConexão":
                    Util.Formularios.AbreFormulario(new Formularios.frmTesteConexao());break;
                case "Criptografia":
                    Util.Formularios.AbreFormulario(new Formularios.frmCriptografia());break;
                case "Criptografia \r\nArquivos":
                    Util.Formularios.AbreFormulario(new Formularios.frmCriptografiaArquivos());break;
                case "XML":
                    Util.Formularios.AbreFormulario(new Formularios.frmEditorXml());break;
                case "Customizações":
                    Util.Formularios.AbreFormulario(new Formularios.frmCustomizacao());break;
                case "Componentes":
                    Util.Formularios.AbreFormulario(new Formularios.frmComponentes(Convert.ToInt32(Util.Parametros[Prm.CodigoInstancia])));break;
                case "Criptografar\r\nUsuários":
                    Util.Formularios.AbreFormulario(new Formularios.frmCriptografiaUsuarios());break;
                default:
                    break;
            }
        }

        private void modulo_Shown(object sender, EventArgs e)
        {
            //int qtd_instancias = Util.Processos.ContarInstancia("sistematica." + global.Modulo.ToLower());
            int qtd_instancias = CoreSDK.Specific.Modulo.ContarInstancia("sistematica." + global.Modulo.ToLower()); 

            if (qtd_instancias > 1)
                Application.Exit();
        }

        #endregion
    }
}
