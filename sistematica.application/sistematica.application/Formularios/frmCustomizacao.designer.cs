namespace sistematica.application.Formularios
{
    partial class frmCustomizacao
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Entidades", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Campos");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Formulários", 2, 2);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Consultas", 3, 3);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Tarefas", 4, 4);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Componentes", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomizacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_baseConectada = new CoreFramework.Controles.Controle.LabelViewExtends();
            this.pnl_esquerdo = new System.Windows.Forms.Panel();
            this.tvw_componentes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.divisionBarExtends1 = new CoreFramework.Controles.Controle.DivisionBarExtends();
            this.tabViewExtends1 = new CoreFramework.Controles.Controle.TabViewExtends();
            this.tab_entidades = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_displayEntidade = new CoreFramework.Controles.Controle.LabelViewExtends();
            this.lbl_entidade = new CoreFramework.Controles.Controle.LabelViewExtends();
            this.panelCaptionExtends1 = new CoreFramework.Controles.Controle.PanelCaptionExtends();
            this.cap_alterar = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cap_entidade = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.cpt_sair = new CoreFramework.Controles.Controle.CaptionItemExtends();
            this.captionExtends1 = new CoreFramework.Controles.Controle.CaptionExtends();
            this.lbl_tipoEntidade = new CoreFramework.Controles.Controle.LabelViewExtends();
            this.lbl_descricaoEntidade = new CoreFramework.Controles.Controle.LabelViewExtends();
            this.panel1.SuspendLayout();
            this.pnl_esquerdo.SuspendLayout();
            this.tabViewExtends1.SuspendLayout();
            this.tab_entidades.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCaptionExtends1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lbl_baseConectada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 36);
            this.panel1.TabIndex = 14;
            // 
            // lbl_baseConectada
            // 
            this.lbl_baseConectada.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_baseConectada.Build = null;
            this.lbl_baseConectada.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_baseConectada.CorValor = System.Drawing.Color.Maroon;
            this.lbl_baseConectada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_baseConectada.GlobalID = 0;
            this.lbl_baseConectada.GlobalName = "";
            this.lbl_baseConectada.Location = new System.Drawing.Point(12, 7);
            this.lbl_baseConectada.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_baseConectada.MensagemPadrao = "";
            this.lbl_baseConectada.MostrarDestacado = true;
            this.lbl_baseConectada.Name = "lbl_baseConectada";
            this.lbl_baseConectada.Size = new System.Drawing.Size(246, 21);
            this.lbl_baseConectada.TabIndex = 0;
            this.lbl_baseConectada.Tamanho = 246;
            this.lbl_baseConectada.TamanhoTextoTitulo = 10F;
            this.lbl_baseConectada.TamanhoTextoValor = 10F;
            this.lbl_baseConectada.TamanhoTitulo = 71F;
            this.lbl_baseConectada.Titulo = "Base";
            this.lbl_baseConectada.Valor = "0";
            // 
            // pnl_esquerdo
            // 
            this.pnl_esquerdo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_esquerdo.Controls.Add(this.tvw_componentes);
            this.pnl_esquerdo.Controls.Add(this.divisionBarExtends1);
            this.pnl_esquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_esquerdo.Location = new System.Drawing.Point(0, 107);
            this.pnl_esquerdo.Name = "pnl_esquerdo";
            this.pnl_esquerdo.Size = new System.Drawing.Size(352, 399);
            this.pnl_esquerdo.TabIndex = 15;
            // 
            // tvw_componentes
            // 
            this.tvw_componentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw_componentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tvw_componentes.ImageIndex = 0;
            this.tvw_componentes.ImageList = this.imageList1;
            this.tvw_componentes.Location = new System.Drawing.Point(0, 25);
            this.tvw_componentes.Name = "tvw_componentes";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Entidades";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Entidades";
            treeNode8.ImageIndex = 5;
            treeNode8.Name = "Campos";
            treeNode8.Text = "Campos";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "Formulário";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Formulários";
            treeNode10.ImageIndex = 3;
            treeNode10.Name = "Node1";
            treeNode10.SelectedImageIndex = 3;
            treeNode10.Text = "Consultas";
            treeNode11.ImageIndex = 4;
            treeNode11.Name = "Tarefas";
            treeNode11.SelectedImageIndex = 4;
            treeNode11.Text = "Tarefas";
            treeNode12.Name = "Componentes";
            treeNode12.Text = "Componentes";
            this.tvw_componentes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.tvw_componentes.SelectedImageIndex = 0;
            this.tvw_componentes.Size = new System.Drawing.Size(352, 374);
            this.tvw_componentes.TabIndex = 1;
            this.tvw_componentes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_componentes_NodeMouseClick);
            this.tvw_componentes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_componentes_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "allpicklistvaluesmapped.gif");
            this.imageList1.Images.SetKeyName(1, "DownloadDocument_16.png");
            this.imageList1.Images.SetKeyName(2, "sistema.jpg");
            this.imageList1.Images.SetKeyName(3, "baixa2.png");
            this.imageList1.Images.SetKeyName(4, "settings_d_24x24.gif");
            this.imageList1.Images.SetKeyName(5, "DataListButton.png");
            // 
            // divisionBarExtends1
            // 
            this.divisionBarExtends1.Borda = System.Windows.Forms.BorderStyle.None;
            this.divisionBarExtends1.Build = null;
            this.divisionBarExtends1.Cor = System.Drawing.SystemColors.ActiveCaption;
            this.divisionBarExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.divisionBarExtends1.GlobalID = 0;
            this.divisionBarExtends1.GlobalName = "";
            this.divisionBarExtends1.Location = new System.Drawing.Point(0, 0);
            this.divisionBarExtends1.MensagemPadrao = "";
            this.divisionBarExtends1.Name = "divisionBarExtends1";
            this.divisionBarExtends1.Size = new System.Drawing.Size(352, 25);
            this.divisionBarExtends1.TabIndex = 0;
            // 
            // tabViewExtends1
            // 
            this.tabViewExtends1.Controls.Add(this.tab_entidades);
            this.tabViewExtends1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabViewExtends1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabViewExtends1.ItemSize = new System.Drawing.Size(96, 25);
            this.tabViewExtends1.Location = new System.Drawing.Point(352, 107);
            this.tabViewExtends1.Name = "tabViewExtends1";
            this.tabViewExtends1.SelectedIndex = 0;
            this.tabViewExtends1.Size = new System.Drawing.Size(646, 399);
            this.tabViewExtends1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabViewExtends1.TabIndex = 16;
            // 
            // tab_entidades
            // 
            this.tab_entidades.Controls.Add(this.panel3);
            this.tab_entidades.Location = new System.Drawing.Point(4, 29);
            this.tab_entidades.Name = "tab_entidades";
            this.tab_entidades.Padding = new System.Windows.Forms.Padding(3);
            this.tab_entidades.Size = new System.Drawing.Size(638, 366);
            this.tab_entidades.TabIndex = 0;
            this.tab_entidades.Text = "Entidade";
            this.tab_entidades.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_descricaoEntidade);
            this.panel3.Controls.Add(this.lbl_tipoEntidade);
            this.panel3.Controls.Add(this.lbl_displayEntidade);
            this.panel3.Controls.Add(this.lbl_entidade);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 140);
            this.panel3.TabIndex = 5;
            // 
            // lbl_displayEntidade
            // 
            this.lbl_displayEntidade.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_displayEntidade.Build = null;
            this.lbl_displayEntidade.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_displayEntidade.CorValor = System.Drawing.Color.Maroon;
            this.lbl_displayEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_displayEntidade.GlobalID = 0;
            this.lbl_displayEntidade.GlobalName = "";
            this.lbl_displayEntidade.Location = new System.Drawing.Point(4, 30);
            this.lbl_displayEntidade.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_displayEntidade.MensagemPadrao = "";
            this.lbl_displayEntidade.MostrarDestacado = true;
            this.lbl_displayEntidade.Name = "lbl_displayEntidade";
            this.lbl_displayEntidade.Size = new System.Drawing.Size(395, 23);
            this.lbl_displayEntidade.TabIndex = 1;
            this.lbl_displayEntidade.Tamanho = 395;
            this.lbl_displayEntidade.TamanhoTextoTitulo = 10F;
            this.lbl_displayEntidade.TamanhoTextoValor = 10F;
            this.lbl_displayEntidade.TamanhoTitulo = 95F;
            this.lbl_displayEntidade.Titulo = "Display";
            this.lbl_displayEntidade.Valor = "";
            // 
            // lbl_entidade
            // 
            this.lbl_entidade.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_entidade.Build = null;
            this.lbl_entidade.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_entidade.CorValor = System.Drawing.Color.Maroon;
            this.lbl_entidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_entidade.GlobalID = 0;
            this.lbl_entidade.GlobalName = "";
            this.lbl_entidade.Location = new System.Drawing.Point(4, 4);
            this.lbl_entidade.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_entidade.MensagemPadrao = "";
            this.lbl_entidade.MostrarDestacado = true;
            this.lbl_entidade.Name = "lbl_entidade";
            this.lbl_entidade.Size = new System.Drawing.Size(395, 23);
            this.lbl_entidade.TabIndex = 0;
            this.lbl_entidade.Tamanho = 395;
            this.lbl_entidade.TamanhoTextoTitulo = 10F;
            this.lbl_entidade.TamanhoTextoValor = 10F;
            this.lbl_entidade.TamanhoTitulo = 95F;
            this.lbl_entidade.Titulo = "Entidade";
            this.lbl_entidade.Valor = "";
            // 
            // panelCaptionExtends1
            // 
            this.panelCaptionExtends1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCaptionExtends1.Controls.Add(this.cap_alterar);
            this.panelCaptionExtends1.Controls.Add(this.cap_entidade);
            this.panelCaptionExtends1.Controls.Add(this.cpt_sair);
            this.panelCaptionExtends1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaptionExtends1.Item.Add(this.cap_alterar);
            this.panelCaptionExtends1.Item.Add(this.cap_entidade);
            this.panelCaptionExtends1.Item.Add(this.cpt_sair);
            this.panelCaptionExtends1.Location = new System.Drawing.Point(0, 33);
            this.panelCaptionExtends1.Name = "panelCaptionExtends1";
            this.panelCaptionExtends1.Size = new System.Drawing.Size(998, 38);
            this.panelCaptionExtends1.TabIndex = 12;
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
            // cap_entidade
            // 
            this.cap_entidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cap_entidade.Borda = System.Windows.Forms.BorderStyle.None;
            this.cap_entidade.Build = null;
            this.cap_entidade.Cor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cap_entidade.Dock = System.Windows.Forms.DockStyle.Left;
            this.cap_entidade.GlobalID = 0;
            this.cap_entidade.GlobalName = "";
            this.cap_entidade.Imagem = ((System.Drawing.Image)(resources.GetObject("cap_entidade.Imagem")));
            this.cap_entidade.Location = new System.Drawing.Point(99, 0);
            this.cap_entidade.MensagemPadrao = "";
            this.cap_entidade.MostrarBorda = false;
            this.cap_entidade.MostrarImagem = true;
            this.cap_entidade.Name = "cap_entidade";
            this.cap_entidade.Size = new System.Drawing.Size(123, 38);
            this.cap_entidade.TabIndex = 3;
            this.cap_entidade.Titulo = "Entidade";
            this.cap_entidade.AoChamar += new System.EventHandler(this.cap_entidade_AoChamar);
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
            this.captionExtends1.Size = new System.Drawing.Size(998, 33);
            this.captionExtends1.Subtitulo = "Subtítulo";
            this.captionExtends1.TabIndex = 11;
            this.captionExtends1.Tamanho = 998;
            this.captionExtends1.TipoPainel = CoreFramework.Objetos.Enums.TipoCaption.Pequeno;
            this.captionExtends1.Titulo = "Customização";
            // 
            // lbl_tipoEntidade
            // 
            this.lbl_tipoEntidade.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_tipoEntidade.Build = null;
            this.lbl_tipoEntidade.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_tipoEntidade.CorValor = System.Drawing.Color.Maroon;
            this.lbl_tipoEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_tipoEntidade.GlobalID = 0;
            this.lbl_tipoEntidade.GlobalName = "";
            this.lbl_tipoEntidade.Location = new System.Drawing.Point(4, 60);
            this.lbl_tipoEntidade.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_tipoEntidade.MensagemPadrao = "";
            this.lbl_tipoEntidade.MostrarDestacado = true;
            this.lbl_tipoEntidade.Name = "lbl_tipoEntidade";
            this.lbl_tipoEntidade.Size = new System.Drawing.Size(304, 23);
            this.lbl_tipoEntidade.TabIndex = 2;
            this.lbl_tipoEntidade.Tamanho = 304;
            this.lbl_tipoEntidade.TamanhoTextoTitulo = 10F;
            this.lbl_tipoEntidade.TamanhoTextoValor = 10F;
            this.lbl_tipoEntidade.TamanhoTitulo = 95F;
            this.lbl_tipoEntidade.Titulo = "Tipo";
            this.lbl_tipoEntidade.Valor = "0";
            // 
            // lbl_descricaoEntidade
            // 
            this.lbl_descricaoEntidade.Borda = System.Windows.Forms.BorderStyle.None;
            this.lbl_descricaoEntidade.Build = null;
            this.lbl_descricaoEntidade.CorTitulo = System.Drawing.SystemColors.ControlText;
            this.lbl_descricaoEntidade.CorValor = System.Drawing.Color.Maroon;
            this.lbl_descricaoEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_descricaoEntidade.GlobalID = 0;
            this.lbl_descricaoEntidade.GlobalName = "";
            this.lbl_descricaoEntidade.Location = new System.Drawing.Point(4, 89);
            this.lbl_descricaoEntidade.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_descricaoEntidade.MensagemPadrao = "";
            this.lbl_descricaoEntidade.MostrarDestacado = true;
            this.lbl_descricaoEntidade.Name = "lbl_descricaoEntidade";
            this.lbl_descricaoEntidade.Size = new System.Drawing.Size(621, 23);
            this.lbl_descricaoEntidade.TabIndex = 3;
            this.lbl_descricaoEntidade.Tamanho = 621;
            this.lbl_descricaoEntidade.TamanhoTextoTitulo = 10F;
            this.lbl_descricaoEntidade.TamanhoTextoValor = 10F;
            this.lbl_descricaoEntidade.TamanhoTitulo = 95F;
            this.lbl_descricaoEntidade.Titulo = "Descrição";
            this.lbl_descricaoEntidade.Valor = "0";
            // 
            // frmCustomizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 506);
            this.ControlBox = false;
            this.Controls.Add(this.tabViewExtends1);
            this.Controls.Add(this.pnl_esquerdo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCaptionExtends1);
            this.Controls.Add(this.captionExtends1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCustomizacao";
            this.Text = "Customização de Entidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnl_esquerdo.ResumeLayout(false);
            this.tabViewExtends1.ResumeLayout(false);
            this.tab_entidades.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCaptionExtends1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreFramework.Controles.Controle.CaptionExtends captionExtends1;
        private CoreFramework.Controles.Controle.PanelCaptionExtends panelCaptionExtends1;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_alterar;
        private CoreFramework.Controles.Controle.CaptionItemExtends cap_entidade;
        private CoreFramework.Controles.Controle.CaptionItemExtends cpt_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_esquerdo;
        private CoreFramework.Controles.Controle.TabViewExtends tabViewExtends1;
        private System.Windows.Forms.TabPage tab_entidades;
        private CoreFramework.Controles.Controle.LabelViewExtends lbl_baseConectada;
        private System.Windows.Forms.TreeView tvw_componentes;
        private System.Windows.Forms.ImageList imageList1;
        private CoreFramework.Controles.Controle.DivisionBarExtends divisionBarExtends1;
        private System.Windows.Forms.Panel panel3;
        private CoreFramework.Controles.Controle.LabelViewExtends lbl_displayEntidade;
        private CoreFramework.Controles.Controle.LabelViewExtends lbl_entidade;
        private CoreFramework.Controles.Controle.LabelViewExtends lbl_descricaoEntidade;
        private CoreFramework.Controles.Controle.LabelViewExtends lbl_tipoEntidade;

    }
}