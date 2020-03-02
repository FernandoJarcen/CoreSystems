namespace sistematica.application.Formularios
{
    partial class frmEditorXml
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorXml));
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.panelCaptionExtends1 = new CoreFramework.Controles.Controle.PanelCaptionExtends();
            this.cap_alterar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cap_salvar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cpt_sair = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_executar = new CoreFramework.Controles.Controle.ButtonImageExtends();
            this.lbl_arquivo = new System.Windows.Forms.Label();
            this.fld_arquivo = new CoreFramework.Controles.Controle.FileExtends();
            this.tabViewExtends1 = new CoreFramework.Controles.Controle.TabViewExtends();
            this.tab_geral = new System.Windows.Forms.TabPage();
            this.panelExtends1 = new CoreFramework.Controles.Controle.PanelExtends();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_expansivel = new CoreFramework.Controles.Controle.ComboBoxExtends();
            this.dte_data = new CoreFramework.Controles.Controle.DateTimeExtends();
            this.msk_versao = new CoreFramework.Controles.Controle.MaskEditExtends();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_formatos = new CoreFramework.Controles.Controle.DirectoryExtends();
            this.fld_exportador = new CoreFramework.Controles.Controle.DirectoryExtends();
            this.fld_customizacao = new CoreFramework.Controles.Controle.DirectoryExtends();
            this.fld_configuracoes = new CoreFramework.Controles.Controle.DirectoryExtends();
            this.fld_executaveis = new CoreFramework.Controles.Controle.DirectoryExtends();
            this.fld_instancia = new CoreFramework.Controles.Controle.FieldExtends();
            this.fld_log = new CoreFramework.Controles.Controle.DirectoryExtends();
            this.fld_padrao = new CoreFramework.Controles.Controle.DirectoryExtends();
            this.tab_instancias = new System.Windows.Forms.TabPage();
            this.panelExtends2 = new CoreFramework.Controles.Controle.PanelExtends();
            this.simpleGridExtends1 = new CoreFramework.Controles.Controle.SimpleGridExtends();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbo_banco = new CoreFramework.Controles.Controle.ComboListExtends();
            this.cbo_autenticacao = new CoreFramework.Controles.Controle.ComboBoxExtends();
            this.fld_source = new CoreFramework.Controles.Controle.FieldExtends();
            this.buttonMaxExtends1 = new CoreFramework.Controles.Controle.ButtonMaxExtends();
            this.fld_id = new CoreFramework.Controles.Controle.FieldExtends();
            this.panelCaptionExtends1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabViewExtends1.SuspendLayout();
            this.tab_geral.SuspendLayout();
            this.panelExtends1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_instancias.SuspendLayout();
            this.panelExtends2.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.captionExtends1.Size = new System.Drawing.Size(984, 33);
            this.captionExtends1.Subtitulo = "Subtítulo";
            this.captionExtends1.TabIndex = 12;
            this.captionExtends1.Tamanho = 984;
            this.captionExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoCaption.Pequeno;
            this.captionExtends1.Titulo = "Editor XML";
            // 
            // panelCaptionExtends1
            // 
            this.panelCaptionExtends1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCaptionExtends1.Controls.Add(this.cap_alterar);
            this.panelCaptionExtends1.Controls.Add(this.cap_salvar);
            this.panelCaptionExtends1.Controls.Add(this.cpt_sair);
            this.panelCaptionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaptionExtends1.Item.Add(this.cap_alterar);
            this.panelCaptionExtends1.Item.Add(this.cap_salvar);
            this.panelCaptionExtends1.Item.Add(this.cpt_sair);
            this.panelCaptionExtends1.Location = new System.Drawing.Point(0, 33);
            this.panelCaptionExtends1.Name = "panelCaptionExtends1";
            this.panelCaptionExtends1.Size = new System.Drawing.Size(984, 38);
            this.panelCaptionExtends1.TabIndex = 13;
            // 
            // cap_alterar
            // 
            this.cap_alterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_alterar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_alterar.Build = null;
            this.cap_alterar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_alterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_alterar.GlobalID = 0;
            this.cap_alterar.GlobalName = "";
            this.cap_alterar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_alterar.Imagem")));
            this.cap_alterar.Location = new System.Drawing.Point(222, 0);
            this.cap_alterar.MensagemPadrao = "";
            this.cap_alterar.MostrarBorda = false;
            this.cap_alterar.MostrarImagem = true;
            this.cap_alterar.Name = "cap_alterar";
            this.cap_alterar.Size = new System.Drawing.Size(123, 38);
            this.cap_alterar.TabIndex = 4;
            this.cap_alterar.Titulo = "Alterar";
            // 
            // cap_salvar
            // 
            this.cap_salvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_salvar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_salvar.Build = null;
            this.cap_salvar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_salvar.GlobalID = 0;
            this.cap_salvar.GlobalName = "";
            this.cap_salvar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_salvar.Imagem")));
            this.cap_salvar.Location = new System.Drawing.Point(99, 0);
            this.cap_salvar.MensagemPadrao = "";
            this.cap_salvar.MostrarBorda = false;
            this.cap_salvar.MostrarImagem = true;
            this.cap_salvar.Name = "cap_salvar";
            this.cap_salvar.Size = new System.Drawing.Size(123, 38);
            this.cap_salvar.TabIndex = 3;
            this.cap_salvar.Titulo = "Salvar";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btn_executar);
            this.panel1.Controls.Add(this.lbl_arquivo);
            this.panel1.Controls.Add(this.fld_arquivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 36);
            this.panel1.TabIndex = 14;
            // 
            // btn_executar
            // 
            this.btn_executar.Borda = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_executar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_executar.Build = null;
            this.btn_executar.Cor = System.Drawing.SystemColors.Info;
            this.btn_executar.GlobalID = 0;
            this.btn_executar.GlobalName = "";
            this.btn_executar.Imagem = ((System.Drawing.Image)(resources.GetObject("btn_executar.Imagem")));
            this.btn_executar.Location = new System.Drawing.Point(755, 7);
            this.btn_executar.MensagemPadrao = "";
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(26, 24);
            this.btn_executar.TabIndex = 2;
            this.btn_executar.Tamanho = 26;
            this.btn_executar.AoClicar += new System.EventHandler(this.btn_executar_AoClicar);
            // 
            // lbl_arquivo
            // 
            this.lbl_arquivo.AutoSize = true;
            this.lbl_arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arquivo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_arquivo.Location = new System.Drawing.Point(189, 11);
            this.lbl_arquivo.Name = "lbl_arquivo";
            this.lbl_arquivo.Size = new System.Drawing.Size(0, 16);
            this.lbl_arquivo.TabIndex = 1;
            // 
            // fld_arquivo
            // 
            this.fld_arquivo.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_arquivo.Build = null;
            this.fld_arquivo.Caminho = "";
            this.fld_arquivo.Editavel = true;
            this.fld_arquivo.GlobalID = 0;
            this.fld_arquivo.GlobalName = "";
            this.fld_arquivo.Location = new System.Drawing.Point(12, 7);
            this.fld_arquivo.MensagemPadrao = "";
            this.fld_arquivo.Name = "fld_arquivo";
            this.fld_arquivo.Obrigatorio = false;
            this.fld_arquivo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_arquivo.Size = new System.Drawing.Size(743, 23);
            this.fld_arquivo.TabIndex = 0;
            this.fld_arquivo.Tamanho = 743;
            this.fld_arquivo.TamanhoTexto = 600;
            this.fld_arquivo.Titulo = "Arquivo";
            // 
            // tabViewExtends1
            // 
            this.tabViewExtends1.Controls.Add(this.tab_geral);
            this.tabViewExtends1.Controls.Add(this.tab_instancias);
            this.tabViewExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabViewExtends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabViewExtends1.ItemSize = new System.Drawing.Size(96, 25);
            this.tabViewExtends1.Location = new System.Drawing.Point(0, 107);
            this.tabViewExtends1.Name = "tabViewExtends1";
            this.tabViewExtends1.SelectedIndex = 0;
            this.tabViewExtends1.Size = new System.Drawing.Size(984, 455);
            this.tabViewExtends1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabViewExtends1.TabIndex = 15;
            // 
            // tab_geral
            // 
            this.tab_geral.Controls.Add(this.panelExtends1);
            this.tab_geral.Location = new System.Drawing.Point(4, 29);
            this.tab_geral.Name = "tab_geral";
            this.tab_geral.Padding = new System.Windows.Forms.Padding(3);
            this.tab_geral.Size = new System.Drawing.Size(976, 422);
            this.tab_geral.TabIndex = 0;
            this.tab_geral.Text = "Geral";
            this.tab_geral.UseVisualStyleBackColor = true;
            // 
            // panelExtends1
            // 
            this.panelExtends1.Altura = 50;
            this.panelExtends1.BackColor = System.Drawing.Color.White;
            this.panelExtends1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExtends1.Cabecalho = "Configurações Gerais";
            this.panelExtends1.Centralizar = true;
            this.panelExtends1.Controls.Add(this.groupBox2);
            this.panelExtends1.Controls.Add(this.groupBox1);
            this.panelExtends1.Cor = System.Drawing.Color.SteelBlue;
            this.panelExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExtends1.Location = new System.Drawing.Point(3, 3);
            this.panelExtends1.MostrarBorda = true;
            this.panelExtends1.Name = "panelExtends1";
            this.panelExtends1.Posicao = CoreFramework.Objetos.Enums.PosicaoPainel.Topo;
            this.panelExtends1.Size = new System.Drawing.Size(970, 416);
            this.panelExtends1.TabIndex = 2;
            this.panelExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoPainel.grande;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_expansivel);
            this.groupBox2.Controls.Add(this.dte_data);
            this.groupBox2.Controls.Add(this.msk_versao);
            this.groupBox2.Location = new System.Drawing.Point(9, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema";
            // 
            // cbo_expansivel
            // 
            this.cbo_expansivel.Borda = System.Windows.Forms.BorderStyle.None;
            this.cbo_expansivel.Build = null;
            this.cbo_expansivel.Chave = "";
            this.cbo_expansivel.Dados = false;
            this.cbo_expansivel.Display = "";
            this.cbo_expansivel.GlobalID = 0;
            this.cbo_expansivel.GlobalName = "";
            this.cbo_expansivel.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbo_expansivel.Location = new System.Drawing.Point(10, 74);
            this.cbo_expansivel.MensagemPadrao = "";
            this.cbo_expansivel.Name = "cbo_expansivel";
            this.cbo_expansivel.Obrigatorio = false;
            this.cbo_expansivel.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.cbo_expansivel.Query = "";
            this.cbo_expansivel.QuerySecundaria = "";
            this.cbo_expansivel.Size = new System.Drawing.Size(242, 24);
            this.cbo_expansivel.Tabela = "";
            this.cbo_expansivel.TabIndex = 2;
            this.cbo_expansivel.Tamanho = 242;
            this.cbo_expansivel.TamanhoTexto = 121;
            this.cbo_expansivel.Titulo = "Expansível";
            this.cbo_expansivel.Valor = "";
            // 
            // dte_data
            // 
            this.dte_data.Borda = System.Windows.Forms.BorderStyle.None;
            this.dte_data.Build = null;
            this.dte_data.Formato = CoreFramework.Objetos.Enums.TipoDatas.DataCurta;
            this.dte_data.GlobalID = 0;
            this.dte_data.GlobalName = "";
            this.dte_data.Location = new System.Drawing.Point(10, 48);
            this.dte_data.MensagemPadrao = "";
            this.dte_data.Name = "dte_data";
            this.dte_data.Obrigatorio = false;
            this.dte_data.Padrao = false;
            this.dte_data.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.dte_data.Size = new System.Drawing.Size(221, 23);
            this.dte_data.TabIndex = 1;
            this.dte_data.Tamanho = 221;
            this.dte_data.TamanhoTexto = 100;
            this.dte_data.Titulo = "Data";
            this.dte_data.Valor = "18/02/2019";
            // 
            // msk_versao
            // 
            this.msk_versao.Borda = System.Windows.Forms.BorderStyle.None;
            this.msk_versao.Build = null;
            this.msk_versao.ComprimentoMaximo = 32767;
            this.msk_versao.FormatoMascara = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.msk_versao.GlobalID = 0;
            this.msk_versao.GlobalName = "";
            this.msk_versao.Location = new System.Drawing.Point(10, 21);
            this.msk_versao.Mascara = "";
            this.msk_versao.MensagemPadrao = "";
            this.msk_versao.Name = "msk_versao";
            this.msk_versao.Obrigatorio = false;
            this.msk_versao.Padrao = CoreFramework.Objetos.Enums.Mascaras.Nulo;
            this.msk_versao.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.msk_versao.RetornaMascara = false;
            this.msk_versao.Size = new System.Drawing.Size(241, 23);
            this.msk_versao.TabIndex = 0;
            this.msk_versao.Tamanho = 241;
            this.msk_versao.TamanhoTexto = 120;
            this.msk_versao.Titulo = "Versão";
            this.msk_versao.Valor = "  ,   ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_formatos);
            this.groupBox1.Controls.Add(this.fld_exportador);
            this.groupBox1.Controls.Add(this.fld_customizacao);
            this.groupBox1.Controls.Add(this.fld_configuracoes);
            this.groupBox1.Controls.Add(this.fld_executaveis);
            this.groupBox1.Controls.Add(this.fld_instancia);
            this.groupBox1.Controls.Add(this.fld_log);
            this.groupBox1.Controls.Add(this.fld_padrao);
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 242);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caminhos";
            // 
            // fld_formatos
            // 
            this.fld_formatos.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_formatos.Build = null;
            this.fld_formatos.Editavel = true;
            this.fld_formatos.GlobalID = 0;
            this.fld_formatos.GlobalName = "";
            this.fld_formatos.Location = new System.Drawing.Point(10, 212);
            this.fld_formatos.MensagemPadrao = "";
            this.fld_formatos.Name = "fld_formatos";
            this.fld_formatos.Obrigatorio = false;
            this.fld_formatos.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_formatos.Size = new System.Drawing.Size(751, 23);
            this.fld_formatos.TabIndex = 14;
            this.fld_formatos.Tamanho = 751;
            this.fld_formatos.TamanhoTexto = 630;
            this.fld_formatos.Titulo = "Formatos";
            // 
            // fld_exportador
            // 
            this.fld_exportador.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_exportador.Build = null;
            this.fld_exportador.Editavel = true;
            this.fld_exportador.GlobalID = 0;
            this.fld_exportador.GlobalName = "";
            this.fld_exportador.Location = new System.Drawing.Point(10, 186);
            this.fld_exportador.MensagemPadrao = "";
            this.fld_exportador.Name = "fld_exportador";
            this.fld_exportador.Obrigatorio = false;
            this.fld_exportador.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_exportador.Size = new System.Drawing.Size(751, 23);
            this.fld_exportador.TabIndex = 13;
            this.fld_exportador.Tamanho = 751;
            this.fld_exportador.TamanhoTexto = 630;
            this.fld_exportador.Titulo = "Exportador";
            // 
            // fld_customizacao
            // 
            this.fld_customizacao.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_customizacao.Build = null;
            this.fld_customizacao.Editavel = true;
            this.fld_customizacao.GlobalID = 0;
            this.fld_customizacao.GlobalName = "";
            this.fld_customizacao.Location = new System.Drawing.Point(10, 159);
            this.fld_customizacao.MensagemPadrao = "";
            this.fld_customizacao.Name = "fld_customizacao";
            this.fld_customizacao.Obrigatorio = false;
            this.fld_customizacao.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_customizacao.Size = new System.Drawing.Size(751, 23);
            this.fld_customizacao.TabIndex = 12;
            this.fld_customizacao.Tamanho = 751;
            this.fld_customizacao.TamanhoTexto = 630;
            this.fld_customizacao.Titulo = "Customização";
            // 
            // fld_configuracoes
            // 
            this.fld_configuracoes.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_configuracoes.Build = null;
            this.fld_configuracoes.Editavel = true;
            this.fld_configuracoes.GlobalID = 0;
            this.fld_configuracoes.GlobalName = "";
            this.fld_configuracoes.Location = new System.Drawing.Point(10, 132);
            this.fld_configuracoes.MensagemPadrao = "";
            this.fld_configuracoes.Name = "fld_configuracoes";
            this.fld_configuracoes.Obrigatorio = false;
            this.fld_configuracoes.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_configuracoes.Size = new System.Drawing.Size(751, 23);
            this.fld_configuracoes.TabIndex = 11;
            this.fld_configuracoes.Tamanho = 751;
            this.fld_configuracoes.TamanhoTexto = 630;
            this.fld_configuracoes.Titulo = "Configurações";
            // 
            // fld_executaveis
            // 
            this.fld_executaveis.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_executaveis.Build = null;
            this.fld_executaveis.Editavel = true;
            this.fld_executaveis.GlobalID = 0;
            this.fld_executaveis.GlobalName = "";
            this.fld_executaveis.Location = new System.Drawing.Point(10, 105);
            this.fld_executaveis.MensagemPadrao = "";
            this.fld_executaveis.Name = "fld_executaveis";
            this.fld_executaveis.Obrigatorio = false;
            this.fld_executaveis.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_executaveis.Size = new System.Drawing.Size(751, 23);
            this.fld_executaveis.TabIndex = 10;
            this.fld_executaveis.Tamanho = 751;
            this.fld_executaveis.TamanhoTexto = 630;
            this.fld_executaveis.Titulo = "Executáveis";
            // 
            // fld_instancia
            // 
            this.fld_instancia.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_instancia.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_instancia.Build = null;
            this.fld_instancia.Caractere = '\0';
            this.fld_instancia.ComprimentoMaximo = 50;
            this.fld_instancia.Destacado = false;
            this.fld_instancia.GlobalID = 0;
            this.fld_instancia.GlobalName = "";
            this.fld_instancia.Location = new System.Drawing.Point(10, 78);
            this.fld_instancia.MensagemPadrao = "";
            this.fld_instancia.Name = "fld_instancia";
            this.fld_instancia.Obrigatorio = false;
            this.fld_instancia.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_instancia.Size = new System.Drawing.Size(221, 23);
            this.fld_instancia.TabIndex = 9;
            this.fld_instancia.Tamanho = 221;
            this.fld_instancia.TamanhoTexto = 100;
            this.fld_instancia.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_instancia.Titulo = "Instância";
            this.fld_instancia.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // fld_log
            // 
            this.fld_log.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_log.Build = null;
            this.fld_log.Editavel = true;
            this.fld_log.GlobalID = 0;
            this.fld_log.GlobalName = "";
            this.fld_log.Location = new System.Drawing.Point(10, 51);
            this.fld_log.MensagemPadrao = "";
            this.fld_log.Name = "fld_log";
            this.fld_log.Obrigatorio = false;
            this.fld_log.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_log.Size = new System.Drawing.Size(751, 23);
            this.fld_log.TabIndex = 8;
            this.fld_log.Tamanho = 751;
            this.fld_log.TamanhoTexto = 630;
            this.fld_log.Titulo = "Log";
            // 
            // fld_padrao
            // 
            this.fld_padrao.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_padrao.Build = null;
            this.fld_padrao.Editavel = true;
            this.fld_padrao.GlobalID = 0;
            this.fld_padrao.GlobalName = "";
            this.fld_padrao.Location = new System.Drawing.Point(10, 24);
            this.fld_padrao.MensagemPadrao = "";
            this.fld_padrao.Name = "fld_padrao";
            this.fld_padrao.Obrigatorio = false;
            this.fld_padrao.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_padrao.Size = new System.Drawing.Size(751, 23);
            this.fld_padrao.TabIndex = 7;
            this.fld_padrao.Tamanho = 751;
            this.fld_padrao.TamanhoTexto = 630;
            this.fld_padrao.Titulo = "Padrão";
            // 
            // tab_instancias
            // 
            this.tab_instancias.Controls.Add(this.panelExtends2);
            this.tab_instancias.Controls.Add(this.panel2);
            this.tab_instancias.Location = new System.Drawing.Point(4, 29);
            this.tab_instancias.Name = "tab_instancias";
            this.tab_instancias.Padding = new System.Windows.Forms.Padding(3);
            this.tab_instancias.Size = new System.Drawing.Size(976, 422);
            this.tab_instancias.TabIndex = 1;
            this.tab_instancias.Text = "Instâncias";
            this.tab_instancias.UseVisualStyleBackColor = true;
            // 
            // panelExtends2
            // 
            this.panelExtends2.Altura = 50;
            this.panelExtends2.BackColor = System.Drawing.Color.White;
            this.panelExtends2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExtends2.Cabecalho = "Configurações de Instâncias";
            this.panelExtends2.Centralizar = true;
            this.panelExtends2.Controls.Add(this.simpleGridExtends1);
            this.panelExtends2.Cor = System.Drawing.Color.SteelBlue;
            this.panelExtends2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExtends2.Location = new System.Drawing.Point(3, 60);
            this.panelExtends2.MostrarBorda = true;
            this.panelExtends2.Name = "panelExtends2";
            this.panelExtends2.Posicao = CoreFramework.Objetos.Enums.PosicaoPainel.Topo;
            this.panelExtends2.Size = new System.Drawing.Size(970, 359);
            this.panelExtends2.TabIndex = 2;
            this.panelExtends2.TipoPainel = CoreFramework.Objetos.Enums.TipoPainel.grande;
            // 
            // simpleGridExtends1
            // 
            this.simpleGridExtends1.Borda = System.Windows.Forms.BorderStyle.None;
            this.simpleGridExtends1.Build = null;
            this.simpleGridExtends1.Cabecalho = "Instâncias Ativas";
            this.simpleGridExtends1.Canonico = true;
            this.simpleGridExtends1.Chave = "";
            this.simpleGridExtends1.ColunaEditavel = System.Drawing.Color.Red;
            this.simpleGridExtends1.Consultas = null;
            this.simpleGridExtends1.CorTitulo = System.Drawing.Color.LightSlateGray;
            this.simpleGridExtends1.Dados = null;
            this.simpleGridExtends1.Details = null;
            this.simpleGridExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleGridExtends1.ExportaPadrao = CoreFramework.Objetos.Enums.ExportaExcel.Excel2007;
            this.simpleGridExtends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.simpleGridExtends1.Fonte = 10F;
            this.simpleGridExtends1.GlobalID = 0;
            this.simpleGridExtends1.GlobalName = "";
            this.simpleGridExtends1.Location = new System.Drawing.Point(0, 50);
            this.simpleGridExtends1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleGridExtends1.Master = CoreFramework.Objetos.Enums.EscolhaBooleana.Não;
            this.simpleGridExtends1.Mensagem = "Mensagem";
            this.simpleGridExtends1.MensagemPadrao = "";
            this.simpleGridExtends1.Modo = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.simpleGridExtends1.MostrarRodape = true;
            this.simpleGridExtends1.Name = "simpleGridExtends1";
            this.simpleGridExtends1.Ocultar = false;
            this.simpleGridExtends1.Ordenacao = "";
            this.simpleGridExtends1.Query = "";
            this.simpleGridExtends1.Size = new System.Drawing.Size(968, 307);
            this.simpleGridExtends1.Subconsulta = false;
            this.simpleGridExtends1.TabIndex = 1;
            this.simpleGridExtends1.Tamanho = 968;
            this.simpleGridExtends1.AoClique += new System.EventHandler(this.simpleGridExtends1_AoClique);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.cbo_banco);
            this.panel2.Controls.Add(this.cbo_autenticacao);
            this.panel2.Controls.Add(this.fld_source);
            this.panel2.Controls.Add(this.buttonMaxExtends1);
            this.panel2.Controls.Add(this.fld_id);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 57);
            this.panel2.TabIndex = 1;
            // 
            // cbo_banco
            // 
            this.cbo_banco.Borda = System.Windows.Forms.BorderStyle.None;
            this.cbo_banco.Build = null;
            this.cbo_banco.GlobalID = 0;
            this.cbo_banco.GlobalName = "";
            this.cbo_banco.Items.AddRange(new object[] {
            "SQL",
            "ORACLE",
            "MY SQL"});
            this.cbo_banco.Location = new System.Drawing.Point(475, 30);
            this.cbo_banco.MensagemPadrao = "";
            this.cbo_banco.Name = "cbo_banco";
            this.cbo_banco.Obrigatorio = false;
            this.cbo_banco.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.cbo_banco.Size = new System.Drawing.Size(227, 24);
            this.cbo_banco.TabIndex = 7;
            this.cbo_banco.Tamanho = 227;
            this.cbo_banco.TamanhoTexto = 121;
            this.cbo_banco.Titulo = "Banco";
            this.cbo_banco.Valor = "";
            // 
            // cbo_autenticacao
            // 
            this.cbo_autenticacao.Borda = System.Windows.Forms.BorderStyle.None;
            this.cbo_autenticacao.Build = null;
            this.cbo_autenticacao.Chave = "";
            this.cbo_autenticacao.Dados = false;
            this.cbo_autenticacao.Display = "";
            this.cbo_autenticacao.GlobalID = 0;
            this.cbo_autenticacao.GlobalName = "";
            this.cbo_autenticacao.Items.AddRange(new object[] {
            "BANCO",
            "AD"});
            this.cbo_autenticacao.Location = new System.Drawing.Point(475, 4);
            this.cbo_autenticacao.MensagemPadrao = "";
            this.cbo_autenticacao.Name = "cbo_autenticacao";
            this.cbo_autenticacao.Obrigatorio = false;
            this.cbo_autenticacao.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.cbo_autenticacao.Query = "";
            this.cbo_autenticacao.QuerySecundaria = "";
            this.cbo_autenticacao.Size = new System.Drawing.Size(227, 24);
            this.cbo_autenticacao.Tabela = "";
            this.cbo_autenticacao.TabIndex = 6;
            this.cbo_autenticacao.Tamanho = 227;
            this.cbo_autenticacao.TamanhoTexto = 121;
            this.cbo_autenticacao.Titulo = "Autenticação";
            this.cbo_autenticacao.Valor = "";
            // 
            // fld_source
            // 
            this.fld_source.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_source.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_source.Build = null;
            this.fld_source.Caractere = '\0';
            this.fld_source.ComprimentoMaximo = 50;
            this.fld_source.Destacado = false;
            this.fld_source.GlobalID = 0;
            this.fld_source.GlobalName = "";
            this.fld_source.Location = new System.Drawing.Point(5, 30);
            this.fld_source.MensagemPadrao = "";
            this.fld_source.Name = "fld_source";
            this.fld_source.Obrigatorio = false;
            this.fld_source.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_source.Size = new System.Drawing.Size(467, 23);
            this.fld_source.TabIndex = 5;
            this.fld_source.Tamanho = 467;
            this.fld_source.TamanhoTexto = 400;
            this.fld_source.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_source.Titulo = "Source";
            this.fld_source.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // buttonMaxExtends1
            // 
            this.buttonMaxExtends1.Borda = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonMaxExtends1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonMaxExtends1.Build = null;
            this.buttonMaxExtends1.Cor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMaxExtends1.GlobalID = 0;
            this.buttonMaxExtends1.GlobalName = "";
            this.buttonMaxExtends1.Imagem = ((System.Drawing.Image)(resources.GetObject("buttonMaxExtends1.Imagem")));
            this.buttonMaxExtends1.Location = new System.Drawing.Point(709, 4);
            this.buttonMaxExtends1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMaxExtends1.Mensagem = "Atualizar";
            this.buttonMaxExtends1.MensagemPadrao = "";
            this.buttonMaxExtends1.Name = "buttonMaxExtends1";
            this.buttonMaxExtends1.Size = new System.Drawing.Size(155, 35);
            this.buttonMaxExtends1.TabIndex = 4;
            // 
            // fld_id
            // 
            this.fld_id.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_id.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_id.Build = null;
            this.fld_id.Caractere = '\0';
            this.fld_id.ComprimentoMaximo = 5;
            this.fld_id.Destacado = false;
            this.fld_id.GlobalID = 0;
            this.fld_id.GlobalName = "";
            this.fld_id.Location = new System.Drawing.Point(5, 4);
            this.fld_id.MensagemPadrao = "";
            this.fld_id.Name = "fld_id";
            this.fld_id.Obrigatorio = false;
            this.fld_id.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_id.Size = new System.Drawing.Size(168, 23);
            this.fld_id.TabIndex = 0;
            this.fld_id.Tamanho = 168;
            this.fld_id.TamanhoTexto = 100;
            this.fld_id.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_id.Titulo = "ID";
            this.fld_id.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // frmEditorXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.ControlBox = false;
            this.Controls.Add(this.tabViewExtends1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCaptionExtends1);
            this.Controls.Add(this.captionExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEditorXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor XML";
            this.panelCaptionExtends1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabViewExtends1.ResumeLayout(false);
            this.tab_geral.ResumeLayout(false);
            this.panelExtends1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tab_instancias.ResumeLayout(false);
            this.panelExtends2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private CoreFramework.Controles.Controle.PanelCaptionExtends panelCaptionExtends1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_alterar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_salvar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_sair;
        private System.Windows.Forms.Panel panel1;
        private CoreFramework.Controles.Controle.TabViewExtends tabViewExtends1;
        private System.Windows.Forms.TabPage tab_geral;
        private CoreFramework.Controles.Controle.PanelExtends panelExtends1;
        private System.Windows.Forms.TabPage tab_instancias;
        private System.Windows.Forms.Label lbl_arquivo;
        private CoreFramework.Controles.Controle.FileExtends fld_arquivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private CoreFramework.Controles.Controle.ComboBoxExtends cbo_expansivel;
        private CoreFramework.Controles.Controle.DateTimeExtends dte_data;
        private CoreFramework.Controles.Controle.MaskEditExtends msk_versao;
        private System.Windows.Forms.GroupBox groupBox1;
        private CoreFramework.Controles.Controle.DirectoryExtends fld_formatos;
        private CoreFramework.Controles.Controle.DirectoryExtends fld_exportador;
        private CoreFramework.Controles.Controle.DirectoryExtends fld_customizacao;
        private CoreFramework.Controles.Controle.DirectoryExtends fld_configuracoes;
        private CoreFramework.Controles.Controle.DirectoryExtends fld_executaveis;
        private CoreFramework.Controles.Controle.FieldExtends fld_instancia;
        private CoreFramework.Controles.Controle.DirectoryExtends fld_log;
        private CoreFramework.Controles.Controle.DirectoryExtends fld_padrao;
        private CoreFramework.Controles.Controle.PanelExtends panelExtends2;
        private CoreFramework.Controles.Controle.SimpleGridExtends simpleGridExtends1;
        private System.Windows.Forms.Panel panel2;
        private CoreFramework.Controles.Controle.ComboListExtends cbo_banco;
        private CoreFramework.Controles.Controle.ComboBoxExtends cbo_autenticacao;
        private CoreFramework.Controles.Controle.FieldExtends fld_source;
        private CoreFramework.Controles.Controle.ButtonMaxExtends buttonMaxExtends1;
        private CoreFramework.Controles.Controle.FieldExtends fld_id;
        private CoreFramework.Controles.Controle.ButtonImageExtends btn_executar;

    }
}