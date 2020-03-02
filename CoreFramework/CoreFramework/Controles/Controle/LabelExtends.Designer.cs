namespace CoreFramework.Controles.Controle
{
    partial class LabelExtends
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(46, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_valor
            // 
            this.lbl_valor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_valor.Location = new System.Drawing.Point(46, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_valor.Size = new System.Drawing.Size(104, 23);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "Valor";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "LabelExtends";
            this.Size = new System.Drawing.Size(150, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_valor;
    }
}
