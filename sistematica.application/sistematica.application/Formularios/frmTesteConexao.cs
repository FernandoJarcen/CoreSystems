using CoreSDK.Enums;
using CoreSDK.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistematica.application.Formularios
{
    public partial class frmTesteConexao : Form
    {
        public frmTesteConexao()
        {
            InitializeComponent();
        }

        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cap_limpar_AoChamar(object sender, EventArgs e)
        {
            fld_stringConnection.Valor = string.Empty;
            mmo_retorno.Valor = string.Empty;
            fld_stringConnection.Focus();
        }

        private void cap_executar_AoChamar(object sender, EventArgs e)
        {
            string retorno = string.Empty;
            mmo_retorno.Valor = string.Empty;
            if (!String.IsNullOrEmpty(fld_stringConnection.Valor))
            {
                retorno = validarConexao(fld_stringConnection.Valor);
                mmo_retorno.Valor = retorno;
            }
            else
                MessageBox.Show("String não preenchida");
        }

        private string validarConexao(string stringConexao)
        {
            return TestarConexao(BancoDados.TipoBaseDados.SqlServer, stringConexao);
        }

        public static string TestarConexao(BancoDados.TipoBaseDados banco, string strConn)
        {
            string retorno = string.Empty;
            try
            {                
                if (banco == BancoDados.TipoBaseDados.SqlServer)
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    retorno = "Conexao estabelecida com sucesso!";
                    conn.Close();
                }
                else if (banco == BancoDados.TipoBaseDados.Oracle)
                {
                    OracleConnection conn = new OracleConnection(strConn);
                    conn.Open();
                    retorno = "Conexao estabelecida com sucesso!";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("Teste Conexão", "Erro: " + ex.Message);
                retorno = ex.Message;
            }
            return retorno;
        }

    }
}
