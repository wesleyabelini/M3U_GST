namespace M3U_GST
{
    partial class FPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.dgvConteudo = new System.Windows.Forms.DataGridView();
            this.dgvIPTV = new System.Windows.Forms.DataGridView();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.chkSD = new System.Windows.Forms.CheckBox();
            this.chkHD = new System.Windows.Forms.CheckBox();
            this.chkFHD = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk4K = new System.Windows.Forms.CheckBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.stsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.stsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadDoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFillByAll = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tslTotal = new System.Windows.Forms.ToolStripLabel();
            this.tslTotalResult = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslPasta = new System.Windows.Forms.ToolStripLabel();
            this.tslPastaResult = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLista = new System.Windows.Forms.ToolStripLabel();
            this.tslListaResult = new System.Windows.Forms.ToolStripLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtGrupoConsulta = new System.Windows.Forms.TextBox();
            this.txtTituloConsulta = new System.Windows.Forms.TextBox();
            this.txtURLConsulta = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPTV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.AllowUserToAddRows = false;
            this.dgvGrupo.AllowUserToDeleteRows = false;
            this.dgvGrupo.AllowUserToOrderColumns = true;
            this.dgvGrupo.AllowUserToResizeColumns = false;
            this.dgvGrupo.AllowUserToResizeRows = false;
            this.dgvGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.ColumnHeadersVisible = false;
            this.dgvGrupo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrupo.Location = new System.Drawing.Point(0, 93);
            this.dgvGrupo.MultiSelect = false;
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.RowHeadersVisible = false;
            this.dgvGrupo.RowHeadersWidth = 51;
            this.dgvGrupo.RowTemplate.Height = 29;
            this.dgvGrupo.Size = new System.Drawing.Size(402, 639);
            this.dgvGrupo.TabIndex = 1;
            this.dgvGrupo.SelectionChanged += new System.EventHandler(this.dgvGrupo_SelectionChanged);
            // 
            // dgvConteudo
            // 
            this.dgvConteudo.AllowUserToAddRows = false;
            this.dgvConteudo.AllowUserToDeleteRows = false;
            this.dgvConteudo.AllowUserToOrderColumns = true;
            this.dgvConteudo.AllowUserToResizeColumns = false;
            this.dgvConteudo.AllowUserToResizeRows = false;
            this.dgvConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConteudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConteudo.ColumnHeadersVisible = false;
            this.dgvConteudo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConteudo.Location = new System.Drawing.Point(426, 93);
            this.dgvConteudo.Name = "dgvConteudo";
            this.dgvConteudo.RowHeadersVisible = false;
            this.dgvConteudo.RowHeadersWidth = 51;
            this.dgvConteudo.RowTemplate.Height = 29;
            this.dgvConteudo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConteudo.Size = new System.Drawing.Size(402, 575);
            this.dgvConteudo.TabIndex = 2;
            this.dgvConteudo.SelectionChanged += new System.EventHandler(this.dgvConteudo_SelectionChanged);
            this.dgvConteudo.DoubleClick += new System.EventHandler(this.dgvConteudo_DoubleClick);
            this.dgvConteudo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // dgvIPTV
            // 
            this.dgvIPTV.AllowUserToAddRows = false;
            this.dgvIPTV.AllowUserToDeleteRows = false;
            this.dgvIPTV.AllowUserToResizeColumns = false;
            this.dgvIPTV.AllowUserToResizeRows = false;
            this.dgvIPTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIPTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIPTV.ColumnHeadersVisible = false;
            this.dgvIPTV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIPTV.Location = new System.Drawing.Point(894, 272);
            this.dgvIPTV.Name = "dgvIPTV";
            this.dgvIPTV.RowHeadersVisible = false;
            this.dgvIPTV.RowHeadersWidth = 51;
            this.dgvIPTV.RowTemplate.Height = 29;
            this.dgvIPTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIPTV.Size = new System.Drawing.Size(508, 460);
            this.dgvIPTV.TabIndex = 4;
            this.dgvIPTV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIPTV_DataBindingComplete);
            this.dgvIPTV.SelectionChanged += new System.EventHandler(this.dgvIPTV_SelectionChanged);
            this.dgvIPTV.DoubleClick += new System.EventHandler(this.dgvIPTV_DoubleClick);
            this.dgvIPTV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAll.ImageIndex = 4;
            this.btnAddAll.ImageList = this.imageList1;
            this.btnAddAll.Location = new System.Drawing.Point(842, 437);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(37, 29);
            this.btnAddAll.TabIndex = 6;
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1486348532-music-play-pause-control-go-arrow_80458.ico");
            this.imageList1.Images.SetKeyName(1, "1486348526-arrow-back-backwards-repeat-previous_80453.ico");
            this.imageList1.Images.SetKeyName(2, "1486348525-music-forward-front-next-arrow_80457.ico");
            this.imageList1.Images.SetKeyName(3, "1486348529-back-backwards-repeat-arrows-arrow_80455.ico");
            this.imageList1.Images.SetKeyName(4, "1486348528-forward-arrows-arrow-front-go_80452.ico");
            this.imageList1.Images.SetKeyName(5, "Control Panel (8).ico");
            this.imageList1.Images.SetKeyName(6, "Image - Import.ico");
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveOne.ImageIndex = 1;
            this.btnRemoveOne.ImageList = this.imageList1;
            this.btnRemoveOne.Location = new System.Drawing.Point(842, 507);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(37, 29);
            this.btnRemoveOne.TabIndex = 7;
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddOne.ImageIndex = 2;
            this.btnAddOne.ImageList = this.imageList1;
            this.btnAddOne.Location = new System.Drawing.Point(842, 472);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(37, 29);
            this.btnAddOne.TabIndex = 8;
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveAll.ImageIndex = 3;
            this.btnRemoveAll.ImageList = this.imageList1;
            this.btnRemoveAll.Location = new System.Drawing.Point(842, 542);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(37, 29);
            this.btnRemoveAll.TabIndex = 9;
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(1411, 418);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 79);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDown.Location = new System.Drawing.Point(1411, 519);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 79);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // chkSD
            // 
            this.chkSD.AutoSize = true;
            this.chkSD.Checked = true;
            this.chkSD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSD.Location = new System.Drawing.Point(24, 20);
            this.chkSD.Name = "chkSD";
            this.chkSD.Size = new System.Drawing.Size(50, 24);
            this.chkSD.TabIndex = 12;
            this.chkSD.Text = "SD";
            this.chkSD.UseVisualStyleBackColor = true;
            this.chkSD.CheckedChanged += new System.EventHandler(this.chkSD_CheckedChanged);
            // 
            // chkHD
            // 
            this.chkHD.AutoSize = true;
            this.chkHD.Checked = true;
            this.chkHD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHD.Location = new System.Drawing.Point(118, 20);
            this.chkHD.Name = "chkHD";
            this.chkHD.Size = new System.Drawing.Size(53, 24);
            this.chkHD.TabIndex = 13;
            this.chkHD.Text = "HD";
            this.chkHD.UseVisualStyleBackColor = true;
            this.chkHD.CheckedChanged += new System.EventHandler(this.chkHD_CheckedChanged);
            // 
            // chkFHD
            // 
            this.chkFHD.AutoSize = true;
            this.chkFHD.Checked = true;
            this.chkFHD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFHD.Location = new System.Drawing.Point(215, 20);
            this.chkFHD.Name = "chkFHD";
            this.chkFHD.Size = new System.Drawing.Size(60, 24);
            this.chkFHD.TabIndex = 14;
            this.chkFHD.Text = "FHD";
            this.chkFHD.UseVisualStyleBackColor = true;
            this.chkFHD.CheckedChanged += new System.EventHandler(this.chkFHD_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.chk4K);
            this.groupBox1.Controls.Add(this.chkFHD);
            this.groupBox1.Controls.Add(this.chkSD);
            this.groupBox1.Controls.Add(this.chkHD);
            this.groupBox1.Location = new System.Drawing.Point(426, 674);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 58);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // chk4K
            // 
            this.chk4K.AutoSize = true;
            this.chk4K.Checked = true;
            this.chk4K.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk4K.Location = new System.Drawing.Point(319, 20);
            this.chk4K.Name = "chk4K";
            this.chk4K.Size = new System.Drawing.Size(48, 24);
            this.chk4K.TabIndex = 15;
            this.chk4K.Text = "4K";
            this.chk4K.UseVisualStyleBackColor = true;
            this.chk4K.CheckedChanged += new System.EventHandler(this.chk4K_CheckedChanged);
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(0, 58);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(402, 27);
            this.txtGrupo.TabIndex = 16;
            this.txtGrupo.TextChanged += new System.EventHandler(this.txtGrupo_TextChanged);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(426, 60);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(402, 27);
            this.txtConteudo.TabIndex = 17;
            this.txtConteudo.TextChanged += new System.EventHandler(this.txtConteudo_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFechar,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1451, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFechar
            // 
            this.tsmFechar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsSave,
            this.stsSaveAs,
            this.tsmImportList,
            this.toolStripMenuItem1,
            this.configToolStripMenuItem,
            this.toolStripSeparator4,
            this.fecharToolStripMenuItem});
            this.tsmFechar.Name = "tsmFechar";
            this.tsmFechar.Size = new System.Drawing.Size(75, 24);
            this.tsmFechar.Text = "Arquivo";
            // 
            // stsSave
            // 
            this.stsSave.Image = global::M3U_GST.Properties.Resources.Floppy;
            this.stsSave.Name = "stsSave";
            this.stsSave.Size = new System.Drawing.Size(184, 26);
            this.stsSave.Text = "Salvar";
            this.stsSave.Click += new System.EventHandler(this.stsSave_Click);
            // 
            // stsSaveAs
            // 
            this.stsSaveAs.Image = global::M3U_GST.Properties.Resources.Folder__32_;
            this.stsSaveAs.Name = "stsSaveAs";
            this.stsSaveAs.Size = new System.Drawing.Size(184, 26);
            this.stsSaveAs.Text = "Salvar Cópia";
            this.stsSaveAs.Click += new System.EventHandler(this.stsSaveAs_Click);
            // 
            // tsmImportList
            // 
            this.tsmImportList.Image = global::M3U_GST.Properties.Resources.Image___Import;
            this.tsmImportList.Name = "tsmImportList";
            this.tsmImportList.Size = new System.Drawing.Size(184, 26);
            this.tsmImportList.Text = "Importar Lista";
            this.tsmImportList.Click += new System.EventHandler(this.tsmImportList_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Image = global::M3U_GST.Properties.Resources.Control_Panel__8_;
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSobre});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // tsmSobre
            // 
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(131, 26);
            this.tsmSobre.Text = "Sobre";
            this.tsmSobre.Click += new System.EventHandler(this.tsmSobre_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbSaveAs,
            this.tsbLoadDoc,
            this.toolStripSeparator3,
            this.tsbConfig,
            this.toolStripSeparator5,
            this.tsbFillByAll});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1451, 27);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::M3U_GST.Properties.Resources.Floppy;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(29, 24);
            this.tsbSave.Text = "tsbSave";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSaveAs
            // 
            this.tsbSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAs.Image = global::M3U_GST.Properties.Resources.Folder__32_;
            this.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAs.Name = "tsbSaveAs";
            this.tsbSaveAs.Size = new System.Drawing.Size(29, 24);
            this.tsbSaveAs.Text = "toolStripButton2";
            this.tsbSaveAs.Click += new System.EventHandler(this.tsbSaveAs_Click);
            // 
            // tsbLoadDoc
            // 
            this.tsbLoadDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadDoc.Image = global::M3U_GST.Properties.Resources.Image___Import;
            this.tsbLoadDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadDoc.Name = "tsbLoadDoc";
            this.tsbLoadDoc.Size = new System.Drawing.Size(29, 24);
            this.tsbLoadDoc.Text = "toolStripButton1";
            this.tsbLoadDoc.ToolTipText = "Importar Lista";
            this.tsbLoadDoc.Click += new System.EventHandler(this.tsbLoadDoc_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbConfig
            // 
            this.tsbConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConfig.Image = global::M3U_GST.Properties.Resources.Control_Panel__8_;
            this.tsbConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfig.Name = "tsbConfig";
            this.tsbConfig.Size = new System.Drawing.Size(29, 24);
            this.tsbConfig.Text = "tsbConfig";
            this.tsbConfig.ToolTipText = "Config";
            this.tsbConfig.Click += new System.EventHandler(this.tsbConfig_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbFillByAll
            // 
            this.tsbFillByAll.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.tsbFillByAll.Name = "tsbFillByAll";
            this.tsbFillByAll.Size = new System.Drawing.Size(230, 27);
            this.tsbFillByAll.ToolTipText = "Busca mídia";
            this.tsbFillByAll.TextChanged += new System.EventHandler(this.tsbFillByAll_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTotal,
            this.tslTotalResult,
            this.toolStripSeparator1,
            this.tslPasta,
            this.tslPastaResult,
            this.toolStripSeparator2,
            this.tslLista,
            this.tslListaResult});
            this.toolStrip2.Location = new System.Drawing.Point(0, 740);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1451, 25);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tslTotal
            // 
            this.tslTotal.Name = "tslTotal";
            this.tslTotal.Size = new System.Drawing.Size(42, 22);
            this.tslTotal.Text = "Total";
            // 
            // tslTotalResult
            // 
            this.tslTotalResult.Name = "tslTotalResult";
            this.tslTotalResult.Size = new System.Drawing.Size(17, 22);
            this.tslTotalResult.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslPasta
            // 
            this.tslPasta.Name = "tslPasta";
            this.tslPasta.Size = new System.Drawing.Size(43, 22);
            this.tslPasta.Text = "Pasta";
            // 
            // tslPastaResult
            // 
            this.tslPastaResult.Name = "tslPastaResult";
            this.tslPastaResult.Size = new System.Drawing.Size(17, 22);
            this.tslPastaResult.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslLista
            // 
            this.tslLista.Name = "tslLista";
            this.tslLista.Size = new System.Drawing.Size(39, 22);
            this.tslLista.Text = "Lista";
            // 
            // tslListaResult
            // 
            this.tslListaResult.Name = "tslListaResult";
            this.tslListaResult.Size = new System.Drawing.Size(17, 22);
            this.tslListaResult.Text = "0";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackColor = System.Drawing.Color.Black;
            this.picLogo.Location = new System.Drawing.Point(413, 17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(136, 180);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 21;
            this.picLogo.TabStop = false;
            // 
            // txtGrupoConsulta
            // 
            this.txtGrupoConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrupoConsulta.Location = new System.Drawing.Point(20, 35);
            this.txtGrupoConsulta.Name = "txtGrupoConsulta";
            this.txtGrupoConsulta.Size = new System.Drawing.Size(373, 27);
            this.txtGrupoConsulta.TabIndex = 22;
            // 
            // txtTituloConsulta
            // 
            this.txtTituloConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloConsulta.Location = new System.Drawing.Point(20, 83);
            this.txtTituloConsulta.Name = "txtTituloConsulta";
            this.txtTituloConsulta.Size = new System.Drawing.Size(373, 27);
            this.txtTituloConsulta.TabIndex = 23;
            // 
            // txtURLConsulta
            // 
            this.txtURLConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURLConsulta.Location = new System.Drawing.Point(20, 135);
            this.txtURLConsulta.Name = "txtURLConsulta";
            this.txtURLConsulta.Size = new System.Drawing.Size(373, 27);
            this.txtURLConsulta.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(20, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 29);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGrupoConsulta);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.picLogo);
            this.groupBox2.Controls.Add(this.txtURLConsulta);
            this.groupBox2.Controls.Add(this.txtTituloConsulta);
            this.groupBox2.Location = new System.Drawing.Point(842, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 208);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.ImageIndex = 0;
            this.btnPlay.ImageList = this.imageList1;
            this.btnPlay.Location = new System.Drawing.Point(323, 168);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(70, 29);
            this.btnPlay.TabIndex = 28;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Grupo";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1451, 765);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnRemoveOne);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.dgvIPTV);
            this.Controls.Add(this.dgvConteudo);
            this.Controls.Add(this.dgvGrupo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPTV List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPTV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.DataGridView dgvConteudo;
        private System.Windows.Forms.DataGridView dgvIPTV;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveOne;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.CheckBox chkSD;
        private System.Windows.Forms.CheckBox chkHD;
        private System.Windows.Forms.CheckBox chkFHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk4K;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFechar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConfig;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
        private System.Windows.Forms.ToolStripButton tsbLoadDoc;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tslTotal;
        private System.Windows.Forms.ToolStripLabel tslTotalResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslPasta;
        private System.Windows.Forms.ToolStripLabel tslPastaResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslLista;
        private System.Windows.Forms.ToolStripLabel tslListaResult;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtGrupoConsulta;
        private System.Windows.Forms.TextBox txtTituloConsulta;
        private System.Windows.Forms.TextBox txtURLConsulta;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox tsbFillByAll;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem stsSave;
        private System.Windows.Forms.ToolStripMenuItem stsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmImportList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}
