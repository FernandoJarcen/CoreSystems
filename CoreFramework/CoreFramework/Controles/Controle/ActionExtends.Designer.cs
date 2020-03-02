namespace CoreFramework.Controles.Controle
{
    partial class ActionExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionExtends));
            this.pnl_action = new System.Windows.Forms.Panel();
            this.pcb_fechar = new System.Windows.Forms.PictureBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.pcb_action = new System.Windows.Forms.PictureBox();
            this.pnl_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_action.Controls.Add(this.pcb_fechar);
            this.pnl_action.Controls.Add(this.lbl_message);
            this.pnl_action.Controls.Add(this.pcb_action);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(384, 22);
            this.pnl_action.TabIndex = 2;
            // 
            // pcb_fechar
            // 
            this.pcb_fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcb_fechar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_fechar.Image")));
            this.pcb_fechar.Location = new System.Drawing.Point(367, 0);
            this.pcb_fechar.Name = "pcb_fechar";
            this.pcb_fechar.Size = new System.Drawing.Size(17, 22);
            this.pcb_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_fechar.TabIndex = 2;
            this.pcb_fechar.TabStop = false;
            this.pcb_fechar.Click += new System.EventHandler(this.pcb_fechar_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_message.Location = new System.Drawing.Point(25, 2);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(57, 17);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Text = "Label1";
            // 
            // pcb_action
            // 
            this.pcb_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcb_action.Image = ((System.Drawing.Image)(resources.GetObject("pcb_action.Image")));
            this.pcb_action.Location = new System.Drawing.Point(0, 0);
            this.pcb_action.Name = "pcb_action";
            this.pcb_action.Size = new System.Drawing.Size(21, 22);
            this.pcb_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_action.TabIndex = 0;
            this.pcb_action.TabStop = false;
            // 
            // ActionExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_action);
            this.Name = "ActionExtends";
            this.Size = new System.Drawing.Size(384, 22);
            this.pnl_action.ResumeLayout(false);
            this.pnl_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.PictureBox pcb_fechar;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.PictureBox pcb_action;
    }
}
