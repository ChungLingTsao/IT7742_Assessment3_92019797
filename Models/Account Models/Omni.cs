/* 
 * Omni.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Child class of Account. 
 *              Has a conditional interest rate, no overdraft, and a fail fee.
*/
using System;

namespace Assessment3
{
    [Serializable]
    public class Omni : Account
    {
        private double _interestRate;
        private double _failFee;
        private double _requiredBalance;
        private bool _sufficentBalance;
        private double _overdraftLimit;

        //Constructor
        public Omni(int accountID, double balance, double interestRate, double failFee, double requiredBalance, double overdraftLimit) : base(accountID, balance, AccountTypes.Omni)
        {
            _interestRate = interestRate;
            _failFee = failFee;
            _requiredBalance = requiredBalance;
            _overdraftLimit = overdraftLimit;

            // Determines if balance is high enough for account to earn interest
            if (balance >= requiredBalance)
            {
                _sufficentBalance = true;
            }
            else
            {
                _sufficentBalance = false;
            }
        }

        public override double GetInterestRate()
        {
            return _interestRate;
        }

        public override double GetOverdraftLimit()
        {
            return _overdraftLimit;
        }

        public override double GetFailFee()
        {
            return _failFee;
        }

        public bool isSufficentBalance()
        {
            return _sufficentBalance;
        }

        public void setSufficentBalance(bool sufficient)
        {
            _sufficentBalance = sufficient;
        }

        public double getRequiredBalance()
        {
            return _requiredBalance;
        }
    }
}

