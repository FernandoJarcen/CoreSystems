namespace sistematica.application.Formularios
{
    partial class frmCriptografiaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriptografiaUsuarios));
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.panelCaptionExtends1 = new CoreFramework.Controles.Controle.PanelCaptionExtends();
            this.cap_descriptografar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cap_criptografar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cpt_sair = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.tabViewExtends1 = new CoreFramework.Controles.Controle.TabViewExtends();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_status = new CoreFramework.Controles.Controle.LabelViewExtends();
            this.panelCaptionExtends1.SuspendLayout();
            this.tabViewExtends1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // captionExtends1
            // 
            this.captionExtends1.BackColor = System.Drawing.Color.SteelBlue;
            this.captionExtends1.Borda = System.Windows.Forms.BorderStyle.None;
            this.captionExtends1.Build = null;
            this.captionExtends1.Cor = System.Drawing.Color.SteelBlue;
            this.captionExtends1.CorSubtitulo = System.Drawing.SystemColors.ControlLightLight;
            this.captionExtends1.CorTitulo = System.Drawing.SystemColors.ControlLightLight;
            this.captionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.captionExtends1.GlobalID = 0;
            this.captionExtends1.GlobalName = "";
            this.captionExtends1.Imagem = ((System.Drawing.Image)(resources.GetObject("captionExtends1.Imagem")));
            this.captionExtends1.Location = new System.Drawing.Point(0, 0);
            this.captionExtends1.MensagemPadrao = "";
            this.captionExtends1.MostrarImagem = true;
            this.captionExtends1.Name = "captionExtends1";
            this.captionExtends1.Size = new System.Drawing.Size(484, 33);
            this.captionExtends1.Subtitulo = "Subtítulo";
            this.captionExtends1.TabIndex = 11;
            this.captionExtends1.Tamanho = 484;
            this.captionExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoCaption.Pequeno;
            this.captionExtends1.Titulo = "Criptografia Usuários";
            // 
            // panelCaptionExtends1
            // 
            this.panelCaptionExtends1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCaptionExtends1.Controls.Add(this.cap_descriptografar);
            this.panelCaptionExtends1.Controls.Add(this.cap_criptografar);
            this.panelCaptionExtends1.Controls.Add(this.cpt_sair);
            this.panelCaptionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaptionExtends1.Item.Add(this.cap_descriptografar);
            this.panelCaptionExtends1.Item.Add(this.cap_criptografar);
            this.panelCaptionExtends1.Item.Add(this.cpt_sair);
            this.panelCaptionExtends1.Location = new System.Drawing.Point(0, 33);
            this.panelCaptionExtends1.Name = "panelCaptionExtends1";
            this.panelCaptionExtends1.Size = new System.Drawing.Size(484, 38);
            this.panelCaptionExtends1.TabIndex = 12;
            // 
            // cap_descriptografar
            // 
            this.cap_descriptografar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_descriptografar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_descriptografar.Build = null;
            this.cap_descriptografar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_descriptografar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_descriptografar.GlobalID = 0;
            this.cap_descriptografar.GlobalName = "";
            this.cap_descriptografar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_descriptografar.Imagem")));
            this.cap_descriptografar.Location = new System.Drawing.Point(244, 0);
            this.cap_descriptografar.MensagemPadrao = "";
            this.cap_descriptografar.MostrarBorda = false;
            this.cap_descriptografar.MostrarImagem = true;
            this.cap_descriptografar.Name = "cap_descriptografar";
            this.cap_descriptografar.Size = new System.Drawing.Size(165, 38);
            this.cap_descriptografar.TabIndex = 6;
            this.cap_descriptografar.Titulo = "Descriptografar";
            this.cap_descriptografar.AoChamar += new System.EventHandler(this.cap_descriptografar_AoChamar);
            // 
            // cap_criptografar
            // 
            this.cap_criptografar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_criptografar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_criptografar.Build = null;
            this.cap_criptografar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_criptografar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_criptografar.GlobalID = 0;
            this.cap_criptografar.GlobalName = "";
            this.cap_criptografar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_criptografar.Imagem")));
            this.cap_criptografar.Location = new System.Drawing.Point(99, 0);
            this.cap_criptografar.MensagemPadrao = "";
            this.cap_criptografar.MostrarBorda = false;
            this.cap_criptografar.MostrarImagem = true;
            this.cap_criptografar.Name = "cap_criptografar";
            this.cap_criptografar.Size = new System.Drawing.Size(145, 38);
            this.cap_criptografar.TabIndex = 5;
            this.cap_criptografar.Titulo = "Criptografar";
            this.cap_criptografar.AoChamar += new System.EventHandler(this.cap_criptografar_AoChamar);
            // 
            // cpt_sair
            // 
            this.cpt_sair.BackColor = System.Drawing.Color.Transparent;
            this.cpt_sair.Borda = System.Windows.Forms.BorderStyle.None;
            this.cpt_sair.Build = null;
            this.cpt_sair.Cor = System.Drawing.Color.Transparent;
            this.cpt_sair.Dock = System.Windows.Forms.DockStyle.Left;
            this.cpt_sair.GlobalID = 0;
            this.cpt_sair.GlobalName = "";
            this.cpt_sair.Imagem = ((System.Drawing.Image)(resources.GetObject("cpt_sair.Imagem")));
            this.cpt_sair.Location = new System.Drawing.Point(0, 0);
            this.cpt_sair.MensagemPadrao = "";
            this.cpt_sair.MostrarBorda = false;
            this.cpt_sair.MostrarImagem = true;
            this.cpt_sair.Name = "cpt_sair";
            this.cpt_sair.Size = new System.Drawing.Size(99, 38);
            this.cpt_sair.TabIndex = 2;
            this.cpt_sair.Titulo = "Sair";
            this.cpt_sair.AoChamar += new System.EventHandler(this.cpt_sair_AoChamar);
            // 
            // tabViewExtends1
            // 
            this.tabViewExtends1.Controls.Add(this.tabPage1);
            this.tabViewExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabViewExtends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabViewExtends1.ItemSize = new System.Drawing.Size(96, 25);
            this.tabViewExtends1.Location = new System.Drawing.Point(0, 71);
            this.tabViewExtends1.Name = "tabViewExtends1";
            this.tabViewExtends1.SelectedIndex = 0;
            this.tabViewExtends1.Size = new System.Drawing.Size(484, 91);
            this.tabViewExtends1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabViewExtends1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_status);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 58);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_status.Build = null;
            this.lbl_status.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_status.CorValor = System.Drawing.SystemColors.ControlText;
            this.lbl_status.GlobalID = 0;
            this.lbl_status.GlobalName = "";
            this.lbl_status.Location = new System.Drawing.Point(7, 6);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_status.MensagemPadrao = "";
            this.lbl_status.MostrarDestacado = false;
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(403, 26);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Tamanho = 403;
            this.lbl_status.TamanhoTextoTitulo = 10F;
            this.lbl_status.TamanhoTextoValor = 9.75F;
            this.lbl_status.TamanhoTitulo = 225F;
            this.lbl_status.Titulo = "Status";
            this.lbl_status.Valor = "0";
            // 
            // frmCriptografiaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 162);
            this.ControlBox = false;
            this.Controls.Add(this.tabViewExtends1);
            this.Controls.Add(this.panelCaptionExtends1);
            this.Controls.Add(this.captionExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCriptografiaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCriptografiaUsuarios";
            this.panelCaptionExtends1.ResumeLayout(false);
            this.tabViewExtends1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private CoreFramework.Controles.Controle.PanelCaptionExtends panelCaptionExtends1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_sair;
        private CoreFramework.Controles.Controle.TabViewExtends tabViewExtends1;
        private System.Windows.Forms.TabPage tabPage1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_descriptografar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_criptografar;
        private CoreFramework.Controles.Controle.LabelViewExtends lbl_status;

    }
}