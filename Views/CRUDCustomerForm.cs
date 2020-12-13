using System;
using System.Collections.Generic;

namespace Assessment3
{
    public partial class CRUDCustomerForm : BrandingParentForm
    {
        public CRUDCustomerForm()
        {
            InitializeComponent();
        }

        //Refreshes the customer listbox
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

        //Functionality to search for a customer
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

        //Functionality to clear the search bar
        private void button1_Click_1(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        // Navigate to the add customer page
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm FormAddCust = new AddCustomerForm();
            FormAddCust.ShowDialog();
        }

        // Navigate to the edit customer page
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = customerListBox.SelectedItem as Customer;
            EditCustomerForm FormEditCust = new EditCustomerForm(c);
            FormEditCust.ShowDialog();
        }

        // Navigate to the delete customer page
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = customerListBox.SelectedItem as Customer;
            DeleteCustomerForm FormDeleteCust = new DeleteCustomerForm(c);
            FormDeleteCust.ShowDialog();
        }

        //Function that disable/enable buttons based on if a customer is selected
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            manageButton.Enabled = true;

            if (customerListBox.SelectedIndex == -1) // -1 means not selected
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                manageButton.Enabled = false;
            }
        }

        // Navigate to the manage account page
        private void manageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = customerListBox.SelectedItem as Customer;
            ManageAccountsForm ManAccForm = new ManageAccountsForm(customer);
            ManAccForm.ShowDialog();
        }
    }
}
