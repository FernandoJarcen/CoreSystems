namespace CoreFramework.Controles.Controle
{
    partial class ItemExtends
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
            this.lbl_action = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_action
            // 
            this.lbl_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_action.Image = global::CoreFramework.Properties.Resources.check;
            this.lbl_action.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_action.Location = new System.Drawing.Point(0, 0);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(150, 22);
            this.lbl_action.TabIndex = 6;
            this.lbl_action.Text = "Item";
            this.lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_action);
            this.Name = "ItemExtends";
            this.Size = new System.Drawing.Size(150, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_action;
    }
}
