namespace CoreFramework.Controles.Controle
{
    partial class FilterDataExtends
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
            this.dte_opcao1 = new CoreFramework.Controles.Controle.DateTimeExtends();
            this.dte_opcao2 = new CoreFramework.Controles.Controle.DateTimeExtends();
            this.chk_action = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dte_opcao1
            // 
            this.dte_opcao1.Borda = System.Windows.Forms.BorderStyle.None;
            this.dte_opcao1.Formato = CoreFramework.Objetos.Enums.TipoDatas.DataCurta;
            this.dte_opcao1.GlobalID = 0;
            this.dte_opcao1.GlobalName = "";
            this.dte_opcao1.Location = new System.Drawing.Point(151, 3);
            this.dte_opcao1.MensagemPadrao = "";
            this.dte_opcao1.Name = "dte_opcao1";
            this.dte_opcao1.Obrigatorio = false;
            this.dte_opcao1.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.dte_opcao1.Size = new System.Drawing.Size(150, 23);
            this.dte_opcao1.TabIndex = 3;
            this.dte_opcao1.Tamanho = 150;
            this.dte_opcao1.TamanhoTexto = 100;
            this.dte_opcao1.Titulo = "De";
            this.dte_opcao1.Valor = "13/04/2017";
            // 
            // dte_opcao2
            // 
            this.dte_opcao2.Borda = System.Windows.Forms.BorderStyle.None;
            this.dte_opcao2.Formato = CoreFramework.Objetos.Enums.TipoDatas.DataCurta;
            this.dte_opcao2.GlobalID = 0;
            this.dte_opcao2.GlobalName = "";
            this.dte_opcao2.Location = new System.Drawing.Point(301, 3);
            this.dte_opcao2.MensagemPadrao = "";
            this.dte_opcao2.Name = "dte_opcao2";
            this.dte_opcao2.Obrigatorio = false;
            this.dte_opcao2.Posicao = CoreFramework.Objetos.Enums.Posicao.Horizontal;
            this.dte_opcao2.Size = new System.Drawing.Size(150, 22);
            this.dte_opcao2.TabIndex = 2;
            this.dte_opcao2.Tamanho = 150;
            this.dte_opcao2.TamanhoTexto = 100;
            this.dte_opcao2.Titulo = "Até";
            this.dte_opcao2.Valor = "13/04/2017";
            // 
            // chk_action
            // 
            this.chk_action.AutoSize = true;
            this.chk_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_action.Location = new System.Drawing.Point(2, 3);
            this.chk_action.Name = "chk_action";
            this.chk_action.Size = new System.Drawing.Size(88, 21);
            this.chk_action.TabIndex = 1;
            this.chk_action.Text = "FilterDate";
            this.chk_action.UseVisualStyleBackColor = true;
            // 
            // FilterDataExtends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dte_opcao1);
            this.Controls.Add(this.dte_opcao2);
            this.Controls.Add(this.chk_action);
            this.Name = "FilterDataExtends";
            this.Size = new System.Drawing.Size(454, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_action;
        private DateTimeExtends dte_opcao2;
        private DateTimeExtends dte_opcao1;
    }
}
