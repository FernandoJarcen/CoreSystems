using CoreKonnector.Model;
//using CoreEntities.Domain.Model.Sistema;
using CoreSDK.Entities.Base;
using CoreSDK.Enums;
using CoreSDK.ODB.Domain;
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

namespace sistematica.application.Formularios
{
    public partial class frmCustomizacao : Form
    {
        string entity = string.Empty;
        string parent = string.Empty;
        public string baseConectada { get; set; }
        public frmCustomizacao()
        {
            InitializeComponent();
            inicializar();
        }

        #region metodos

        private void inicializar()
        {
            lbl_baseConectada.Valor = Objetos.Utilidades.instanciaAtiva;
            baseConectada = Objetos.Utilidades.instanciaAtiva;
            bool tabelaEntidade = CoreSDK.ODB.Domain.DBUtilities.ExisteTabela("EntidadeSistema");
            if (tabelaEntidade)
            mostrarEntidades(lbl_baseConectada.Valor);
        }

        private void mostrarEntidades(string baseconectada)
        {
            MostrarEntidades(baseconectada);
        }

        private void mostraEntidadeSelecionada(string entidadeSelecionada, string parenteSelecionado)
        {
            entity = entidadeSelecionada;
            parent = parenteSelecionado;
            using (DataTable dtEntidade = Acao<EntidadeSistema>.SelecionarTodos(new string[]{"*"},"Apelido = '" + entidadeSelecionada + "'"))
            {
                if (dtEntidade.Rows.Count > 0)
                {
                    lbl_entidade.Valor = entity;
                    lbl_displayEntidade.Valor = dtEntidade.Rows[0]["Display"].ToString();
                    lbl_tipoEntidade.Valor = dtEntidade.Rows[0]["Tipo"].ToString();
                    lbl_descricaoEntidade.Valor = dtEntidade.Rows[0]["Descricao"].ToString();
                }
            }
        }

        public void MostrarEntidades(string baseconectada)
        {
            DataTable dtEntidades = Acao<EntidadeSistema>.SelecionarTodos(new string[] { "*" }, "Escopo = 'P' order by Apelido");
            TreeNode tn = tvw_componentes.Nodes[0].Nodes[0];
            tn.Nodes.Clear();
            if (dtEntidades != null)
            {
                if (dtEntidades.Rows.Count > 0)
                {
                    for (int indice = 0; indice < dtEntidades.Rows.Count; indice++)
                    {
                        string nomeEntidade = dtEntidades.Rows[indice][4].ToString();
                        tn.Nodes.Add(nomeEntidade);
                    }
                }
            }
        }

        #endregion

        #region eventos

        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvw_componentes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string entidade = string.Empty;
            string parente = string.Empty;
            entidade = e.Node.Text.ToString();

            if ((entidade != "Componentes") && (entidade != "Entidades"))
            {
                parente = e.Node.Parent.Name.ToString();
                if (parente == "Entidades")
                {
                    mostraEntidadeSelecionada(entidade, parente);
                    this.tabViewExtends1.SelectedTab = tab_entidades;
                }
            }
        }

        private void cap_entidade_AoChamar(object sender, EventArgs e)
        {
            Util.Formularios.AbreFormulario(new Formularios.frmEntidade(this));
        }

        

        private void tvw_componentes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string entidade = string.Empty;
            string parente = string.Empty;
            entidade = e.Node.Text.ToString();

            if ((entidade != "Componentes") && (entidade != "Entidades"))
            {
                parente = e.Node.Parent.Name.ToString();
                if (parente == "Entidades")
                {
                    Util.Formularios.AbreFormulario(new Formularios.frmCadastroEntidade(entidade,parente));
                    //mostraEntidadeSelecionada(entidade, parente);
                    //this.tabViewExtends1.SelectedTab = tab_entidades;
                }
            }
        }

        #endregion
    }
}
