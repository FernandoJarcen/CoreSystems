namespace CoreFramework.Controles.Controle
{
    partial class ImageGridExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGridExtends));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_busca = new System.Windows.Forms.ToolStripLabel();
            this.tcb_action = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ttb_action = new System.Windows.Forms.ToolStripTextBox();
            this.tsp_excel = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_action = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_refresh,
            this.toolStripSeparator2,
            this.lbl_busca,
            this.tcb_action,
            this.toolStripSeparator1,
            this.ttb_action,
            this.tsp_excel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tbs_refresh.Click += new System.EventHandler(this.tbs_refresh_Click);
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
            this.tcb_action.Size = new System.Drawing.Size(199, 25);
            this.tcb_action.SelectedIndexChanged += new System.EventHandler(this.tcb_action_SelectedIndexChanged);
            this.tcb_action.TextChanged += new System.EventHandler(this.tcb_action_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ttb_action
            // 
            this.ttb_action.Name = "ttb_action";
            this.ttb_action.Size = new System.Drawing.Size(199, 25);
            this.ttb_action.TextChanged += new System.EventHandler(this.ttb_action_TextChanged);
            // 
            // tsp_excel
            // 
            this.tsp_excel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsp_excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsp_excel.Image = ((System.Drawing.Image)(resources.GetObject("tsp_excel.Image")));
            this.tsp_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsp_excel.Name = "tsp_excel";
            this.tsp_excel.Size = new System.Drawing.Size(23, 22);
            this.tsp_excel.Text = "toolStripButton1";
            this.tsp_excel.Click += new System.EventHandler(this.tsp_excel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_status,
            this.tss_action});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(600, 24);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_consulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_consulta.EnableHeadersVisualStyles = false;
            this.dgv_consulta.Location = new System.Drawing.Point(0, 25);
            this.dgv_consulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.RowHeadersVisible = false;
            this.dgv_consulta.Size = new System.Drawing.Size(600, 251);
            this.dgv_consulta.TabIndex = 8;
            this.dgv_consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellClick);
            this.dgv_consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellContentClick);
            this.dgv_consulta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellDoubleClick);
            this.dgv_consulta.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellValidated);
            this.dgv_consulta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 20;
            // 
            // ImageGridExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ImageGridExtends";
            this.Size = new System.Drawing.Size(600, 300);
            this.Load += new System.EventHandler(this.ImageGridExtends_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl_busca;
        private System.Windows.Forms.ToolStripComboBox tcb_action;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ttb_action;
        private System.Windows.Forms.ToolStripButton tsp_excel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_status;
        private System.Windows.Forms.ToolStripStatusLabel tss_action;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
