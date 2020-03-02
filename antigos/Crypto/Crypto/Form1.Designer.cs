namespace Crypto
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_de = new System.Windows.Forms.TextBox();
            this.btn_criptografar = new System.Windows.Forms.Button();
            this.tbx_para = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_de
            // 
            this.tbx_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_de.Location = new System.Drawing.Point(13, 13);
            this.tbx_de.Name = "tbx_de";
            this.tbx_de.Size = new System.Drawing.Size(358, 26);
            this.tbx_de.TabIndex = 0;
            // 
            // btn_criptografar
            // 
            this.btn_criptografar.Location = new System.Drawing.Point(12, 77);
            this.btn_criptografar.Name = "btn_criptografar";
            this.btn_criptografar.Size = new System.Drawing.Size(88, 23);
            this.btn_criptografar.TabIndex = 1;
            this.btn_criptografar.Text = "criptografar";
            this.btn_criptografar.UseVisualStyleBackColor = true;
            this.btn_criptografar.Click += new System.EventHandler(this.btn_criptografar_Click);
            // 
            // tbx_para
            // 
            this.tbx_para.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_para.Location = new System.Drawing.Point(13, 45);
            this.tbx_para.Name = "tbx_para";
            this.tbx_para.Size = new System.Drawing.Size(358, 26);
            this.tbx_para.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "descriptografar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 109);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_para);
            this.Controls.Add(this.btn_criptografar);
            this.Controls.Add(this.tbx_de);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_de;
        private System.Windows.Forms.Button btn_criptografar;
        private System.Windows.Forms.TextBox tbx_para;
        private System.Windows.Forms.Button button1;
    }
}

