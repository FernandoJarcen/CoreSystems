namespace CoreFramework.Controles.Controle
{
    partial class InfoGridExtends
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_action = new System.Windows.Forms.Panel();
            this.lbl_action = new System.Windows.Forms.Label();
            this.sst_action = new System.Windows.Forms.StatusStrip();
            this.tss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_action = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_mensagem = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.pnl_action.SuspendLayout();
            this.sst_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnl_action.Controls.Add(this.lbl_action);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(245, 26);
            this.pnl_action.TabIndex = 9;
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_action.Location = new System.Drawing.Point(4, 6);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(84, 17);
            this.lbl_action.TabIndex = 0;
            this.lbl_action.Text = "Cabecalho";
            // 
            // sst_action
            // 
            this.sst_action.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sst_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_status,
            this.tss_action});
            this.sst_action.Location = new System.Drawing.Point(0, 179);
            this.sst_action.Name = "sst_action";
            this.sst_action.Size = new System.Drawing.Size(245, 22);
            this.sst_action.TabIndex = 10;
            this.sst_action.Text = "statusStrip1";
            // 
            // tss_status
            // 
            this.tss_status.Name = "tss_status";
            this.tss_status.Size = new System.Drawing.Size(0, 17);
            // 
            // tss_action
            // 
            this.tss_action.Name = "tss_action";
            this.tss_action.Size = new System.Drawing.Size(66, 17);
            this.tss_action.Text = "Mensagem";
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AllowUserToAddRows = false;
            this.dgv_consulta.AllowUserToOrderColumns = true;
            this.dgv_consulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_consulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgv_mensagem});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_consulta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_consulta.EnableHeadersVisualStyles = false;
            this.dgv_consulta.Location = new System.Drawing.Point(0, 26);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.RowHeadersVisible = false;
            this.dgv_consulta.Size = new System.Drawing.Size(245, 153);
            this.dgv_consulta.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 5;
            // 
            // dgv_mensagem
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_mensagem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_mensagem.HeaderText = "Mensagem";
            this.dgv_mensagem.Name = "dgv_mensagem";
            this.dgv_mensagem.Width = 90;
            // 
            // InfoGridExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.sst_action);
            this.Controls.Add(this.pnl_action);
            this.Name = "InfoGridExtends";
            this.Size = new System.Drawing.Size(245, 201);
            this.Load += new System.EventHandler(this.InfoGridExtends_Load);
            this.pnl_action.ResumeLayout(false);
            this.pnl_action.PerformLayout();
            this.sst_action.ResumeLayout(false);
            this.sst_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.Label lbl_action;
        private System.Windows.Forms.StatusStrip sst_action;
        private System.Windows.Forms.ToolStripStatusLabel tss_status;
        private System.Windows.Forms.ToolStripStatusLabel tss_action;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn dgv_mensagem;
    }
}
