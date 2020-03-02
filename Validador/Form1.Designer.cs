namespace Validador
{
    partial class Form1
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
            this.tabViewExtends1 = new CoreFramework.Controles.Controle.TabViewExtends();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExtends1 = new CoreFramework.Controles.Controle.ButtonExtends();
            this.fld_data = new CoreFramework.Controles.Controle.FieldExtends();
            this.fld_chave = new CoreFramework.Controles.Controle.FieldExtends();
            this.dte_data = new CoreFramework.Controles.Controle.DateTimeExtends();
            this.fld_resultado = new CoreFramework.Controles.Controle.FieldExtends();
            this.buttonExtends2 = new CoreFramework.Controles.Controle.ButtonExtends();
            this.tabViewExtends1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabViewExtends1
            // 
            this.tabViewExtends1.Controls.Add(this.tabPage1);
            this.tabViewExtends1.Controls.Add(this.tabPage2);
            this.tabViewExtends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabViewExtends1.ItemSize = new System.Drawing.Size(96, 25);
            this.tabViewExtends1.Location = new System.Drawing.Point(6, 8);
            this.tabViewExtends1.Name = "tabViewExtends1";
            this.tabViewExtends1.SelectedIndex = 0;
            this.tabViewExtends1.Size = new System.Drawing.Size(395, 142);
            this.tabViewExtends1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabViewExtends1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonExtends1);
            this.tabPage1.Controls.Add(this.fld_data);
            this.tabPage1.Controls.Add(this.fld_chave);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 109);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chave";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExtends2);
            this.tabPage2.Controls.Add(this.fld_resultado);
            this.tabPage2.Controls.Add(this.dte_data);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 109);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExtends1
            // 
            this.buttonExtends1.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExtends1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExtends1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExtends1.ForeColor = System.Drawing.Color.White;
            this.buttonExtends1.Location = new System.Drawing.Point(6, 62);
            this.buttonExtends1.Name = "buttonExtends1";
            this.buttonExtends1.Size = new System.Drawing.Size(110, 35);
            this.buttonExtends1.TabIndex = 5;
            this.buttonExtends1.Text = "Executar";
            this.buttonExtends1.UseVisualStyleBackColor = false;
            this.buttonExtends1.Click += new System.EventHandler(this.ButtonExtends1_Click);
            // 
            // fld_data
            // 
            this.fld_data.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_data.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_data.Build = null;
            this.fld_data.Caractere = '\0';
            this.fld_data.ComprimentoMaximo = 50;
            this.fld_data.Destacado = false;
            this.fld_data.GlobalID = 0;
            this.fld_data.GlobalName = "";
            this.fld_data.Location = new System.Drawing.Point(6, 33);
            this.fld_data.MensagemPadrao = "";
            this.fld_data.Name = "fld_data";
            this.fld_data.Obrigatorio = false;
            this.fld_data.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_data.Size = new System.Drawing.Size(269, 23);
            this.fld_data.TabIndex = 4;
            this.fld_data.Tamanho = 269;
            this.fld_data.TamanhoTexto = 200;
            this.fld_data.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_data.Titulo = "Data";
            this.fld_data.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // fld_chave
            // 
            this.fld_chave.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_chave.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_chave.Build = null;
            this.fld_chave.Caractere = '\0';
            this.fld_chave.ComprimentoMaximo = 50;
            this.fld_chave.Destacado = false;
            this.fld_chave.GlobalID = 0;
            this.fld_chave.GlobalName = "";
            this.fld_chave.Location = new System.Drawing.Point(6, 6);
            this.fld_chave.MensagemPadrao = "";
            this.fld_chave.Name = "fld_chave";
            this.fld_chave.Obrigatorio = false;
            this.fld_chave.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_chave.Size = new System.Drawing.Size(269, 23);
            this.fld_chave.TabIndex = 3;
            this.fld_chave.Tamanho = 269;
            this.fld_chave.TamanhoTexto = 200;
            this.fld_chave.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_chave.Titulo = "Chave";
            this.fld_chave.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // dte_data
            // 
            this.dte_data.Borda = System.Windows.Forms.BorderStyle.None;
            this.dte_data.Build = null;
            this.dte_data.Formato = CoreFramework.Objetos.Enums.TipoDatas.DataCurta;
            this.dte_data.GlobalID = 0;
            this.dte_data.GlobalName = "";
            this.dte_data.Location = new System.Drawing.Point(6, 6);
            this.dte_data.MensagemPadrao = "";
            this.dte_data.Name = "dte_data";
            this.dte_data.Obrigatorio = false;
            this.dte_data.Padrao = false;
            this.dte_data.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.dte_data.Size = new System.Drawing.Size(177, 23);
            this.dte_data.TabIndex = 0;
            this.dte_data.Tamanho = 177;
            this.dte_data.TamanhoTexto = 100;
            this.dte_data.Titulo = "Data";
            this.dte_data.Valor = " ";
            // 
            // fld_resultado
            // 
            this.fld_resultado.AlinhamentoTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.fld_resultado.Borda = System.Windows.Forms.BorderStyle.None;
            this.fld_resultado.Build = null;
            this.fld_resultado.Caractere = '\0';
            this.fld_resultado.ComprimentoMaximo = 50;
            this.fld_resultado.Destacado = false;
            this.fld_resultado.GlobalID = 0;
            this.fld_resultado.GlobalName = "";
            this.fld_resultado.Location = new System.Drawing.Point(7, 32);
            this.fld_resultado.MensagemPadrao = "";
            this.fld_resultado.Name = "fld_resultado";
            this.fld_resultado.Obrigatorio = false;
            this.fld_resultado.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.fld_resultado.Size = new System.Drawing.Size(176, 23);
            this.fld_resultado.TabIndex = 1;
            this.fld_resultado.Tamanho = 176;
            this.fld_resultado.TamanhoTexto = 100;
            this.fld_resultado.TipoCaractere = CoreFramework.Objetos.Enums.TipoCaractere.Nenhum;
            this.fld_resultado.Titulo = "Resultado";
            this.fld_resultado.ValidacaoTexto = CoreFramework.Objetos.Enums.ValidacaoCaracteres.Nenhum;
            // 
            // buttonExtends2
            // 
            this.buttonExtends2.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExtends2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExtends2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtends2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExtends2.ForeColor = System.Drawing.Color.White;
            this.buttonExtends2.Location = new System.Drawing.Point(7, 65);
            this.buttonExtends2.Name = "buttonExtends2";
            this.buttonExtends2.Size = new System.Drawing.Size(110, 35);
            this.buttonExtends2.TabIndex = 6;
            this.buttonExtends2.Text = "Executar";
            this.buttonExtends2.UseVisualStyleBackColor = false;
            this.buttonExtends2.Click += new System.EventHandler(this.ButtonExtends2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 155);
            this.Controls.Add(this.tabViewExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação";
            this.tabViewExtends1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.TabViewExtends tabViewExtends1;
        private System.Windows.Forms.TabPage tabPage1;
        private CoreFramework.Controles.Controle.ButtonExtends buttonExtends1;
        private CoreFramework.Controles.Controle.FieldExtends fld_data;
        private CoreFramework.Controles.Controle.FieldExtends fld_chave;
        private System.Windows.Forms.TabPage tabPage2;
        private CoreFramework.Controles.Controle.ButtonExtends buttonExtends2;
        private CoreFramework.Controles.Controle.FieldExtends fld_resultado;
        private CoreFramework.Controles.Controle.DateTimeExtends dte_data;
    }
}

