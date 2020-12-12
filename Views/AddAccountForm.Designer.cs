
namespace Assessment3
{
    partial class AddAccountForm
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
            this.everydayButton = new System.Windows.Forms.Button();
            this.omniButton = new System.Windows.Forms.Button();
            this.investmentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // everydayButton
            // 
            this.everydayButton.FlatAppearance.BorderSize = 3;
            this.everydayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.everydayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.everydayButton.Location = new System.Drawing.Point(45, 163);
            this.everydayButton.Name = "everydayButton";
            this.everydayButton.Size = new System.Drawing.Size(210, 160);
            this.everydayButton.TabIndex = 33;
            this.everydayButton.Text = "Everyday";
            this.everydayButton.UseVisualStyleBackColor = true;
            this.everydayButton.Click += new System.EventHandler(this.everydayButton_Click);
            // 
            // omniButton
            // 
            this.omniButton.FlatAppearance.BorderSize = 3;
            this.omniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.omniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.omniButton.Location = new System.Drawing.Point(546, 163);
            this.omniButton.Name = "omniButton";
            this.omniButton.Size = new System.Drawing.Size(210, 160);
            this.omniButton.TabIndex = 34;
            this.omniButton.Text = "Omni";
            this.omniButton.UseVisualStyleBackColor = true;
            this.omniButton.Click += new System.EventHandler(this.omniButton_Click);
            // 
            // investmentButton
            // 
            this.investmentButton.FlatAppearance.BorderSize = 3;
            this.investmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.investmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.investmentButton.Location = new System.Drawing.Point(294, 163);
            this.investmentButton.Name = "investmentButton";
            this.investmentButton.Size = new System.Drawing.Size(210, 160);
            this.investmentButton.TabIndex = 35;
            this.investmentButton.Text = "Investment";
            this.investmentButton.UseVisualStyleBackColor = true;
            this.investmentButton.Click += new System.EventHandler(this.investmentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Choose an account to add";
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.omniButton);
            this.Controls.Add(this.investmentButton);
            this.Controls.Add(this.everydayButton);
            this.Name = "AddAccountForm";
            this.Controls.SetChildIndex(this.everydayButton, 0);
            this.Controls.SetChildIndex(this.investmentButton, 0);
            this.Controls.SetChildIndex(this.omniButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button everydayButton;
        private System.Windows.Forms.Button omniButton;
        private System.Windows.Forms.Button investmentButton;
        private System.Windows.Forms.Label label1;
    }
}
