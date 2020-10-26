/* 
 * Investment.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Child class of Account. 
 *              Has a variable interest rate, no overdraft, and a fail fee.
*/
namespace Assessment2.Models
{
    class Investment : Account
    {
        private double _interestRate;
        private double _failFee;

        // Constructor
        public Investment(int accountID, double balance, double interestRate, double failFee) : base(accountID, balance, AccountTypes.Investment)
        {
            _interestRate = interestRate;
            _failFee = failFee;
        }

        public override double GetInterestRate()
        {
            return _interestRate;
        }

        public override double GetOverdraftLimit()
        {
            return 0;  // No overdraft. Also used to display the no overdraft info.
        }

        public override double GetFailFee()
        {
            return _failFee;
        }
    }
}
