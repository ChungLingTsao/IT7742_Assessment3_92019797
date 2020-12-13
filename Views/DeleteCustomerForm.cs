using System;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class DeleteCustomerForm : Assessment3.CUDCustomerParentForm
    {
        public DeleteCustomerForm(Customer customer)
        {
            InitializeComponent();
            this.titleLabel.Text = "DELETE CUSTOMER";
            this.button3.Text = "Delete Customer";
            this.idTextBox.Text = customer.CustomerNumber.ToString();
            this.nameTextBox.Text = customer.Name;
            this.phoneTextBox.Text = customer.Phone;
            this.emailTextBox.Text = customer.Email;
            this.addressTextBox.Text = customer.Address;
            this.suburbTextBox.Text = customer.Suburb;
            this.cityTextBox.Text = customer.City;
            this.zipTextBox.Text = customer.Zip;
            this.staffCheckBox.Checked = customer.IsStaff;

            this.nameTextBox.Enabled = false;
            this.idTextBox.Enabled = false;
            this.phoneTextBox.Enabled = false;
            this.emailTextBox.Enabled = false;
            this.addressTextBox.Enabled = false;
            this.suburbTextBox.Enabled = false;
            this.cityTextBox.Enabled = false;
            this.zipTextBox.Enabled = false;
            this.staffCheckBox.Enabled = false;
        }

        // Allows user to delete a customer
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete " + nameTextBox.Text + " from the system? ", "CAUTION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                controller.DeleteCustomer(Convert.ToInt32(this.idTextBox.Text));

                this.Hide();
                this.Close();
                CRUDCustomerForm FormCRUDCust = new CRUDCustomerForm();
                FormCRUDCust.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Nothing
            }
        }
    }
}
