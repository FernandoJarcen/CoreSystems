namespace CoreFramework.Controles.Controle
{
    partial class MessageExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageExtends));
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.pbx_titulo = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_titulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_superior.Controls.Add(this.pbx_titulo);
            this.pnl_superior.Controls.Add(this.lbl_titulo);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(220, 35);
            this.pnl_superior.TabIndex = 5;
            // 
            // pbx_titulo
            // 
            this.pbx_titulo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_titulo.Image")));
            this.pbx_titulo.Location = new System.Drawing.Point(3, 5);
            this.pbx_titulo.Name = "pbx_titulo";
            this.pbx_titulo.Size = new System.Drawing.Size(23, 26);
            this.pbx_titulo.TabIndex = 0;
            this.pbx_titulo.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(32, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(64, 26);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Titulo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbl_mensagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 115);
            this.panel1.TabIndex = 6;
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_mensagem.Location = new System.Drawing.Point(9, 9);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(202, 97);
            this.lbl_mensagem.TabIndex = 3;
            this.lbl_mensagem.Text = "Mensagem";
            // 
            // MessageExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_superior);
            this.Name = "MessageExtends";
            this.Size = new System.Drawing.Size(220, 150);
            this.SizeChanged += new System.EventHandler(this.MessageExtends_SizeChanged);
            this.pnl_superior.ResumeLayout(false);
            this.pnl_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_titulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.PictureBox pbx_titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_mensagem;
    }
}
