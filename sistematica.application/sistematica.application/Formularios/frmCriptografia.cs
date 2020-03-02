using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sistematica.application.Formularios
{
    public partial class frmCriptografia : Form
    {
        public frmCriptografia()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            verificarStatus();
        }

        private void verificarStatus()
        {
            XmlDocument documento = new XmlDocument();
            bool retorno = false;
            documento.Load(@"c:\sistematica\CFG\mcapl.xml");
            retorno = ArquivoEncriptado(documento, "conectividade");
            mostraStatus(retorno);
        }

        private void mostraStatus(bool retorno)
        {
            if (retorno)
            {
                this.lbl_status.Valor = "DesCriptografado!";
                this.cap_criptografar.Enabled = true;
                this.cap_descriptografar.Enabled = false;
            }
            else
            {
                this.lbl_status.Valor = "Criptografado!";
                this.cap_criptografar.Enabled = false;
                this.cap_descriptografar.Enabled = true;
            }
        }

        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cap_criptografar_AoChamar(object sender, EventArgs e)
        {
            string caminho = @"c:\sistematica\CFG\mcapl.xml";
            try
            {
                CoreSDK.Utils.Xml.Criptografar(caminho, "GlobalDefinitions");
                MessageBox.Show("Arquivo Criptografado com sucesso!");
                verificarStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cap_descriptografar_AoChamar(object sender, EventArgs e)
        {
            string caminho = @"c:\sistematica\CFG\mcapl.xml";
            try
            {
                CoreSDK.Utils.Xml.Descriptografar(caminho);
                MessageBox.Show("Arquivo Descriptografado com sucesso!");
                verificarStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool ArquivoEncriptado(XmlDocument Doc, string ElementToEncrypt)
        {
            bool retorno = false;
            try
            {
                int encontrado = Doc.GetElementsByTagName(ElementToEncrypt).Count;
                if (encontrado > 0)
                    retorno = true;
            }
            catch (Exception ex)
            {
                CoreSDK.Utils.LOG.Escrever("XmlCryptoService.ArquivoEncriptado", ex.Message);
                retorno = false;
            }
            return retorno;
        }
    }
}
