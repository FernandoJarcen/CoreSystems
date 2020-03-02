using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public partial class MessageCheckExtends :ChooseControlBase
    {
        public event EventHandler AoChamar;

        public MessageCheckExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Texto da label")]
        public String Mensagem
        {
            get
            {
                return chk_action.Text;
            }

            set
            {
                chk_action.Text = value;
            }
        }


        [Category("Custom")]
        [Description("Texto Botão")]
        public string TituloBotao
        {
            get { return btn_action.Text; }
            set { btn_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Tamanho do botão")]
        public int TamanhoBotao
        {
            get { return btn_action.Size.Width; }
            set { btn_action.Size = new Size(value, this.Size.Height); }
        }

        [Category("Custom")]
        [Description("cor do botão")]
        public System.Drawing.Color CorBotao
        {
            get { return btn_action.BackColor; }
            set { btn_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Valor do radiobox")]
        public bool Ativado
        {
            get
            {
                return this.chk_action.Checked;
            }
            set
            {
                this.chk_action.Checked = value;
            }
        }

        #endregion

        #region metodos
        
        #endregion

        #region eventos

        private void chk_action_CheckedChanged(object sender, EventArgs e)
        {
            btn_action.Enabled = chk_action.Checked;
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (this.AoChamar != null)
            {
                this.AoChamar(this, e);
            }   
        }

        #endregion
    }
}
