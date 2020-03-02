namespace CoreFramework.Controles.Controle
{
    partial class MessageButtonExtends
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
            this.lbl_action = new System.Windows.Forms.Label();
            this.pcb_action = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).BeginInit();
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
            this.btn_action.TabIndex = 5;
            this.btn_action.Text = "Botao";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_action.Location = new System.Drawing.Point(31, 4);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(65, 17);
            this.lbl_action.TabIndex = 4;
            this.lbl_action.Text = "Message";
            this.lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcb_action
            // 
            this.pcb_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcb_action.Image = global::CoreFramework.Properties.Resources.acrescimo;
            this.pcb_action.Location = new System.Drawing.Point(0, 0);
            this.pcb_action.Name = "pcb_action";
            this.pcb_action.Size = new System.Drawing.Size(26, 25);
            this.pcb_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_action.TabIndex = 3;
            this.pcb_action.TabStop = false;
            // 
            // MessageButtonExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.lbl_action);
            this.Controls.Add(this.pcb_action);
            this.Name = "MessageButtonExtends";
            this.Size = new System.Drawing.Size(220, 25);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_action)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Label lbl_action;
        private System.Windows.Forms.PictureBox pcb_action;
    }
}
