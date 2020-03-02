using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;
using CoreFramework.Controles.Controle.Base;

namespace CoreFramework.Controles.Controle
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class FilterExtends : DesignControlBase
    {
        private bool ativado = true;

        public FilterExtends()
        {
            InitializeComponent();
            inicializar();
        }

        #region propriedades

        [Category("Custom")]
        [Description("Texto do Titulo")]
        public string Titulo
        {
            get { return chk_action.Text; }
            set { chk_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Controle Ativado")]
        public bool Ativado
        {
            get { return ativado; }
            set
            {
                ativado = value;
                chk_action.Checked = ativado;
            }
        }

        #endregion

        #region metodos
        
        #endregion

        #region eventos

        private void inicializar()
        {
            this.Size = new System.Drawing.Size(300, 23);
            chk_action.Checked = ativado;
        }

        private void chk_action_CheckedChanged(object sender, EventArgs e)
        {
            ativado = chk_action.Checked;
        }

        #endregion
    }
}
