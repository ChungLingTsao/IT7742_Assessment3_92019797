﻿/* 
 * Account.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Abstract class that is used to implement the other account subtypes
*/
namespace Assessment3.Models
{
    public abstract class Account
    {
        private int _accountID;
        private double _balance;
        private AccountTypes _accountType;
        public abstract double GetInterestRate();
        public abstract double GetOverdraftLimit();
        public abstract double GetFailFee();

        public Account(int accountID, double balance, AccountTypes type)
        {
            _accountID = accountID;
            _balance = balance;
            _accountType = type;
        }

        public int getAccountID()
        {
            return _accountID;
        }

        public double getBalance()
        {
            return _balance;
        }

        public void Deposit(double credit)
        {
            _balance += credit;
        }

        public void Withdraw(double debit)
        {
            //_balance -= debit;

            // The following is functionality that has been added due to tests initialally failing
            if (debit <= 0)
            {
                throw new FailedWithdrawlException();
            }
            else if (debit < _balance)
            {
                double newBalance = _balance - debit;
                _balance = newBalance;
            }
            else
            {
                throw new FailedWithdrawlException();
            }
        }

        public AccountTypes getAccountType()
        {
            return _accountType;
        }

        public enum AccountTypes
        {
            Everyday,
            Investment,
            Omni
        }

    }
}