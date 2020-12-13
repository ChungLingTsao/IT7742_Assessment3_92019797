/* 
 * CustomerController.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: This controller class will be responsible for how the user interacts with the application.
 *				It is the bridge between the model and view components. 
 *				When a user performs a relevant action, the controller should send the appropriate response.
*/
using System.Windows.Forms;

namespace Assessment3
{
    public class AccountController
	{
		public void Deposit(double credit, Customer customer, Account account)
		{
			CustomerRepository.getInstance().DepositTransactionToCustomerAccount(credit, customer.CustomerNumber, account.getAccountID());
		}

		public void AddAccount(Investment investment)
		{
		}

		public void AddAccount(Omni omni)
		{
		}

		//public void EditCustomer(int id, string name, string phone, string email, string address, string suburb, string city, string zip, bool isStaff)
		//{
		//	Customer newCust = new Customer(id, name, phone, email, address, suburb, city, zip, isStaff);
		//	CustomerRepository.getInstance().EditCustomer(newCust, id);
		//}

		//public void DeleteCustomer(int deleteCustID)
		//{
		//	CustomerRepository.getInstance().DeleteCustomer(deleteCustID);
		//}
	}
}
