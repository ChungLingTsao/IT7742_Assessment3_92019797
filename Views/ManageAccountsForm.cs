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
                accountListBox.Items.Add(account.getAccountType().ToString() );//+ " #" + account.getAccountID().ToString()) ;
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
            int f = accountListBox.SelectedIndex;
            MessageBox.Show(currentCustomer.AccountList[f].GetType().ToString());

            // Hack used to allow Selected Item to be cast as the correct account type
           if (currentCustomer.AccountList[f].GetType() == typeof(Everyday)) 
            {
                Everyday everyday = (Everyday)currentCustomer.AccountList[f];
                AccountForm accform = new AccountForm(everyday, currentCustomer);
                accform.ShowDialog();
            }
            //  {
            if (currentCustomer.AccountList[f].GetType() == typeof(Investment))
            {
                Investment investment = (Investment)currentCustomer.AccountList[f];
                AccountForm accform = new AccountForm(investment, currentCustomer);
                accform.ShowDialog();
            }
            if (currentCustomer.AccountList[f].GetType() == typeof(Omni))
            {
                Omni omni = (Omni)currentCustomer.AccountList[f];
                AccountForm accform = new AccountForm(omni, currentCustomer);
                accform.ShowDialog();
            }

            ////////    SessionController sessionController = new SessionController();
            ////////    Account selectedAccount = accountListBox.SelectedItem as Account;
            ////////MessageBox.Show(selectedAccount.getAccountID().ToString());
            //sessionController.SetSessionID(selectedAccount.getAccountID());


            //sessionController.SetSessionID(selectedAccount.getAccountID());


            //   }

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
