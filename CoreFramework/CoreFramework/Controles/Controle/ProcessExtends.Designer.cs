namespace CoreFramework.Controles.Controle
{
    partial class ProcessExtends
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_mensagem = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.lbl_action = new System.Windows.Forms.Label();
            this.lkl_mensagem = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lkl_mensagem);
            this.panel1.Controls.Add(this.lbl_action);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 26);
            this.panel1.TabIndex = 0;
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AllowUserToAddRows = false;
            this.dgv_consulta.AllowUserToOrderColumns = true;
            this.dgv_consulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_consulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgv_mensagem});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_consulta.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_consulta.EnableHeadersVisualStyles = false;
            this.dgv_consulta.Location = new System.Drawing.Point(0, 26);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.RowHeadersVisible = false;
            this.dgv_consulta.Size = new System.Drawing.Size(681, 124);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_mensagem.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_mensagem.HeaderText = "Processo";
            this.dgv_mensagem.Name = "dgv_mensagem";
            this.dgv_mensagem.Width = 72;
            // 
            // lbl_action
            // 
            this.lbl_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.Image = global::CoreFramework.Properties.Resources.executar;
            this.lbl_action.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_action.Location = new System.Drawing.Point(0, 0);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(108, 26);
            this.lbl_action.TabIndex = 2;
            this.lbl_action.Text = "Sucesso";
            this.lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lkl_mensagem
            // 
            this.lkl_mensagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkl_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl_mensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lkl_mensagem.Location = new System.Drawing.Point(108, 0);
            this.lkl_mensagem.Name = "lkl_mensagem";
            this.lkl_mensagem.Size = new System.Drawing.Size(573, 26);
            this.lkl_mensagem.TabIndex = 3;
            this.lkl_mensagem.TabStop = true;
            this.lkl_mensagem.Text = "Executado 0 Processos";
            this.lkl_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lkl_mensagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_mensagem_LinkClicked);
            // 
            // ProcessExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.panel1);
            this.Name = "ProcessExtends";
            this.Size = new System.Drawing.Size(681, 150);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn dgv_mensagem;
        private System.Windows.Forms.LinkLabel lkl_mensagem;
        private System.Windows.Forms.Label lbl_action;
    }
}
