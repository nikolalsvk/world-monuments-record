namespace ProjektniZadatak_NikolaDjuza
{
    partial class PrikazTipSpomenikaFrame
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
            this.izaberiTipButton = new System.Windows.Forms.Button();
            this.postojeciTipoviGridView = new System.Windows.Forms.DataGridView();
            this.SlikaSpomenikaBox = new System.Windows.Forms.PictureBox();
            this.SifraTipaTextBox = new System.Windows.Forms.TextBox();
            this.ImeTipaTextBox = new System.Windows.Forms.TextBox();
            this.OpisTipaTextBox = new System.Windows.Forms.TextBox();
            this.ImeTipaLabel = new System.Windows.Forms.Label();
            this.OpisTipaLabel = new System.Windows.Forms.Label();
            this.SifraTipaLabel = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.IzmeniSpomenikButton = new System.Windows.Forms.Button();
            this.izbrisiButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolstripItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.postojeciTipoviGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaSpomenikaBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izaberiTipButton
            // 
            this.izaberiTipButton.Location = new System.Drawing.Point(255, 328);
            this.izaberiTipButton.Name = "izaberiTipButton";
            this.izaberiTipButton.Size = new System.Drawing.Size(112, 32);
            this.izaberiTipButton.TabIndex = 64;
            this.izaberiTipButton.Text = "Izaberi tip";
            this.izaberiTipButton.UseVisualStyleBackColor = true;
            this.izaberiTipButton.Click += new System.EventHandler(this.izaberiTipButton_Click);
            // 
            // postojeciTipoviGridView
            // 
            this.postojeciTipoviGridView.AllowUserToAddRows = false;
            this.postojeciTipoviGridView.AllowUserToDeleteRows = false;
            this.postojeciTipoviGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postojeciTipoviGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postojeciTipoviGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.postojeciTipoviGridView.Location = new System.Drawing.Point(12, 33);
            this.postojeciTipoviGridView.MultiSelect = false;
            this.postojeciTipoviGridView.Name = "postojeciTipoviGridView";
            this.postojeciTipoviGridView.ReadOnly = true;
            this.postojeciTipoviGridView.RowHeadersVisible = false;
            this.postojeciTipoviGridView.RowHeadersWidth = 100;
            this.postojeciTipoviGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.postojeciTipoviGridView.Size = new System.Drawing.Size(355, 164);
            this.postojeciTipoviGridView.TabIndex = 60;
            this.postojeciTipoviGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.postojeciTipoviGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.postojeciTipoviGridView_CellDoubleClick);
            // 
            // SlikaSpomenikaBox
            // 
            this.SlikaSpomenikaBox.BackColor = System.Drawing.SystemColors.Control;
            this.SlikaSpomenikaBox.Image = global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default;
            this.SlikaSpomenikaBox.InitialImage = global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default;
            this.SlikaSpomenikaBox.Location = new System.Drawing.Point(83, 206);
            this.SlikaSpomenikaBox.Name = "SlikaSpomenikaBox";
            this.SlikaSpomenikaBox.Size = new System.Drawing.Size(128, 120);
            this.SlikaSpomenikaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlikaSpomenikaBox.TabIndex = 73;
            this.SlikaSpomenikaBox.TabStop = false;
            // 
            // SifraTipaTextBox
            // 
            this.SifraTipaTextBox.Enabled = false;
            this.SifraTipaTextBox.Location = new System.Drawing.Point(70, 332);
            this.SifraTipaTextBox.Name = "SifraTipaTextBox";
            this.SifraTipaTextBox.Size = new System.Drawing.Size(154, 20);
            this.SifraTipaTextBox.TabIndex = 72;
            // 
            // ImeTipaTextBox
            // 
            this.ImeTipaTextBox.Enabled = false;
            this.ImeTipaTextBox.Location = new System.Drawing.Point(70, 367);
            this.ImeTipaTextBox.Name = "ImeTipaTextBox";
            this.ImeTipaTextBox.Size = new System.Drawing.Size(154, 20);
            this.ImeTipaTextBox.TabIndex = 71;
            // 
            // OpisTipaTextBox
            // 
            this.OpisTipaTextBox.Enabled = false;
            this.OpisTipaTextBox.Location = new System.Drawing.Point(70, 402);
            this.OpisTipaTextBox.Multiline = true;
            this.OpisTipaTextBox.Name = "OpisTipaTextBox";
            this.OpisTipaTextBox.Size = new System.Drawing.Size(154, 40);
            this.OpisTipaTextBox.TabIndex = 70;
            // 
            // ImeTipaLabel
            // 
            this.ImeTipaLabel.AutoSize = true;
            this.ImeTipaLabel.Location = new System.Drawing.Point(16, 370);
            this.ImeTipaLabel.Name = "ImeTipaLabel";
            this.ImeTipaLabel.Size = new System.Drawing.Size(44, 13);
            this.ImeTipaLabel.TabIndex = 69;
            this.ImeTipaLabel.Text = "Ime tipa";
            // 
            // OpisTipaLabel
            // 
            this.OpisTipaLabel.AutoSize = true;
            this.OpisTipaLabel.Location = new System.Drawing.Point(16, 405);
            this.OpisTipaLabel.Name = "OpisTipaLabel";
            this.OpisTipaLabel.Size = new System.Drawing.Size(48, 13);
            this.OpisTipaLabel.TabIndex = 68;
            this.OpisTipaLabel.Text = "Opis tipa";
            // 
            // SifraTipaLabel
            // 
            this.SifraTipaLabel.AutoSize = true;
            this.SifraTipaLabel.Location = new System.Drawing.Point(12, 335);
            this.SifraTipaLabel.Name = "SifraTipaLabel";
            this.SifraTipaLabel.Size = new System.Drawing.Size(48, 13);
            this.SifraTipaLabel.TabIndex = 67;
            this.SifraTipaLabel.Text = "Sifra tipa";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(255, 290);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(112, 32);
            this.dodajButton.TabIndex = 123;
            this.dodajButton.Text = "Dodaj tip";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // IzmeniSpomenikButton
            // 
            this.IzmeniSpomenikButton.Location = new System.Drawing.Point(255, 214);
            this.IzmeniSpomenikButton.Name = "IzmeniSpomenikButton";
            this.IzmeniSpomenikButton.Size = new System.Drawing.Size(112, 32);
            this.IzmeniSpomenikButton.TabIndex = 121;
            this.IzmeniSpomenikButton.Text = "Izmeni tip";
            this.IzmeniSpomenikButton.UseVisualStyleBackColor = true;
            this.IzmeniSpomenikButton.Click += new System.EventHandler(this.IzmeniSpomenikButton_Click);
            // 
            // izbrisiButton
            // 
            this.izbrisiButton.Location = new System.Drawing.Point(255, 252);
            this.izbrisiButton.Name = "izbrisiButton";
            this.izbrisiButton.Size = new System.Drawing.Size(112, 32);
            this.izbrisiButton.TabIndex = 122;
            this.izbrisiButton.Text = "Izbriši tip";
            this.izbrisiButton.UseVisualStyleBackColor = true;
            this.izbrisiButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolstripItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 128;
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
            // PrikazTipSpomenikaFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 451);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.IzmeniSpomenikButton);
            this.Controls.Add(this.izbrisiButton);
            this.Controls.Add(this.SlikaSpomenikaBox);
            this.Controls.Add(this.SifraTipaTextBox);
            this.Controls.Add(this.ImeTipaTextBox);
            this.Controls.Add(this.OpisTipaTextBox);
            this.Controls.Add(this.ImeTipaLabel);
            this.Controls.Add(this.OpisTipaLabel);
            this.Controls.Add(this.SifraTipaLabel);
            this.Controls.Add(this.izaberiTipButton);
            this.Controls.Add(this.postojeciTipoviGridView);
            this.Name = "PrikazTipSpomenikaFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz svih tipova";
            this.Activated += new System.EventHandler(this.PrikazTipSpomenikaFrame_Activated);
            this.Load += new System.EventHandler(this.IzaberiTipSpomenikaFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postojeciTipoviGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaSpomenikaBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izaberiTipButton;
        private System.Windows.Forms.DataGridView postojeciTipoviGridView;
        private System.Windows.Forms.PictureBox SlikaSpomenikaBox;
        private System.Windows.Forms.TextBox SifraTipaTextBox;
        private System.Windows.Forms.TextBox ImeTipaTextBox;
        private System.Windows.Forms.TextBox OpisTipaTextBox;
        private System.Windows.Forms.Label ImeTipaLabel;
        private System.Windows.Forms.Label OpisTipaLabel;
        private System.Windows.Forms.Label SifraTipaLabel;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button IzmeniSpomenikButton;
        private System.Windows.Forms.Button izbrisiButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolstripItem;
    }
}