
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
            this.addinterestButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addinterestButton
            // 
            this.addinterestButton.FlatAppearance.BorderSize = 3;
            this.addinterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addinterestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addinterestButton.Location = new System.Drawing.Point(45, 163);
            this.addinterestButton.Name = "addinterestButton";
            this.addinterestButton.Size = new System.Drawing.Size(210, 160);
            this.addinterestButton.TabIndex = 33;
            this.addinterestButton.Text = "Everyday";
            this.addinterestButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(546, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 160);
            this.button1.TabIndex = 34;
            this.button1.Text = "Omni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button2.Location = new System.Drawing.Point(294, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 160);
            this.button2.TabIndex = 35;
            this.button2.Text = "Investment";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addinterestButton);
            this.Name = "AddAccountForm";
            this.Controls.SetChildIndex(this.addinterestButton, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addinterestButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
