using System;
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
            _customer = currentCustomer;
            _account = currentAccount;

            this.transferListBox.Items.Clear();

            CustomerRepository.getInstance().ReadBinaryData();
            _customer = CustomerRepository.getInstance().SelectCustomerFromCustomerList(currentCustomer.CustomerNumber);
            _account = CustomerRepository.getInstance().SelectAccountFromAccountList(currentCustomer, currentAccount.getAccountID());


            foreach (Account account in _customer.AccountList)
            {
                if (account.getAccountID() != _account.getAccountID())
                {
                    //transactionListBox.Items.Add(transaction.GetAmount().ToString("c") + " " + transaction.GetActionType().ToString() + transaction.transactionID);
                    transferListBox.Items.Add(account.getAccountType().ToString());
                }                
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            double transferAmount = Convert.ToDouble(transferInputBox.Text);

            int selectedIndex = transferListBox.SelectedIndex;
            MessageBox.Show(selectedIndex.ToString());



            //Account toAccount = transferListBox.SelectedItem as Account;
            Account toAccount = _customer.AccountList[selectedIndex];

            MessageBox.Show(transferAmount.ToString());
            MessageBox.Show(toAccount.getBalance().ToString());

            TransactionController transactionController = new TransactionController();
            transactionController.Transfer(transferAmount, _customer.CustomerNumber, _account.getAccountID(), toAccount.getAccountID());
            
            int nextId = _account.TransactionsList.Count + 1;
            Transaction transaction = new Transaction(nextId, false, transferAmount, _account, ActionTypes.Transfer);

            transactionController.RecordTransaction(transaction, _customer.CustomerNumber, _account.getAccountID());

            _account = CustomerRepository.getInstance().SelectAccountFromAccountList(_customer, _account.getAccountID());
            MessageBox.Show("Transfered " + transferAmount.ToString("c") + " to " + toAccount.getAccountType().ToString());
            //InitialiseFields();

        }

        private void cancelButton_Click(object sender, EventArgs e) { }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
