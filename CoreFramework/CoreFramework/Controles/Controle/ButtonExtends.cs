using CoreFramework.Controles.Controle.Interfaces;
using CoreFramework.Objetos;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public class ButtonExtends : Button
    {
        private CoreFramework.Objetos.Enums.TipoControle tipoControle = Enums.TipoControle.Acao;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            inicializar();
        }

        [Browsable(true)]
        public CoreFramework.Objetos.Enums.TipoControle TipoControle
        {
            get
            {
                return tipoControle;
            }
        }

        private void inicializar()
        {
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.FlatAppearance.BorderSize = 1;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(110, 35);
            //Invalidate();

        }

    }
}
