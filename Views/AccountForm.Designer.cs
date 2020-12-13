
namespace Assessment3
{
    partial class AccountForm
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
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moneyInputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.interestLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addinterestButton = new System.Windows.Forms.Button();
            this.calculateinterestButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountinfoButton = new System.Windows.Forms.Button();
            this.switchaccountButton = new System.Windows.Forms.Button();
            this.transactionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountIDLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.accountIDLabel.Location = new System.Drawing.Point(236, 249);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(116, 25);
            this.accountIDLabel.TabIndex = 28;
            this.accountIDLabel.Text = "Account ID";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(112, 318);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(120, 33);
            this.balanceLabel.TabIndex = 26;
            this.balanceLabel.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(115, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Enter an amount ($):";
            // 
            // moneyInputTextBox
            // 
            this.moneyInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyInputTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.moneyInputTextBox.Location = new System.Drawing.Point(30, 60);
            this.moneyInputTextBox.Name = "moneyInputTextBox";
            this.moneyInputTextBox.Size = new System.Drawing.Size(270, 31);
            this.moneyInputTextBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.interestLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.addinterestButton);
            this.groupBox3.Controls.Add(this.calculateinterestButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(834, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 265);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interest";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLabel.Location = new System.Drawing.Point(202, 54);
            this.interestLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(108, 37);
            this.interestLabel.TabIndex = 40;
            this.interestLabel.Text = "0.00%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Current Interest Rate is:";
            // 
            // addinterestButton
            // 
            this.addinterestButton.FlatAppearance.BorderSize = 3;
            this.addinterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addinterestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addinterestButton.Location = new System.Drawing.Point(29, 181);
            this.addinterestButton.Name = "addinterestButton";
            this.addinterestButton.Size = new System.Drawing.Size(270, 60);
            this.addinterestButton.TabIndex = 32;
            this.addinterestButton.Text = "Add Interest";
            this.addinterestButton.UseVisualStyleBackColor = true;
            this.addinterestButton.Click += new System.EventHandler(this.addinterestButton_Click);
            // 
            // calculateinterestButton
            // 
            this.calculateinterestButton.FlatAppearance.BorderSize = 3;
            this.calculateinterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateinterestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.calculateinterestButton.Location = new System.Drawing.Point(29, 109);
            this.calculateinterestButton.Name = "calculateinterestButton";
            this.calculateinterestButton.Size = new System.Drawing.Size(270, 60);
            this.calculateinterestButton.TabIndex = 33;
            this.calculateinterestButton.Text = "Calculate Interest";
            this.calculateinterestButton.UseVisualStyleBackColor = true;
            this.calculateinterestButton.Click += new System.EventHandler(this.calculateinterestButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.moneyInputTextBox);
            this.groupBox2.Controls.Add(this.depositButton);
            this.groupBox2.Controls.Add(this.withdrawButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(482, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 265);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Withdraw/Deposit";
            // 
            // depositButton
            // 
            this.depositButton.FlatAppearance.BorderSize = 3;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.depositButton.Location = new System.Drawing.Point(30, 109);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(270, 60);
            this.depositButton.TabIndex = 35;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.FlatAppearance.BorderSize = 3;
            this.withdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.withdrawButton.Location = new System.Drawing.Point(30, 181);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(270, 60);
            this.withdrawButton.TabIndex = 34;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.accountTypeLabel.Location = new System.Drawing.Point(112, 195);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(229, 39);
            this.accountTypeLabel.TabIndex = 27;
            this.accountTypeLabel.Text = "Account Type";
            // 
            // accountinfoButton
            // 
            this.accountinfoButton.FlatAppearance.BorderSize = 3;
            this.accountinfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountinfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.accountinfoButton.Location = new System.Drawing.Point(119, 415);
            this.accountinfoButton.Name = "accountinfoButton";
            this.accountinfoButton.Size = new System.Drawing.Size(270, 60);
            this.accountinfoButton.TabIndex = 36;
            this.accountinfoButton.Text = "Account Info (?)";
            this.accountinfoButton.UseVisualStyleBackColor = true;
            this.accountinfoButton.Click += new System.EventHandler(this.accountinfoButton_Click);
            // 
            // switchaccountButton
            // 
            this.switchaccountButton.FlatAppearance.BorderSize = 3;
            this.switchaccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchaccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.switchaccountButton.Location = new System.Drawing.Point(119, 560);
            this.switchaccountButton.Name = "switchaccountButton";
            this.switchaccountButton.Size = new System.Drawing.Size(270, 60);
            this.switchaccountButton.TabIndex = 37;
            this.switchaccountButton.Text = "Switch Account";
            this.switchaccountButton.UseVisualStyleBackColor = true;
            this.switchaccountButton.Click += new System.EventHandler(this.switchaccountButton_Click);
            // 
            // transactionListBox
            // 
            this.transactionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionListBox.FormattingEnabled = true;
            this.transactionListBox.Location = new System.Drawing.Point(482, 499);
            this.transactionListBox.Name = "transactionListBox";
            this.transactionListBox.Size = new System.Drawing.Size(679, 121);
            this.transactionListBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Transaction History";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(119, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 60);
            this.button1.TabIndex = 40;
            this.button1.Text = "Transfer from here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(114, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Account ID:";
            // 
            // AccountForm
            // 
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transactionListBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.switchaccountButton);
            this.Controls.Add(this.accountinfoButton);
            this.Controls.Add(this.accountIDLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.accountTypeLabel);
            this.Name = "AccountForm";
            this.Controls.SetChildIndex(this.accountTypeLabel, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.balanceLabel, 0);
            this.Controls.SetChildIndex(this.accountIDLabel, 0);
            this.Controls.SetChildIndex(this.accountinfoButton, 0);
            this.Controls.SetChildIndex(this.switchaccountButton, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.transactionListBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox moneyInputTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addinterestButton;
        private System.Windows.Forms.Button calculateinterestButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button accountinfoButton;
        private System.Windows.Forms.Button switchaccountButton;
        private System.Windows.Forms.ListBox transactionListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}
