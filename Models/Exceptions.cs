/* 
 * Exceptions.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: The exception class that will throw custom exceptions.
*/
using System;

namespace Assessment3
{
    [Serializable]
    public class FailedWithdrawlException : Exception
    {
        public FailedWithdrawlException()
        {
        }

        public FailedWithdrawlException(double debit)
            : base(String.Format("Invalid Debit Withdrawl Amount: {0}", debit))
        {
        }
    }

    [Serializable]
    public class InvalidCustomerException : Exception
    {
        public InvalidCustomerException()
            : base(String.Format("Invalid Customer"))
        {
        }
    }

    [Serializable]
    public class InvalidTransferAmountException : Exception
    {
        public InvalidTransferAmountException()
            : base(String.Format("Invalid Transfer Amount"))
        {
        }
    }
    
}
