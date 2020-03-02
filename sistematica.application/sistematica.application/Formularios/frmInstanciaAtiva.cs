using CoreSDK.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

//using xml = CoreFramework.Utils.Xml;
//using utl = CoreFramework.Utils.Util;
//using ins = CoreFramework.Utils;

namespace sistematica.application.Formularios
{
    public partial class frmInstanciaAtiva : Form
    {
        int codigo = -1;
        string instancia = string.Empty;
        string caminhoPadrao = string.Empty;
        StatusStrip barraAtiva = new StatusStrip();
        public frmInstanciaAtiva(StatusStrip barra)
        {
            InitializeComponent();
            barraAtiva = barra;
            inicializar();
        }

        private void inicializar()
        {
            codigo = Convert.ToInt32(Util.Parametros[CoreSDK.Enums.Prm.CodigoInstancia]);
            instancia = Xml.BuscaNomeInstancia(codigo);
            rst_instancia.Valor = codigo.ToString();
            rst_nome.Valor = instancia;
            fld_arquivo.Valor = Objetos.Utilidades.caminhoPadrao;
            lbl_instanciaAtiva.Valor = Objetos.Utilidades.instanciaAtiva;
        }

        private void cap_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_instancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            rst_instancia.Valor = Xml.BuscaAtributo(fld_arquivo.Valor, cbo_instancias.Text, "id");
            rst_nome.Valor = cbo_instancias.Text;
        }

        private void cap_executar_AoChamar(object sender, EventArgs e)
        {
            string nomeproduto = string.Empty;
            string caminhoPadrao = string.Empty;

            if (!String.IsNullOrEmpty(fld_arquivo.Valor))
            {
                Objetos.Utilidades.caminhoPadrao = fld_arquivo.Valor;
                Util.Parametros[CoreSDK.Enums.Prm.CaminhoPadrao] = fld_arquivo.Valor;
                caminhoPadrao = Util.Parametros[CoreSDK.Enums.Prm.CaminhoPadrao].ToString();

                int codigoInstancia = Convert.ToInt32(this.rst_instancia.Valor);
                if (codigoInstancia >= 0)
                {
                    Util.Executar(codigoInstancia);
                    Objetos.Utilidades.instanciaAtiva = rst_nome.Valor;
                }
                MessageBox.Show("Instância '" + rst_nome.Valor.ToUpper() + "' Atualizada com sucesso!");
                barraAtiva.Items[9].Text = rst_instancia.Valor;
                barraAtiva.Items[10].Text = rst_nome.Valor;
            }
            else
            {
                MessageBox.Show("Não é possível alterar a instância!");
                rst_instancia.Valor = string.Empty;
                rst_nome.Valor = string.Empty;
            }
        }

        private void fld_arquivo_Validated(object sender, EventArgs e)
        {
            mostrarInstancias();
        }

        private void mostrarInstancias()
        {
            caminhoPadrao = fld_arquivo.Valor;
            if (!string.IsNullOrEmpty(caminhoPadrao))
            {
                bool criptografado = Xml.VerificarCriptografia(caminhoPadrao);

                if (cbo_instancias.Items.Count > 0)
                {
                    cbo_instancias.Items.Clear();
                    List<string> instancias = new List<string>();
                    if (criptografado)
                        Xml.Descriptografar(caminhoPadrao);
                    if (instancias != null)
                    {
                        instancias = CoreSDK.Utils.Xml.BuscaListaTAGS(caminhoPadrao, "conectividade");
                        preencherInstancias(instancias);
                    }
                    if (criptografado)
                        Xml.Criptografar(caminhoPadrao);
                }
                else
                {
                    List<string> instancias = new List<string>();
                    if (criptografado)
                        Xml.Descriptografar(caminhoPadrao);
                    if (instancias != null)
                    {
                        instancias = CoreSDK.Utils.Xml.BuscaListaTAGS(caminhoPadrao, "conectividade");
                        if (instancias.Count > 0)
                            preencherInstancias(instancias);
                        else
                            MessageBox.Show("Não foi possível carregar as instâncias do arquivo!");
                    }
                    if (criptografado)
                        Xml.Criptografar(caminhoPadrao);
                }
            }
            else
                MessageBox.Show("Não foi possível verificar as instâncias desse arquivo!");
        }

        private void preencherInstancias(List<string> instancias)
        {
            try
            {
                if (instancias != null)
                {
                    if (instancias.Count > 0)
                    {
                        for (int indice = 0; indice < instancias.Count; indice++)
                        {
                            cbo_instancias.Items.Add(instancias[indice].ToString());
                        }
                    }
                    else
                        MessageBox.Show("Não foi possível encontrar as instancias solicitadas!");
                }
                else
                    MessageBox.Show("Não foi possível encontrar as instancias solicitadas!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmInstanciaAtiva_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fld_arquivo.Valor))
                mostrarInstancias();
        }

        private void comboListExtends1_AoMudarIndice(object sender, EventArgs e)
        {
            rst_instancia.Valor = Xml.BuscaAtributo(fld_arquivo.Valor, cbo_instancias.Text, "id");
            rst_nome.Valor = cbo_instancias.Text;
        }
    }
}
