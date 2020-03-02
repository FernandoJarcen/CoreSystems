using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public class InfoExtends : Panel
    {
        Label lbl_cabecalho = new Label();
        Label lbl_informacao = new Label();

        #region Propriedades

        [Category("Custom")]
        [Description("Texto do cabecalho do controle")]
        public string Cabecalho
        {
            get
            {
                return lbl_cabecalho.Text;
            }
            set
            {
                lbl_cabecalho.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Texto da mensagem")]
        public string Mensagem
        {
            get
            {
                return lbl_informacao.Text;
            }
            set
            {
                lbl_informacao.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Cabecalho em negrito")]
        public bool MostrarNegrito
        {
            get
            {
                return lbl_cabecalho.Font.Bold;
            }
            set
            {
                if (value)
                    lbl_cabecalho.Font = new Font("Timew New Roman", 16F, FontStyle.Bold);
                else
                    lbl_cabecalho.Font = new Font("Timew New Roman", 16F, FontStyle.Regular);
            }
        }

        #endregion

        #region metodos
        
        #endregion

        #region Eventos

        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            var painel = this;
            painel.BackColor = SystemColors.Info;

            int largura = Convert.ToInt32(painel.Size.Width) - 10;
            int altura = Convert.ToInt32(painel.Size.Height) - 10;
            var cabecalho = this.lbl_cabecalho;
            cabecalho.Location = new Point(1, 3);
            cabecalho.AutoSize = true;
            cabecalho.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);

            var informacao = this.lbl_informacao;
            informacao.Size = new Size(largura, altura);
            informacao.Location = new Point(5, 35);
            informacao.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);

            this.Controls.Add(lbl_cabecalho);
            this.Controls.Add(lbl_informacao);
        }
    }

}
