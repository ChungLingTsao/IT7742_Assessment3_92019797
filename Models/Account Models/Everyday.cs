/* 
 * Everyday.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Child class of Account. 
 *              Has no interest rate, no overdraft, no fees.
*/
using System;

namespace Assessment3
{
    [Serializable]
    public class Everyday : Account
    {
        // Constructor
        public Everyday(int accountID, double balance) : base(accountID, balance, AccountTypes.Everyday)
        {
        }

        public override double GetInterestRate()
        {
            return 0; // No interest. Also used to display the no interest info.
        }

        public override double GetOverdraftLimit()
        {
            return 0; // No overdraft. Also used to display the no overdraft info.
        }

        public override double GetFailFee()
        {
            return 0; // No fees. Also used to display the no fee info.
        }

        public override double GetRequiredBalance()
        {
            return 0; // As if it is not implemented. Field expects a non-zero interger.
        }
    }
}
