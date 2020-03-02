namespace sistematica.application.Formularios
{
    partial class frmComponentes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salvar = new CoreFramework.Controles.Controle.ButtonExtends();
            this.btn_sair = new CoreFramework.Controles.Controle.ButtonExtends();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fld_aplicacao = new CoreFramework.Controles.Controle.FieldExtends();
            this.sgd_modulos = new CoreFramework.Controles.Controle.SelectGridExtends();
            this.fld_funcao = new CoreFramework.Controles.Controle.FieldExtends();
            this.fld_rotina = new CoreFramework.Controles.Controle.FieldExtends();
            this.fld_modulo = new CoreFramework.Controles.Controle.FieldExtends();
            this.cbo_modulo = new CoreFramework.Controles.Controle.ComboBoxExtends();
            this.connectionExtends1 = new CoreFramework.Componentes.Componente.ConnectionComponent(this.components);
            this.queryExtends1 = new CoreFramework.Componentes.Componente.QueryComponent(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // captionExtends1
            // 
            this.captionExtends1.BackColor = System.Drawing.Color.SteelBlue;
            this.captionExtends1.Borda = System.Windows.Forms.BorderStyle.None;
            this.captionExtends1.Build = null;
            this.captionExtends1.Cor = System.Drawing.Color.Gray;
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
            this.captionExtends1.Size = new System.Drawing.Size(904, 62);
            this.captionExtends1.Subtitulo = "";
            this.captionExtends1.TabIndex = 3;
            this.captionExtends1.Tamanho = 904;
            this.captionExtends1.Titulo = "Componentes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 41);
            this.panel1.TabIndex = 4;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(675, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(110, 35);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Inserir";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(787, 3);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(110, 35);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(96, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 412);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Controls.Add(this.fld_aplicacao);
            this.tabPage1.Controls.Add(this.sgd_modulos);
            this.tabPage1.Controls.Add(this.fld_funcao);
            this.tabPage1.Controls.Add(this.fld_rotina);
            this.tabPage1.Controls.Add(this.fld_modulo);
            this.tabPage1.Controls.Add(this.cbo_modulo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "componentes";
            // 
            // fld_aplicacao
            // 
            this.fld_aplicacao.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_aplicacao.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_aplicacao.Build = null;
            this.fld_aplicacao.Caractere = '\0';
            this.fld_aplicacao.ComprimentoMaximo = 70;
            this.fld_aplicacao.Destacado = false;
            this.fld_aplicacao.GlobalID = 0;
            this.fld_aplicacao.GlobalName = "";
            this.fld_aplicacao.Location = new System.Drawing.Point(9, 33);
            this.fld_aplicacao.MensagemPadrao = "";
            this.fld_aplicacao.Name = "fld_aplicacao";
            this.fld_aplicacao.Obrigatorio = false;
            this.fld_aplicacao.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_aplicacao.Size = new System.Drawing.Size(335, 23);
            this.fld_aplicacao.TabIndex = 1;
            this.fld_aplicacao.Tamanho = 335;
            this.fld_aplicacao.TamanhoTexto = 250;
            this.fld_aplicacao.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Minúscula;
            this.fld_aplicacao.Titulo = "Aplicação";
            this.fld_aplicacao.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Texto;
            // 
            // sgd_modulos
            // 
            this.sgd_modulos.Borda = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sgd_modulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sgd_modulos.Build = null;
            this.sgd_modulos.Canonico = true;
            this.sgd_modulos.Chave = "";
            this.sgd_modulos.ColunaEditavel = System.Drawing.Color.Red;
            this.sgd_modulos.Consultas = null;
            this.sgd_modulos.Dados = null;
            this.sgd_modulos.Details = null;
            this.sgd_modulos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sgd_modulos.ExportaPadrao = CoreFramework.Objetos.Enums.ExportaExcel.Excel2007;
            this.sgd_modulos.Fonte = 10F;
            this.sgd_modulos.GlobalID = 0;
            this.sgd_modulos.GlobalName = "";
            this.sgd_modulos.Location = new System.Drawing.Point(3, 137);
            this.sgd_modulos.Margin = new System.Windows.Forms.Padding(4);
            this.sgd_modulos.Master = CoreFramework.Objetos.Enums.EscolhaBooleana.Não;
            this.sgd_modulos.Mensagem = "Mensagem";
            this.sgd_modulos.MensagemPadrao = "";
            this.sgd_modulos.Modo = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.sgd_modulos.MostrarFiltro = true;
            this.sgd_modulos.MostrarFiltroParcial = true;
            this.sgd_modulos.MostrarRodape = true;
            this.sgd_modulos.Name = "sgd_modulos";
            this.sgd_modulos.Ocultar = false;
            this.sgd_modulos.Ordenacao = "q.ItemAplicacao, q.ItemModulo, q.ItemRotina";
            this.sgd_modulos.Query = "";
            this.sgd_modulos.Size = new System.Drawing.Size(890, 239);
            this.sgd_modulos.Subconsulta = true;
            this.sgd_modulos.TabIndex = 4;
            this.sgd_modulos.Tamanho = 890;
            this.sgd_modulos.TamanhoCombo = 199;
            this.sgd_modulos.TamanhoTexto = 199;
            // 
            // fld_funcao
            // 
            this.fld_funcao.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_funcao.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_funcao.Build = null;
            this.fld_funcao.Caractere = '\0';
            this.fld_funcao.ComprimentoMaximo = 50;
            this.fld_funcao.Destacado = false;
            this.fld_funcao.GlobalID = 0;
            this.fld_funcao.GlobalName = "";
            this.fld_funcao.Location = new System.Drawing.Point(8, 111);
            this.fld_funcao.MensagemPadrao = "";
            this.fld_funcao.Name = "fld_funcao";
            this.fld_funcao.Obrigatorio = false;
            this.fld_funcao.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_funcao.Size = new System.Drawing.Size(336, 23);
            this.fld_funcao.TabIndex = 4;
            this.fld_funcao.Tamanho = 336;
            this.fld_funcao.TamanhoTexto = 250;
            this.fld_funcao.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_funcao.Titulo = "Função";
            this.fld_funcao.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // fld_rotina
            // 
            this.fld_rotina.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_rotina.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_rotina.Build = null;
            this.fld_rotina.Caractere = '\0';
            this.fld_rotina.ComprimentoMaximo = 70;
            this.fld_rotina.Destacado = false;
            this.fld_rotina.GlobalID = 0;
            this.fld_rotina.GlobalName = "";
            this.fld_rotina.Location = new System.Drawing.Point(8, 85);
            this.fld_rotina.MensagemPadrao = "";
            this.fld_rotina.Name = "fld_rotina";
            this.fld_rotina.Obrigatorio = false;
            this.fld_rotina.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_rotina.Size = new System.Drawing.Size(336, 23);
            this.fld_rotina.TabIndex = 3;
            this.fld_rotina.Tamanho = 336;
            this.fld_rotina.TamanhoTexto = 250;
            this.fld_rotina.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Minúscula;
            this.fld_rotina.Titulo = "Rotina";
            this.fld_rotina.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Texto;
            // 
            // fld_modulo
            // 
            this.fld_modulo.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_modulo.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_modulo.Build = null;
            this.fld_modulo.Caractere = '\0';
            this.fld_modulo.ComprimentoMaximo = 70;
            this.fld_modulo.Destacado = false;
            this.fld_modulo.GlobalID = 0;
            this.fld_modulo.GlobalName = "";
            this.fld_modulo.Location = new System.Drawing.Point(8, 59);
            this.fld_modulo.MensagemPadrao = "";
            this.fld_modulo.Name = "fld_modulo";
            this.fld_modulo.Obrigatorio = false;
            this.fld_modulo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_modulo.Size = new System.Drawing.Size(336, 23);
            this.fld_modulo.TabIndex = 2;
            this.fld_modulo.Tamanho = 336;
            this.fld_modulo.TamanhoTexto = 250;
            this.fld_modulo.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Minúscula;
            this.fld_modulo.Titulo = "Módulo";
            this.fld_modulo.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Texto;
            // 
            // cbo_modulo
            // 
            this.cbo_modulo.Borda = System.Windows.Forms.BorderStyle.None;
            this.cbo_modulo.Build = null;
            this.cbo_modulo.Chave = "";
            this.cbo_modulo.Display = "Descricao";
            this.cbo_modulo.GlobalID = 0;
            this.cbo_modulo.GlobalName = "";
            this.cbo_modulo.Location = new System.Drawing.Point(8, 6);
            this.cbo_modulo.MensagemPadrao = "";
            this.cbo_modulo.Name = "cbo_modulo";
            this.cbo_modulo.Obrigatorio = false;
            this.cbo_modulo.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.cbo_modulo.Query = "select Descricao from dbo.ModuloSistema";
            this.cbo_modulo.QuerySecundaria = "";
            this.cbo_modulo.Size = new System.Drawing.Size(337, 24);
            this.cbo_modulo.Tabela = "";
            this.cbo_modulo.TabIndex = 0;
            this.cbo_modulo.Tamanho = 337;
            this.cbo_modulo.TamanhoTexto = 250;
            this.cbo_modulo.Titulo = "Módulo";
            this.cbo_modulo.Valor = "";
            this.cbo_modulo.AoMudarIndice += new System.EventHandler(this.cbo_modulo_AoMudarIndice);
            // 
            // connectionExtends1
            // 
            this.connectionExtends1.Conectado = true;
            // 
            // queryExtends1
            // 
            this.queryExtends1.Query = new string[] {
        "select * from (select Unidade, ItemAplicacao, ItemModulo, ItemRotina, Funcao from" +
            " dbo.Componente) as q"};
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 515);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.captionExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroComponentes";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private System.Windows.Forms.Panel panel1;
        private CoreFramework.Controles.Controle.ButtonExtends btn_salvar;
        private CoreFramework.Controles.Controle.ButtonExtends btn_sair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CoreFramework.Controles.Controle.ComboBoxExtends cbo_modulo;
        private CoreFramework.Componentes.Componente.ConnectionComponent connectionExtends1;
        private CoreFramework.Controles.Controle.FieldExtends fld_funcao;
        private CoreFramework.Controles.Controle.FieldExtends fld_rotina;
        private CoreFramework.Controles.Controle.FieldExtends fld_modulo;
        private CoreFramework.Controles.Controle.SelectGridExtends sgd_modulos;
        private CoreFramework.Componentes.Componente.QueryComponent queryExtends1;
        private CoreFramework.Controles.Controle.FieldExtends fld_aplicacao;
    }
}