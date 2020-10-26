using System;
using System.Collections.Generic;

namespace Assessment2
{
    public partial class CRUDCustomerForm : BrandingParentForm
    {
        AddCustomerForm FormAddCust = new AddCustomerForm();

        public CRUDCustomerForm()
        {
            InitializeComponent();
        }

        private void UpdateCustomerList(string selectedName)
        {
            customerListBox.Items.Clear();

            List<Customer> customerRepository = CustomerRepository.getInstance().GetAllCustomers();

            foreach (Customer customer in customerRepository)
            {
                if (customer.Name.Contains(selectedName))
                {
                    customerListBox.Items.Add(customer);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                UpdateCustomerList(searchTextBox.Text);
            }
            else
            {
                customerListBox.SelectedIndex = -1; // Reset the index. Nothing is selected.
                customerListBox.Items.Clear(); // In case user starts typing and then clears textbox
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            FormAddCust.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = customerListBox.SelectedItem as Customer;

            EditCustomerForm FormEditCust = new EditCustomerForm(c);
            FormEditCust.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = customerListBox.SelectedItem as Customer;

            DeleteCustomerForm FormDeleteCust = new DeleteCustomerForm(c);
            FormDeleteCust.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            deleteButton.Enabled = true;

            if (customerListBox.SelectedIndex == -1)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }
    }
}
