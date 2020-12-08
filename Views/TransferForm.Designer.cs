
namespace IT7742_Assessment2_92019797.Views
{
    partial class TransferForm
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
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabeverydayinputTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountListBox
            // 
            this.accountListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.ItemHeight = 24;
            this.accountListBox.Location = new System.Drawing.Point(43, 154);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(411, 172);
            this.accountListBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Choose an account to transfer to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Enter an amount ($):";
            // 
            // tabeverydayinputTextBox
            // 
            this.tabeverydayinputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabeverydayinputTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabeverydayinputTextBox.Location = new System.Drawing.Point(486, 188);
            this.tabeverydayinputTextBox.Name = "tabeverydayinputTextBox";
            this.tabeverydayinputTextBox.Size = new System.Drawing.Size(270, 31);
            this.tabeverydayinputTextBox.TabIndex = 39;
            // 
            // depositButton
            // 
            this.depositButton.FlatAppearance.BorderSize = 3;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.depositButton.Location = new System.Drawing.Point(486, 266);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(270, 60);
            this.depositButton.TabIndex = 41;
            this.depositButton.Text = "Transfer";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabeverydayinputTextBox);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountListBox);
            this.Name = "TransferForm";
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.accountListBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.depositButton, 0);
            this.Controls.SetChildIndex(this.tabeverydayinputTextBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox accountListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tabeverydayinputTextBox;
        private System.Windows.Forms.Button depositButton;
    }
}
