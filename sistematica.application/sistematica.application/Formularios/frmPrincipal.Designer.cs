namespace sistematica.application.Formularios
{
    partial class modulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modulo));
            this.rct_modulo = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.rbt_instancias = new DevComponents.DotNetBar.ButtonItem();
            this.rbt_testeConexao = new DevComponents.DotNetBar.ButtonItem();
            this.rbt_criptografar = new DevComponents.DotNetBar.ButtonItem();
            this.rbt_criptografarArquivo = new DevComponents.DotNetBar.ButtonItem();
            this.rba_modulo = new DevComponents.DotNetBar.RibbonBar();
            this.rbt_sair = new DevComponents.DotNetBar.ButtonItem();
            this.rbt_minimizar = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.rbt_criptografarUsers = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.rbt_xml = new DevComponents.DotNetBar.ButtonItem();
            this.rbt_customizacoes = new DevComponents.DotNetBar.ButtonItem();
            this.rbt_componentes = new DevComponents.DotNetBar.ButtonItem();
            this.rtb_modulo = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.sst_modulo = new System.Windows.Forms.StatusStrip();
            this.tss_data1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_modulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_codigo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_filial = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_id = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_codigoinstancia = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_instanciaAtiva = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_principal = new System.Windows.Forms.Timer(this.components);
            this.rct_modulo.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.sst_modulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rct_modulo
            // 
            // 
            // 
            // 
            this.rct_modulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rct_modulo.Controls.Add(this.ribbonPanel2);
            this.rct_modulo.Controls.Add(this.ribbonPanel1);
            this.rct_modulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.rct_modulo.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rtb_modulo,
            this.ribbonTabItem1});
            this.rct_modulo.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.rct_modulo.Location = new System.Drawing.Point(0, 0);
            this.rct_modulo.Name = "rct_modulo";
            this.rct_modulo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.rct_modulo.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.rct_modulo.Size = new System.Drawing.Size(879, 138);
            this.rct_modulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rct_modulo.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.rct_modulo.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.rct_modulo.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.rct_modulo.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.rct_modulo.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.rct_modulo.SystemText.QatDialogAddButton = "&Add >>";
            this.rct_modulo.SystemText.QatDialogCancelButton = "Cancel";
            this.rct_modulo.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.rct_modulo.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.rct_modulo.SystemText.QatDialogOkButton = "OK";
            this.rct_modulo.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.rct_modulo.SystemText.QatDialogRemoveButton = "&Remove";
            this.rct_modulo.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.rct_modulo.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.rct_modulo.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.rct_modulo.TabGroupHeight = 14;
            this.rct_modulo.TabIndex = 5;
            this.rct_modulo.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Controls.Add(this.rba_modulo);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(879, 110);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbt_instancias,
            this.rbt_testeConexao,
            this.rbt_criptografar,
            this.rbt_criptografarArquivo});
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(211, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(424, 107);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 2;
            this.ribbonBar1.Text = "Funcionalidades";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbt_instancias
            // 
            this.rbt_instancias.FixedSize = new System.Drawing.Size(100, 90);
            this.rbt_instancias.Image = ((System.Drawing.Image)(resources.GetObject("rbt_instancias.Image")));
            this.rbt_instancias.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_instancias.Name = "rbt_instancias";
            this.rbt_instancias.SubItemsExpandWidth = 14;
            this.rbt_instancias.Text = "Instâncias";
            this.rbt_instancias.Click += new System.EventHandler(this.rotina_click);
            // 
            // rbt_testeConexao
            // 
            this.rbt_testeConexao.FixedSize = new System.Drawing.Size(105, 90);
            this.rbt_testeConexao.Image = ((System.Drawing.Image)(resources.GetObject("rbt_testeConexao.Image")));
            this.rbt_testeConexao.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_testeConexao.Name = "rbt_testeConexao";
            this.rbt_testeConexao.SubItemsExpandWidth = 14;
            this.rbt_testeConexao.Text = "Teste\r\nConexão";
            this.rbt_testeConexao.Click += new System.EventHandler(this.rotina_click);
            // 
            // rbt_criptografar
            // 
            this.rbt_criptografar.FixedSize = new System.Drawing.Size(105, 90);
            this.rbt_criptografar.Image = ((System.Drawing.Image)(resources.GetObject("rbt_criptografar.Image")));
            this.rbt_criptografar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_criptografar.Name = "rbt_criptografar";
            this.rbt_criptografar.SubItemsExpandWidth = 14;
            this.rbt_criptografar.Text = "Criptografia";
            this.rbt_criptografar.Click += new System.EventHandler(this.rotina_click);
            // 
            // rbt_criptografarArquivo
            // 
            this.rbt_criptografarArquivo.EnableMarkup = false;
            this.rbt_criptografarArquivo.FixedSize = new System.Drawing.Size(105, 90);
            this.rbt_criptografarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("rbt_criptografarArquivo.Image")));
            this.rbt_criptografarArquivo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_criptografarArquivo.Name = "rbt_criptografarArquivo";
            this.rbt_criptografarArquivo.SubItemsExpandWidth = 14;
            this.rbt_criptografarArquivo.Text = "Criptografia \r\nArquivos";
            this.rbt_criptografarArquivo.Click += new System.EventHandler(this.rotina_click);
            // 
            // rba_modulo
            // 
            this.rba_modulo.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rba_modulo.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rba_modulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rba_modulo.ContainerControlProcessDialogKey = true;
            this.rba_modulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rba_modulo.DragDropSupport = true;
            this.rba_modulo.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbt_sair,
            this.rbt_minimizar});
            this.rba_modulo.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.rba_modulo.Location = new System.Drawing.Point(3, 0);
            this.rba_modulo.Name = "rba_modulo";
            this.rba_modulo.Size = new System.Drawing.Size(208, 107);
            this.rba_modulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rba_modulo.TabIndex = 1;
            this.rba_modulo.Text = "Módulo";
            // 
            // 
            // 
            this.rba_modulo.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rba_modulo.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbt_sair
            // 
            this.rbt_sair.FixedSize = new System.Drawing.Size(100, 90);
            this.rbt_sair.Image = ((System.Drawing.Image)(resources.GetObject("rbt_sair.Image")));
            this.rbt_sair.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_sair.Name = "rbt_sair";
            this.rbt_sair.SubItemsExpandWidth = 14;
            this.rbt_sair.Text = "&Sair";
            this.rbt_sair.Click += new System.EventHandler(this.rotina_click);
            // 
            // rbt_minimizar
            // 
            this.rbt_minimizar.FixedSize = new System.Drawing.Size(100, 90);
            this.rbt_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("rbt_minimizar.Image")));
            this.rbt_minimizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_minimizar.Name = "rbt_minimizar";
            this.rbt_minimizar.SubItemsExpandWidth = 14;
            this.rbt_minimizar.Text = "&Minimizar";
            this.rbt_minimizar.Click += new System.EventHandler(this.rotina_click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(879, 110);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbt_criptografarUsers});
            this.ribbonBar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar3.Location = new System.Drawing.Point(321, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(236, 107);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Text = "Banco de Dados";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbt_criptografarUsers
            // 
            this.rbt_criptografarUsers.FixedSize = new System.Drawing.Size(105, 90);
            this.rbt_criptografarUsers.Image = ((System.Drawing.Image)(resources.GetObject("rbt_criptografarUsers.Image")));
            this.rbt_criptografarUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_criptografarUsers.Name = "rbt_criptografarUsers";
            this.rbt_criptografarUsers.SubItemsExpandWidth = 14;
            this.rbt_criptografarUsers.Text = "Criptografar\r\nUsuários";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbt_xml,
            this.rbt_customizacoes,
            this.rbt_componentes});
            this.ribbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(318, 107);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "Customizações";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbt_xml
            // 
            this.rbt_xml.FixedSize = new System.Drawing.Size(105, 90);
            this.rbt_xml.Image = ((System.Drawing.Image)(resources.GetObject("rbt_xml.Image")));
            this.rbt_xml.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_xml.Name = "rbt_xml";
            this.rbt_xml.SubItemsExpandWidth = 14;
            this.rbt_xml.Text = "XML";
            this.rbt_xml.Click += new System.EventHandler(this.rotina_click);
            // 
            // rbt_customizacoes
            // 
            this.rbt_customizacoes.FixedSize = new System.Drawing.Size(100, 90);
            this.rbt_customizacoes.Image = ((System.Drawing.Image)(resources.GetObject("rbt_customizacoes.Image")));
            this.rbt_customizacoes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_customizacoes.Name = "rbt_customizacoes";
            this.rbt_customizacoes.SubItemsExpandWidth = 14;
            this.rbt_customizacoes.Text = "Customizações";
            this.rbt_customizacoes.Click += new System.EventHandler(this.rotina_click);
            // 
            // rbt_componentes
            // 
            this.rbt_componentes.FixedSize = new System.Drawing.Size(100, 90);
            this.rbt_componentes.Image = ((System.Drawing.Image)(resources.GetObject("rbt_componentes.Image")));
            this.rbt_componentes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbt_componentes.Name = "rbt_componentes";
            this.rbt_componentes.SubItemsExpandWidth = 14;
            this.rbt_componentes.Text = "Componentes";
            this.rbt_componentes.Click += new System.EventHandler(this.rotina_click);
            // 
            // rtb_modulo
            // 
            this.rtb_modulo.Name = "rtb_modulo";
            this.rtb_modulo.Panel = this.ribbonPanel1;
            this.rtb_modulo.Text = "Modulo";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel2;
            this.ribbonTabItem1.Text = "Customizações";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.sst_modulo);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 138);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(879, 256);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // sst_modulo
            // 
            this.sst_modulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sst_modulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.sst_modulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_data1,
            this.tss_data,
            this.tss_hora,
            this.tss_modulo,
            this.tss_codigo,
            this.tss_filial,
            this.toolStripStatusLabel2,
            this.tss_id,
            this.tss_usuario,
            this.tss_codigoinstancia,
            this.tss_instanciaAtiva});
            this.sst_modulo.Location = new System.Drawing.Point(0, 232);
            this.sst_modulo.Name = "sst_modulo";
            this.sst_modulo.Size = new System.Drawing.Size(879, 24);
            this.sst_modulo.TabIndex = 5;
            // 
            // tss_data1
            // 
            this.tss_data1.Name = "tss_data1";
            this.tss_data1.Size = new System.Drawing.Size(0, 19);
            // 
            // tss_data
            // 
            this.tss_data.Name = "tss_data";
            this.tss_data.Size = new System.Drawing.Size(40, 19);
            this.tss_data.Text = "Data";
            // 
            // tss_hora
            // 
            this.tss_hora.Name = "tss_hora";
            this.tss_hora.Size = new System.Drawing.Size(43, 19);
            this.tss_hora.Text = "Hora";
            // 
            // tss_modulo
            // 
            this.tss_modulo.Name = "tss_modulo";
            this.tss_modulo.Size = new System.Drawing.Size(61, 19);
            this.tss_modulo.Text = "Modulo";
            // 
            // tss_codigo
            // 
            this.tss_codigo.Name = "tss_codigo";
            this.tss_codigo.Size = new System.Drawing.Size(56, 19);
            this.tss_codigo.Text = "codigo";
            // 
            // tss_filial
            // 
            this.tss_filial.Name = "tss_filial";
            this.tss_filial.Size = new System.Drawing.Size(40, 19);
            this.tss_filial.Text = "Filial";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(14, 19);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tss_id
            // 
            this.tss_id.Name = "tss_id";
            this.tss_id.Size = new System.Drawing.Size(22, 19);
            this.tss_id.Text = "id";
            // 
            // tss_usuario
            // 
            this.tss_usuario.Name = "tss_usuario";
            this.tss_usuario.Size = new System.Drawing.Size(58, 19);
            this.tss_usuario.Text = "usuário";
            // 
            // tss_codigoinstancia
            // 
            this.tss_codigoinstancia.Name = "tss_codigoinstancia";
            this.tss_codigoinstancia.Size = new System.Drawing.Size(159, 19);
            this.tss_codigoinstancia.Text = "Código Instância Ativa";
            // 
            // tss_instanciaAtiva
            // 
            this.tss_instanciaAtiva.Name = "tss_instanciaAtiva";
            this.tss_instanciaAtiva.Size = new System.Drawing.Size(67, 19);
            this.tss_instanciaAtiva.Text = "Instância";
            // 
            // tmr_principal
            // 
            this.tmr_principal.Enabled = true;
            this.tmr_principal.Interval = 1000;
            this.tmr_principal.Tick += new System.EventHandler(this.tmr_principal_Tick);
            // 
            // modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 394);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.rct_modulo);
            this.Name = "modulo";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.modulo_Shown);
            this.rct_modulo.ResumeLayout(false);
            this.rct_modulo.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.sst_modulo.ResumeLayout(false);
            this.sst_modulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl rct_modulo;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar rba_modulo;
        private DevComponents.DotNetBar.ButtonItem rbt_sair;
        private DevComponents.DotNetBar.ButtonItem rbt_minimizar;
        private DevComponents.DotNetBar.RibbonTabItem rtb_modulo;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Timer tmr_principal;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem rbt_criptografar;
        private DevComponents.DotNetBar.ButtonItem rbt_testeConexao;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem rbt_customizacoes;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.ButtonItem rbt_instancias;
        private DevComponents.DotNetBar.ButtonItem rbt_componentes;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem rbt_criptografarUsers;
        private DevComponents.DotNetBar.ButtonItem rbt_xml;
        private System.Windows.Forms.StatusStrip sst_modulo;
        private System.Windows.Forms.ToolStripStatusLabel tss_data1;
        private System.Windows.Forms.ToolStripStatusLabel tss_data;
        private System.Windows.Forms.ToolStripStatusLabel tss_hora;
        private System.Windows.Forms.ToolStripStatusLabel tss_modulo;
        private System.Windows.Forms.ToolStripStatusLabel tss_codigo;
        private System.Windows.Forms.ToolStripStatusLabel tss_filial;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tss_id;
        private System.Windows.Forms.ToolStripStatusLabel tss_usuario;
        private System.Windows.Forms.ToolStripStatusLabel tss_codigoinstancia;
        private System.Windows.Forms.ToolStripStatusLabel tss_instanciaAtiva;
        private DevComponents.DotNetBar.ButtonItem rbt_criptografarArquivo;
    }
}

