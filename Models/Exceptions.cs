/* 
 * Exceptions.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: The exception class that will throw an exception for a failed withdrawl.
*/
using System;

namespace Assessment2
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
}
