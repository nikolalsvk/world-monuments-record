namespace ProjektniZadatak_NikolaDjuza
{
    partial class UnosEtiketaSpomenikaFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosEtiketaSpomenikaFrame));
            this.BojaButton = new System.Windows.Forms.Button();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.SifraLabel = new System.Windows.Forms.Label();
            this.opisEiketeTextBox = new System.Windows.Forms.TextBox();
            this.sifraEtiketeTextBox = new System.Windows.Forms.TextBox();
            this.dodajEtiketuButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolstripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BojaButton
            // 
            this.BojaButton.ForeColor = System.Drawing.Color.Snow;
            this.BojaButton.Location = new System.Drawing.Point(82, 63);
            this.BojaButton.Name = "BojaButton";
            this.BojaButton.Size = new System.Drawing.Size(139, 23);
            this.BojaButton.TabIndex = 2;
            this.BojaButton.UseVisualStyleBackColor = true;
            this.BojaButton.Click += new System.EventHandler(this.BojaButton_Click);
            this.BojaButton.Validating += new System.ComponentModel.CancelEventHandler(this.BojaButton_Validating);
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(13, 104);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(63, 13);
            this.OpisLabel.TabIndex = 72;
            this.OpisLabel.Text = "Opis etikete";
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(13, 68);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(63, 13);
            this.ImeLabel.TabIndex = 71;
            this.ImeLabel.Text = "Boja etikete";
            // 
            // SifraLabel
            // 
            this.SifraLabel.AutoSize = true;
            this.SifraLabel.Location = new System.Drawing.Point(13, 33);
            this.SifraLabel.Name = "SifraLabel";
            this.SifraLabel.Size = new System.Drawing.Size(63, 13);
            this.SifraLabel.TabIndex = 70;
            this.SifraLabel.Text = "Sifra etikete";
            // 
            // opisEiketeTextBox
            // 
            this.opisEiketeTextBox.Location = new System.Drawing.Point(82, 101);
            this.opisEiketeTextBox.Multiline = true;
            this.opisEiketeTextBox.Name = "opisEiketeTextBox";
            this.opisEiketeTextBox.Size = new System.Drawing.Size(139, 48);
            this.opisEiketeTextBox.TabIndex = 3;
            this.opisEiketeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.opisEiketeTextBox_Validating);
            // 
            // sifraEtiketeTextBox
            // 
            this.sifraEtiketeTextBox.Location = new System.Drawing.Point(82, 30);
            this.sifraEtiketeTextBox.Name = "sifraEtiketeTextBox";
            this.sifraEtiketeTextBox.Size = new System.Drawing.Size(139, 20);
            this.sifraEtiketeTextBox.TabIndex = 1;
            this.sifraEtiketeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // dodajEtiketuButton
            // 
            this.dodajEtiketuButton.Location = new System.Drawing.Point(82, 164);
            this.dodajEtiketuButton.Name = "dodajEtiketuButton";
            this.dodajEtiketuButton.Size = new System.Drawing.Size(86, 32);
            this.dodajEtiketuButton.TabIndex = 4;
            this.dodajEtiketuButton.Text = "Unesi";
            this.dodajEtiketuButton.UseVisualStyleBackColor = true;
            this.dodajEtiketuButton.Click += new System.EventHandler(this.DodajEtiketuButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolstripItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 129;
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // UnosEtiketaSpomenikaFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 205);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dodajEtiketuButton);
            this.Controls.Add(this.BojaButton);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.SifraLabel);
            this.Controls.Add(this.opisEiketeTextBox);
            this.Controls.Add(this.sifraEtiketeTextBox);
            this.Name = "UnosEtiketaSpomenikaFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiketa spomenika";
            this.Load += new System.EventHandler(this.EtiketaSpomenikaFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BojaButton;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.Label SifraLabel;
        private System.Windows.Forms.TextBox opisEiketeTextBox;
        private System.Windows.Forms.TextBox sifraEtiketeTextBox;
        private System.Windows.Forms.Button dodajEtiketuButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolstripItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}