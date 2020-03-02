namespace CoreFramework.Controles.Controle
{
    partial class ImageButtonExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageButtonExtends));
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pct_action = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_action)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_descricao.Location = new System.Drawing.Point(60, 26);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(243, 32);
            this.lbl_descricao.TabIndex = 5;
            this.lbl_descricao.Text = "Subtitulo";
            this.lbl_descricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(60, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(243, 26);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Titulo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pct_action
            // 
            this.pct_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.pct_action.Image = ((System.Drawing.Image)(resources.GetObject("pct_action.Image")));
            this.pct_action.Location = new System.Drawing.Point(0, 0);
            this.pct_action.Name = "pct_action";
            this.pct_action.Size = new System.Drawing.Size(60, 58);
            this.pct_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_action.TabIndex = 3;
            this.pct_action.TabStop = false;
            // 
            // ImageButtonExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pct_action);
            this.Name = "ImageButtonExtends";
            this.Size = new System.Drawing.Size(303, 58);
            ((System.ComponentModel.ISupportInitialize)(this.pct_action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pct_action;
    }
}
