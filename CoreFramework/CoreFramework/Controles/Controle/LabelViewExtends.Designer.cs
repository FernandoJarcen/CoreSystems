namespace CoreFramework.Controles.Controle
{
    partial class LabelViewExtends
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
            this.tlp_action = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.tlp_action.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_action
            // 
            this.tlp_action.ColumnCount = 2;
            this.tlp_action.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlp_action.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tlp_action.Controls.Add(this.lbl_titulo, 0, 0);
            this.tlp_action.Controls.Add(this.lbl_valor, 1, 0);
            this.tlp_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_action.Location = new System.Drawing.Point(0, 0);
            this.tlp_action.Margin = new System.Windows.Forms.Padding(4);
            this.tlp_action.Name = "tlp_action";
            this.tlp_action.RowCount = 1;
            this.tlp_action.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_action.Size = new System.Drawing.Size(304, 23);
            this.tlp_action.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_titulo.Location = new System.Drawing.Point(4, 0);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(87, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_valor
            // 
            this.lbl_valor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_valor.Location = new System.Drawing.Point(99, 0);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(201, 23);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "0";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelViewExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_action);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LabelViewExtends";
            this.Size = new System.Drawing.Size(304, 23);
            this.tlp_action.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_action;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_valor;
    }
}
