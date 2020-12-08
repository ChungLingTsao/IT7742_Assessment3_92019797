using System;

namespace Assessment3
{
    public partial class CUDCustomerParentForm : BrandingParentForm
    {
        public CUDCustomerParentForm()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (staffCheckBox.Checked)
            {
                staffCheckBox.BackgroundImage = Assessment3.Properties.Resources.toggleon1; 
                staffCheckBox.Padding = new System.Windows.Forms.Padding(2, 2, 30, 2);
                staffCheckBox.Text = "YES"; }
            else
            {
                staffCheckBox.BackgroundImage = Assessment3.Properties.Resources.toggleoff1;
                staffCheckBox.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
                staffCheckBox.Text = "NO";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            CRUDCustomerForm FormCRUDCust = new CRUDCustomerForm();
            FormCRUDCust.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
