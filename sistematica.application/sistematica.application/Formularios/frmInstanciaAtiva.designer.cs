namespace sistematica.application.Formularios
{
    partial class frmInstanciaAtiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstanciaAtiva));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_instanciaAtiva = new CoreFramework.Controles.Controle.LabelExtends();
            this.rst_nome = new CoreFramework.Controles.Controle.ResultExtends();
            this.rst_instancia = new CoreFramework.Controles.Controle.ResultExtends();
            this.fld_arquivo = new CoreFramework.Controles.Controle.FileExtends();
            this.panelCaptionExtends1 = new CoreFramework.Controles.Controle.PanelCaptionExtends();
            this.cap_executar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cap_sair = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.cbo_instancias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCaptionExtends1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_instancias);
            this.panel1.Controls.Add(this.lbl_instanciaAtiva);
            this.panel1.Controls.Add(this.rst_nome);
            this.panel1.Controls.Add(this.rst_instancia);
            this.panel1.Controls.Add(this.fld_arquivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 176);
            this.panel1.TabIndex = 3;
            // 
            // lbl_instanciaAtiva
            // 
            this.lbl_instanciaAtiva.AlinhamentoEsquerda = System.Windows.Forms.RightToLeft.No;
            this.lbl_instanciaAtiva.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_instanciaAtiva.Build = null;
            this.lbl_instanciaAtiva.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_instanciaAtiva.CorValor = System.Drawing.Color.Maroon;
            this.lbl_instanciaAtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_instanciaAtiva.GlobalID = 0;
            this.lbl_instanciaAtiva.GlobalName = "";
            this.lbl_instanciaAtiva.Location = new System.Drawing.Point(10, 5);
            this.lbl_instanciaAtiva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_instanciaAtiva.MensagemPadrao = "";
            this.lbl_instanciaAtiva.MostrarDestacado = true;
            this.lbl_instanciaAtiva.Name = "lbl_instanciaAtiva";
            this.lbl_instanciaAtiva.Size = new System.Drawing.Size(402, 23);
            this.lbl_instanciaAtiva.TabIndex = 10;
            this.lbl_instanciaAtiva.Tamanho = 402;
            this.lbl_instanciaAtiva.TamanhoTextoTitulo = 10F;
            this.lbl_instanciaAtiva.TamanhoTextoValor = 10F;
            this.lbl_instanciaAtiva.TamanhoTitulo = 160;
            this.lbl_instanciaAtiva.Titulo = "Instância Ativa";
            this.lbl_instanciaAtiva.Valor = "Valor";
            // 
            // rst_nome
            // 
            this.rst_nome.Borda = System.Windows.Forms.BorderStyle.None;
            this.rst_nome.Build = null;
            this.rst_nome.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.rst_nome.CorValor = System.Drawing.SystemColors.ControlText;
            this.rst_nome.GlobalID = 0;
            this.rst_nome.GlobalName = "";
            this.rst_nome.Location = new System.Drawing.Point(6, 116);
            this.rst_nome.MensagemPadrao = "";
            this.rst_nome.MostrarDestacado = false;
            this.rst_nome.Name = "rst_nome";
            this.rst_nome.Size = new System.Drawing.Size(324, 23);
            this.rst_nome.TabIndex = 8;
            this.rst_nome.Tamanho = 324;
            this.rst_nome.TamanhoTextoTitulo = 10F;
            this.rst_nome.TamanhoTextoValor = 10F;
            this.rst_nome.TamanhoTitulo = 45;
            this.rst_nome.Titulo = "Nome";
            this.rst_nome.Valor = "";
            // 
            // rst_instancia
            // 
            this.rst_instancia.Borda = System.Windows.Forms.BorderStyle.None;
            this.rst_instancia.Build = null;
            this.rst_instancia.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.rst_instancia.CorValor = System.Drawing.SystemColors.ControlText;
            this.rst_instancia.GlobalID = 0;
            this.rst_instancia.GlobalName = "";
            this.rst_instancia.Location = new System.Drawing.Point(6, 90);
            this.rst_instancia.MensagemPadrao = "";
            this.rst_instancia.MostrarDestacado = false;
            this.rst_instancia.Name = "rst_instancia";
            this.rst_instancia.Size = new System.Drawing.Size(324, 23);
            this.rst_instancia.TabIndex = 7;
            this.rst_instancia.Tamanho = 324;
            this.rst_instancia.TamanhoTextoTitulo = 10F;
            this.rst_instancia.TamanhoTextoValor = 10F;
            this.rst_instancia.TamanhoTitulo = 52;
            this.rst_instancia.Titulo = "Código";
            this.rst_instancia.Valor = "";
            // 
            // fld_arquivo
            // 
            this.fld_arquivo.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_arquivo.Build = null;
            this.fld_arquivo.Caminho = "";
            this.fld_arquivo.Editavel = true;
            this.fld_arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_arquivo.GlobalID = 0;
            this.fld_arquivo.GlobalName = "";
            this.fld_arquivo.Location = new System.Drawing.Point(9, 35);
            this.fld_arquivo.MensagemPadrao = "";
            this.fld_arquivo.Name = "fld_arquivo";
            this.fld_arquivo.Obrigatorio = false;
            this.fld_arquivo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_arquivo.Size = new System.Drawing.Size(403, 23);
            this.fld_arquivo.TabIndex = 0;
            this.fld_arquivo.Tamanho = 403;
            this.fld_arquivo.TamanhoTexto = 300;
            this.fld_arquivo.Titulo = "Arquivo";
            this.fld_arquivo.Validated += new System.EventHandler(this.fld_arquivo_Validated);
            // 
            // panelCaptionExtends1
            // 
            this.panelCaptionExtends1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCaptionExtends1.Controls.Add(this.cap_executar);
            this.panelCaptionExtends1.Controls.Add(this.cap_sair);
            this.panelCaptionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaptionExtends1.Item.Add(this.cap_executar);
            this.panelCaptionExtends1.Item.Add(this.cap_sair);
            this.panelCaptionExtends1.Location = new System.Drawing.Point(0, 62);
            this.panelCaptionExtends1.Name = "panelCaptionExtends1";
            this.panelCaptionExtends1.Size = new System.Drawing.Size(589, 44);
            this.panelCaptionExtends1.TabIndex = 2;
            // 
            // cap_executar
            // 
            this.cap_executar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_executar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_executar.Build = null;
            this.cap_executar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_executar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_executar.GlobalID = 0;
            this.cap_executar.GlobalName = "";
            this.cap_executar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_executar.Imagem")));
            this.cap_executar.Location = new System.Drawing.Point(123, 0);
            this.cap_executar.MensagemPadrao = "";
            this.cap_executar.MostrarBorda = false;
            this.cap_executar.MostrarImagem = true;
            this.cap_executar.Name = "cap_executar";
            this.cap_executar.Size = new System.Drawing.Size(123, 44);
            this.cap_executar.TabIndex = 1;
            this.cap_executar.Titulo = "Executar";
            this.cap_executar.AoChamar += new System.EventHandler(this.cap_executar_AoChamar);
            // 
            // cap_sair
            // 
            this.cap_sair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_sair.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_sair.Build = null;
            this.cap_sair.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_sair.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_sair.GlobalID = 0;
            this.cap_sair.GlobalName = "";
            this.cap_sair.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_sair.Imagem")));
            this.cap_sair.Location = new System.Drawing.Point(0, 0);
            this.cap_sair.MensagemPadrao = "";
            this.cap_sair.MostrarBorda = false;
            this.cap_sair.MostrarImagem = true;
            this.cap_sair.Name = "cap_sair";
            this.cap_sair.Size = new System.Drawing.Size(123, 44);
            this.cap_sair.TabIndex = 0;
            this.cap_sair.Titulo = "Sair";
            this.cap_sair.AoChamar += new System.EventHandler(this.cap_sair_AoChamar);
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
            this.captionExtends1.Size = new System.Drawing.Size(589, 62);
            this.captionExtends1.Subtitulo = "";
            this.captionExtends1.TabIndex = 0;
            this.captionExtends1.Tamanho = 589;
            this.captionExtends1.Titulo = "Instância Ativa";
            // 
            // cbo_instancias
            // 
            this.cbo_instancias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_instancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_instancias.FormattingEnabled = true;
            this.cbo_instancias.Location = new System.Drawing.Point(113, 62);
            this.cbo_instancias.Name = "cbo_instancias";
            this.cbo_instancias.Size = new System.Drawing.Size(299, 24);
            this.cbo_instancias.TabIndex = 13;
            this.cbo_instancias.SelectedIndexChanged += new System.EventHandler(this.cbo_instancias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Instâncias";
            // 
            // frmInstanciaAtiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 282);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCaptionExtends1);
            this.Controls.Add(this.captionExtends1);
            this.Name = "frmInstanciaAtiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instancia Ativa";
            this.Shown += new System.EventHandler(this.frmInstanciaAtiva_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCaptionExtends1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private CoreFramework.Controles.Controle.PanelCaptionExtends panelCaptionExtends1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_executar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_sair;
        private System.Windows.Forms.Panel panel1;
        private CoreFramework.Controles.Controle.FileExtends fld_arquivo;
        private CoreFramework.Controles.Controle.ResultExtends rst_nome;
        private CoreFramework.Controles.Controle.ResultExtends rst_instancia;
        private CoreFramework.Controles.Controle.LabelExtends lbl_instanciaAtiva;
        private System.Windows.Forms.ComboBox cbo_instancias;
        private System.Windows.Forms.Label label1;
    }
}