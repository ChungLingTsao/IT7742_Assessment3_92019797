﻿using System;
using System.Windows.Forms;

namespace Assessment2
{
    public partial class EditCustomerForm : Assessment2.CUDCustomerParentForm
    {
        public EditCustomerForm(Customer customer)
        {
            InitializeComponent();
            this.titleLabel.Text = "EDIT CUSTOMER";
            this.button3.Text = "Edit Customer";
            this.idTextBox.Text = customer.CustomerNumber.ToString();
            this.nameTextBox.Text = customer.Name;
            this.phoneTextBox.Text = customer.Phone;
            this.emailTextBox.Text = customer.Email;
            this.addressTextBox.Text = customer.Address;
            this.suburbTextBox.Text = customer.Suburb;
            this.cityTextBox.Text = customer.City;
            this.zipTextBox.Text = customer.Zip;
            this.staffCheckBox.Checked = customer.IsStaff;

            this.idTextBox.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
                this.zipTextBox.Text != ""
                )
            {
                control.EditCustomer(
                (int)long.Parse(this.idTextBox.Text),
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
                MessageBox.Show("Please fill all fields!", "WARNING");
            }
        }
    }
}