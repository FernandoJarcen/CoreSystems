namespace CoreFramework.Controles.Controle
{
    partial class TaskItemExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskItemExtends));
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pct_action = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_action)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_subtitulo.Location = new System.Drawing.Point(59, 27);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(283, 28);
            this.lbl_subtitulo.TabIndex = 11;
            this.lbl_subtitulo.Text = "Subtitulo";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(59, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(283, 18);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "Titulo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(49, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 55);
            this.panel1.TabIndex = 9;
            // 
            // pct_action
            // 
            this.pct_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.pct_action.Image = ((System.Drawing.Image)(resources.GetObject("pct_action.Image")));
            this.pct_action.Location = new System.Drawing.Point(0, 0);
            this.pct_action.Name = "pct_action";
            this.pct_action.Size = new System.Drawing.Size(49, 55);
            this.pct_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_action.TabIndex = 8;
            this.pct_action.TabStop = false;
            // 
            // TaskItemExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pct_action);
            this.Name = "TaskItemExtends";
            this.Size = new System.Drawing.Size(342, 55);
            ((System.ComponentModel.ISupportInitialize)(this.pct_action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pct_action;
    }
}
