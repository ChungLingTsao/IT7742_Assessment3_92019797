using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Assessment3.Enums;

namespace Assessment3
{
    public partial class TransferForm : Assessment3.PopupParentForm
    {
        Customer _customer;
        Account _account;

        public TransferForm(Account currentAccount, Customer currentCustomer)
        {
            InitializeComponent();
            this.titleLabel.Text = "MONEY TRANSFER";
            _customer = currentCustomer;
            _account = currentAccount;
            InitializeFields();
        }

        // Allows the user to transfer money between their accounts
        private void transferButton_Click(object sender, EventArgs e)
        {
            // Some lite input validation, does not catch letters.
            double transferAmount = 0;
            bool moneyValidate = validateMoneyInput();
            transferAmount = Convert.ToDouble(transferInputBox.Text);

            if ((moneyValidate == true) && (transferAmount < _account.getBalance()))
            {
                //Selects the account to be transfered to and transfers money
                int selectedIndex = transferListBox.SelectedIndex;
                Account toAccount = _customer.AccountList[selectedIndex];
                controller.Transfer(transferAmount, _customer.CustomerNumber, _account.getAccountID(), toAccount.getAccountID());

                // Log the transfer transaction
                int nextId = _account.TransactionsList.Count + 1;
                Transaction transaction = new Transaction(nextId, false, transferAmount, _account, ActionTypes.Transfer);
                controller.RecordTransaction(transaction, _customer.CustomerNumber, _account.getAccountID());

                //Set current account the same as customer repository
                _account = CustomerRepository.getInstance().SelectAccountFromAccountList(_customer, _account.getAccountID());
                MessageBox.Show("Transfered " + transferAmount.ToString("c") + " to " + toAccount.getAccountType().ToString());
                
                InitializeFields();
            }
            else
            {
                MessageBox.Show("Please input a valid amount of money", "Warning!");
            }
        }

        // Displays the customer's other accounts 
        public void InitializeFields()
        {
            // Clears list box
            this.transferListBox.Items.Clear();

            // Selecting customer and account from customer repository
            CustomerRepository.getInstance().ReadBinaryData();
            _customer = CustomerRepository.getInstance().SelectCustomerFromCustomerList(_customer.CustomerNumber);
            _account = CustomerRepository.getInstance().SelectAccountFromAccountList(_customer, _account.getAccountID());

            //Lists accounts in the list box that is not the current selected account
            foreach (Account account in _customer.AccountList)
            {
                if (account.getAccountID() != _account.getAccountID())
                {
                    transferListBox.Items.Add(account.getAccountType().ToString());
                }
            }
        }

        // Closes the dialog
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validates that the input is a positive number in a standard currency format
        public bool validateMoneyInput()
        {
            // Regex for validating currency
            Regex regex = new Regex("^\\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$");
            bool hasOnlyNumbers = regex.IsMatch(transferInputBox.Text);
            return hasOnlyNumbers;
        }
    }
}
