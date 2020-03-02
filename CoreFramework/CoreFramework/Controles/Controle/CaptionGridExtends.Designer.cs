namespace CoreFramework.Controles.Controle
{
    partial class CaptionGridExtends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptionGridExtends));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_action = new System.Windows.Forms.Panel();
            this.lbl_cabecalho = new System.Windows.Forms.Label();
            this.pbx_cabecalho = new System.Windows.Forms.PictureBox();
            this.tsp_action = new System.Windows.Forms.ToolStrip();
            this.tsb_action = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_busca = new System.Windows.Forms.ToolStripLabel();
            this.tcb_action = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ttb_action = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_refresh = new System.Windows.Forms.ToolStripButton();
            this.tsb_excel = new System.Windows.Forms.ToolStripButton();
            this.sst_action = new System.Windows.Forms.StatusStrip();
            this.tss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_action = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cabecalho)).BeginInit();
            this.tsp_action.SuspendLayout();
            this.sst_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_action
            // 
            this.pnl_action.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_action.Controls.Add(this.lbl_cabecalho);
            this.pnl_action.Controls.Add(this.pbx_cabecalho);
            this.pnl_action.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_action.Location = new System.Drawing.Point(0, 0);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(638, 40);
            this.pnl_action.TabIndex = 0;
            // 
            // lbl_cabecalho
            // 
            this.lbl_cabecalho.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_cabecalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabecalho.ForeColor = System.Drawing.Color.White;
            this.lbl_cabecalho.Location = new System.Drawing.Point(49, 0);
            this.lbl_cabecalho.Name = "lbl_cabecalho";
            this.lbl_cabecalho.Size = new System.Drawing.Size(589, 40);
            this.lbl_cabecalho.TabIndex = 3;
            this.lbl_cabecalho.Text = "Caption";
            this.lbl_cabecalho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbx_cabecalho
            // 
            this.pbx_cabecalho.BackColor = System.Drawing.Color.SteelBlue;
            this.pbx_cabecalho.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbx_cabecalho.Image = ((System.Drawing.Image)(resources.GetObject("pbx_cabecalho.Image")));
            this.pbx_cabecalho.Location = new System.Drawing.Point(0, 0);
            this.pbx_cabecalho.Name = "pbx_cabecalho";
            this.pbx_cabecalho.Size = new System.Drawing.Size(49, 40);
            this.pbx_cabecalho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_cabecalho.TabIndex = 2;
            this.pbx_cabecalho.TabStop = false;
            // 
            // tsp_action
            // 
            this.tsp_action.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsp_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsp_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_action,
            this.toolStripSeparator2,
            this.lbl_busca,
            this.tcb_action,
            this.toolStripSeparator1,
            this.ttb_action,
            this.tbs_refresh,
            this.tsb_excel});
            this.tsp_action.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsp_action.Location = new System.Drawing.Point(0, 40);
            this.tsp_action.Name = "tsp_action";
            this.tsp_action.Size = new System.Drawing.Size(638, 25);
            this.tsp_action.TabIndex = 4;
            this.tsp_action.Text = "toolStrip1";
            // 
            // tsb_action
            // 
            this.tsb_action.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_action.Image = ((System.Drawing.Image)(resources.GetObject("tsb_action.Image")));
            this.tsb_action.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_action.Name = "tsb_action";
            this.tsb_action.Size = new System.Drawing.Size(23, 22);
            this.tsb_action.Text = "toolStripButton1";
            this.tsb_action.Click += new System.EventHandler(this.tsb_action_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_busca
            // 
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
            // sst_action
            // 
            this.sst_action.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sst_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sst_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_status,
            this.tss_action});
            this.sst_action.Location = new System.Drawing.Point(0, 355);
            this.sst_action.Name = "sst_action";
            this.sst_action.Size = new System.Drawing.Size(638, 22);
            this.sst_action.TabIndex = 6;
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
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_consulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_consulta.EnableHeadersVisualStyles = false;
            this.dgv_consulta.Location = new System.Drawing.Point(0, 65);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.RowHeadersVisible = false;
            this.dgv_consulta.Size = new System.Drawing.Size(638, 290);
            this.dgv_consulta.TabIndex = 7;
            this.dgv_consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellClick);
            this.dgv_consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellContentClick);
            this.dgv_consulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellDoubleClick);
            this.dgv_consulta.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellValidated);
            this.dgv_consulta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consulta_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // CaptionGridExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.sst_action);
            this.Controls.Add(this.tsp_action);
            this.Controls.Add(this.pnl_action);
            this.Name = "CaptionGridExtends";
            this.Size = new System.Drawing.Size(638, 377);
            this.Load += new System.EventHandler(this.CaptionGridExtends_Load);
            this.pnl_action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cabecalho)).EndInit();
            this.tsp_action.ResumeLayout(false);
            this.tsp_action.PerformLayout();
            this.sst_action.ResumeLayout(false);
            this.sst_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.PictureBox pbx_cabecalho;
        private System.Windows.Forms.Label lbl_cabecalho;
        private System.Windows.Forms.ToolStrip tsp_action;
        private System.Windows.Forms.ToolStripButton tsb_action;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl_busca;
        private System.Windows.Forms.ToolStripComboBox tcb_action;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ttb_action;
        private System.Windows.Forms.ToolStripButton tbs_refresh;
        private System.Windows.Forms.StatusStrip sst_action;
        private System.Windows.Forms.ToolStripStatusLabel tss_status;
        private System.Windows.Forms.ToolStripStatusLabel tss_action;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ToolStripButton tsb_excel;
    }
}
