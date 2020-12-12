using System;
using System.Data;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class ManageAccountsForm : BrandingParentForm
    {
        Customer currentCustomer;

        public ManageAccountsForm(Customer c)
        {
            InitializeComponent();

            this.welcomeLabel.Text = String.Format("Welcome, {0}!", c.Name);
            currentCustomer = c;

            foreach (Account account in currentCustomer.AccountList)
            {
                accountListBox.Items.Add(account.getAccountType().ToString() + " #" + account.getAccountID().ToString());
            }
            //customer initialisation
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            AddAccountForm addaccform = new AddAccountForm(currentCustomer);
            addaccform.ShowDialog(); // ShowDialog used to prevent selecting main form until this form completed
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            //this.Hide();

            // Hack used to allow Selected Item to be cast as the correct account type
            if (accountListBox.SelectedItem.ToString() == "Everyday")
            {
                Everyday selectedAccount = accountListBox.SelectedItem as Everyday;
                AccountForm accform = new AccountForm(selectedAccount);
                accform.ShowDialog();
            }

            //if (accountListBox.SelectedItem.ToString() == "Investment")
            //{
            //    Investment selectedAccount = accountListBox.SelectedItem as Investment;
            //    AccountForm accform = new AccountForm(selectedAccount);
            //    accform.ShowDialog();
            //}

            //if (accountListBox.SelectedItem.ToString() == "Omni")
            //{
            //    Omni selectedAccount = accountListBox.SelectedItem as Omni;
            //    AccountForm accform = new AccountForm(selectedAccount);
            //    accform.ShowDialog();
            //}

            //else 
            //{
            //    MessageBox.Show("Error");
            //}
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            CRUDCustomerForm Form1 = new CRUDCustomerForm();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }

        private void accountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageButton.Enabled = true;

            if (accountListBox.SelectedIndex == -1)
            {
                manageButton.Enabled = false;
            }
        }

        private void ReInitialize (object sender, EventArgs e)
        {
            ManageAccountsForm RefreshedForm = new ManageAccountsForm(currentCustomer);
            this.Hide();
            RefreshedForm.ShowDialog();
            this.Close();
        }
            
    }
}
