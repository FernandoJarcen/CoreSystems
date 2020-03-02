namespace CoreBusinessApplication.Formularios
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_fechar = new CoreFramework.Controles.Controle.ButtonExtends();
            this.btn_acessar = new CoreFramework.Controles.Controle.ButtonExtends();
            this.pnl_topo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbx_pwd = new CoreFramework.Controles.Controle.WaterMarkExtends();
            this.tbx_user = new CoreFramework.Controles.Controle.WaterMarkExtends();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.pnl_topo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.btn_fechar);
            this.panel4.Controls.Add(this.btn_acessar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 43);
            this.panel4.TabIndex = 15;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_fechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_fechar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(259, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(110, 35);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_acessar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_acessar.ForeColor = System.Drawing.Color.White;
            this.btn_acessar.Location = new System.Drawing.Point(146, 4);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(110, 35);
            this.btn_acessar.TabIndex = 0;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_topo.Controls.Add(this.lbl_titulo);
            this.pnl_topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topo.Location = new System.Drawing.Point(0, 0);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(379, 35);
            this.pnl_topo.TabIndex = 14;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_titulo.Location = new System.Drawing.Point(37, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(277, 18);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Sistemática - Business Applications";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Controls.Add(this.logoPictureBox);
            this.panel3.Controls.Add(this.tbx_pwd);
            this.panel3.Controls.Add(this.tbx_user);
            this.panel3.Controls.Add(this.lbl_subtitulo);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 171);
            this.panel3.TabIndex = 16;
            // 
            // tbx_pwd
            // 
            this.tbx_pwd.Borda = System.Windows.Forms.BorderStyle.None;
            this.tbx_pwd.Build = null;
            this.tbx_pwd.Caractere = '*';
            this.tbx_pwd.ComprimentoMaximo = 18;
            this.tbx_pwd.GlobalID = 0;
            this.tbx_pwd.GlobalName = "";
            this.tbx_pwd.Location = new System.Drawing.Point(128, 68);
            this.tbx_pwd.MensagemPadrao = "";
            this.tbx_pwd.Name = "tbx_pwd";
            this.tbx_pwd.Obrigatorio = false;
            this.tbx_pwd.Size = new System.Drawing.Size(241, 23);
            this.tbx_pwd.TabIndex = 4;
            this.tbx_pwd.Tamanho = 241;
            this.tbx_pwd.TamanhoTexto = 170;
            this.tbx_pwd.TextoMarca = "Digite a Senha";
            this.tbx_pwd.Titulo = "Senha";
            this.tbx_pwd.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // tbx_user
            // 
            this.tbx_user.Borda = System.Windows.Forms.BorderStyle.None;
            this.tbx_user.Build = null;
            this.tbx_user.Caractere = '\0';
            this.tbx_user.ComprimentoMaximo = 40;
            this.tbx_user.GlobalID = 0;
            this.tbx_user.GlobalName = "";
            this.tbx_user.Location = new System.Drawing.Point(128, 43);
            this.tbx_user.MensagemPadrao = "";
            this.tbx_user.Name = "tbx_user";
            this.tbx_user.Obrigatorio = false;
            this.tbx_user.Size = new System.Drawing.Size(241, 23);
            this.tbx_user.TabIndex = 3;
            this.tbx_user.Tamanho = 241;
            this.tbx_user.TamanhoTexto = 170;
            this.tbx_user.TextoMarca = "Digite o Usuário";
            this.tbx_user.Titulo = "Usuário";
            this.tbx_user.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_subtitulo.Location = new System.Drawing.Point(8, 9);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(252, 17);
            this.lbl_subtitulo.TabIndex = 0;
            this.lbl_subtitulo.Text = "Digite o Usuário e Senha para acesso:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_status.Location = new System.Drawing.Point(128, 98);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(139, 17);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Status do serviço:";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(118, 171);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 19;
            this.logoPictureBox.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 171);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_topo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel4.ResumeLayout(false);
            this.pnl_topo.ResumeLayout(false);
            this.pnl_topo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private CoreFramework.Controles.Controle.ButtonExtends btn_fechar;
        private CoreFramework.Controles.Controle.ButtonExtends btn_acessar;
        private System.Windows.Forms.Panel pnl_topo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel3;
        private CoreFramework.Controles.Controle.WaterMarkExtends tbx_pwd;
        private CoreFramework.Controles.Controle.WaterMarkExtends tbx_user;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}