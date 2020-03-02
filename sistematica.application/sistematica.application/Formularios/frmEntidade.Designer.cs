namespace sistematica.application.Formularios
{
    partial class frmEntidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntidade));
            this.tabViewExtends1 = new CoreFramework.Controles.Controle.TabViewExtends();
            this.tab_entidade = new System.Windows.Forms.TabPage();
            this.panelExtends2 = new CoreFramework.Controles.Controle.PanelExtends();
            this.cbo_escopo = new CoreFramework.Controles.Controle.ComboBoxExtends();
            this.label1 = new System.Windows.Forms.Label();
            this.fld_displayEntidade = new CoreFramework.Controles.Controle.FieldExtends();
            this.mmo_descricao = new CoreFramework.Controles.Controle.MemoExtends();
            this.lbl_internoEntidade = new System.Windows.Forms.Label();
            this.fld_nomeEntidade = new CoreFramework.Controles.Controle.FieldExtends();
            this.tab_campos = new System.Windows.Forms.TabPage();
            this.pnl_campos = new CoreFramework.Controles.Controle.PanelExtends();
            this.fld_comentario = new CoreFramework.Controles.Controle.FieldExtends();
            this.chk_dataAtual = new System.Windows.Forms.CheckBox();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.sgd_campos = new CoreFramework.Controles.Controle.SimpleGridExtends();
            this.cbo_aceitaNulo = new CoreFramework.Controles.Controle.ComboBoxExtends();
            this.fld_padrao = new CoreFramework.Controles.Controle.FieldExtends();
            this.fld_tamanho = new CoreFramework.Controles.Controle.FieldExtends();
            this.cbo_tipo = new CoreFramework.Controles.Controle.ComboBoxExtends();
            this.fld_nome = new CoreFramework.Controles.Controle.FieldExtends();
            this.panelCaptionExtends1 = new CoreFramework.Controles.Controle.PanelCaptionExtends();
            this.cap_aplicar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cpt_sair = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.tabViewExtends1.SuspendLayout();
            this.tab_entidade.SuspendLayout();
            this.panelExtends2.SuspendLayout();
            this.tab_campos.SuspendLayout();
            this.pnl_campos.SuspendLayout();
            this.panelCaptionExtends1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabViewExtends1
            // 
            this.tabViewExtends1.Controls.Add(this.tab_entidade);
            this.tabViewExtends1.Controls.Add(this.tab_campos);
            this.tabViewExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabViewExtends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabViewExtends1.ItemSize = new System.Drawing.Size(96, 25);
            this.tabViewExtends1.Location = new System.Drawing.Point(0, 71);
            this.tabViewExtends1.Name = "tabViewExtends1";
            this.tabViewExtends1.SelectedIndex = 0;
            this.tabViewExtends1.Size = new System.Drawing.Size(884, 433);
            this.tabViewExtends1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabViewExtends1.TabIndex = 13;
            // 
            // tab_entidade
            // 
            this.tab_entidade.Controls.Add(this.panelExtends2);
            this.tab_entidade.Location = new System.Drawing.Point(4, 29);
            this.tab_entidade.Name = "tab_entidade";
            this.tab_entidade.Padding = new System.Windows.Forms.Padding(3);
            this.tab_entidade.Size = new System.Drawing.Size(876, 400);
            this.tab_entidade.TabIndex = 1;
            this.tab_entidade.Text = "Entidade";
            this.tab_entidade.UseVisualStyleBackColor = true;
            // 
            // panelExtends2
            // 
            this.panelExtends2.Altura = 50;
            this.panelExtends2.BackColor = System.Drawing.Color.White;
            this.panelExtends2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExtends2.Cabecalho = "";
            this.panelExtends2.Centralizar = true;
            this.panelExtends2.Controls.Add(this.cbo_escopo);
            this.panelExtends2.Controls.Add(this.label1);
            this.panelExtends2.Controls.Add(this.fld_displayEntidade);
            this.panelExtends2.Controls.Add(this.mmo_descricao);
            this.panelExtends2.Controls.Add(this.lbl_internoEntidade);
            this.panelExtends2.Controls.Add(this.fld_nomeEntidade);
            this.panelExtends2.Cor = System.Drawing.Color.SteelBlue;
            this.panelExtends2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExtends2.Location = new System.Drawing.Point(3, 3);
            this.panelExtends2.MostrarBorda = true;
            this.panelExtends2.Name = "panelExtends2";
            this.panelExtends2.Posicao = CoreFramework.Objetos.Enums.PosicaoPainel.Topo;
            this.panelExtends2.Size = new System.Drawing.Size(870, 394);
            this.panelExtends2.TabIndex = 0;
            this.panelExtends2.TipoPainel = CoreFramework.Objetos.Enums.TipoPainel.grande;
            // 
            // cbo_escopo
            // 
            this.cbo_escopo.Borda = System.Windows.Forms.BorderStyle.None;
            this.cbo_escopo.Build = null;
            this.cbo_escopo.Chave = "";
            this.cbo_escopo.Dados = false;
            this.cbo_escopo.Display = "";
            this.cbo_escopo.GlobalID = 0;
            this.cbo_escopo.GlobalName = "";
            this.cbo_escopo.Items.AddRange(new object[] {
            "Publica",
            "Restrita"});
            this.cbo_escopo.Location = new System.Drawing.Point(8, 179);
            this.cbo_escopo.MensagemPadrao = "";
            this.cbo_escopo.Name = "cbo_escopo";
            this.cbo_escopo.Obrigatorio = false;
            this.cbo_escopo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.cbo_escopo.Query = "";
            this.cbo_escopo.QuerySecundaria = "";
            this.cbo_escopo.Size = new System.Drawing.Size(216, 24);
            this.cbo_escopo.Tabela = "";
            this.cbo_escopo.TabIndex = 4;
            this.cbo_escopo.Tamanho = 216;
            this.cbo_escopo.TamanhoTexto = 121;
            this.cbo_escopo.Titulo = "Escopo";
            this.cbo_escopo.Valor = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tabela";
            // 
            // fld_displayEntidade
            // 
            this.fld_displayEntidade.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_displayEntidade.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_displayEntidade.Build = null;
            this.fld_displayEntidade.Caractere = '\0';
            this.fld_displayEntidade.ComprimentoMaximo = 50;
            this.fld_displayEntidade.Destacado = false;
            this.fld_displayEntidade.GlobalID = 0;
            this.fld_displayEntidade.GlobalName = "";
            this.fld_displayEntidade.Location = new System.Drawing.Point(4, 107);
            this.fld_displayEntidade.MensagemPadrao = "";
            this.fld_displayEntidade.Name = "fld_displayEntidade";
            this.fld_displayEntidade.Obrigatorio = false;
            this.fld_displayEntidade.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_displayEntidade.Size = new System.Drawing.Size(380, 23);
            this.fld_displayEntidade.TabIndex = 2;
            this.fld_displayEntidade.Tamanho = 380;
            this.fld_displayEntidade.TamanhoTexto = 280;
            this.fld_displayEntidade.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_displayEntidade.Titulo = "Display";
            this.fld_displayEntidade.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // mmo_descricao
            // 
            this.mmo_descricao.Borda = System.Windows.Forms.BorderStyle.None;
            this.mmo_descricao.Build = null;
            this.mmo_descricao.ComprimentoMaximo = 30;
            this.mmo_descricao.GlobalID = 0;
            this.mmo_descricao.GlobalName = "";
            this.mmo_descricao.Location = new System.Drawing.Point(4, 133);
            this.mmo_descricao.MensagemPadrao = "";
            this.mmo_descricao.Name = "mmo_descricao";
            this.mmo_descricao.Obrigatorio = false;
            this.mmo_descricao.Size = new System.Drawing.Size(499, 43);
            this.mmo_descricao.TabIndex = 3;
            this.mmo_descricao.Tamanho = 499;
            this.mmo_descricao.TamanhoTexto = 400;
            this.mmo_descricao.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.mmo_descricao.Titulo = "Descrição";
            this.mmo_descricao.Valor = "";
            // 
            // lbl_internoEntidade
            // 
            this.lbl_internoEntidade.AutoSize = true;
            this.lbl_internoEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_internoEntidade.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_internoEntidade.Location = new System.Drawing.Point(105, 83);
            this.lbl_internoEntidade.Name = "lbl_internoEntidade";
            this.lbl_internoEntidade.Size = new System.Drawing.Size(72, 17);
            this.lbl_internoEntidade.TabIndex = 1;
            this.lbl_internoEntidade.Text = "Entidade";
            // 
            // fld_nomeEntidade
            // 
            this.fld_nomeEntidade.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_nomeEntidade.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_nomeEntidade.Build = null;
            this.fld_nomeEntidade.Caractere = '\0';
            this.fld_nomeEntidade.ComprimentoMaximo = 80;
            this.fld_nomeEntidade.Destacado = false;
            this.fld_nomeEntidade.GlobalID = 0;
            this.fld_nomeEntidade.GlobalName = "";
            this.fld_nomeEntidade.Location = new System.Drawing.Point(4, 55);
            this.fld_nomeEntidade.MensagemPadrao = "";
            this.fld_nomeEntidade.Name = "fld_nomeEntidade";
            this.fld_nomeEntidade.Obrigatorio = true;
            this.fld_nomeEntidade.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_nomeEntidade.Size = new System.Drawing.Size(380, 23);
            this.fld_nomeEntidade.TabIndex = 0;
            this.fld_nomeEntidade.Tamanho = 380;
            this.fld_nomeEntidade.TamanhoTexto = 280;
            this.fld_nomeEntidade.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_nomeEntidade.Titulo = "Nome";
            this.fld_nomeEntidade.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            this.fld_nomeEntidade.AoPerderFoco += new System.EventHandler(this.fld_nomeEntidade_AoPerderFoco);
            // 
            // tab_campos
            // 
            this.tab_campos.Controls.Add(this.pnl_campos);
            this.tab_campos.Location = new System.Drawing.Point(4, 29);
            this.tab_campos.Name = "tab_campos";
            this.tab_campos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_campos.Size = new System.Drawing.Size(876, 400);
            this.tab_campos.TabIndex = 0;
            this.tab_campos.Text = "Campos";
            this.tab_campos.UseVisualStyleBackColor = true;
            // 
            // pnl_campos
            // 
            this.pnl_campos.Altura = 50;
            this.pnl_campos.BackColor = System.Drawing.Color.White;
            this.pnl_campos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_campos.Cabecalho = "Campos da Entidade";
            this.pnl_campos.Centralizar = true;
            this.pnl_campos.Controls.Add(this.fld_comentario);
            this.pnl_campos.Controls.Add(this.chk_dataAtual);
            this.pnl_campos.Controls.Add(this.btn_Atualizar);
            this.pnl_campos.Controls.Add(this.btn_remover);
            this.pnl_campos.Controls.Add(this.btn_adicionar);
            this.pnl_campos.Controls.Add(this.sgd_campos);
            this.pnl_campos.Controls.Add(this.cbo_aceitaNulo);
            this.pnl_campos.Controls.Add(this.fld_padrao);
            this.pnl_campos.Controls.Add(this.fld_tamanho);
            this.pnl_campos.Controls.Add(this.cbo_tipo);
            this.pnl_campos.Controls.Add(this.fld_nome);
            this.pnl_campos.Cor = System.Drawing.Color.SteelBlue;
            this.pnl_campos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_campos.Location = new System.Drawing.Point(3, 3);
            this.pnl_campos.MostrarBorda = true;
            this.pnl_campos.Name = "pnl_campos";
            this.pnl_campos.Posicao = CoreFramework.Objetos.Enums.PosicaoPainel.Topo;
            this.pnl_campos.Size = new System.Drawing.Size(870, 394);
            this.pnl_campos.TabIndex = 0;
            this.pnl_campos.TipoPainel = CoreFramework.Objetos.Enums.TipoPainel.grande;
            // 
            // fld_comentario
            // 
            this.fld_comentario.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_comentario.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_comentario.Build = null;
            this.fld_comentario.Caractere = '\0';
            this.fld_comentario.ComprimentoMaximo = 50;
            this.fld_comentario.Destacado = false;
            this.fld_comentario.GlobalID = 0;
            this.fld_comentario.GlobalName = "";
            this.fld_comentario.Location = new System.Drawing.Point(371, 82);
            this.fld_comentario.MensagemPadrao = "";
            this.fld_comentario.Name = "fld_comentario";
            this.fld_comentario.Obrigatorio = false;
            this.fld_comentario.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_comentario.Size = new System.Drawing.Size(293, 23);
            this.fld_comentario.TabIndex = 13;
            this.fld_comentario.Tamanho = 293;
            this.fld_comentario.TamanhoTexto = 200;
            this.fld_comentario.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_comentario.Titulo = "Comentário";
            this.fld_comentario.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // chk_dataAtual
            // 
            this.chk_dataAtual.AutoSize = true;
            this.chk_dataAtual.Location = new System.Drawing.Point(371, 110);
            this.chk_dataAtual.Name = "chk_dataAtual";
            this.chk_dataAtual.Size = new System.Drawing.Size(93, 21);
            this.chk_dataAtual.TabIndex = 6;
            this.chk_dataAtual.Text = "Data Atual";
            this.chk_dataAtual.UseVisualStyleBackColor = true;
            this.chk_dataAtual.Visible = false;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Atualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Atualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Atualizar.Location = new System.Drawing.Point(749, 126);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(110, 35);
            this.btn_Atualizar.TabIndex = 11;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_remover.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_remover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remover.Location = new System.Drawing.Point(749, 90);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(110, 35);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_adicionar.Location = new System.Drawing.Point(749, 54);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(110, 35);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // sgd_campos
            // 
            this.sgd_campos.Borda = System.Windows.Forms.BorderStyle.None;
            this.sgd_campos.Build = null;
            this.sgd_campos.Cabecalho = "Campos da Entidade";
            this.sgd_campos.Canonico = true;
            this.sgd_campos.Chave = "";
            this.sgd_campos.ColunaEditavel = System.Drawing.Color.Red;
            this.sgd_campos.Consultas = null;
            this.sgd_campos.CorTitulo = System.Drawing.Color.LightSlateGray;
            this.sgd_campos.Dados = null;
            this.sgd_campos.Details = null;
            this.sgd_campos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sgd_campos.ExportaPadrao = CoreFramework.Objetos.Enums.ExportaExcel.Excel2007;
            this.sgd_campos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sgd_campos.Fonte = 10F;
            this.sgd_campos.GlobalID = 0;
            this.sgd_campos.GlobalName = "";
            this.sgd_campos.Location = new System.Drawing.Point(0, 167);
            this.sgd_campos.Margin = new System.Windows.Forms.Padding(4);
            this.sgd_campos.Master = CoreFramework.Objetos.Enums.EscolhaBooleana.Não;
            this.sgd_campos.Mensagem = "Mensagem";
            this.sgd_campos.MensagemPadrao = "";
            this.sgd_campos.Modo = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.sgd_campos.MostrarRodape = true;
            this.sgd_campos.Name = "sgd_campos";
            this.sgd_campos.Ocultar = false;
            this.sgd_campos.Ordenacao = "";
            this.sgd_campos.Query = "";
            this.sgd_campos.Size = new System.Drawing.Size(868, 225);
            this.sgd_campos.Subconsulta = false;
            this.sgd_campos.TabIndex = 8;
            this.sgd_campos.Tamanho = 868;
            this.sgd_campos.AoClique += new System.EventHandler(this.sgd_campos_AoClique);
            // 
            // cbo_aceitaNulo
            // 
            this.cbo_aceitaNulo.Borda = System.Windows.Forms.BorderStyle.None;
            this.cbo_aceitaNulo.Build = null;
            this.cbo_aceitaNulo.Chave = "";
            this.cbo_aceitaNulo.Dados = false;
            this.cbo_aceitaNulo.Display = "";
            this.cbo_aceitaNulo.GlobalID = 0;
            this.cbo_aceitaNulo.GlobalName = "";
            this.cbo_aceitaNulo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbo_aceitaNulo.Location = new System.Drawing.Point(371, 55);
            this.cbo_aceitaNulo.MensagemPadrao = "";
            this.cbo_aceitaNulo.Name = "cbo_aceitaNulo";
            this.cbo_aceitaNulo.Obrigatorio = false;
            this.cbo_aceitaNulo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.cbo_aceitaNulo.Query = "";
            this.cbo_aceitaNulo.QuerySecundaria = "";
            this.cbo_aceitaNulo.Size = new System.Drawing.Size(214, 24);
            this.cbo_aceitaNulo.Tabela = "";
            this.cbo_aceitaNulo.TabIndex = 5;
            this.cbo_aceitaNulo.Tamanho = 214;
            this.cbo_aceitaNulo.TamanhoTexto = 121;
            this.cbo_aceitaNulo.Titulo = "Aceita Nulo?";
            this.cbo_aceitaNulo.Valor = "";
            // 
            // fld_padrao
            // 
            this.fld_padrao.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_padrao.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_padrao.Build = null;
            this.fld_padrao.Caractere = '\0';
            this.fld_padrao.ComprimentoMaximo = 50;
            this.fld_padrao.Destacado = false;
            this.fld_padrao.GlobalID = 0;
            this.fld_padrao.GlobalName = "";
            this.fld_padrao.Location = new System.Drawing.Point(4, 135);
            this.fld_padrao.MensagemPadrao = "";
            this.fld_padrao.Name = "fld_padrao";
            this.fld_padrao.Obrigatorio = false;
            this.fld_padrao.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_padrao.Size = new System.Drawing.Size(328, 23);
            this.fld_padrao.TabIndex = 4;
            this.fld_padrao.Tamanho = 328;
            this.fld_padrao.TamanhoTexto = 250;
            this.fld_padrao.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_padrao.Titulo = "Padrão";
            this.fld_padrao.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // fld_tamanho
            // 
            this.fld_tamanho.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_tamanho.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_tamanho.Build = null;
            this.fld_tamanho.Caractere = '\0';
            this.fld_tamanho.ComprimentoMaximo = 50;
            this.fld_tamanho.Destacado = false;
            this.fld_tamanho.GlobalID = 0;
            this.fld_tamanho.GlobalName = "";
            this.fld_tamanho.Location = new System.Drawing.Point(4, 108);
            this.fld_tamanho.MensagemPadrao = "";
            this.fld_tamanho.Name = "fld_tamanho";
            this.fld_tamanho.Obrigatorio = false;
            this.fld_tamanho.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_tamanho.Size = new System.Drawing.Size(328, 23);
            this.fld_tamanho.TabIndex = 3;
            this.fld_tamanho.Tamanho = 328;
            this.fld_tamanho.TamanhoTexto = 250;
            this.fld_tamanho.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_tamanho.Titulo = "Tamanho";
            this.fld_tamanho.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.Borda = System.Windows.Forms.BorderStyle.None;
            this.cbo_tipo.Build = null;
            this.cbo_tipo.Chave = "";
            this.cbo_tipo.Dados = false;
            this.cbo_tipo.Display = "";
            this.cbo_tipo.GlobalID = 0;
            this.cbo_tipo.GlobalName = "";
            this.cbo_tipo.Items.AddRange(new object[] {
            "INT",
            "VARCHAR",
            "SMALLDATETIME",
            "BIT",
            "DECIMAL",
            "NUMERIC",
            "CHAR",
            "VARBINARY",
            "IDENTITY"});
            this.cbo_tipo.Location = new System.Drawing.Point(4, 81);
            this.cbo_tipo.MensagemPadrao = "";
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Obrigatorio = false;
            this.cbo_tipo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.cbo_tipo.Query = "";
            this.cbo_tipo.QuerySecundaria = "";
            this.cbo_tipo.Size = new System.Drawing.Size(298, 24);
            this.cbo_tipo.Tabela = "";
            this.cbo_tipo.TabIndex = 2;
            this.cbo_tipo.Tamanho = 298;
            this.cbo_tipo.TamanhoTexto = 220;
            this.cbo_tipo.Titulo = "Tipo";
            this.cbo_tipo.Valor = "";
            this.cbo_tipo.AoMudarIndice += new System.EventHandler(this.cbo_tipo_AoMudarIndice);
            // 
            // fld_nome
            // 
            this.fld_nome.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_nome.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_nome.Build = null;
            this.fld_nome.Caractere = '\0';
            this.fld_nome.ComprimentoMaximo = 50;
            this.fld_nome.Destacado = false;
            this.fld_nome.GlobalID = 0;
            this.fld_nome.GlobalName = "";
            this.fld_nome.Location = new System.Drawing.Point(4, 55);
            this.fld_nome.MensagemPadrao = "";
            this.fld_nome.Name = "fld_nome";
            this.fld_nome.Obrigatorio = false;
            this.fld_nome.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_nome.Size = new System.Drawing.Size(328, 23);
            this.fld_nome.TabIndex = 1;
            this.fld_nome.Tamanho = 328;
            this.fld_nome.TamanhoTexto = 250;
            this.fld_nome.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_nome.Titulo = "Nome";
            this.fld_nome.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // panelCaptionExtends1
            // 
            this.panelCaptionExtends1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCaptionExtends1.Controls.Add(this.cap_aplicar);
            this.panelCaptionExtends1.Controls.Add(this.cpt_sair);
            this.panelCaptionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaptionExtends1.Item.Add(this.cap_aplicar);
            this.panelCaptionExtends1.Item.Add(this.cpt_sair);
            this.panelCaptionExtends1.Location = new System.Drawing.Point(0, 33);
            this.panelCaptionExtends1.Name = "panelCaptionExtends1";
            this.panelCaptionExtends1.Size = new System.Drawing.Size(884, 38);
            this.panelCaptionExtends1.TabIndex = 12;
            // 
            // cap_aplicar
            // 
            this.cap_aplicar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_aplicar.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_aplicar.Build = null;
            this.cap_aplicar.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_aplicar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_aplicar.GlobalID = 0;
            this.cap_aplicar.GlobalName = "";
            this.cap_aplicar.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_aplicar.Imagem")));
            this.cap_aplicar.Location = new System.Drawing.Point(99, 0);
            this.cap_aplicar.MensagemPadrao = "";
            this.cap_aplicar.MostrarBorda = false;
            this.cap_aplicar.MostrarImagem = true;
            this.cap_aplicar.Name = "cap_aplicar";
            this.cap_aplicar.Size = new System.Drawing.Size(123, 38);
            this.cap_aplicar.TabIndex = 3;
            this.cap_aplicar.Titulo = "Aplicar";
            this.cap_aplicar.AoChamar += new System.EventHandler(this.cap_aplicar_AoChamar);
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
            this.captionExtends1.Size = new System.Drawing.Size(884, 33);
            this.captionExtends1.Subtitulo = "Subtítulo";
            this.captionExtends1.TabIndex = 11;
            this.captionExtends1.Tamanho = 884;
            this.captionExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoCaption.Pequeno;
            this.captionExtends1.Titulo = "Entidade";
            // 
            // frmEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 504);
            this.ControlBox = false;
            this.Controls.Add(this.tabViewExtends1);
            this.Controls.Add(this.panelCaptionExtends1);
            this.Controls.Add(this.captionExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEntidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entidades do sistema";
            this.tabViewExtends1.ResumeLayout(false);
            this.tab_entidade.ResumeLayout(false);
            this.panelExtends2.ResumeLayout(false);
            this.panelExtends2.PerformLayout();
            this.tab_campos.ResumeLayout(false);
            this.pnl_campos.ResumeLayout(false);
            this.pnl_campos.PerformLayout();
            this.panelCaptionExtends1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private CoreFramework.Controles.Controle.PanelCaptionExtends panelCaptionExtends1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_aplicar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_sair;
        private CoreFramework.Controles.Controle.TabViewExtends tabViewExtends1;
        private System.Windows.Forms.TabPage tab_campos;
        private CoreFramework.Controles.Controle.PanelExtends pnl_campos;
        private CoreFramework.Controles.Controle.SimpleGridExtends sgd_campos;
        private CoreFramework.Controles.Controle.ComboBoxExtends cbo_aceitaNulo;
        private CoreFramework.Controles.Controle.FieldExtends fld_padrao;
        private CoreFramework.Controles.Controle.FieldExtends fld_tamanho;
        private CoreFramework.Controles.Controle.ComboBoxExtends cbo_tipo;
        private CoreFramework.Controles.Controle.FieldExtends fld_nome;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.CheckBox chk_dataAtual;
        private System.Windows.Forms.TabPage tab_entidade;
        private CoreFramework.Controles.Controle.PanelExtends panelExtends2;
        private System.Windows.Forms.Label lbl_internoEntidade;
        private CoreFramework.Controles.Controle.FieldExtends fld_nomeEntidade;
        private CoreFramework.Controles.Controle.MemoExtends mmo_descricao;
        private System.Windows.Forms.Label label1;
        private CoreFramework.Controles.Controle.FieldExtends fld_displayEntidade;
        private CoreFramework.Controles.Controle.ComboBoxExtends cbo_escopo;
        private CoreFramework.Controles.Controle.FieldExtends fld_comentario;

    }
}