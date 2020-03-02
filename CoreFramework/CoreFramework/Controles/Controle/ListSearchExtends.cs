using CoreFramework.Controles.Controle.Collection;
using CoreFramework.Controles.Controle.Editors;
using CoreFramework.Controles.Controle.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class ListSearchExtends : DesignControlBase
    {
        Button btn = new Button();
        Dictionary<int, string> Colecao = new Dictionary<int, string>();
        //int cont = 0;
        bool icone = true;
        private ListSearchCollection lista = new ListSearchCollection();

        public ListSearchExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Editor(typeof(ListSearchCollectionEditor),
    typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Custom")]
        [Description("A collection of the employees within the organization")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ListSearchCollection Items
        {
            get { return lista; }
            set { lista = value; }
        }

        [Category("Custom")]
        [Description("titulo do cabeçalho do controle")]
        public string Titulo
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Mostrar/Ocultar Ícone")]
        public bool MostrarImagem
        {
            get { return icone; }
            set
            {
                icone = value;
                visibilidade(icone);
            }
        }

        [Category("Custom")]
        [Description("Carregar Imagem")]
        public System.Drawing.Image Imagem
        {
            get { return pcb_action.Image; }
            set
            {
                if (icone)
                {
                    pcb_action.Image = value;
                }
            }
        }

        [Category("Custom")]
        [Description("Cor do Titulo")]
        public System.Drawing.Color CorTitulo
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value; }
        }

        #endregion

        #region metodos

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        public List<string> RetornarColecao()
        {
            List<string> retorno = new List<string>();
            for (int indice = 0; indice < lista.Count; indice++)
            {
                retorno.Add(lbx_action.Items[indice].ToString());
            }
            return retorno;
        }

        private int contarColecao()
        {
            return lbx_action.Items.Count;
        }

        private void carregarColecao()
        {
            lbx_action.Items.Clear();
            for (int indice = 0; indice < lista.Count; indice++)
            {
                lbx_action.Items.Add(lista[indice].Display.ToString());
            }
        }

        private void visibilidade(bool valor)
        {
            if (valor)
            {
                pcb_action.Visible = true;
                lbl_action.Location = new System.Drawing.Point(47, 13);
            }
            else
            {
                pcb_action.Visible = false;
                lbl_action.Location = new System.Drawing.Point(10, 13);
            };
        }

        #endregion

        #region eventos

        protected void novoBotao_Click(object sender, EventArgs e)
        {
            if (tbx_action.Text != string.Empty)
            {
                lbx_action.Items.Add(tbx_action.Text);
                int count = lista.Count + 1;
                lista.Add(new Itens.ListSearchItem(count, tbx_action.Text, tbx_action.Text));
                tbx_action.Text = string.Empty;
                carregarColecao();
            }
            else
                MessageBox.Show("Não existe item a ser adicionado!");
        }

        private void ListSearchExtends_SizeChanged(object sender, EventArgs e)
        {
            lbx_action.Height = this.Size.Height - 86;
            lbx_action.Width = this.Size.Width - 16;
            tbx_action.Width = this.Size.Width - 16;
        }

        #endregion
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            btn.Size = new Size(25, this.ClientSize.Height + 2);
            btn.Dock = DockStyle.Right;
            btn.Cursor = Cursors.Default;
            btn.Image = CoreFramework.Properties.Resources.acrescimo;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += new EventHandler(novoBotao_Click);

            this.tbx_action.Controls.Add(btn);

            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            carregarColecao();
        }
    }
}
