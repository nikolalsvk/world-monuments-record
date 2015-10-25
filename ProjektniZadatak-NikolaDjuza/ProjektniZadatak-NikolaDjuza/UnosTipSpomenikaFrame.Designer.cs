namespace ProjektniZadatak_NikolaDjuza
{
    partial class UnosTipSpomenikaFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosTipSpomenikaFrame));
            this.SifraTipaTextBox = new System.Windows.Forms.TextBox();
            this.ImeTipaTextBox = new System.Windows.Forms.TextBox();
            this.OpisTipaTextBox = new System.Windows.Forms.TextBox();
            this.ImeTipaLabel = new System.Windows.Forms.Label();
            this.OpisTipaLabel = new System.Windows.Forms.Label();
            this.SifraTipaLabel = new System.Windows.Forms.Label();
            this.dodajTipButton = new System.Windows.Forms.Button();
            this.SlikaSpomenikaBox = new System.Windows.Forms.PictureBox();
            this.removePicButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolstripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SlikaSpomenikaBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SifraTipaTextBox
            // 
            this.SifraTipaTextBox.Location = new System.Drawing.Point(70, 209);
            this.SifraTipaTextBox.Name = "SifraTipaTextBox";
            this.SifraTipaTextBox.Size = new System.Drawing.Size(154, 20);
            this.SifraTipaTextBox.TabIndex = 46;
            this.SifraTipaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // ImeTipaTextBox
            // 
            this.ImeTipaTextBox.Location = new System.Drawing.Point(70, 244);
            this.ImeTipaTextBox.Name = "ImeTipaTextBox";
            this.ImeTipaTextBox.Size = new System.Drawing.Size(154, 20);
            this.ImeTipaTextBox.TabIndex = 45;
            this.ImeTipaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // OpisTipaTextBox
            // 
            this.OpisTipaTextBox.Location = new System.Drawing.Point(70, 279);
            this.OpisTipaTextBox.Multiline = true;
            this.OpisTipaTextBox.Name = "OpisTipaTextBox";
            this.OpisTipaTextBox.Size = new System.Drawing.Size(154, 40);
            this.OpisTipaTextBox.TabIndex = 3;
            this.OpisTipaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // ImeTipaLabel
            // 
            this.ImeTipaLabel.AutoSize = true;
            this.ImeTipaLabel.Location = new System.Drawing.Point(16, 247);
            this.ImeTipaLabel.Name = "ImeTipaLabel";
            this.ImeTipaLabel.Size = new System.Drawing.Size(44, 13);
            this.ImeTipaLabel.TabIndex = 43;
            this.ImeTipaLabel.Text = "Ime tipa";
            // 
            // OpisTipaLabel
            // 
            this.OpisTipaLabel.AutoSize = true;
            this.OpisTipaLabel.Location = new System.Drawing.Point(16, 282);
            this.OpisTipaLabel.Name = "OpisTipaLabel";
            this.OpisTipaLabel.Size = new System.Drawing.Size(48, 13);
            this.OpisTipaLabel.TabIndex = 42;
            this.OpisTipaLabel.Text = "Opis tipa";
            // 
            // SifraTipaLabel
            // 
            this.SifraTipaLabel.AutoSize = true;
            this.SifraTipaLabel.Location = new System.Drawing.Point(12, 212);
            this.SifraTipaLabel.Name = "SifraTipaLabel";
            this.SifraTipaLabel.Size = new System.Drawing.Size(48, 13);
            this.SifraTipaLabel.TabIndex = 41;
            this.SifraTipaLabel.Text = "Sifra tipa";
            // 
            // dodajTipButton
            // 
            this.dodajTipButton.Location = new System.Drawing.Point(93, 335);
            this.dodajTipButton.Name = "dodajTipButton";
            this.dodajTipButton.Size = new System.Drawing.Size(75, 32);
            this.dodajTipButton.TabIndex = 5;
            this.dodajTipButton.Text = "Unesi";
            this.dodajTipButton.UseVisualStyleBackColor = true;
            this.dodajTipButton.Click += new System.EventHandler(this.dodajTipButton_Click);
            // 
            // SlikaSpomenikaBox
            // 
            this.SlikaSpomenikaBox.BackColor = System.Drawing.SystemColors.Control;
            this.SlikaSpomenikaBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlikaSpomenikaBox.Image = global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default;
            this.SlikaSpomenikaBox.InitialImage = global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default;
            this.SlikaSpomenikaBox.Location = new System.Drawing.Point(70, 33);
            this.SlikaSpomenikaBox.Name = "SlikaSpomenikaBox";
            this.SlikaSpomenikaBox.Size = new System.Drawing.Size(128, 120);
            this.SlikaSpomenikaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlikaSpomenikaBox.TabIndex = 52;
            this.SlikaSpomenikaBox.TabStop = false;
            this.SlikaSpomenikaBox.Click += new System.EventHandler(this.SlikaSpomenikaBox_Click);
            this.SlikaSpomenikaBox.MouseHover += new System.EventHandler(this.SlikaSpomenikaBox_MouseHover);
            // 
            // removePicButton
            // 
            this.removePicButton.Location = new System.Drawing.Point(70, 159);
            this.removePicButton.Name = "removePicButton";
            this.removePicButton.Size = new System.Drawing.Size(75, 32);
            this.removePicButton.TabIndex = 53;
            this.removePicButton.Text = "Obrisite sliku";
            this.removePicButton.UseVisualStyleBackColor = true;
            this.removePicButton.Click += new System.EventHandler(this.removePicButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(151, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SlikaSpomenikaBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolstripItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(245, 24);
            this.menuStrip1.TabIndex = 130;
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
            // UnosTipSpomenikaFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 375);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removePicButton);
            this.Controls.Add(this.SlikaSpomenikaBox);
            this.Controls.Add(this.dodajTipButton);
            this.Controls.Add(this.SifraTipaTextBox);
            this.Controls.Add(this.ImeTipaTextBox);
            this.Controls.Add(this.OpisTipaTextBox);
            this.Controls.Add(this.ImeTipaLabel);
            this.Controls.Add(this.OpisTipaLabel);
            this.Controls.Add(this.SifraTipaLabel);
            this.Name = "UnosTipSpomenikaFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos tipa";
            this.Load += new System.EventHandler(this.TipSpomenikaFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SlikaSpomenikaBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SifraTipaTextBox;
        private System.Windows.Forms.TextBox ImeTipaTextBox;
        private System.Windows.Forms.TextBox OpisTipaTextBox;
        private System.Windows.Forms.Label ImeTipaLabel;
        private System.Windows.Forms.Label OpisTipaLabel;
        private System.Windows.Forms.Label SifraTipaLabel;
        private System.Windows.Forms.Button dodajTipButton;
        private System.Windows.Forms.PictureBox SlikaSpomenikaBox;
        private System.Windows.Forms.Button removePicButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolstripItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}