namespace CoreFramework.Controles.Controle
{
    partial class ResultExtends
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
            this.tbl_container = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.tbl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_container
            // 
            this.tbl_container.ColumnCount = 2;
            this.tbl_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_container.Controls.Add(this.lbl_titulo, 0, 0);
            this.tbl_container.Controls.Add(this.lbl_valor, 1, 0);
            this.tbl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_container.Location = new System.Drawing.Point(0, 0);
            this.tbl_container.Name = "tbl_container";
            this.tbl_container.RowCount = 1;
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tbl_container.Size = new System.Drawing.Size(324, 23);
            this.tbl_container.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_titulo.Location = new System.Drawing.Point(3, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(72, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Somatório";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_valor.Location = new System.Drawing.Point(81, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(28, 23);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "0,0";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_valor.TextChanged += new System.EventHandler(this.lbl_valor_TextChanged);
            // 
            // ResultExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbl_container);
            this.Name = "ResultExtends";
            this.Size = new System.Drawing.Size(324, 23);
            this.tbl_container.ResumeLayout(false);
            this.tbl_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_container;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_valor;
    }
}
