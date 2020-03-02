using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreStudio.Objetos;

namespace CoreStudio.Controles.Base
{
    public partial class DesignControlBase : UserControl
    {
        private bool _obrigatorio = false;
        private Enums.EnumTipoControle _tipoControle = Enums.EnumTipoControle.Visual;
        private Control _controle;

        public DesignControlBase()
        {
            InitializeComponent();
        }

        #region campos

        [Category("Custom")]
        public bool Obrigatorio
        {
            get { return _obrigatorio; }
            set
            {
                _obrigatorio = value;
                if (_obrigatorio)
                    _controle.Text += "*";
                else
                    _controle.Text = _controle.Text.Replace("*", "");
            }
        }

        [Category("Dados")]
        public string Build { get; set; }

        [Category("Dados")]
        [Description("Mensagem Padrão")]
        public string MensagemPadrao { get; set; }

        [Category("Dados")]
        [Description("Indice global")]
        [DefaultValue("0")]
        public int GlobalID { get; set; }

        [Category("Dados")]
        [Description("Nome global")]
        [DefaultValue("0")]
        public string GlobalName { get; set; }

        [Category("Custom")]
        public Enums.EnumTipoControle TipoControle
        {
            get
            {
                return _tipoControle;
            }
            private set { _tipoControle = value; }
        }

        #endregion

        #region metodos

        public void InicializaControle(Control controle)
        {
            _controle = controle;
        }
        public void VerificarObrigatorio(Control controle, bool status)
        {
            Obrigatorio = status;
            if (Obrigatorio)
                controle.Text += "*";
            else
                controle.Text = controle.Text.Replace("*", "");
        }

        public bool RetornarObrigatorio()
        {
            return Obrigatorio;
        }

        #endregion

    }
}
