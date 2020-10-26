using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assessment2
{
    public partial class AddCustomerForm : CUDCustomerParentForm
    {
        public AddCustomerForm()
        {
            InitializeComponent();
            this.titleLabel.Text = "ADD CUSTOMER";
            this.button3.Text = "Add Customer";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Regex to prevent letters from being accepted as Customer Number
            Regex regex = new Regex("^[0-9]*$");
            bool hasOnlyNumbers = regex.IsMatch(idTextBox.Text);

            // Some very light client-side validation
            if (this.titleLabel.Text != "" &&
                this.button3.Text != "" &&
                this.nameTextBox.Text != "" &&
                this.idTextBox.Text != "" &&
                this.phoneTextBox.Text != "" &&
                this.emailTextBox.Text != "" &&
                this.addressTextBox.Text != "" &&
                this.suburbTextBox.Text != "" &&
                this.cityTextBox.Text != "" &&
                this.zipTextBox.Text != "" &&
                hasOnlyNumbers == true
                )
            {
                control.AddCustomer(
                    Convert.ToInt32(this.idTextBox.Text), 
                    this.nameTextBox.Text, 
                    this.phoneTextBox.Text, 
                    this.emailTextBox.Text, 
                    this.addressTextBox.Text, 
                    this.suburbTextBox.Text, 
                    this.cityTextBox.Text, 
                    this.zipTextBox.Text, 
                    this.staffCheckBox.Checked
                );

                this.Hide();
                this.Close();
                CRUDCustomerForm FormCRUDCust = new CRUDCustomerForm();
                FormCRUDCust.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please fill all fields properly!\n(Customer Number must not contain letters)", "WARNING");
            }
        }
    }
}
