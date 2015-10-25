namespace ProjektniZadatak_NikolaDjuza
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spomenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogSpomenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazSpomenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipSpomenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosTipovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazTipovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosEtiketaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazEtiketaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorijalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spomeniciTreeView = new System.Windows.Forms.TreeView();
            this.IdSpomenikaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImeSpomenikaTextBox = new System.Windows.Forms.TextBox();
            this.KlimaLabel = new System.Windows.Forms.Label();
            this.KlimaComboBox = new System.Windows.Forms.ComboBox();
            this.TuristickiStatusLabel = new System.Windows.Forms.Label();
            this.TuristickiStatusComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SlikaSpomenikaBox = new System.Windows.Forms.PictureBox();
            this.NaseljenCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UgrozeneVrsteCheckBox = new System.Windows.Forms.CheckBox();
            this.EtiketeDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.UgrozenostCheckBox = new System.Windows.Forms.CheckBox();
            this.TipSpomenikaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.pbxRight = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.tutorijalPanel = new System.Windows.Forms.Panel();
            this.previousStepButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tutorijalTextBox = new System.Windows.Forms.TextBox();
            this.tutorijalLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaSpomenikaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtiketeDataGridView)).BeginInit();
            this.mapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).BeginInit();
            this.tutorijalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.spomenikToolStripMenuItem,
            this.tipSpomenikaToolStripMenuItem,
            this.etiketeToolStripMenuItem,
            this.tutorijalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem,
            this.prikaziHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // prikaziHelpToolStripMenuItem
            // 
            this.prikaziHelpToolStripMenuItem.Name = "prikaziHelpToolStripMenuItem";
            this.prikaziHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.prikaziHelpToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.prikaziHelpToolStripMenuItem.Text = "Prikazi help";
            this.prikaziHelpToolStripMenuItem.Click += new System.EventHandler(this.prikaziHelpToolStripMenuItem_Click);
            // 
            // spomenikToolStripMenuItem
            // 
            this.spomenikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogSpomenikaToolStripMenuItem,
            this.prikazSpomenikaToolStripMenuItem});
            this.spomenikToolStripMenuItem.Name = "spomenikToolStripMenuItem";
            this.spomenikToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.spomenikToolStripMenuItem.Text = "Spomenik";
            // 
            // unosNovogSpomenikaToolStripMenuItem
            // 
            this.unosNovogSpomenikaToolStripMenuItem.Name = "unosNovogSpomenikaToolStripMenuItem";
            this.unosNovogSpomenikaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.unosNovogSpomenikaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.unosNovogSpomenikaToolStripMenuItem.Text = "Unos spomenika";
            this.unosNovogSpomenikaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogSpomenikaToolStripMenuItem_Click);
            // 
            // prikazSpomenikaToolStripMenuItem
            // 
            this.prikazSpomenikaToolStripMenuItem.Name = "prikazSpomenikaToolStripMenuItem";
            this.prikazSpomenikaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.prikazSpomenikaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.prikazSpomenikaToolStripMenuItem.Text = "Prikaz spomenika";
            this.prikazSpomenikaToolStripMenuItem.Click += new System.EventHandler(this.prikazSpomenikaToolStripMenuItem_Click);
            // 
            // tipSpomenikaToolStripMenuItem
            // 
            this.tipSpomenikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosTipovaToolStripMenuItem,
            this.prikazTipovaToolStripMenuItem});
            this.tipSpomenikaToolStripMenuItem.Name = "tipSpomenikaToolStripMenuItem";
            this.tipSpomenikaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tipSpomenikaToolStripMenuItem.Text = "Tipovi";
            // 
            // unosTipovaToolStripMenuItem
            // 
            this.unosTipovaToolStripMenuItem.Name = "unosTipovaToolStripMenuItem";
            this.unosTipovaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.unosTipovaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.unosTipovaToolStripMenuItem.Text = "Unos tipova";
            this.unosTipovaToolStripMenuItem.Click += new System.EventHandler(this.unosTipovaToolStripMenuItem_Click);
            // 
            // prikazTipovaToolStripMenuItem
            // 
            this.prikazTipovaToolStripMenuItem.Name = "prikazTipovaToolStripMenuItem";
            this.prikazTipovaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.prikazTipovaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.prikazTipovaToolStripMenuItem.Text = "Prikaz tipova";
            this.prikazTipovaToolStripMenuItem.Click += new System.EventHandler(this.prikazTipovaToolStripMenuItem_Click);
            // 
            // etiketeToolStripMenuItem
            // 
            this.etiketeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosEtiketaToolStripMenuItem,
            this.prikazEtiketaToolStripMenuItem});
            this.etiketeToolStripMenuItem.Name = "etiketeToolStripMenuItem";
            this.etiketeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.etiketeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.etiketeToolStripMenuItem.Text = "Etikete";
            // 
            // unosEtiketaToolStripMenuItem
            // 
            this.unosEtiketaToolStripMenuItem.Name = "unosEtiketaToolStripMenuItem";
            this.unosEtiketaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.unosEtiketaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.unosEtiketaToolStripMenuItem.Text = "Unos etiketa";
            this.unosEtiketaToolStripMenuItem.Click += new System.EventHandler(this.unosEtiketaToolStripMenuItem_Click);
            // 
            // prikazEtiketaToolStripMenuItem
            // 
            this.prikazEtiketaToolStripMenuItem.Name = "prikazEtiketaToolStripMenuItem";
            this.prikazEtiketaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.prikazEtiketaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.prikazEtiketaToolStripMenuItem.Text = "Prikaz etiketa";
            this.prikazEtiketaToolStripMenuItem.Click += new System.EventHandler(this.prikazEtiketaToolStripMenuItem_Click);
            // 
            // tutorijalToolStripMenuItem
            // 
            this.tutorijalToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tutorijalToolStripMenuItem.Name = "tutorijalToolStripMenuItem";
            this.tutorijalToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tutorijalToolStripMenuItem.Text = "Tutorijal";
            this.tutorijalToolStripMenuItem.Click += new System.EventHandler(this.tutorijalToolStripMenuItem_Click);
            // 
            // spomeniciTreeView
            // 
            this.spomeniciTreeView.Location = new System.Drawing.Point(12, 27);
            this.spomeniciTreeView.Name = "spomeniciTreeView";
            this.spomeniciTreeView.Size = new System.Drawing.Size(169, 374);
            this.spomeniciTreeView.TabIndex = 3;
            this.spomeniciTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.spomeniciTreeView_AfterSelect);
            this.spomeniciTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.spomeniciTreeView_NodeMouseClick);
            this.spomeniciTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spomeniciTreeView_MouseDown);
            this.spomeniciTreeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spomeniciTreeView_MouseMove);
            // 
            // IdSpomenikaTextBox
            // 
            this.IdSpomenikaTextBox.Enabled = false;
            this.IdSpomenikaTextBox.Location = new System.Drawing.Point(118, 7);
            this.IdSpomenikaTextBox.Name = "IdSpomenikaTextBox";
            this.IdSpomenikaTextBox.ReadOnly = true;
            this.IdSpomenikaTextBox.Size = new System.Drawing.Size(185, 20);
            this.IdSpomenikaTextBox.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Ime";
            // 
            // ImeSpomenikaTextBox
            // 
            this.ImeSpomenikaTextBox.Enabled = false;
            this.ImeSpomenikaTextBox.Location = new System.Drawing.Point(118, 36);
            this.ImeSpomenikaTextBox.Name = "ImeSpomenikaTextBox";
            this.ImeSpomenikaTextBox.ReadOnly = true;
            this.ImeSpomenikaTextBox.Size = new System.Drawing.Size(185, 20);
            this.ImeSpomenikaTextBox.TabIndex = 84;
            // 
            // KlimaLabel
            // 
            this.KlimaLabel.AutoSize = true;
            this.KlimaLabel.Location = new System.Drawing.Point(80, 68);
            this.KlimaLabel.Name = "KlimaLabel";
            this.KlimaLabel.Size = new System.Drawing.Size(32, 13);
            this.KlimaLabel.TabIndex = 92;
            this.KlimaLabel.Text = "Klima";
            // 
            // KlimaComboBox
            // 
            this.KlimaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlimaComboBox.Enabled = false;
            this.KlimaComboBox.FormattingEnabled = true;
            this.KlimaComboBox.Items.AddRange(new object[] {
            "polarna",
            "kontinentalna",
            "umereno-kontinentalna",
            "pustinjska",
            "suptropska",
            "tropska"});
            this.KlimaComboBox.Location = new System.Drawing.Point(118, 65);
            this.KlimaComboBox.Name = "KlimaComboBox";
            this.KlimaComboBox.Size = new System.Drawing.Size(185, 21);
            this.KlimaComboBox.TabIndex = 93;
            // 
            // TuristickiStatusLabel
            // 
            this.TuristickiStatusLabel.AutoSize = true;
            this.TuristickiStatusLabel.Location = new System.Drawing.Point(32, 96);
            this.TuristickiStatusLabel.Name = "TuristickiStatusLabel";
            this.TuristickiStatusLabel.Size = new System.Drawing.Size(80, 13);
            this.TuristickiStatusLabel.TabIndex = 94;
            this.TuristickiStatusLabel.Text = "Turistički status";
            // 
            // TuristickiStatusComboBox
            // 
            this.TuristickiStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TuristickiStatusComboBox.Enabled = false;
            this.TuristickiStatusComboBox.FormattingEnabled = true;
            this.TuristickiStatusComboBox.Items.AddRange(new object[] {
            "eksploatisan",
            "dostupan",
            "nedostupan"});
            this.TuristickiStatusComboBox.Location = new System.Drawing.Point(118, 93);
            this.TuristickiStatusComboBox.Name = "TuristickiStatusComboBox";
            this.TuristickiStatusComboBox.Size = new System.Drawing.Size(185, 21);
            this.TuristickiStatusComboBox.TabIndex = 95;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SlikaSpomenikaBox);
            this.panel1.Controls.Add(this.NaseljenCheckBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TuristickiStatusComboBox);
            this.panel1.Controls.Add(this.UgrozeneVrsteCheckBox);
            this.panel1.Controls.Add(this.EtiketeDataGridView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UgrozenostCheckBox);
            this.panel1.Controls.Add(this.TipSpomenikaTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TuristickiStatusLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.KlimaComboBox);
            this.panel1.Controls.Add(this.KlimaLabel);
            this.panel1.Controls.Add(this.ImeSpomenikaTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IdSpomenikaTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 122);
            this.panel1.TabIndex = 4;
            // 
            // SlikaSpomenikaBox
            // 
            this.SlikaSpomenikaBox.BackColor = System.Drawing.SystemColors.Control;
            this.SlikaSpomenikaBox.Image = global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default;
            this.SlikaSpomenikaBox.InitialImage = global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default;
            this.SlikaSpomenikaBox.Location = new System.Drawing.Point(692, 2);
            this.SlikaSpomenikaBox.Name = "SlikaSpomenikaBox";
            this.SlikaSpomenikaBox.Size = new System.Drawing.Size(128, 120);
            this.SlikaSpomenikaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlikaSpomenikaBox.TabIndex = 113;
            this.SlikaSpomenikaBox.TabStop = false;
            // 
            // NaseljenCheckBox
            // 
            this.NaseljenCheckBox.AutoSize = true;
            this.NaseljenCheckBox.Enabled = false;
            this.NaseljenCheckBox.Location = new System.Drawing.Point(442, 95);
            this.NaseljenCheckBox.Name = "NaseljenCheckBox";
            this.NaseljenCheckBox.Size = new System.Drawing.Size(15, 14);
            this.NaseljenCheckBox.TabIndex = 123;
            this.NaseljenCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 130;
            this.label10.Text = "Etikete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "U naseljenom mestu";
            // 
            // UgrozeneVrsteCheckBox
            // 
            this.UgrozeneVrsteCheckBox.AutoSize = true;
            this.UgrozeneVrsteCheckBox.Enabled = false;
            this.UgrozeneVrsteCheckBox.Location = new System.Drawing.Point(442, 68);
            this.UgrozeneVrsteCheckBox.Name = "UgrozeneVrsteCheckBox";
            this.UgrozeneVrsteCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UgrozeneVrsteCheckBox.TabIndex = 121;
            this.UgrozeneVrsteCheckBox.UseVisualStyleBackColor = true;
            // 
            // EtiketeDataGridView
            // 
            this.EtiketeDataGridView.AllowUserToAddRows = false;
            this.EtiketeDataGridView.AllowUserToDeleteRows = false;
            this.EtiketeDataGridView.AllowUserToResizeRows = false;
            this.EtiketeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EtiketeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EtiketeDataGridView.Location = new System.Drawing.Point(518, 16);
            this.EtiketeDataGridView.MultiSelect = false;
            this.EtiketeDataGridView.Name = "EtiketeDataGridView";
            this.EtiketeDataGridView.ReadOnly = true;
            this.EtiketeDataGridView.RowHeadersVisible = false;
            this.EtiketeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EtiketeDataGridView.Size = new System.Drawing.Size(129, 93);
            this.EtiketeDataGridView.TabIndex = 129;
            this.EtiketeDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.EtiketeDataGridView_CellFormatting);
            this.EtiketeDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellMouseEnter);
            this.EtiketeDataGridView.MouseLeave += new System.EventHandler(this.EtiketeDataGridView_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Stanište ugroženih vrsta";
            // 
            // UgrozenostCheckBox
            // 
            this.UgrozenostCheckBox.AutoSize = true;
            this.UgrozenostCheckBox.Enabled = false;
            this.UgrozenostCheckBox.Location = new System.Drawing.Point(442, 41);
            this.UgrozenostCheckBox.Name = "UgrozenostCheckBox";
            this.UgrozenostCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UgrozenostCheckBox.TabIndex = 119;
            this.UgrozenostCheckBox.UseVisualStyleBackColor = true;
            // 
            // TipSpomenikaTextBox
            // 
            this.TipSpomenikaTextBox.Enabled = false;
            this.TipSpomenikaTextBox.Location = new System.Drawing.Point(335, 7);
            this.TipSpomenikaTextBox.Name = "TipSpomenikaTextBox";
            this.TipSpomenikaTextBox.Size = new System.Drawing.Size(120, 20);
            this.TipSpomenikaTextBox.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Ekološka ugroženost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 127;
            this.label9.Text = "Tip";
            // 
            // mapPanel
            // 
            this.mapPanel.AllowDrop = true;
            this.mapPanel.BackgroundImage = global::ProjektniZadatak_NikolaDjuza.Properties.Resources.map;
            this.mapPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mapPanel.Controls.Add(this.pbxRight);
            this.mapPanel.Location = new System.Drawing.Point(187, 27);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(689, 374);
            this.mapPanel.TabIndex = 2;
            this.mapPanel.Click += new System.EventHandler(this.mapPanel_Click);
            this.mapPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragDrop);
            this.mapPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragEnter);
            // 
            // pbxRight
            // 
            this.pbxRight.BackColor = System.Drawing.Color.Transparent;
            this.pbxRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxRight.BackgroundImage")));
            this.pbxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxRight.Location = new System.Drawing.Point(0, 0);
            this.pbxRight.Name = "pbxRight";
            this.pbxRight.Size = new System.Drawing.Size(102, 110);
            this.pbxRight.TabIndex = 3;
            this.pbxRight.TabStop = false;
            this.pbxRight.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "E:\\Documents\\VI\\HCI\\ProjektniZadatak\\ProjektniZadatak-NikolaDjuza\\ProjektniZadata" +
    "k-NikolaDjuza\\Resources\\Help.chm";
            // 
            // tutorijalPanel
            // 
            this.tutorijalPanel.Controls.Add(this.previousStepButton);
            this.tutorijalPanel.Controls.Add(this.button1);
            this.tutorijalPanel.Controls.Add(this.tutorijalTextBox);
            this.tutorijalPanel.Controls.Add(this.tutorijalLabel);
            this.tutorijalPanel.Location = new System.Drawing.Point(12, 206);
            this.tutorijalPanel.Name = "tutorijalPanel";
            this.tutorijalPanel.Size = new System.Drawing.Size(419, 195);
            this.tutorijalPanel.TabIndex = 0;
            this.tutorijalPanel.Visible = false;
            // 
            // previousStepButton
            // 
            this.previousStepButton.Location = new System.Drawing.Point(358, 140);
            this.previousStepButton.Name = "previousStepButton";
            this.previousStepButton.Size = new System.Drawing.Size(28, 23);
            this.previousStepButton.TabIndex = 10;
            this.previousStepButton.Text = "<<";
            this.previousStepButton.UseVisualStyleBackColor = true;
            this.previousStepButton.Click += new System.EventHandler(this.previousStepButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Završi tutorijal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tutorijalTextBox
            // 
            this.tutorijalTextBox.Enabled = false;
            this.tutorijalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorijalTextBox.Location = new System.Drawing.Point(0, 52);
            this.tutorijalTextBox.Multiline = true;
            this.tutorijalTextBox.Name = "tutorijalTextBox";
            this.tutorijalTextBox.Size = new System.Drawing.Size(329, 140);
            this.tutorijalTextBox.TabIndex = 1;
            // 
            // tutorijalLabel
            // 
            this.tutorijalLabel.AutoSize = true;
            this.tutorijalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorijalLabel.Location = new System.Drawing.Point(3, 9);
            this.tutorijalLabel.Name = "tutorijalLabel";
            this.tutorijalLabel.Size = new System.Drawing.Size(414, 25);
            this.tutorijalLabel.TabIndex = 0;
            this.tutorijalLabel.Text = "Tutorijal za stavljanje spomenika na mapu";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 541);
            this.Controls.Add(this.tutorijalPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spomeniciTreeView);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija svetskih spomenika";
            this.Activated += new System.EventHandler(this.MainFrame_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaSpomenikaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EtiketeDataGridView)).EndInit();
            this.mapPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).EndInit();
            this.tutorijalPanel.ResumeLayout(false);
            this.tutorijalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spomenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogSpomenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazSpomenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipSpomenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosTipovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazTipovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiketeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosEtiketaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazEtiketaToolStripMenuItem;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.TreeView spomeniciTreeView;
        private System.Windows.Forms.TextBox IdSpomenikaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImeSpomenikaTextBox;
        private System.Windows.Forms.Label KlimaLabel;
        private System.Windows.Forms.ComboBox KlimaComboBox;
        private System.Windows.Forms.Label TuristickiStatusLabel;
        private System.Windows.Forms.ComboBox TuristickiStatusComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView EtiketeDataGridView;
        private System.Windows.Forms.TextBox TipSpomenikaTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox NaseljenCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox UgrozeneVrsteCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox UgrozenostCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox SlikaSpomenikaBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem prikaziHelpToolStripMenuItem;
        public System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolStripMenuItem tutorijalToolStripMenuItem;
        private System.Windows.Forms.Panel tutorijalPanel;
        private System.Windows.Forms.TextBox tutorijalTextBox;
        private System.Windows.Forms.Label tutorijalLabel;
        private System.Windows.Forms.PictureBox pbxRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button previousStepButton;

    }
}

