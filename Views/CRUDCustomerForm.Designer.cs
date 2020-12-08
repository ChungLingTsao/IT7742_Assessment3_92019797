namespace Assessment3
{
    partial class CRUDCustomerForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Size = new System.Drawing.Size(552, 55);
            this.titleLabel.Text = "MANAGE CUSTOMERS";
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderSize = 3;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addButton.Location = new System.Drawing.Point(891, 255);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(270, 100);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Customer";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.FlatAppearance.BorderSize = 3;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.editButton.Location = new System.Drawing.Point(891, 386);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(270, 100);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit Selected Customer";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatAppearance.BorderSize = 3;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.deleteButton.Location = new System.Drawing.Point(891, 519);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(270, 100);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete Selected Customer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 24;
            this.customerListBox.Location = new System.Drawing.Point(119, 255);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(704, 364);
            this.customerListBox.TabIndex = 18;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(119, 209);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(560, 38);
            this.searchTextBox.TabIndex = 19;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(115, 176);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(274, 20);
            this.instructionLabel.TabIndex = 20;
            this.instructionLabel.Text = "Type to begin searching for customer:";
            // 
            // clearButton
            // 
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.clearButton.Location = new System.Drawing.Point(685, 209);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(138, 38);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CRUDCustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Name = "CRUDCustomerForm";
            this.Text = "CRUDCustomerForm";
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.editButton, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            this.Controls.SetChildIndex(this.customerListBox, 0);
            this.Controls.SetChildIndex(this.searchTextBox, 0);
            this.Controls.SetChildIndex(this.instructionLabel, 0);
            this.Controls.SetChildIndex(this.clearButton, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button clearButton;
    }
}