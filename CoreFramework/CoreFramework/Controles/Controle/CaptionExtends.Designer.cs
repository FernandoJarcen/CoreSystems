namespace CoreFramework.Controles.Controle
{
    partial class CaptionExtends
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptionExtends));
            this.pnl_action = new System.Windows.Forms.Panel();
            this.lbl_principal = new System.Windows.Forms.Label();
            this.pcb_action = new System.Windows.Forms.PictureBox();
            this.lbl_referencia = new System.Windows.Forms.Label();
            this.pnl_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.Controls.Add(this.pcb_action);
            this.pnl_action.Controls.Add(this.lbl_referencia);
            this.pnl_action.Controls.Add(this.lbl_principal);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(598, 62);
            this.pnl_action.TabIndex = 0;
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_principal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_principal.Location = new System.Drawing.Point(56, 9);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(70, 26);
            this.lbl_principal.TabIndex = 21;
            this.lbl_principal.Text = "Título";
            // 
            // pcb_action
            // 
            this.pcb_action.BackColor = System.Drawing.Color.Transparent;
            this.pcb_action.Image = ((System.Drawing.Image)(resources.GetObject("pcb_action.Image")));
            this.pcb_action.Location = new System.Drawing.Point(7, 6);
            this.pcb_action.Name = "pcb_action";
            this.pcb_action.Size = new System.Drawing.Size(48, 50);
            this.pcb_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_action.TabIndex = 23;
            this.pcb_action.TabStop = false;
            // 
            // lbl_referencia
            // 
            this.lbl_referencia.AutoSize = true;
            this.lbl_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_referencia.Location = new System.Drawing.Point(59, 37);
            this.lbl_referencia.Name = "lbl_referencia";
            this.lbl_referencia.Size = new System.Drawing.Size(63, 17);
            this.lbl_referencia.TabIndex = 22;
            this.lbl_referencia.Text = "Subtítulo";
            // 
            // CaptionExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.pnl_action);
            this.Name = "CaptionExtends";
            this.Size = new System.Drawing.Size(598, 62);
            this.Load += new System.EventHandler(this.CaptionExtends_Load);
            this.Resize += new System.EventHandler(this.CaptionExtends_Resize);
            this.pnl_action.ResumeLayout(false);
            this.pnl_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.PictureBox pcb_action;
        private System.Windows.Forms.Label lbl_referencia;
        private System.Windows.Forms.Label lbl_principal;

    }
}
