//using CoreEntities.Base;
//using CoreEntities.Domain.Model.Sistema;
using CoreKonnector.Model;
using CoreSDK.Entities.Base;
using CoreSDK.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace sistematica.application.Formularios
{
    public partial class frmCriptografiaUsuarios : Form
    {
        public frmCriptografiaUsuarios()
        {
            InitializeComponent();
        }

        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cap_criptografar_AoChamar(object sender, EventArgs e)
        {
            string retorno = string.Empty;
            if (MessageBox.Show("Deseja criptografar os usuários?", "Sistematica", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {                
                using (DataTable dtUsuarios = Acao<Usuario>.SelecionarTodos(new string[] { "UsuarioID", "PWD" }))
                {
                    for (int indice = 0; indice < dtUsuarios.Rows.Count; indice++)
                    {
                        
                        string user = dtUsuarios.Rows[indice]["UsuarioID"].ToString();
                        string pwd = dtUsuarios.Rows[indice]["Pwd"].ToString();
                        pwd = Seguranca.MD5Crypt.Criptografar(pwd);
                        Dictionary<string, object> usr = new Dictionary<string, object>();
                        usr.Add("PWD", pwd);
                        retorno = Acao<Usuario>.Atualizar(usr, "UsuarioID = " + user);
                    }
                    if (retorno == "Registro Atualizado com sucesso!")
                    {
                        lbl_status.Valor = "Senhas Criptografadas com sucesso!";
                        cap_criptografar.Enabled = false;
                        cap_descriptografar.Enabled = true;
                    }
                }
            }
        }

        private void cap_descriptografar_AoChamar(object sender, EventArgs e)
        {
            string retorno = string.Empty;
            if (MessageBox.Show("Deseja descriptografar os usuários?", "Sistematica", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (DataTable dtUsuarios = Acao<Usuario>.SelecionarTodos(new string[] { "UsuarioID", "PWD" }))
                {
                    for (int indice = 0; indice < dtUsuarios.Rows.Count; indice++)
                    {

                        string user = dtUsuarios.Rows[indice]["UsuarioID"].ToString();
                        string pwd = dtUsuarios.Rows[indice]["Pwd"].ToString();
                        pwd = Seguranca.MD5Crypt.Descriptografar(pwd);
                        Dictionary<string, object> usr = new Dictionary<string, object>();
                        usr.Add("PWD", pwd);
                        retorno = Acao<Usuario>.Atualizar(usr, "UsuarioID = " + user);
                    }
                    if (retorno == "Registro Atualizado com sucesso!")
                    {
                        lbl_status.Valor = "Senhas Criptografadas com sucesso!";
                        cap_criptografar.Enabled = true;
                        cap_descriptografar.Enabled = false;
                    }
                }
            }
        }
    }
}
