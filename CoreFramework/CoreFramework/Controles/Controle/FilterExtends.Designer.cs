namespace CoreFramework.Controles.Controle
{
    partial class FilterExtends
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
            this.chk_action = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chk_action
            // 
            this.chk_action.AutoSize = true;
            this.chk_action.Checked = true;
            this.chk_action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_action.Location = new System.Drawing.Point(0, 0);
            this.chk_action.Name = "chk_action";
            this.chk_action.Size = new System.Drawing.Size(58, 25);
            this.chk_action.TabIndex = 1;
            this.chk_action.Text = "Filter";
            this.chk_action.UseVisualStyleBackColor = true;
            this.chk_action.CheckedChanged += new System.EventHandler(this.chk_action_CheckedChanged);
            // 
            // FilterExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_action);
            this.Name = "FilterExtends";
            this.Size = new System.Drawing.Size(300, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_action;
    }
}
