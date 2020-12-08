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
    public class CustomerController
	{
		public void AddCustomer(int customerNumber, string name, string phone, string email, string address, string suburb, string city, string zip, bool isStaff)
		{
			Customer newCust = new Customer(customerNumber, name, phone, email, address, suburb, city, zip, isStaff);
			CustomerRepository.getInstance().AddNewCustomer(newCust);
			MessageBox.Show(name + " added to system");
		}

		public void EditCustomer(int id, string name, string phone, string email, string address, string suburb, string city, string zip, bool isStaff)
		{
			Customer newCust = new Customer(id, name, phone, email, address, suburb, city, zip, isStaff);
			CustomerRepository.getInstance().EditCustomer(newCust, id);
		}

		public void DeleteCustomer(int deleteCustID)
		{
			CustomerRepository.getInstance().DeleteCustomer(deleteCustID);
		}
	}
}
