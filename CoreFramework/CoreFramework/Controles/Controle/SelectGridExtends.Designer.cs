namespace CoreFramework.Controles.Controle
{
    partial class SelectGridExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGridExtends));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_refresh = new System.Windows.Forms.ToolStripButton();
            this.lbl_busca = new System.Windows.Forms.ToolStripLabel();
            this.tcb_action = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ttb_action = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_excel = new System.Windows.Forms.ToolStripButton();
            this.sts_action = new System.Windows.Forms.StatusStrip();
            this.tss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_action = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.sts_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_refresh,
            this.lbl_busca,
            this.tcb_action,
            this.toolStripSeparator1,
            this.ttb_action,
            this.tsb_excel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 25);
            this.toolStrip1.TabIndex = 3;
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
            // lbl_busca
            // 
            this.lbl_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_busca.Name = "lbl_busca";
            this.lbl_busca.Size = new System.Drawing.Size(46, 22);
            this.lbl_busca.Text = "Busca";
            // 
            // tcb_action
            // 
            this.tcb_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tcb_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcb_action.Items.AddRange(new object[] {
            "Itens"});
            this.tcb_action.Name = "tcb_action";
            this.tcb_action.Size = new System.Drawing.Size(150, 25);
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
            this.ttb_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_action.Name = "ttb_action";
            this.ttb_action.Size = new System.Drawing.Size(150, 25);
            this.ttb_action.TextChanged += new System.EventHandler(this.ttb_action_TextChanged);
            // 
            // tsb_excel
            // 
            this.tsb_excel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_excel.Image = ((System.Drawing.Image)(resources.GetObject("tsb_excel.Image")));
            this.tsb_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_excel.Name = "tsb_excel";
            this.tsb_excel.Size = new System.Drawing.Size(23, 22);
            this.tsb_excel.Text = "toolStripButton1";
            this.tsb_excel.Click += new System.EventHandler(this.tsb_excel_Click);
            // 
            // sts_action
            // 
            this.sts_action.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sts_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sts_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_status,
            this.tss_action});
            this.sts_action.Location = new System.Drawing.Point(0, 217);
            this.sts_action.Name = "sts_action";
            this.sts_action.Size = new System.Drawing.Size(463, 22);
            this.sts_action.TabIndex = 5;
            this.sts_action.Text = "statusStrip1";
            // 
            // tss_status
            // 
            this.tss_status.Name = "tss_status";
            this.tss_status.Size = new System.Drawing.Size(0, 17);
            // 
            // tss_action
            // 
            this.tss_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss_action.Name = "tss_action";
            this.tss_action.Size = new System.Drawing.Size(76, 17);
            this.tss_action.Text = "Mensagem";
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AllowUserToAddRows = false;
            this.dgv_consulta.AllowUserToOrderColumns = true;
            this.dgv_consulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_consulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgv_consulta.Size = new System.Drawing.Size(463, 192);
            this.dgv_consulta.TabIndex = 6;
            this.dgv_consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellClick);
            this.dgv_consulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellDoubleClick);
            this.dgv_consulta.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellValidated);
            this.dgv_consulta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellValueChanged);
            // 
            // SelectGridExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.sts_action);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SelectGridExtends";
            this.Size = new System.Drawing.Size(463, 239);
            this.Load += new System.EventHandler(this.SelectGridExtends_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sts_action.ResumeLayout(false);
            this.sts_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_refresh;
        private System.Windows.Forms.ToolStripLabel lbl_busca;
        private System.Windows.Forms.ToolStripComboBox tcb_action;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ttb_action;
        private System.Windows.Forms.StatusStrip sts_action;
        private System.Windows.Forms.ToolStripStatusLabel tss_status;
        private System.Windows.Forms.ToolStripStatusLabel tss_action;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.ToolStripButton tsb_excel;
    }
}
