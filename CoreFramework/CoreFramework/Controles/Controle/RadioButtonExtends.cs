using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public partial class RadioButtonExtends :ChooseControlBase
    {
        private Enums.TipoControle tipoControle = Enums.TipoControle.Edicao;
        RadioButton rbt_action = new RadioButton();
        TextBox tbx_action = new TextBox();
        private bool obrigatorio = false;

        public RadioButtonExtends()
        {
            inicializar();
            this.Size = new Size(180, 23);
            atualizar();
        }

        #region Propriedades

        //[Browsable(false)]
        //public Enums.TipoControle TipoControle
        //{
        //    get
        //    {
        //        return tipoControle;
        //    }
        //}

        [Category("Custom")]
        [Description("Tamanho do controle")]
        public int Tamanho
        {
            get
            {
                return this.Width;
            }

            set
            {
                this.Width = value;
            }
        }

        [Category("Custom")]
        [Description("Texto da label")]
        public String Titulo
        {
            get
            {
                return this.rbt_action.Text;
            }

            set
            {
                this.rbt_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return this.tbx_action.Size.Width;
            }

            set
            {
                this.tbx_action.Size = new System.Drawing.Size(value, 23);
            }
        }

        [Category("Custom")]
        [Description("Verifica se o campo é obrigatorio")]
        public bool Obrigatorio
        {
            get { return obrigatorio; }
            set
            {
                obrigatorio = value;
                if (obrigatorio)
                {
                    this.tbx_action.BackColor = SystemColors.Info;
                    this.rbt_action.ForeColor = SystemColors.HotTrack;
                    this.rbt_action.Text += "*";
                }
                else
                {
                    this.tbx_action.BackColor = SystemColors.Window;
                    this.rbt_action.ForeColor = SystemColors.ControlText;
                    this.rbt_action.Text = rbt_action.Text.Replace("*", "");
                }
            }
        }

        [Category("Custom")]
        [Description("Valor do combo")]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public String Valor
        {
            get
            {
                return this.tbx_action.Text;
            }
            private set { this.tbx_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Valor do radiobox")]
        public bool Ativado
        {
            get
            {
                return this.rbt_action.Checked;
            }
            set
            {
                this.rbt_action.Checked = value;
            }
        }

        #endregion

        #region Metodos

        private void inicializar()
        {
            rbt_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            rbt_action.Text = "Radio";
            rbt_action.AutoSize = true;
            rbt_action.Location = new Point(2, 1);

            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Dock = DockStyle.Right;
            tbx_action.GotFocus += onFocus;
            tbx_action.LostFocus += onDefocus;

            this.Controls.Add(rbt_action);
            this.Controls.Add(tbx_action);
        }

        private void atualizar()
        {
            tbx_action.Size = new Size(this.TamanhoTexto, 23);
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        #endregion

        #region eventos

        private void onFocus(object sender, EventArgs e)
        {
            this.tbx_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void onDefocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.tbx_action.BackColor = SystemColors.Info;
            else
                this.tbx_action.BackColor = SystemColors.Window;
        }

        #endregion
    }
}
