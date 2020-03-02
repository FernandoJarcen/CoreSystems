namespace CoreFramework.Controles.Controle
{
    partial class ListSearchExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSearchExtends));
            this.pnl_action = new System.Windows.Forms.Panel();
            this.pcb_action = new System.Windows.Forms.PictureBox();
            this.lbl_action = new System.Windows.Forms.Label();
            this.tbx_action = new System.Windows.Forms.TextBox();
            this.lbx_action = new System.Windows.Forms.ListBox();
            this.pnl_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_action.Controls.Add(this.pcb_action);
            this.pnl_action.Controls.Add(this.lbl_action);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(243, 42);
            this.pnl_action.TabIndex = 4;
            // 
            // pcb_action
            // 
            this.pcb_action.Image = ((System.Drawing.Image)(resources.GetObject("pcb_action.Image")));
            this.pcb_action.Location = new System.Drawing.Point(7, 4);
            this.pcb_action.Name = "pcb_action";
            this.pcb_action.Size = new System.Drawing.Size(34, 33);
            this.pcb_action.TabIndex = 2;
            this.pcb_action.TabStop = false;
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_action.Location = new System.Drawing.Point(47, 13);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(85, 17);
            this.lbl_action.TabIndex = 1;
            this.lbl_action.Text = "ListSearch";
            // 
            // tbx_action
            // 
            this.tbx_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_action.Location = new System.Drawing.Point(7, 48);
            this.tbx_action.Name = "tbx_action";
            this.tbx_action.Size = new System.Drawing.Size(229, 23);
            this.tbx_action.TabIndex = 5;
            // 
            // lbx_action
            // 
            this.lbx_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbx_action.FormattingEnabled = true;
            this.lbx_action.ItemHeight = 16;
            this.lbx_action.Location = new System.Drawing.Point(7, 78);
            this.lbx_action.Name = "lbx_action";
            this.lbx_action.Size = new System.Drawing.Size(229, 196);
            this.lbx_action.TabIndex = 6;
            // 
            // ListSearchExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.lbx_action);
            this.Controls.Add(this.tbx_action);
            this.Controls.Add(this.pnl_action);
            this.Name = "ListSearchExtends";
            this.Size = new System.Drawing.Size(243, 282);
            this.SizeChanged += new System.EventHandler(this.ListSearchExtends_SizeChanged);
            this.pnl_action.ResumeLayout(false);
            this.pnl_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.PictureBox pcb_action;
        private System.Windows.Forms.Label lbl_action;
        private System.Windows.Forms.TextBox tbx_action;
        private System.Windows.Forms.ListBox lbx_action;

    }
}
