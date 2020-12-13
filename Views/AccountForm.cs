using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class AccountForm : BrandingParentForm
    {
        Account account;
        Customer customer;
        List<Customer> customerRepository = CustomerRepository.getInstance().GetAllCustomers();

        public AccountForm(Everyday everyday, Customer currentCustomer)
        {
            //SessionController sessionController = new SessionController();
            //int customerID = sessionController.GetSessionID();
            //int accountID = 1;

            //Customer selectedCustomer = customerRepository.Find(x => x.CustomerNumber == customerID);
            //Account selectedAccount = selectedCustomer.AccountList.Find(x => x.getAccountID() == accountID);



            //   MessageBox.Show(everyday.GetInterestRate().ToString());
            account = everyday;
            customer = currentCustomer;
            InitializeComponent();
            this.accountTypeLabel.Text = account.getAccountType().ToString();
            this.accountIDLabel.Text = account.getAccountID().ToString();
            this.balanceLabel.Text = account.getBalance().ToString("c");
            this.interestLabel.Text = account.GetInterestRate().ToString("P");
        }

        public AccountForm(Investment investment, Customer currentCustomer)
        {
            account = investment;
            customer = currentCustomer;
            InitializeComponent();
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
            this.accountTypeLabel.Text = omni.getAccountType().ToString();
            this.accountIDLabel.Text = omni.getAccountID().ToString();
            this.balanceLabel.Text = omni.getBalance().ToString("c");
            this.interestLabel.Text = omni.GetInterestRate().ToString("P");
        }

        private void calculateinterestButton_Click(object sender, EventArgs e)
        {

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            //AccountController accountController = new AccountController();
           // accountController.Deposit(Convert.ToDouble(moneyInputTextBox.Text), customer , account);

            TransactionController transactionController = new TransactionController();
            transactionController.Deposit(Convert.ToDouble(moneyInputTextBox.Text), customer.CustomerNumber, account.getAccountID());
            InitialiseFields();
        }

        private void InitialiseFields()
        {
           // List<Account> accountlist = CustomerRepository.getInstance().GetAccountListByCustomerId(customer.CustomerNumber);
            Account currentAccount = CustomerRepository.getInstance().SelectAccountFromAccountList(customer,account.getAccountID());

            MessageBox.Show(currentAccount.getBalance().ToString("c"));
            //this.accountTypeLabel.Text = currentAccount.getAccountType().ToString();
            this.accountIDLabel.Text = currentAccount.getAccountID().ToString();
            this.balanceLabel.Text = currentAccount.getBalance().ToString("c");
            this.interestLabel.Text = currentAccount.GetInterestRate().ToString("P");


//            CustomerRepository.getInstance().EditCustomer(customer, customer.CustomerNumber);
        }
    }
}
