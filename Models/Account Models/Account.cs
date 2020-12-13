/* 
 * Account.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Abstract class that is used to implement the other account subtypes
*/
using System;
using System.Collections.Generic;
using static Assessment3.Enums;

namespace Assessment3
{
    [Serializable]
    public abstract class Account
    {
        private int _accountID;
        private double _balance;
        private AccountTypes _accountType;
        public abstract double GetInterestRate();
        public abstract double GetOverdraftLimit();
        public abstract double GetFailFee();
        public abstract double GetRequiredBalance();

        private List<Transaction> _transactionsList; // Each account has a list of transactions

        //Account Constructor
        public Account(int accountID, double balance, AccountTypes type)
        {
            _accountID = accountID;
            _balance = balance;
            _accountType = type;

            _transactionsList = new List<Transaction>();
        }

        /*****************************
         *  GETTERS/SETTER Functions *
         *****************************/
        public int getAccountID()
        {
            return _accountID;
        }

        public double getBalance() 
        {
            return _balance;
        }

        public void setBalance(double balance)
        {
            _balance = balance;
        }

        public AccountTypes getAccountType()
        {
            return _accountType;
        }

        public List<Transaction> TransactionsList { get => _transactionsList; set => _transactionsList = value; }

        //Function for depositing an amount of money into the account
        public void Deposit(double credit)
        {
            _balance += credit;
        }

        //Function for widthrawing an amount of money from the account
        public void Withdraw(double debit)
        {
            //_balance -= debit;
            double overdraftLimit = this.GetOverdraftLimit();

            // The following is functionality that has been added due to tests initially failing
            if (debit <= 0)
            {
                throw new FailedWithdrawlException(debit);
            }
            else if (debit < (_balance + overdraftLimit))
            {
                double newBalance = _balance - debit;
                _balance = newBalance;
            }
            else
            {
                throw new FailedWithdrawlException(debit);
            }
        }
    }
}
