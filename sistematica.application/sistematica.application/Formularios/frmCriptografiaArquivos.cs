using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreSDK.Utils;

namespace sistematica.application.Formularios
{
    public partial class frmCriptografiaArquivos : Form
    {
        public frmCriptografiaArquivos()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            cpt_criptografar.Enabled = false;
            cpt_descriptografar.Enabled = false;
        }

        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            string caminho = string.Empty;
            bool resultado = false;

            caminho = fld_arquivo.Valor;
            if (!String.IsNullOrEmpty(caminho))
            {
                if (System.IO.File.Exists(caminho))
                {
                    resultado = Xml.VerificarCriptografia(caminho);
                    if (resultado)
                    {
                        lbl_statusAtual.Valor = "Criptografado!";
                        cpt_criptografar.Enabled = false;
                        cpt_descriptografar.Enabled = true;
                    }
                    else
                    {
                        lbl_statusAtual.Valor = "Descriptografado!";
                        cpt_criptografar.Enabled = true;
                        cpt_descriptografar.Enabled = false;
                    }

                }
            }
            else
                MessageBox.Show("Impossível verificar sem o caminho do arquivo!");
        }

        private void cpt_criptografar_AoChamar(object sender, EventArgs e)
        {
            string caminho = string.Empty;

            caminho = fld_arquivo.Valor;
            if (!String.IsNullOrEmpty(caminho))
            {
                if (System.IO.File.Exists(caminho))
                {
                    Xml.Criptografar(caminho);
                    MessageBox.Show("Criptografado com sucesso!");
                    lbl_statusAtual.Valor = "Criptografado!";
                    cpt_criptografar.Enabled = false;
                    cpt_descriptografar.Enabled = true;
                }
            }
        }

        private void cpt_descriptografar_AoChamar(object sender, EventArgs e)
        {
            string caminho = string.Empty;

            caminho = fld_arquivo.Valor;
            if (!String.IsNullOrEmpty(caminho))
            {
                if (System.IO.File.Exists(caminho))
                {
                    Xml.Descriptografar(caminho);
                    MessageBox.Show("DesCriptografado com sucesso!");
                    lbl_statusAtual.Valor = "Descriptografado!";
                    cpt_criptografar.Enabled = true;
                    cpt_descriptografar.Enabled = false;
                }
            }
        }
    }
}
