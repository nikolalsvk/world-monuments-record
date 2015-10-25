namespace ProjektniZadatak_NikolaDjuza
{
    partial class PrikazEtiketaSpomenikaFrame
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
            this.postojeceEtiketeDataGridView = new System.Windows.Forms.DataGridView();
            this.BojaButton = new System.Windows.Forms.Button();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.SifraLabel = new System.Windows.Forms.Label();
            this.opisEiketeTextBox = new System.Windows.Forms.TextBox();
            this.sifraEtiketeTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.izmeniButton = new System.Windows.Forms.Button();
            this.izbrisiButton = new System.Windows.Forms.Button();
            this.dodajEtiketuButton = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolstripItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.postojeceEtiketeDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // postojeceEtiketeDataGridView
            // 
            this.postojeceEtiketeDataGridView.AllowUserToAddRows = false;
            this.postojeceEtiketeDataGridView.AllowUserToDeleteRows = false;
            this.postojeceEtiketeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postojeceEtiketeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postojeceEtiketeDataGridView.Location = new System.Drawing.Point(12, 27);
            this.postojeceEtiketeDataGridView.Name = "postojeceEtiketeDataGridView";
            this.postojeceEtiketeDataGridView.ReadOnly = true;
            this.postojeceEtiketeDataGridView.RowHeadersVisible = false;
            this.postojeceEtiketeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.postojeceEtiketeDataGridView.Size = new System.Drawing.Size(300, 122);
            this.postojeceEtiketeDataGridView.TabIndex = 59;
            this.postojeceEtiketeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.postojeceEtiketeDataGridView_CellContentClick);
            this.postojeceEtiketeDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.postojeceEtiketeDataGridView_CellFormatting);
            // 
            // BojaButton
            // 
            this.BojaButton.Enabled = false;
            this.BojaButton.ForeColor = System.Drawing.Color.Snow;
            this.BojaButton.Location = new System.Drawing.Point(82, 193);
            this.BojaButton.Name = "BojaButton";
            this.BojaButton.Size = new System.Drawing.Size(121, 23);
            this.BojaButton.TabIndex = 67;
            this.BojaButton.UseVisualStyleBackColor = true;
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(13, 234);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(63, 13);
            this.OpisLabel.TabIndex = 66;
            this.OpisLabel.Text = "Opis etikete";
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(13, 198);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(63, 13);
            this.ImeLabel.TabIndex = 65;
            this.ImeLabel.Text = "Boja etikete";
            // 
            // SifraLabel
            // 
            this.SifraLabel.AutoSize = true;
            this.SifraLabel.Location = new System.Drawing.Point(13, 163);
            this.SifraLabel.Name = "SifraLabel";
            this.SifraLabel.Size = new System.Drawing.Size(63, 13);
            this.SifraLabel.TabIndex = 64;
            this.SifraLabel.Text = "Sifra etikete";
            // 
            // opisEiketeTextBox
            // 
            this.opisEiketeTextBox.Enabled = false;
            this.opisEiketeTextBox.Location = new System.Drawing.Point(82, 231);
            this.opisEiketeTextBox.Multiline = true;
            this.opisEiketeTextBox.Name = "opisEiketeTextBox";
            this.opisEiketeTextBox.Size = new System.Drawing.Size(121, 48);
            this.opisEiketeTextBox.TabIndex = 63;
            // 
            // sifraEtiketeTextBox
            // 
            this.sifraEtiketeTextBox.Enabled = false;
            this.sifraEtiketeTextBox.Location = new System.Drawing.Point(82, 160);
            this.sifraEtiketeTextBox.Name = "sifraEtiketeTextBox";
            this.sifraEtiketeTextBox.Size = new System.Drawing.Size(121, 20);
            this.sifraEtiketeTextBox.TabIndex = 62;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(116, 289);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(87, 32);
            this.OkButton.TabIndex = 68;
            this.OkButton.Text = "Nazad";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // izmeniButton
            // 
            this.izmeniButton.Location = new System.Drawing.Point(226, 160);
            this.izmeniButton.Name = "izmeniButton";
            this.izmeniButton.Size = new System.Drawing.Size(86, 32);
            this.izmeniButton.TabIndex = 71;
            this.izmeniButton.Text = "Izmeni etiketu";
            this.izmeniButton.UseVisualStyleBackColor = true;
            this.izmeniButton.Click += new System.EventHandler(this.izmeniButton_Click);
            // 
            // izbrisiButton
            // 
            this.izbrisiButton.Location = new System.Drawing.Point(226, 198);
            this.izbrisiButton.Name = "izbrisiButton";
            this.izbrisiButton.Size = new System.Drawing.Size(86, 32);
            this.izbrisiButton.TabIndex = 70;
            this.izbrisiButton.Text = "Izbriši etiketu";
            this.izbrisiButton.UseVisualStyleBackColor = true;
            this.izbrisiButton.Click += new System.EventHandler(this.izbrisiButton_Click);
            // 
            // dodajEtiketuButton
            // 
            this.dodajEtiketuButton.Location = new System.Drawing.Point(226, 236);
            this.dodajEtiketuButton.Name = "dodajEtiketuButton";
            this.dodajEtiketuButton.Size = new System.Drawing.Size(86, 32);
            this.dodajEtiketuButton.TabIndex = 69;
            this.dodajEtiketuButton.Text = "Dodaj etiketu";
            this.dodajEtiketuButton.UseVisualStyleBackColor = true;
            this.dodajEtiketuButton.Click += new System.EventHandler(this.dodajEtiketuButton_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "E:\\Documents\\VI\\HCI\\ProjektniZadatak\\ProjektniZadatak-NikolaDjuza\\ProjektniZadata" +
    "k-NikolaDjuza\\Resources\\Help.chm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolstripItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HelpToolstripItem
            // 
            this.HelpToolstripItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HelpToolstripItem.Name = "HelpToolstripItem";
            this.HelpToolstripItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpToolstripItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpToolstripItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolstripItem.Text = "Help";
            this.HelpToolstripItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.HelpToolstripItem.Click += new System.EventHandler(this.HelpToolstripItem_Click);
            // 
            // PrikazEtiketaSpomenikaFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 333);
            this.Controls.Add(this.izmeniButton);
            this.Controls.Add(this.izbrisiButton);
            this.Controls.Add(this.dodajEtiketuButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.BojaButton);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.SifraLabel);
            this.Controls.Add(this.opisEiketeTextBox);
            this.Controls.Add(this.sifraEtiketeTextBox);
            this.Controls.Add(this.postojeceEtiketeDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrikazEtiketaSpomenikaFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz svih etiketa";
            this.Activated += new System.EventHandler(this.PrikazEtiketaSpomenikaFrame_Activated);
            this.Load += new System.EventHandler(this.PrikazEtiketaSpomenikaFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postojeceEtiketeDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView postojeceEtiketeDataGridView;
        private System.Windows.Forms.Button BojaButton;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.Label SifraLabel;
        private System.Windows.Forms.TextBox opisEiketeTextBox;
        private System.Windows.Forms.TextBox sifraEtiketeTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button izmeniButton;
        private System.Windows.Forms.Button izbrisiButton;
        private System.Windows.Forms.Button dodajEtiketuButton;
        public System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolstripItem;
    }
}