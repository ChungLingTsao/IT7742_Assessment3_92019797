using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Assessment3.Enums;

namespace Assessment3
{
    public partial class AccountForm : BrandingParentForm
    {
        Account account;
        Customer customer;
        List<Customer> customerRepository = CustomerRepository.getInstance().GetAllCustomers();

        // Contructor for accepting everyday account parameter
        public AccountForm(Everyday everyday, Customer currentCustomer)
        {
            account = everyday;
            customer = currentCustomer;
            InitializeComponent();
            InitialiseFields();
        }

        // Contructor for accepting investment account parameter
        public AccountForm(Investment investment, Customer currentCustomer)
        {
            account = investment;
            customer = currentCustomer;
            InitializeComponent();
            InitialiseFields();
        }

        // Contructor for accepting omni account parameter
        public AccountForm(Omni omni, Customer currentCustomer)
        {
            account = omni;
            customer = currentCustomer;
            InitializeComponent();
            InitialiseFields();
        }

        // Initialise all display fields necessary for the Form
        public void InitialiseFields()
        {
            // Refresh the customer and account fields before redrawing form fields
            CustomerRepository.getInstance().ReadBinaryData();
            customer = CustomerRepository.getInstance().SelectCustomerFromCustomerList(customer.CustomerNumber);
            account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());

            // Displays account information
            this.titleLabel.Text = "ACCOUNT DASHBOARD";
            this.accountTypeLabel.Text = account.getAccountType().ToString();
            this.accountIDLabel.Text = account.getAccountID().ToString();
            this.balanceLabel.Text = account.getBalance().ToString("c");
            this.interestLabel.Text = account.GetInterestRate().ToString("P");

            // Refreshes the transaction listbox
            this.transactionListBox.Items.Clear();
            foreach (Transaction transaction in account.TransactionsList)
            {
                transactionListBox.Items.Add(transaction.ToString());
            }
        }

        // Navigates back to the Account Management Form
        private void switchaccountButton_Click(object sender, EventArgs e)
        {
            ManageAccountsForm manageAccountForm = new ManageAccountsForm(customer);
            this.Hide();
            manageAccountForm.ShowDialog();
            this.Close();
        }

        // Performs an account deposit
        private void depositButton_Click(object sender, EventArgs e)
        {
            // Validating that input field is positive currency
            bool moneyValidate = validateMoneyInput();

            if (moneyValidate == true)
            {
                // Retrieves amount and deposits to account
                double creditAmount = Convert.ToDouble(moneyInputTextBox.Text);
                controller.Deposit(creditAmount, customer.CustomerNumber, account.getAccountID());

                // Logs the deposit transaction to the transaction list
                int nextId = account.TransactionsList.Count + 1;
                Transaction transaction = new Transaction(nextId, false, creditAmount, account, ActionTypes.Deposit);
                controller.RecordTransaction(transaction, customer.CustomerNumber, account.getAccountID());

                // Sets the new account as the current account being displayed on the Form 
                account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
                InitialiseFields();
            }

            else
            {
                MessageBox.Show("Please input a valid amount for money", "Warning!");
            }
        }

        // Performs an account withdrawl
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // Validating that input field is positive currency
            bool moneyValidate = validateMoneyInput();

            if (moneyValidate == true)
            {
                // Retrieves amount and withdraws to account
                double debitAmount = Convert.ToDouble(moneyInputTextBox.Text);
                controller.Withdraw(debitAmount, customer.CustomerNumber, account.getAccountID());

                // Logs the deposit transaction to the transaction list
                int nextId = account.TransactionsList.Count + 1;
                Transaction transaction = new Transaction(nextId, false, debitAmount, account, ActionTypes.Withdraw);
                controller.RecordTransaction(transaction, customer.CustomerNumber, account.getAccountID());

                // Sets the new account as the current account being displayed on the Form 
                account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
                InitialiseFields();
            }
            else
            {
                MessageBox.Show("Please input a valid amount for money", "Warning!");
            }
        }

        // Calculates the amount of interest to be gained
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

        // Performs an account deposit of interest gained
        private void addinterestButton_Click(object sender, EventArgs e)
        {
            // Calculates and deposits the amount of interest gained
            double interestRecieved = account.GetInterestRate() * account.getBalance();
            controller.AddInterest(interestRecieved, customer.CustomerNumber, account.getAccountID());

            // Logs the add interest transaction to the transaction list
            int nextId = account.TransactionsList.Count + 1;
            Transaction transaction = new Transaction(nextId, false, interestRecieved, account, ActionTypes.Add_Interest);
            controller.RecordTransaction(transaction, customer.CustomerNumber, account.getAccountID());

            // Sets the new account as the current account being displayed on the Form 
            account = CustomerRepository.getInstance().SelectAccountFromAccountList(customer, account.getAccountID());
            InitialiseFields();
        }

        // Shows the account information regarding rates, fees, limits
        private void accountinfoButton_Click(object sender, EventArgs e)
        {
            double requiredBalance = account.GetRequiredBalance();
            string requiredBalanceInfo;

            // Displays extra line only for omni account info
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

        //Opens up the transfer money dialog
        private void transferButton_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(account, customer);
            transferForm.ShowDialog();
        }

        // Validates that the input is a positive number in a standard currency format
        public bool validateMoneyInput()
        {
            // Regex for validating currency
            Regex regex = new Regex("^\\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$");
            bool hasOnlyNumbers = regex.IsMatch(moneyInputTextBox.Text);
            return hasOnlyNumbers;
        }
    }
}
