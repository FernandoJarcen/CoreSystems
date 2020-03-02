namespace CoreFramework.Controles.Controle
{
    partial class DivisionBarExtends
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
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(150, 25);
            this.pnl_action.TabIndex = 0;
            // 
            // DivisionBarExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_action);
            this.Name = "DivisionBarExtends";
            this.Size = new System.Drawing.Size(150, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
    }
}
