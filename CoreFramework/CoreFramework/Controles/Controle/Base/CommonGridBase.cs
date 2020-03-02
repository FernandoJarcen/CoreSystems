using CoreFramework.Controles.Controle.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Base
{
    public partial class CommonGridExtends : DesignControlBase
    {
        bool canonico = true;
        bool subconsulta = false;
        private bool ocultar = false;
        private string query = String.Empty;
        //private string criteria = String.Empty;
        string ordenacao = string.Empty;
        private String chave = string.Empty;
        private String mensagem = String.Empty;
        System.Drawing.Color colEditavel = System.Drawing.Color.Red;
        Dictionary<String, String> colecao = new Dictionary<string, string>();
        Enums.EscolhaBooleana master = Enums.EscolhaBooleana.Não;
        string[] consultas;
        Control[] details;  

        #region propriedades

        [Category("Custom")]
        [Description("Consulta a ser executada no controle")]
        public String Query
        {
            get
            {
                return query;
            }

            set
            {
                this.query = value;
            }
        }

        [Category("Custom")]
        [Description("Chave do controle")]
        public string Chave
        {
            get { return chave; }
            set { chave = value; }
        }

        [Category("Custom")]
        [Description("Tamanho do controle")]
        public int Tamanho
        {
            get
            {
                return this.Width;
            }

            set
            {
                this.Width = value;
            }
        }

        [Category("Custom")]
        [Description("Utilizar nome canônico para consulta")]
        public bool Canonico
        {
            get { return canonico; }
            set { this.canonico = value; }
        }

        [Category("Custom")]
        [Description("Metodo de ordenação de consulta")]
        public string Ordenacao
        {
            get { return ordenacao; }
            set { ordenacao = value; }
        }

        [Category("Custom")]
        [Description("Verifica se é subconsulta")]
        public bool Subconsulta
        {
            get { return subconsulta; }
            set { subconsulta = value; }
        }


        [Category("Custom")]
        [Description("Ocultar Campo Chave")]
        public bool Ocultar
        {
            get { return ocultar; }
            set { ocultar = value; }
        }

        [Category("Custom")]
        [Description("Cor de coluna editavel")]
        public System.Drawing.Color ColunaEditavel
        {
            get { return colEditavel; }
            set { colEditavel = value; }
        }

        [Category("Custom")]
        [Description("MasterDetail control")]
        public Enums.EscolhaBooleana Master
        {
            get { return master; }
            set { master = value; }
        }

        [Category("Custom")]
        public Control[] Details
        {
            get { return details; }
            set { details = value; }
        }

        [Category("Custom")]
        [Description("Consultas details")]
        public string[] Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }

        #endregion

        public CommonGridExtends()
        {
            InitializeComponent();
        }
    }
}
