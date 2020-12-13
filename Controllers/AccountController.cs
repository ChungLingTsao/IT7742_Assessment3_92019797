/// <summary>
/// The <c>AccountController </c>
/// This class will be responsible for taking an user input and sending the approriate 
/// response to perform a function related to Accounts
/// <list type="bullet">
/// <item>
/// <term>AddAccount</term>
/// <description>Adds Account to Customer</description>
/// </item>
/// </summary>
/// <remarks>
/// <para>This class is the controller that adds accounts to customers.</para>
/// </remarks>
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
        // Adds an everyday account to customer
        /// <summary>
        /// Adds an account <paramref name="account"/> to a customer <paramref name="customer"/>
        /// </summary>
        /// <example>
        /// <code>
        /// AccountController accountController = new AccountController();
        /// accountController.AddAccount(currentCustomer, newEveryday);
        /// </code>
        /// </example>
        /// <param name="account">An account.</param>
        /// <param name="customer">A customer.</param>
        public void AddAccount(Customer customer, Account account)
        {
            CustomerRepository.getInstance().AddNewAccount(customer, account);
        }
	}
}
