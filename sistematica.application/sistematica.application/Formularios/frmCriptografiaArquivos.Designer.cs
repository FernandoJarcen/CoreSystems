namespace sistematica.application.Formularios
{
    partial class frmCriptografiaArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriptografiaArquivos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelExtends1 = new CoreFramework.Controles.Controle.PanelExtends();
            this.lbl_statusAtual = new CoreFramework.Controles.Controle.LabelViewExtends();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.fld_arquivo = new CoreFramework.Controles.Controle.FileExtends();
            this.PanelCaptionExtends1 = new CoreFramework.Controles.Controle.PanelCaptionExtends();
            this.cpt_descriptografar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cpt_criptografar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cpt_sair = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelExtends1.SuspendLayout();
            this.PanelCaptionExtends1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(96, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 148);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelExtends1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelExtends1
            // 
            this.panelExtends1.Altura = 25;
            this.panelExtends1.BackColor = System.Drawing.Color.White;
            this.panelExtends1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExtends1.Cabecalho = "";
            this.panelExtends1.Centralizar = false;
            this.panelExtends1.Controls.Add(this.lbl_statusAtual);
            this.panelExtends1.Controls.Add(this.btn_verificar);
            this.panelExtends1.Controls.Add(this.fld_arquivo);
            this.panelExtends1.Cor = System.Drawing.Color.SteelBlue;
            this.panelExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExtends1.Location = new System.Drawing.Point(3, 3);
            this.panelExtends1.MostrarBorda = true;
            this.panelExtends1.Name = "panelExtends1";
            this.panelExtends1.Posicao = CoreFramework.Objetos.Enums.PosicaoPainel.Topo;
            this.panelExtends1.Size = new System.Drawing.Size(570, 109);
            this.panelExtends1.TabIndex = 0;
            this.panelExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoPainel.normal;
            // 
            // lbl_statusAtual
            // 
            this.lbl_statusAtual.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_statusAtual.Build = null;
            this.lbl_statusAtual.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_statusAtual.CorValor = System.Drawing.Color.Maroon;
            this.lbl_statusAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_statusAtual.GlobalID = 0;
            this.lbl_statusAtual.GlobalName = "";
            this.lbl_statusAtual.Location = new System.Drawing.Point(-1, 57);
            this.lbl_statusAtual.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_statusAtual.MensagemPadrao = "";
            this.lbl_statusAtual.MostrarDestacado = true;
            this.lbl_statusAtual.Name = "lbl_statusAtual";
            this.lbl_statusAtual.Size = new System.Drawing.Size(304, 23);
            this.lbl_statusAtual.TabIndex = 4;
            this.lbl_statusAtual.Tamanho = 304;
            this.lbl_statusAtual.TamanhoTextoTitulo = 10F;
            this.lbl_statusAtual.TamanhoTextoValor = 10F;
            this.lbl_statusAtual.TamanhoTitulo = 95F;
            this.lbl_statusAtual.Titulo = "Status Atual";
            this.lbl_statusAtual.Valor = "0";
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_verificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_verificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_verificar.Location = new System.Drawing.Point(454, 58);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(110, 35);
            this.btn_verificar.TabIndex = 3;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // fld_arquivo
            // 
            this.fld_arquivo.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_arquivo.Build = null;
            this.fld_arquivo.Caminho = "";
            this.fld_arquivo.Editavel = true;
            this.fld_arquivo.GlobalID = 0;
            this.fld_arquivo.GlobalName = "";
            this.fld_arquivo.Location = new System.Drawing.Point(4, 29);
            this.fld_arquivo.MensagemPadrao = "";
            this.fld_arquivo.Name = "fld_arquivo";
            this.fld_arquivo.Obrigatorio = false;
            this.fld_arquivo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_arquivo.Size = new System.Drawing.Size(560, 23);
            this.fld_arquivo.TabIndex = 1;
            this.fld_arquivo.Tamanho = 560;
            this.fld_arquivo.TamanhoTexto = 450;
            this.fld_arquivo.Titulo = "Arquivo";
            // 
            // PanelCaptionExtends1
            // 
            this.PanelCaptionExtends1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelCaptionExtends1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCaptionExtends1.Controls.Add(this.cpt_descriptografar);
            this.PanelCaptionExtends1.Controls.Add(this.cpt_criptografar);
            this.PanelCaptionExtends1.Controls.Add(this.cpt_sair);
            this.PanelCaptionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCaptionExtends1.Item.Add(this.cpt_descriptografar);
            this.PanelCaptionExtends1.Item.Add(this.cpt_criptografar);
            this.PanelCaptionExtends1.Item.Add(this.cpt_sair);
            this.PanelCaptionExtends1.Location = new System.Drawing.Point(0, 33);
            this.PanelCaptionExtends1.Name = "PanelCaptionExtends1";
            this.PanelCaptionExtends1.Size = new System.Drawing.Size(584, 41);
            this.PanelCaptionExtends1.TabIndex = 19;
            // 
            // cpt_descriptografar
            // 
            this.cpt_descriptografar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpt_descriptografar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cpt_descriptografar.Build = null;
            this.cpt_descriptografar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cpt_descriptografar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cpt_descriptografar.GlobalID = 0;
            this.cpt_descriptografar.GlobalName = "";
            this.cpt_descriptografar.Imagem = ((System.Drawing.Image)(resources.GetObject("cpt_descriptografar.Imagem")));
            this.cpt_descriptografar.Location = new System.Drawing.Point(251, 0);
            this.cpt_descriptografar.MensagemPadrao = "";
            this.cpt_descriptografar.MostrarBorda = false;
            this.cpt_descriptografar.MostrarImagem = true;
            this.cpt_descriptografar.Name = "cpt_descriptografar";
            this.cpt_descriptografar.Size = new System.Drawing.Size(175, 39);
            this.cpt_descriptografar.TabIndex = 3;
            this.cpt_descriptografar.Titulo = "DesCriptografar";
            this.cpt_descriptografar.AoChamar += new System.EventHandler(this.cpt_descriptografar_AoChamar);
            // 
            // cpt_criptografar
            // 
            this.cpt_criptografar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpt_criptografar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cpt_criptografar.Build = null;
            this.cpt_criptografar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cpt_criptografar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cpt_criptografar.GlobalID = 0;
            this.cpt_criptografar.GlobalName = "";
            this.cpt_criptografar.Imagem = ((System.Drawing.Image)(resources.GetObject("cpt_criptografar.Imagem")));
            this.cpt_criptografar.Location = new System.Drawing.Point(99, 0);
            this.cpt_criptografar.MensagemPadrao = "";
            this.cpt_criptografar.MostrarBorda = false;
            this.cpt_criptografar.MostrarImagem = true;
            this.cpt_criptografar.Name = "cpt_criptografar";
            this.cpt_criptografar.Size = new System.Drawing.Size(152, 39);
            this.cpt_criptografar.TabIndex = 2;
            this.cpt_criptografar.Titulo = "Criptografar";
            this.cpt_criptografar.AoChamar += new System.EventHandler(this.cpt_criptografar_AoChamar);
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
            this.cpt_sair.Size = new System.Drawing.Size(99, 39);
            this.cpt_sair.TabIndex = 1;
            this.cpt_sair.Titulo = "Sair";
            this.cpt_sair.AoChamar += new System.EventHandler(this.cpt_sair_AoChamar);
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
            this.captionExtends1.Size = new System.Drawing.Size(584, 33);
            this.captionExtends1.Subtitulo = "Subtítulo";
            this.captionExtends1.TabIndex = 18;
            this.captionExtends1.Tamanho = 584;
            this.captionExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoCaption.Pequeno;
            this.captionExtends1.Titulo = "Criptografia de Arquivos";
            // 
            // frmCriptografiaArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 222);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PanelCaptionExtends1);
            this.Controls.Add(this.captionExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCriptografiaArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia de Arquivos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelExtends1.ResumeLayout(false);
            this.PanelCaptionExtends1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private CoreFramework.Controles.Controle.PanelCaptionExtends PanelCaptionExtends1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_sair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CoreFramework.Controles.Controle.PanelExtends panelExtends1;
        private CoreFramework.Controles.Controle.LabelViewExtends lbl_statusAtual;
        private System.Windows.Forms.Button btn_verificar;
        private CoreFramework.Controles.Controle.FileExtends fld_arquivo;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_descriptografar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_criptografar;
    }
}