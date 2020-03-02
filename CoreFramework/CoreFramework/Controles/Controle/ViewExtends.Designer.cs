namespace CoreFramework.Controles.Controle
{
    partial class ViewExtends
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExtends));
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sst_action = new System.Windows.Forms.StatusStrip();
            this.tss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_action = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_action = new System.Windows.Forms.ToolStripButton();
            this.tbs_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_busca = new System.Windows.Forms.ToolStripLabel();
            this.tcb_action = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ttb_action = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.sst_action.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AllowUserToAddRows = false;
            this.dgv_consulta.AllowUserToOrderColumns = true;
            this.dgv_consulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_consulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_consulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_consulta.EnableHeadersVisualStyles = false;
            this.dgv_consulta.Location = new System.Drawing.Point(0, 25);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.RowHeadersVisible = false;
            this.dgv_consulta.Size = new System.Drawing.Size(477, 188);
            this.dgv_consulta.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // sst_action
            // 
            this.sst_action.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sst_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_status,
            this.tss_action});
            this.sst_action.Location = new System.Drawing.Point(0, 213);
            this.sst_action.Name = "sst_action";
            this.sst_action.Size = new System.Drawing.Size(477, 24);
            this.sst_action.TabIndex = 6;
            this.sst_action.Text = "statusStrip1";
            // 
            // tss_status
            // 
            this.tss_status.Name = "tss_status";
            this.tss_status.Size = new System.Drawing.Size(0, 19);
            // 
            // tss_action
            // 
            this.tss_action.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tss_action.Name = "tss_action";
            this.tss_action.Size = new System.Drawing.Size(77, 19);
            this.tss_action.Text = "Mensagem";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_action,
            this.tbs_refresh,
            this.toolStripSeparator2,
            this.lbl_busca,
            this.tcb_action,
            this.toolStripSeparator1,
            this.ttb_action});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(477, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_action
            // 
            this.tsb_action.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_action.Image = ((System.Drawing.Image)(resources.GetObject("tsb_action.Image")));
            this.tsb_action.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_action.Name = "tsb_action";
            this.tsb_action.Size = new System.Drawing.Size(23, 22);
            this.tsb_action.Text = "toolStripButton1";
            // 
            // tbs_refresh
            // 
            this.tbs_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbs_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbs_refresh.Image = ((System.Drawing.Image)(resources.GetObject("tbs_refresh.Image")));
            this.tbs_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_refresh.Name = "tbs_refresh";
            this.tbs_refresh.Size = new System.Drawing.Size(23, 22);
            this.tbs_refresh.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_busca
            // 
            this.lbl_busca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_busca.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_busca.Name = "lbl_busca";
            this.lbl_busca.Size = new System.Drawing.Size(44, 22);
            this.lbl_busca.Text = "Busca";
            // 
            // tcb_action
            // 
            this.tcb_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tcb_action.Items.AddRange(new object[] {
            "Itens"});
            this.tcb_action.Name = "tcb_action";
            this.tcb_action.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ttb_action
            // 
            this.ttb_action.Name = "ttb_action";
            this.ttb_action.Size = new System.Drawing.Size(150, 25);
            // 
            // ViewExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.sst_action);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ViewExtends";
            this.Size = new System.Drawing.Size(477, 237);
            this.Tamanho = 477;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.sst_action.ResumeLayout(false);
            this.sst_action.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_action;
        private System.Windows.Forms.ToolStripButton tbs_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl_busca;
        private System.Windows.Forms.ToolStripComboBox tcb_action;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ttb_action;
        private System.Windows.Forms.StatusStrip sst_action;
        private System.Windows.Forms.ToolStripStatusLabel tss_status;
        private System.Windows.Forms.ToolStripStatusLabel tss_action;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}
