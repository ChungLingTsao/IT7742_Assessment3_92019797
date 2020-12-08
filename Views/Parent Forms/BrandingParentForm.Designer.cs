namespace Assessment3
{
    partial class BrandingParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandingParentForm));
            this.blackTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blackTextBox
            // 
            this.blackTextBox.BackColor = System.Drawing.Color.Black;
            this.blackTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blackTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.blackTextBox.Enabled = false;
            this.blackTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackTextBox.ForeColor = System.Drawing.Color.White;
            this.blackTextBox.Location = new System.Drawing.Point(0, 0);
            this.blackTextBox.Multiline = true;
            this.blackTextBox.Name = "blackTextBox";
            this.blackTextBox.ReadOnly = true;
            this.blackTextBox.Size = new System.Drawing.Size(1260, 140);
            this.blackTextBox.TabIndex = 11;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(981, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(180, 180);
            this.logoPictureBox.TabIndex = 15;
            this.logoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(109, 43);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(100, 34, 34, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(526, 55);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "PLACEHOLDER TITLE";
            // 
            // BrandingParentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.blackTextBox);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "BrandingParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox blackTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        public System.Windows.Forms.Label titleLabel;
    }
}

