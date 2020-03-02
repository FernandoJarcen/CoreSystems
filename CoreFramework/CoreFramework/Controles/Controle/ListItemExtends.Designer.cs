namespace CoreFramework.Controles.Controle
{
    partial class ListItemExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItemExtends));
            this.lbl_action = new System.Windows.Forms.Label();
            this.pct_action = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_action)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_action
            // 
            this.lbl_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_action.Location = new System.Drawing.Point(30, 0);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(312, 52);
            this.lbl_action.TabIndex = 3;
            this.lbl_action.Text = "label1";
            this.lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pct_action
            // 
            this.pct_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.pct_action.Image = ((System.Drawing.Image)(resources.GetObject("pct_action.Image")));
            this.pct_action.Location = new System.Drawing.Point(0, 0);
            this.pct_action.Name = "pct_action";
            this.pct_action.Size = new System.Drawing.Size(30, 52);
            this.pct_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_action.TabIndex = 2;
            this.pct_action.TabStop = false;
            // 
            // ListItemExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_action);
            this.Controls.Add(this.pct_action);
            this.Name = "ListItemExtends";
            this.Size = new System.Drawing.Size(342, 52);
            ((System.ComponentModel.ISupportInitialize)(this.pct_action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_action;
        private System.Windows.Forms.PictureBox pct_action;
    }
}
