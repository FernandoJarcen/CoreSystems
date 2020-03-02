namespace CoreFramework.Controles.Controle
{
    partial class MessageCheckExtends
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
            this.btn_action = new System.Windows.Forms.Button();
            this.chk_action = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_action
            // 
            this.btn_action.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_action.Location = new System.Drawing.Point(145, 0);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(75, 25);
            this.btn_action.TabIndex = 3;
            this.btn_action.Text = "Botão";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // chk_action
            // 
            this.chk_action.AutoSize = true;
            this.chk_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_action.Location = new System.Drawing.Point(0, 0);
            this.chk_action.Name = "chk_action";
            this.chk_action.Size = new System.Drawing.Size(84, 25);
            this.chk_action.TabIndex = 2;
            this.chk_action.Text = "Message";
            this.chk_action.UseVisualStyleBackColor = true;
            this.chk_action.CheckedChanged += new System.EventHandler(this.chk_action_CheckedChanged);
            // 
            // MessageCheckExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.chk_action);
            this.Name = "MessageCheckExtends";
            this.Size = new System.Drawing.Size(220, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.CheckBox chk_action;
    }
}
