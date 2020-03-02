namespace CoreFramework.Controles.Controle
{
    partial class TitleBlockExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBlockExtends));
            this.pnl_action = new System.Windows.Forms.Panel();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.pcb_action = new System.Windows.Forms.PictureBox();
            this.pnl_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_action.Controls.Add(this.lbl_mensagem);
            this.pnl_action.Controls.Add(this.pcb_action);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(230, 37);
            this.pnl_action.TabIndex = 0;
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mensagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_mensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensagem.Location = new System.Drawing.Point(32, 0);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(198, 37);
            this.lbl_mensagem.TabIndex = 5;
            this.lbl_mensagem.Text = "Caption";
            this.lbl_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcb_action
            // 
            this.pcb_action.BackColor = System.Drawing.Color.Transparent;
            this.pcb_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcb_action.Image = ((System.Drawing.Image)(resources.GetObject("pcb_action.Image")));
            this.pcb_action.Location = new System.Drawing.Point(0, 0);
            this.pcb_action.Name = "pcb_action";
            this.pcb_action.Size = new System.Drawing.Size(32, 37);
            this.pcb_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_action.TabIndex = 3;
            this.pcb_action.TabStop = false;
            // 
            // TitleBlockExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_action);
            this.Name = "TitleBlockExtends";
            this.Size = new System.Drawing.Size(230, 37);
            this.pnl_action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.PictureBox pcb_action;
        private System.Windows.Forms.Label lbl_mensagem;
    }
}
