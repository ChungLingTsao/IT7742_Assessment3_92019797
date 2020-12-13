/* 
 * Enums.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Custome enumerators used for accounts and transactions
*/

namespace Assessment3
{
    public class Enums
    {
        public enum AccountTypes
        {
            Everyday,
            Investment,
            Omni
        }
        public enum ActionTypes
        {
            Deposit,
            Withdraw,
            Add_Interest,
            ViewCurrentBalance, 
            Transfer
        }
    }
}
