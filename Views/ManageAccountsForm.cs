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
            this.titleLabel.Text = "MANAGE ACCOUNTS";
            currentCustomer = c;

            RefreshAccountList();
        }

        // Navigate to the add account form
        private void addnewButton_Click(object sender, EventArgs e)
        {
            AddAccountForm addaccform = new AddAccountForm(currentCustomer);
            addaccform.ShowDialog(); // ShowDialog used to prevent selecting main form until this form completed
        }

        //Opens AccountForm relative to what account has been selected in the accountListBox
        private void manageButton_Click(object sender, EventArgs e)
        {
            int f = accountListBox.SelectedIndex;

            // Hack used to allow Selected Item to be cast as the correct account type
            if (currentCustomer.AccountList[f].GetType() == typeof(Everyday))
            {
                Everyday everyday = (Everyday)currentCustomer.AccountList[f];
                OpenAccountForm(everyday);
            }
            if (currentCustomer.AccountList[f].GetType() == typeof(Investment))
            {
                Investment investment = (Investment)currentCustomer.AccountList[f];
                OpenAccountForm(investment);
            }
            if (currentCustomer.AccountList[f].GetType() == typeof(Omni))
            {
                Omni omni = (Omni)currentCustomer.AccountList[f];
                OpenAccountForm(omni);
            }
        }

        // Closes current form and opens AccountForm based on account type.
        // The parameter passed changes during runtime.
        public void OpenAccountForm(dynamic account)
        {
            this.Hide();
            AccountForm accform = new AccountForm(account, currentCustomer);
            accform.ShowDialog();
            this.Close();
        }

        // Navigate back to Customer Management form
        private void backButton_Click(object sender, EventArgs e)
        {
            CRUDCustomerForm Form1 = new CRUDCustomerForm();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }

        //Function to enable/disable the managebutton if an account has been selected
        private void accountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageButton.Enabled = true;

            if (accountListBox.SelectedIndex == -1)
            {
                manageButton.Enabled = false;
            }
        }

        // Button to refresh the account list
        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshAccountList();
        }

        // Refreshes the list box with the current account list.
        public void RefreshAccountList()
        {
            accountListBox.Items.Clear();
            manageButton.Enabled = false;

            currentCustomer = CustomerRepository.getInstance().SelectCustomerFromCustomerList(currentCustomer.CustomerNumber);

            foreach (Account account in currentCustomer.AccountList)
            {
                accountListBox.Items.Add(account.getAccountType().ToString());//+ " #" + account.getAccountID().ToString()) ;
            }
        }
    }
}
