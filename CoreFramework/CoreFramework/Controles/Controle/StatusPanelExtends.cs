using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace CoreFramework.Controles.Controle
{
    public class StatusPanelExtends : TabControl
    {
        private string value;
        private string[] myValues;
        private string selecionado = string.Empty;
        private Int32 seleciona = 0;

        #region Propriedades

        internal string[] Values
        {
            get { return this.myValues; }
        }

        [Category("Custom")]
        [Description("Controle ativado")]
        [TypeConverter(typeof(ValueTypeConverter))]
        public string Selecionado
        {
            get { return this.value; }
            set
            {
                this.value = value;
                selecionado = this.value;
                //if (DesignMode)
                //{
                seleciona = SelecionaPages(this, selecionado);
                this.SelectedTab = this.TabPages[seleciona];
                this.Invalidate();
                //}
            }
        }

        #endregion

        #region Metodos

        public string[] ListaPages(TabControl controle)
        {
            int tabs = controle.TabPages.Count;
            string[] colecao = new string[tabs];

            for (int indice1 = 0; indice1 < tabs; indice1++)
            {
                colecao[indice1] = controle.TabPages[indice1].Name;
            }
            return colecao;
        }

        public System.Int32 SelecionaPages(TabControl controle, string busca)
        {
            int tabs = controle.TabPages.Count;
            int retorno = 0;
            for (int indice1 = 0; indice1 < tabs; indice1++)
            {
                if (controle.TabPages[indice1].Name == busca)
                {
                    retorno = indice1;
                    break;
                }
            }
            return retorno;
        }

        #endregion

        #region Eventos

        protected override Control.ControlCollection CreateControlsInstance()
        {
            this.myValues = ListaPages(this);
            if (DesignMode)
            {
                this.Invalidate();
            }

            return base.CreateControlsInstance();
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            this.myValues = ListaPages(this);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            this.myValues = ListaPages(this);
        }

        #endregion

        public StatusPanelExtends()
        {
            this.Size = new Size(400, 100);
            this.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
        }
    }

    class ValueTypeConverter : TypeConverter
    {
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            string[] myValues = (context.Instance as StatusPanelExtends).Values;
            return new StandardValuesCollection(myValues);
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}
