using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using enm = CoreFramework.Objetos.Enums;

namespace CoreFramework.Controles.Controle
{
    public class TabViewExtends:TabControl
    {
        private enm.TipoControle tipoControle = enm.TipoControle.SuperContainer;

        [Browsable(true)]
        public enm.TipoControle TipoControle
        {
            get
            {
                return tipoControle;
            }

        }
        public TabViewExtends()
        {
            inicializar();
        }

        private void inicializar()
        {
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new System.Drawing.Size(96, 25);
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
        }

        public void inserirTab(string nome, TabPage tabpage)
        {
            int quantidade = 0;

            if (!verificaTab(nome))
            {
                quantidade = 1;
                this.TabPages.Insert(quantidade, tabpage);
            }
        }

        public void removerTab(TabPage tabpage)
        {
            this.TabPages.Remove(tabpage);
        }

        private bool verificaTab(string nome)
        {
            bool retorno = false;
            for (int indice = 0; indice < this.TabPages.Count; indice++)
            {
                if (this.TabPages[indice].Text == nome)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}
