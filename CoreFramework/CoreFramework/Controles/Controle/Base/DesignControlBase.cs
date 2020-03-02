using CoreFramework.Objetos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle.Base
{
    public class DesignControlBase:UserControl
    {
        private int _globalID = 0;
        private string _globalName = string.Empty;
        private string _mensagemPadrao = string.Empty;
        private Enums.TipoControle _tipoControle = Enums.TipoControle.Visual;

        [Category("Access")]
        [Description("Indice global")]
        [DefaultValue("0")]
        public int GlobalID
        {
            get
            {
                return _globalID;
            }
            set
            {
                _globalID = value;
            }
        }

        [Category("Access")]
        [Description("Nome global")]
        [DefaultValue("0")]
        public string GlobalName
        {
            get
            {
                return _globalName;
            }
            set
            {
                _globalName = value;
            }
        }

        [Category("Access")]
        [Description("Mensagem Padrão")]
        public string MensagemPadrao
        {
            get { return _mensagemPadrao; }
            set { _mensagemPadrao = value; }
        }

        [Category("Custom")]
        [Description("Tipo de Borda")]
        public BorderStyle Borda
        {
            get { return this.BorderStyle; }
            set { this.BorderStyle = value; }
        }

        [Category("Dados")]
        public string Build { get; set; }

        [Category("Dados")]
        public Enums.TipoControle TipoControle
        {
            get
            {
                return _tipoControle;
            }
            private set { _tipoControle = value; }
        }

        public void InicializarTipo(Enums.TipoControle tipo)
        {
            _tipoControle = tipo;
        }
    }
}
