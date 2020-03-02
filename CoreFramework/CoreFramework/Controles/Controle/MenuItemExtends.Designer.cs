namespace CoreFramework.Controles.Controle
{
    partial class MenuItemExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItemExtends));
            this.btn_action = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_action.FlatAppearance.BorderSize = 0;
            this.btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_action.Image = ((System.Drawing.Image)(resources.GetObject("btn_action.Image")));
            this.btn_action.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_action.Location = new System.Drawing.Point(0, 0);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(76, 65);
            this.btn_action.TabIndex = 1;
            this.btn_action.Text = "Item";
            this.btn_action.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_action.UseVisualStyleBackColor = false;
            // 
            // MenuItemExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_action);
            this.Name = "MenuItemExtends";
            this.Size = new System.Drawing.Size(76, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_action;
    }
}
