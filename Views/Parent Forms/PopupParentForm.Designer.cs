
namespace Assessment3
{
    partial class PopupParentForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.blackTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(38, 24);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(100, 34, 34, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(350, 37);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "PLACEHOLDER TITLE";
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
            this.blackTextBox.Size = new System.Drawing.Size(800, 80);
            this.blackTextBox.TabIndex = 17;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 3;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cancelButton.Location = new System.Drawing.Point(486, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(270, 60);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            // 
            // PopupParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.blackTextBox);
            this.Name = "PopupParentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox blackTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}