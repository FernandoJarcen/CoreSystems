using CoreStudio.Controles.Global;
using CoreStudio.Objetos;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreStudio.Controles.Controle
{
    public class ButtonExtends:Button
    {
        Enums.EnumCores _cor = Enums.EnumCores.FacebookBlue;
        System.Windows.Forms.FlatStyle _tipoBorda = FlatStyle.Flat;
        int _tamanhoBorda = 0;

        #region campos
        
        [Category("Custom")]
        [Description("Cor do Botão")]
        public Enums.EnumCores Cor
        {
            get { return _cor; }
            set
            {
                _cor = value;
                this.BackColor = GlobalColor.Cor(_cor);
            }
        }

        [Category("Custom")]
        public System.Windows.Forms.FlatStyle TipoBorda
        {
            get { return _tipoBorda; }
            set {
                _tipoBorda = value;
                this.FlatStyle = _tipoBorda; 
            }
        }

        [Category("Custom")]
        public int TamanhoBorda
        {
            get { return _tamanhoBorda; }
            set
            {
                _tamanhoBorda = value;
                this.FlatAppearance.BorderSize = _tamanhoBorda;
            }
        }

        #endregion

        protected override void OnCreateControl()
        {
            this.FlatStyle = _tipoBorda;
            this.FlatAppearance.BorderSize = _tamanhoBorda;
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
        }
    }
}
