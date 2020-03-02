using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    [DefaultEvent("btn_action_Click")]
    public partial class CaptionItemExtends : DesignControlBase
    {        
        public event EventHandler AoChamar;
        private bool borda = false;
        private bool imagem = true;

        public CaptionItemExtends()
        {
            InitializeComponent();
        }


        #region propriedades

        [Category("Custom")]
        [Description("Texto do botão")]
        public string Titulo
        {
            get { return btn_action.Text; }
            set { btn_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Imagem do botão")]
        public System.Drawing.Image Imagem
        {
            get { return btn_action.Image; }
            set { btn_action.Image = value; }
        }

        [Category("Custom")]
        [Description("Mostrar Imagem")]
        public bool MostrarImagem
        {
            get { return imagem; }
            set
            {
                imagem = value;
                if (imagem)
                    btn_action.Image = Imagem;
                else
                    btn_action.Image = null;
            }
        }

        [Category("Custom")]
        [Description("Cor do botão")]
        public System.Drawing.Color Cor
        {
            get { return btn_action.BackColor; }
            set { btn_action.BackColor = value; }
        }

        [Category("Custom")]
        [Description("Borda do botão")]
        public bool MostrarBorda
        {
            get { return borda; }
            set
            {
                borda = value;
                if (borda)
                    btn_action.FlatAppearance.BorderSize = 1;
                else
                    btn_action.FlatAppearance.BorderSize = 0;
            }
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
