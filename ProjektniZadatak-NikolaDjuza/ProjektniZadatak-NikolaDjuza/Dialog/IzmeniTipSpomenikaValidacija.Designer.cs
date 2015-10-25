namespace ProjektniZadatak_NikolaDjuza.Dialog
{
    partial class IzmeniTipSpomenikaValidacija
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelMyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(218, 145);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(87, 32);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelMyButton
            // 
            this.CancelMyButton.Location = new System.Drawing.Point(12, 145);
            this.CancelMyButton.Name = "CancelMyButton";
            this.CancelMyButton.Size = new System.Drawing.Size(93, 32);
            this.CancelMyButton.TabIndex = 4;
            this.CancelMyButton.Text = "Cancel";
            this.CancelMyButton.UseVisualStyleBackColor = true;
            this.CancelMyButton.Click += new System.EventHandler(this.CancelMyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Da li zelite da izmenite tip?";
            // 
            // IzmeniTipSpomenikaValidacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelMyButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IzmeniTipSpomenikaValidacija";
            this.Text = "IzmeniTipSpomenikaValidacija";
            this.Load += new System.EventHandler(this.IzmeniTipSpomenikaValidacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelMyButton;
        private System.Windows.Forms.Label label1;
    }
}