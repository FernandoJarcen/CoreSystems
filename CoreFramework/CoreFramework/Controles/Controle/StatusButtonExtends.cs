using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using enm = CoreFramework.Objetos.Enums;


namespace CoreFramework.Controles.Controle
{
    public partial class StatusButtonExtends : DesignControlBase
    {
        enm.Estado estado = enm.Estado.Comecar;
        System.Drawing.Color comecar;
        System.Drawing.Color atencao;
        System.Drawing.Color finalizar;
        public event EventHandler AoChamar;

        public StatusButtonExtends()
        {
            InitializeComponent();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Texto do botão")]
        public string Texto
        {
            get { return btn_action.Text; }
            set { btn_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Estado do componente")]
        public enm.Estado Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                if (estado == enm.Estado.Comecar)
                    btn_action.BackColor = comecar;
                else if (estado == enm.Estado.Atencao)
                    btn_action.BackColor = atencao;
                else
                    btn_action.BackColor = finalizar;
            }
        }

        [Category("Custom")]
        [Description("Cor do Estado Começar")]
        public System.Drawing.Color Comecar
        {
            get { return comecar; }
            set { comecar = value; }
        }

        [Category("Custom")]
        [Description("Cor do Estado Atencao")]
        public System.Drawing.Color Atencao
        {
            get { return atencao; }
            set { atencao = value; }
        }

        [Category("Custom")]
        [Description("Cor do Estado Finalizar")]
        public System.Drawing.Color Finalizar
        {
            get { return finalizar; }
            set { finalizar = value; }
        }

        [Category("Custom")]
        [Description("Cor do texto")]
        public System.Drawing.Color CorTexto
        {
            get { return btn_action.ForeColor; }
            set { btn_action.ForeColor = value; }
        }

        #endregion

        #region metodos

        #endregion

        #region eventos

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
