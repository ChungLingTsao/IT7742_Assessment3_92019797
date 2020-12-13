using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Assessment3.Enums;

namespace Assessment3
{
    public partial class AccountForm : BrandingParentForm
    {
        Account account;
        Customer customer;
        List<Customer> customerRepository = CustomerRepository.getInstance().GetAllCustomers();

        public AccountForm(Everyday everyday, Customer currentCustomer)
        {
            account = everyday;
            customer = currentCustomer;
            InitializeComponent();
            InitialiseFields();
            this.accountTypeLabel.Text = account.getAccountType().ToString();
            //this.accountIDLabel.Text = account.getAccountID().ToString();
            //this.balanceLabel.Text = account.getBalance().ToString("c");
            //this.interestLabel.Text = account.GetInterestRate().ToString("P");
        }

        public AccountForm(Investment investment, Customer currentCustomer)
        {
            account = investment;
            customer = currentCustomer;
            InitializeComponent();
            InitialiseFields();
            this.accountTypeLabel.Text = investment.getAccountType().ToString();
            this.accountIDLabel.Text = investment.getAccountID().ToString();
            this.balanceLabel.Text = investment.getBalance().ToString("c");
            this.interestLabel.Text = investment.GetInterestRate().ToString("P");
        }

        public AccountForm(Omni omni, Customer currentCustomer)
        {
            account = omni;
            customer = currentCustomer;
            InitializeComponent();
            InitialiseFields();
            this.accountTypeLabel.Text = omni.getAccountType().ToString();
            this.accountIDLabel.Text = omni.getAccountID().ToString();
            this.balanceLabel.Text = omni.getBalance().ToString("c");
            this.interestLabel.Text = omni.GetInterestRate().ToString("P");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            //AccountController accountController = new AccountController();
            // accountController.Deposit(Convert.ToDouble(moneyInputTextBox.Text), customer , account);
            double creditAmount = Convert.ToDouble(moneyInputTextBox.Text);

            TransactionController transactionController = new TransactionController();
            transactionController.Deposit(creditAmount, customer.CustomerNumber, account.getAccountID());

            int nextId = account.TransactionsList.Count + 1;
            Transaction transaction = new Transaction(nextId, false, creditAmount, account, ActionTypes.Deposit);
            
            transactionController.RecordTransaction(transaction, customer.CustomerNumber, account.getAccountID());

            account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
            //MessageBox.Show(account.getBalance().ToString());
            InitialiseFields();
        }

        public void InitialiseFields()
        {
            //MessageBox.Show(account.getBalance().ToString("c"));

            // Refresh the customer and account fields before redrawing form fields
            CustomerRepository.getInstance().ReadBinaryData();
            customer = CustomerRepository.getInstance().SelectCustomerFromCustomerList(customer.CustomerNumber);
            account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());

            this.accountIDLabel.Text = account.getAccountID().ToString();
            this.balanceLabel.Text = account.getBalance().ToString("c");
            this.interestLabel.Text = account.GetInterestRate().ToString("P");

            this.transactionListBox.Items.Clear();
            foreach (Transaction transaction in account.TransactionsList)
            {
                //transactionListBox.Items.Add(transaction.GetAmount().ToString("c") + " " + transaction.GetActionType().ToString() + transaction.transactionID);
                transactionListBox.Items.Add(transaction.ToString());
            }
        }

        private void switchaccountButton_Click(object sender, EventArgs e)
        {
            ManageAccountsForm manageAccountForm = new ManageAccountsForm(customer);
            this.Hide();
            manageAccountForm.ShowDialog();
            this.Close();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            //TransactionController transactionController = new TransactionController();
            //transactionController.Withdraw(Convert.ToDouble(moneyInputTextBox.Text), customer.CustomerNumber, account.getAccountID());

            //account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
            //MessageBox.Show(account.getBalance().ToString());
            //InitialiseFields();

            double debitAmount = Convert.ToDouble(moneyInputTextBox.Text);

            TransactionController transactionController = new TransactionController();
            transactionController.Withdraw(debitAmount, customer.CustomerNumber, account.getAccountID());
           
            int nextId = account.TransactionsList.Count + 1;
            Transaction transaction = new Transaction(nextId, false, debitAmount, account, ActionTypes.Withdraw);

            transactionController.RecordTransaction(transaction, customer.CustomerNumber, account.getAccountID());

            account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
            
            InitialiseFields();
        }

        private void calculateinterestButton_Click(object sender, EventArgs e)
        {
            double rate = account.GetInterestRate();
            double balance = account.getBalance();
            double interestRecieved = rate * balance;

            MessageBox.Show($"Interest recieved per annum is: ${interestRecieved:F} \n\n" +
                "Calculated using: \n" +
                $"Rate: {(rate * 100):F}% \n" +
                $"Balance: ${balance:F}",
                "Calculating interest");
        }

        private void addinterestButton_Click(object sender, EventArgs e)
        {
            double interestRecieved = account.GetInterestRate() * account.getBalance();

            TransactionController transactionController = new TransactionController();
            transactionController.AddInterest(interestRecieved, customer.CustomerNumber, account.getAccountID());

            //account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
          //  MessageBox.Show(account.getBalance().ToString());
           // InitialiseFields();

            

            int nextId = account.TransactionsList.Count + 1;
            Transaction transaction = new Transaction(nextId, false, interestRecieved, account, ActionTypes.Add_Interest);

            transactionController.RecordTransaction(transaction, customer.CustomerNumber, account.getAccountID());

            account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
            //MessageBox.Show(account.getBalance().ToString());
            InitialiseFields();

            //Transaction transaction = new Transaction(false, interestRecieved, account, ActionTypes.Add_Interest);
        }

        private void accountinfoButton_Click(object sender, EventArgs e)
        {
            double requiredBalance = account.GetRequiredBalance();
            string requiredBalanceInfo;

            if (requiredBalance > 0)
            {
                requiredBalanceInfo = ("Required Balance for gaining interest: $" + requiredBalance.ToString("F"));
            }
            else
            {
                requiredBalanceInfo = "";
            }

            MessageBox.Show($"Account Type: {account.getAccountType()} \n" +
            $"Interest Rate: {account.GetInterestRate() * 100}% \n" +
            $"Overdraft Limit: ${account.GetOverdraftLimit():F} \n" +
            $"Failed Transaction Fee: ${account.GetOverdraftLimit():F} \n" +
            requiredBalanceInfo, 
            "Account Information");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            TransferForm transferForm = new TransferForm(account, customer);
            transferForm.ShowDialog();
            //this.Close();
        }
    }
}
