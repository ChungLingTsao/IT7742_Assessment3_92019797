/* 
 * CustomerController.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: This controller class will be responsible for how the user interacts with the application.
 *				It is the bridge between the model and view components. 
 *				When a user performs a relevant action, the controller should send the appropriate response.
*/
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assessment3
{
    public class TransactionController
	{
		public void Deposit(double credit, int customerID, int accountID)
		{
			CustomerRepository.getInstance().DepositTransactionToCustomerAccount(credit, customerID, accountID);

			//Account a = (from account in accountlist where account.getAccountID() == accountID select account).First();

			//List<Transaction> transactionlist = a.TransactionsList;
			//transactionlist.Add
		}

		public void Withdraw(double debit)
		{
		}
	}
}
