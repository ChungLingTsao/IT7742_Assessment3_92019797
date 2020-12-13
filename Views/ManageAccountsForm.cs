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

            RefreshAccountList();
            //foreach (Account account in currentCustomer.AccountList)
            //{
            //    accountListBox.Items.Add(account.getAccountType().ToString() );//+ " #" + account.getAccountID().ToString()) ;
            //}
            //customer initialisation
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            AddAccountForm addaccform = new AddAccountForm(currentCustomer);
            addaccform.ShowDialog(); // ShowDialog used to prevent selecting main form until this form completed
        }

        //Opens AccountForm relative to what account has been selected in the accountListBox
        private void manageButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            int f = accountListBox.SelectedIndex;
            //MessageBox.Show(currentCustomer.AccountList[f].GetType().ToString());

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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshAccountList();
        }

        public void RefreshAccountList()
        {
            accountListBox.Items.Clear();

            currentCustomer = CustomerRepository.getInstance().SelectCustomerFromCustomerList(currentCustomer.CustomerNumber);

            foreach (Account account in currentCustomer.AccountList)
            {
                accountListBox.Items.Add(account.getAccountType().ToString());//+ " #" + account.getAccountID().ToString()) ;
            }
        }
    }
}
