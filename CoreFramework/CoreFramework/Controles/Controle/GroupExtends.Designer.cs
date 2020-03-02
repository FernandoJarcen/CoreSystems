namespace CoreFramework.Controles.Controle
{
    partial class GroupExtends
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
            this.pnl_action = new System.Windows.Forms.Panel();
            this.cbx_action = new System.Windows.Forms.CheckBox();
            this.pnl_action.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_action.Controls.Add(this.cbx_action);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(320, 37);
            this.pnl_action.TabIndex = 1;
            // 
            // cbx_action
            // 
            this.cbx_action.AutoSize = true;
            this.cbx_action.Checked = true;
            this.cbx_action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbx_action.Location = new System.Drawing.Point(12, 8);
            this.cbx_action.Name = "cbx_action";
            this.cbx_action.Size = new System.Drawing.Size(96, 21);
            this.cbx_action.TabIndex = 0;
            this.cbx_action.Text = "Mensagem";
            this.cbx_action.UseVisualStyleBackColor = true;
            this.cbx_action.CheckedChanged += new System.EventHandler(this.cbx_action_CheckedChanged);
            // 
            // GroupExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Borda = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_action);
            this.Name = "GroupExtends";
            this.Size = new System.Drawing.Size(320, 165);
            this.pnl_action.ResumeLayout(false);
            this.pnl_action.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.CheckBox cbx_action;
    }
}
