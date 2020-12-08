
namespace Assessment3
{
    partial class ManageAccountsForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.manageButton = new System.Windows.Forms.Button();
            this.addnewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(115, 176);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(366, 37);
            this.instructionLabel.TabIndex = 21;
            this.instructionLabel.Text = "Welcome, Placeholder!";
            // 
            // accountListBox
            // 
            this.accountListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.ItemHeight = 24;
            this.accountListBox.Location = new System.Drawing.Point(119, 279);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(706, 340);
            this.accountListBox.TabIndex = 26;
            // 
            // manageButton
            // 
            this.manageButton.Enabled = false;
            this.manageButton.FlatAppearance.BorderSize = 3;
            this.manageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.manageButton.Location = new System.Drawing.Point(891, 404);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(270, 90);
            this.manageButton.TabIndex = 24;
            this.manageButton.Text = "Manage Selected Account";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // addnewButton
            // 
            this.addnewButton.FlatAppearance.BorderSize = 3;
            this.addnewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addnewButton.Location = new System.Drawing.Point(891, 279);
            this.addnewButton.Name = "addnewButton";
            this.addnewButton.Size = new System.Drawing.Size(270, 90);
            this.addnewButton.TabIndex = 23;
            this.addnewButton.Text = "Add New Account";
            this.addnewButton.UseVisualStyleBackColor = true;
            this.addnewButton.Click += new System.EventHandler(this.addnewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Select an account";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(891, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 90);
            this.button1.TabIndex = 28;
            this.button1.Text = "Delete Selected Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageAccountsForm
            // 
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountListBox);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.addnewButton);
            this.Controls.Add(this.instructionLabel);
            this.Name = "ManageAccountsForm";
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.instructionLabel, 0);
            this.Controls.SetChildIndex(this.addnewButton, 0);
            this.Controls.SetChildIndex(this.manageButton, 0);
            this.Controls.SetChildIndex(this.accountListBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.ListBox accountListBox;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button addnewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
