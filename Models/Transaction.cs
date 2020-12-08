/* 
 * Transaction.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Implements the transactions for the banking system
*/
using System.Threading;

namespace Assessment3.Models
{
    class Transaction
    {
        private Account _accountType;
        private ActionTypes _actionType;
        private bool _isFailed;
        private double _amount;
        private double _remainingBalance;

        public int transactionID { get; private set; } // Prototype doesn't require incremental transaction IDs
        public static int nextID;

        // Constructor
        public Transaction(bool transactionFail, double amount, Account account, ActionTypes action)
        {
            transactionID = Interlocked.Increment(ref nextID);
            _isFailed = transactionFail;
            _amount = amount;
            _accountType = account;
            _actionType = action;
            _remainingBalance = account.getBalance();
        }

        public Account GetAccount()
        {
            return _accountType;
        }

        public double GetRemainingBalance()
        {
            return _remainingBalance;
        }

        //Overrides the ToString Method to display transaction info
        public override string ToString()
        {
            if (_isFailed == true)
            {
                return $"{_accountType.getAccountType()} Account ID: {_accountType.getAccountID()}; {_actionType} ${_amount:F}; TRANSACTION FAILED; Fee: ${_accountType.GetFailFee():F}; Balance: ${_remainingBalance:F}";
            }

            else if (_actionType == ActionTypes.ViewCurrentBalance)  
            {
                return $"{_accountType.getAccountType()} Account ID: {_accountType.getAccountID()}; Interest Rate: {_accountType.GetInterestRate():F}%; Overdraft Limit: ${_accountType.GetOverdraftLimit():F}; Fee: ${_accountType.GetFailFee():F}; Balance: ${_remainingBalance:F}";
            }

            else if ((_actionType == ActionTypes.Deposit) || (_actionType == ActionTypes.Add_Interest) || (_actionType == ActionTypes.Withdraw))
            {
                return $"{_accountType.getAccountType()} Account ID: {_accountType.getAccountID()}; {_actionType} ${_amount:F}; Balance: ${_remainingBalance:F}";
            }

            else
            {
                return null;
            }
        }
    }
}
