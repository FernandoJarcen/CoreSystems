using System.ComponentModel;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public class TabGridExtends:Panel
    {
        Panel pnl_action = new System.Windows.Forms.Panel();
        Label lbl_action = new System.Windows.Forms.Label();
        StatusStrip sts_action = new System.Windows.Forms.StatusStrip();
        ToolStripStatusLabel tss_action = new System.Windows.Forms.ToolStripStatusLabel();
        bool rodape = true;

        #region propriedades

        [Category("Custom")]
        [Description("Titulo do controle")]
        public string Cabecalho
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Mostra rodape")]
        public bool MostraRodape
        {
            get { return rodape; }
            set
            {
                rodape = value;
                if (!rodape)
                    sts_action.Visible = false;
                else
                    sts_action.Visible = true;
            }
        }

        [Category("Custom")]
        [Description("Mensagem do rodape")]
        public string Rodape
        {
            get { return tss_action.Text; }
            set { tss_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do cabecalho")]
        public System.Drawing.Color CorCabecalho
        {
            get { return pnl_action.BackColor; }
            set { pnl_action.BackColor = value;  }
        }

        [Category("Custom")]
        [Description("Cor do rodapé")]
        public System.Drawing.Color CorRodape
        {
            get { return tss_action.BackColor; }
            set { tss_action.BackColor = value; }
        }
        #endregion

        #region metodos

        private void inicializar()
        {
            lbl_action.AutoSize = false;
            lbl_action.BackColor = System.Drawing.Color.Transparent;
            lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_action.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lbl_action.Text = "Titulo";
            lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            pnl_action.BackColor = CorCabecalho;
            pnl_action.Controls.Add(this.lbl_action);
            pnl_action.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_action.Location = new System.Drawing.Point(0, 0);
            pnl_action.Size = new System.Drawing.Size(368, 35);

            tss_action.Size = new System.Drawing.Size(118, 17);
            tss_action.Text = "Rodape";

            sts_action.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            sts_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                tss_action});
            sts_action.Location = new System.Drawing.Point(0, 225);
            sts_action.Size = new System.Drawing.Size(368, 22);
            sts_action.Text = "statusStrip1";


            this.Controls.Add(sts_action);
            this.Controls.Add(pnl_action);
        }

        #endregion
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            inicializar();
        }
    }
}
