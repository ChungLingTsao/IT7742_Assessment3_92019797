/* 
 * Transaction.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Implements the transactions for the banking system
*/
using System;
using static Assessment3.Enums;

namespace Assessment3
{
    [Serializable]
    public class Transaction
    {
        private int _transactionID;
        private Account _accountType;
        private ActionTypes _actionType;
        private bool _isFailed;
        private double _amount;
        private double _remainingBalance;

        // Constructor
        public Transaction(int transactionID, bool transactionFail, double amount, Account account, ActionTypes action)
        {
            _transactionID = transactionID;
            _isFailed = transactionFail;
            _amount = amount;
            _accountType = account;
            _actionType = action;
            _remainingBalance = account.getBalance();
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

            else if ((_actionType == ActionTypes.Deposit) || (_actionType == ActionTypes.Add_Interest))
            {
                double currentBalance = _remainingBalance + _amount;
                return $"{_accountType.getAccountType()} Account ID: {_accountType.getAccountID()}; {_actionType} ${_amount:F}; Balance: ${currentBalance:F}";
            }

            else if (_actionType == ActionTypes.Withdraw)
            {
                double currentBalance = _remainingBalance - _amount;
                return $"{_accountType.getAccountType()} Account ID: {_accountType.getAccountID()}; {_actionType} ${_amount:F}; Balance: ${currentBalance:F}";
            }

            else if (_actionType == ActionTypes.Transfer)
            {
                double currentBalance = _remainingBalance - _amount;
                return $"{_accountType.getAccountType()} Account ID: {_accountType.getAccountID()}; {_actionType} ${_amount:F}; Balance: ${currentBalance:F}";
            }

            else
            {
                return null;
            }
        }
    }
}
