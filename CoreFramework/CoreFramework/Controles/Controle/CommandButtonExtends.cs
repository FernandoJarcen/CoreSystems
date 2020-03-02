using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using CoreFramework.Controles.Controle.Base;
using System.Collections.Generic;

namespace CoreFramework.Controles.Controle
{
    public partial class CommandButtonExtends : DesignControlBase
    {
        public event EventHandler AoClicar;
        public event EventHandler AoChamar;
        Button btn_action = new Button();
        string namespc = string.Empty;
        string nomeForm = string.Empty;
        bool mostraForm = false;
        List<object> parametros = new List<object>();

        public CommandButtonExtends()
        {
            inicializar();            
        }

        #region propriedades

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
        [Description("Texto do botão")]
        public String Titulo
        {
            get
            {
                return btn_action.Text;
            }

            set
            {
                btn_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Cor do painel")]
        public Color Cor
        {
            get
            {
                return btn_action.BackColor;
            }
            set
            {
                btn_action.BackColor = value;
            }
        }

        [Category("Custom")]
        [Description("Namespace do form")]
        public string NameSpace
        {
            get { return namespc; }
            set { namespc = value; }
        }

        [Category("Custom")]
        [Description("Nome do formulario")]
        public string Formulario
        {
            get { return nomeForm; }
            set { nomeForm = value; }
        }

        [Category("Custom")]
        [Description("Cor do painel")]
        public bool MostrarFormulario
        {
            get { return mostraForm; }
            set { mostraForm = value; }
        }

        #endregion
        private void inicializar()
        {
            btn_action.Text = "Button";
            btn_action.Dock = DockStyle.Fill;
            btn_action.BackColor = System.Drawing.Color.SteelBlue;
            btn_action.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            btn_action.FlatAppearance.BorderSize = 1;
            btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_action.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            btn_action.ForeColor = System.Drawing.Color.White;
            btn_action.Click += btn_action_Click;

            this.Size = new Size(137, 33);
            this.Controls.Add(btn_action);
        }

        private void iniciarForm(string nomeNsp, string nomeForm)
        {
            Assembly myAssembly = null;
            Form form = new Form();
            try
            {
                parametros.Clear();
                Chamar(this);
                foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (String.Compare(a.GetName().Name, nomeNsp) == 0)
                    {
                        myAssembly = a;
                        break;
                    }
                }

                string referencia = myAssembly.GetName().Name + "." + nomeForm;
                Type type = myAssembly.GetType(referencia);
                if (parametros.Count > 0)
                {
                    if (parametros.Count == 1)
                        form = (Form)Activator.CreateInstance(type, parametros[0]);
                    else if (parametros.Count == 2)
                        form = (Form)Activator.CreateInstance(type, parametros[0], parametros[1]);
                    else if (parametros.Count == 3)
                        form = (Form)Activator.CreateInstance(type, parametros[0], parametros[1], parametros[2]);
                    else if (parametros.Count == 4)
                        form = (Form)Activator.CreateInstance(type, parametros[0], parametros[1], parametros[2], parametros[3]);
                    else if (parametros.Count == 5)
                        form = (Form)Activator.CreateInstance(type, parametros[0], parametros[1], parametros[2], parametros[3], parametros[4]);
                    else if (parametros.Count == 6)
                        form = (Form)Activator.CreateInstance(type, parametros[0], parametros[1], parametros[2], parametros[3], parametros[4], parametros[5]);
                }
                else
                    form = (Form)Activator.CreateInstance(type);

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                string e = ex.Message.ToString();
                MessageBox.Show("Não foi possível abrir o form solicitado");
            }
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (mostraForm)
            {
                if ((!String.IsNullOrEmpty(namespc)) && (!String.IsNullOrEmpty(nomeForm)))
                {
                    iniciarForm(namespc, nomeForm);
                }
            }
            else
            {
                if (this.AoClicar != null)
                {
                    this.AoClicar(this, e);
                }
            }
        }

        public void Parametro(object objeto)
        {
            parametros.Add(objeto);
        }

        private void Chamar(object sender)
        {
            EventArgs e = new EventArgs();
            if (this.AoChamar != null)
            {
                this.AoChamar(this, e);
            }
        }

    }
}
