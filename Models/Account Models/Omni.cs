/* 
 * Omni.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Child class of Account. 
 *              Has a conditional interest rate, no overdraft, and a fail fee.
*/
using System;
using static Assessment3.Enums;

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

            _sufficentBalance = CheckSufficentBalance(balance, requiredBalance);

        }

        // Determines if balance is high enough for the account to earn interest
        public bool CheckSufficentBalance(double balance, double requiredBalance)
        {
            if (balance >= requiredBalance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Applies fail fee if an invalid transaction has taken place
        public void ApplyFailFee(bool isStaff)
        {
            double appliedFee;

            if (isStaff == true)
            {
                appliedFee = _failFee / 2;
            }
            else
            {
                appliedFee = _failFee;
            }
            double remainingBalance = this.getBalance() - appliedFee;
            setBalance(remainingBalance);
        }

        /****************************************************
        * Overridden methods of the abstract Account methods*
        *****************************************************/

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

        public override double GetRequiredBalance()
        {
            return _requiredBalance;
        }

        /*******************
        * GETTER Functions *
        *******************/
        public bool isSufficentBalance()
        {
            return _sufficentBalance;
        }

        public double getRequiredBalance()
        {
            return _requiredBalance;
        }
    }
}

