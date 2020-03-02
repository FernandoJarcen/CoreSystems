namespace sistematica.application.Formularios
{
    partial class frmTesteConexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteConexao));
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.panelCaptionExtends1 = new CoreFramework.Controles.Controle.PanelCaptionExtends();
            this.cap_limpar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cap_executar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cpt_sair = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.tabViewExtends1 = new CoreFramework.Controles.Controle.TabViewExtends();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelExtends1 = new CoreFramework.Controles.Controle.PanelExtends();
            this.mmo_retorno = new CoreFramework.Controles.Controle.MemoExtends();
            this.fld_stringConnection = new CoreFramework.Controles.Controle.FieldExtends();
            this.panelCaptionExtends1.SuspendLayout();
            this.tabViewExtends1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelExtends1.SuspendLayout();
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
            this.captionExtends1.Size = new System.Drawing.Size(612, 33);
            this.captionExtends1.Subtitulo = "Subtítulo";
            this.captionExtends1.TabIndex = 11;
            this.captionExtends1.Tamanho = 612;
            this.captionExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoCaption.Pequeno;
            this.captionExtends1.Titulo = "Teste Conexão";
            // 
            // panelCaptionExtends1
            // 
            this.panelCaptionExtends1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCaptionExtends1.Controls.Add(this.cap_limpar);
            this.panelCaptionExtends1.Controls.Add(this.cap_executar);
            this.panelCaptionExtends1.Controls.Add(this.cpt_sair);
            this.panelCaptionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaptionExtends1.Item.Add(this.cap_limpar);
            this.panelCaptionExtends1.Item.Add(this.cap_executar);
            this.panelCaptionExtends1.Item.Add(this.cpt_sair);
            this.panelCaptionExtends1.Location = new System.Drawing.Point(0, 33);
            this.panelCaptionExtends1.Name = "panelCaptionExtends1";
            this.panelCaptionExtends1.Size = new System.Drawing.Size(612, 38);
            this.panelCaptionExtends1.TabIndex = 12;
            // 
            // cap_limpar
            // 
            this.cap_limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_limpar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_limpar.Build = null;
            this.cap_limpar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_limpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_limpar.GlobalID = 0;
            this.cap_limpar.GlobalName = "";
            this.cap_limpar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_limpar.Imagem")));
            this.cap_limpar.Location = new System.Drawing.Point(222, 0);
            this.cap_limpar.MensagemPadrao = "";
            this.cap_limpar.MostrarBorda = false;
            this.cap_limpar.MostrarImagem = true;
            this.cap_limpar.Name = "cap_limpar";
            this.cap_limpar.Size = new System.Drawing.Size(123, 38);
            this.cap_limpar.TabIndex = 4;
            this.cap_limpar.Titulo = "Limpar";
            this.cap_limpar.AoChamar += new System.EventHandler(this.cap_limpar_AoChamar);
            // 
            // cap_executar
            // 
            this.cap_executar.AccessibleDescription = "";
            this.cap_executar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_executar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_executar.Build = null;
            this.cap_executar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_executar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_executar.GlobalID = 0;
            this.cap_executar.GlobalName = "";
            this.cap_executar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_executar.Imagem")));
            this.cap_executar.Location = new System.Drawing.Point(99, 0);
            this.cap_executar.MensagemPadrao = "";
            this.cap_executar.MostrarBorda = false;
            this.cap_executar.MostrarImagem = true;
            this.cap_executar.Name = "cap_executar";
            this.cap_executar.Size = new System.Drawing.Size(123, 38);
            this.cap_executar.TabIndex = 3;
            this.cap_executar.Titulo = "Executar";
            this.cap_executar.AoChamar += new System.EventHandler(this.cap_executar_AoChamar);
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
            this.tabViewExtends1.Size = new System.Drawing.Size(612, 291);
            this.tabViewExtends1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabViewExtends1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelExtends1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelExtends1
            // 
            this.panelExtends1.Altura = 50;
            this.panelExtends1.BackColor = System.Drawing.Color.White;
            this.panelExtends1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExtends1.Cabecalho = "Informações sobre a conexão";
            this.panelExtends1.Centralizar = true;
            this.panelExtends1.Controls.Add(this.mmo_retorno);
            this.panelExtends1.Controls.Add(this.fld_stringConnection);
            this.panelExtends1.Cor = System.Drawing.Color.SteelBlue;
            this.panelExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExtends1.Location = new System.Drawing.Point(3, 3);
            this.panelExtends1.MostrarBorda = true;
            this.panelExtends1.Name = "panelExtends1";
            this.panelExtends1.Posicao = CoreFramework.Objetos.Enums.PosicaoPainel.Topo;
            this.panelExtends1.Size = new System.Drawing.Size(598, 252);
            this.panelExtends1.TabIndex = 0;
            this.panelExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoPainel.grande;
            // 
            // mmo_retorno
            // 
            this.mmo_retorno.Borda = System.Windows.Forms.BorderStyle.None;
            this.mmo_retorno.Build = null;
            this.mmo_retorno.ComprimentoMaximo = 30;
            this.mmo_retorno.GlobalID = 0;
            this.mmo_retorno.GlobalName = "";
            this.mmo_retorno.Location = new System.Drawing.Point(4, 84);
            this.mmo_retorno.MensagemPadrao = "";
            this.mmo_retorno.Name = "mmo_retorno";
            this.mmo_retorno.Obrigatorio = false;
            this.mmo_retorno.Size = new System.Drawing.Size(581, 162);
            this.mmo_retorno.TabIndex = 2;
            this.mmo_retorno.Tamanho = 581;
            this.mmo_retorno.TamanhoTexto = 500;
            this.mmo_retorno.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.mmo_retorno.Titulo = "Resultado";
            this.mmo_retorno.Valor = "";
            // 
            // fld_stringConnection
            // 
            this.fld_stringConnection.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_stringConnection.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_stringConnection.Build = null;
            this.fld_stringConnection.Caractere = '\0';
            this.fld_stringConnection.ComprimentoMaximo = 500;
            this.fld_stringConnection.Destacado = false;
            this.fld_stringConnection.GlobalID = 0;
            this.fld_stringConnection.GlobalName = "";
            this.fld_stringConnection.Location = new System.Drawing.Point(4, 56);
            this.fld_stringConnection.MensagemPadrao = "";
            this.fld_stringConnection.Name = "fld_stringConnection";
            this.fld_stringConnection.Obrigatorio = false;
            this.fld_stringConnection.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_stringConnection.Size = new System.Drawing.Size(581, 23);
            this.fld_stringConnection.TabIndex = 1;
            this.fld_stringConnection.Tamanho = 581;
            this.fld_stringConnection.TamanhoTexto = 500;
            this.fld_stringConnection.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_stringConnection.Titulo = "String";
            this.fld_stringConnection.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // frmTesteConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 362);
            this.ControlBox = false;
            this.Controls.Add(this.tabViewExtends1);
            this.Controls.Add(this.panelCaptionExtends1);
            this.Controls.Add(this.captionExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTesteConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Conexão";
            this.panelCaptionExtends1.ResumeLayout(false);
            this.tabViewExtends1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelExtends1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private CoreFramework.Controles.Controle.PanelCaptionExtends panelCaptionExtends1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_limpar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_executar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_sair;
        private CoreFramework.Controles.Controle.TabViewExtends tabViewExtends1;
        private System.Windows.Forms.TabPage tabPage1;
        private CoreFramework.Controles.Controle.PanelExtends panelExtends1;
        private CoreFramework.Controles.Controle.MemoExtends mmo_retorno;
        private CoreFramework.Controles.Controle.FieldExtends fld_stringConnection;

    }
}