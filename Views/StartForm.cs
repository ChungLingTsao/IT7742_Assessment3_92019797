﻿using System;

namespace Assessment3
{
    public partial class StartForm : BrandingParentForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        // Navigates to the Customer Management Form
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CRUDCustomerForm crudCustomerForm = new CRUDCustomerForm();
            crudCustomerForm.ShowDialog();
            this.Close();
        }
    }
}
