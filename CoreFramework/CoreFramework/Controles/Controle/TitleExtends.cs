using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public class TitleExtends:ToolStrip
    {
        public event EventHandler AoClicar;
        ToolStripLabel tsl_action = new ToolStripLabel();
        ToolStripButton tsb_action = new ToolStripButton();
        ToolStripButton tsb_fechar = new ToolStripButton();
        class CustomProfessionalColors : ProfessionalColorTable
        {
            public override Color ToolStripGradientBegin
            { get { return SystemColors.GradientInactiveCaption; } }

            public override Color ToolStripGradientMiddle
            { get { return SystemColors.GradientActiveCaption; } }

            public override Color ToolStripGradientEnd
            { get { return SystemColors.GradientActiveCaption; } }
        }

        public TitleExtends()
        {
            Inicializar();
        }

        #region propriedades

        [Category("Custom")]
        public String Valor
        {
            get { return tsl_action.Text; }
            set
            {
                tsl_action.Text = value;
            }
        }

        [Category("Custom")]
        [DefaultValue(true)]
        public bool MostrarFechar
        {
            get { return tsb_fechar.Visible; }
            set
            {
                tsb_fechar.Visible = value;
            }
        }


        #endregion

        #region Metodos

        private void Inicializar()
        {
            this.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
            tsl_action.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tsl_action.ForeColor = System.Drawing.SystemColors.HotTrack;
            tsl_action.Size = new System.Drawing.Size(233, 25);
            tsl_action.Text = "TitleExtends";

            tsb_fechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsb_fechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsb_fechar.Image = CoreFramework.Properties.Resources.cancel;
            tsb_fechar.ImageTransparentColor = System.Drawing.Color.White;
            tsb_fechar.Name = "btn_fechar";
            tsb_fechar.Size = new System.Drawing.Size(23, 22);
            tsb_fechar.Text = "fechar janela";
            tsb_fechar.Click += tsb_fechar_Click;

            tsb_action.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsb_action.Image = CoreFramework.Properties.Resources.hierarchytoolbar;
            tsb_action.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsb_action.Size = new System.Drawing.Size(23, 25);

            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                tsb_fechar,
                tsb_action,
                this.tsl_action});

        }

        #endregion

        #region Eventos

        private void tsb_fechar_Click(object sender, EventArgs e)
        {
            if (this.AoClicar != null)
            {
                this.AoClicar(this, e);
            }
            var lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Close();
        }

        #endregion

    }
}
