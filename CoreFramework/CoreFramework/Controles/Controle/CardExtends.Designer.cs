namespace CoreFramework.Controles.Controle
{
    partial class CardExtends
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
            this.sts_action = new System.Windows.Forms.StatusStrip();
            this.tss_action = new System.Windows.Forms.ToolStripStatusLabel();
            this.sts_action.SuspendLayout();
            this.SuspendLayout();
            // 
            // sts_action
            // 
            this.sts_action.BackColor = System.Drawing.Color.LightSlateGray;
            this.sts_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_action});
            this.sts_action.Location = new System.Drawing.Point(0, 257);
            this.sts_action.Name = "sts_action";
            this.sts_action.Size = new System.Drawing.Size(453, 22);
            this.sts_action.TabIndex = 1;
            this.sts_action.Text = "statusStrip1";
            // 
            // tss_action
            // 
            this.tss_action.Name = "tss_action";
            this.tss_action.Size = new System.Drawing.Size(66, 17);
            this.tss_action.Text = "Mensagem";
            // 
            // CardExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sts_action);
            this.Name = "CardExtends";
            this.Size = new System.Drawing.Size(453, 279);
            this.sts_action.ResumeLayout(false);
            this.sts_action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts_action;
        private System.Windows.Forms.ToolStripStatusLabel tss_action;
    }
}
