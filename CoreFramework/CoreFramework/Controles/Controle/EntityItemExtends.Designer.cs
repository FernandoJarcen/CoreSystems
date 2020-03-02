namespace CoreFramework.Controles.Controle
{
    partial class EntityItemExtends
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
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_item.Location = new System.Drawing.Point(98, 0);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(99, 23);
            this.lbl_item.TabIndex = 3;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_valor
            // 
            this.lbl_valor.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_valor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_valor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_valor.Location = new System.Drawing.Point(0, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(98, 23);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntityItemExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.lbl_valor);
            this.Name = "EntityItemExtends";
            this.Size = new System.Drawing.Size(197, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_valor;
    }
}
