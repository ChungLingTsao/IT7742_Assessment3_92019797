/* 
 * Controller.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: This controller class will be responsible for how the user interacts with the application.
 *				It is the bridge between the model and view components. 
 *				When a user performs a relevant action, the controller should send the appropriate response.
*/
namespace Assessment3
{
    /// <summary>
    /// The <c>AccountController </c>
    /// This class will be responsible for taking an user input and sending the approriate 
    /// response to perform a function related to Accounts
    /// <list type="bullet">
    /// <item>
    /// <term>AddAccount</term>
    /// <description>Adds Account to Customer</description>
    /// </item>
    /// <item>
    /// <term>AddCustomer</term>
    /// <description>Adds Customer to Customer Repository</description>
    /// </item>
    /// <item>
    /// <term>EditCustomer</term>
    /// <description>Removes old customer with same customerID from Customer Repository and then adds new Customer</description>
    /// </item>
    /// <item>
    /// <term>DeleteCustomer</term>
    /// <description>Removes Customer from Customer Repository</description>
    /// </item>
    /// <item>
    /// <term>Deposit</term>
    /// <description>Credits money to an account</description>
    /// </item>
    /// <item>
    /// <term>Withdraw</term>
    /// <description>Debits money to an account</description>
    /// </item>
    /// <item>
    /// <term>AddInterest</term>
    /// <description>Credits the interest earned by the account</description>
    /// </item>
    /// <item>
    /// <term>Transfer</term>
    /// <description>Transfers money between accounts by debitting one and creditting the other</description>
    /// </item>
    /// <item>
    /// <term>RecordTransaction</term>
    /// <description>Saves the transaction to an Account</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This class is the controller that adds accounts to customers.</para>
    /// </remarks>
    public class Controller
	{
        /// <summary>
        /// Adds an account <paramref name="account"/> to a customer <paramref name="customer"/>
        /// </summary>
        /// <param name="account">An account</param>
        /// <param name="customer">A customer</param>
        public void AddAccount(Customer customer, Account account)
        {
            CustomerRepository.getInstance().AddNewAccount(customer, account);
        }

        /// <summary>
        /// Adds a customer <paramref name="customer"/> to the customer repository/>
        /// </summary>
        /// <param name="customer">A customer</param>
        public void AddCustomer(Customer customer)
        {
            CustomerRepository.getInstance().AddNewCustomer(customer);
        }

        /// <summary>
        /// Edits a customer <paramref name="Customer"/> by replacing the old customer from the customer repository
        /// </summary>
        /// <param name="Customer">A customer</param>
        public void EditCustomer(Customer editCustomer)
        {
            CustomerRepository.getInstance().EditCustomer(editCustomer, editCustomer.CustomerNumber);
        }

        /// <summary>
        /// Deletes a customer from the customer repository by their customerNumber <paramref name="deleteCustomerWithID"/>
        /// </summary>
        /// <param name="deleteCustomerWithID">A customer number where the associated customer is to be deleted</param>        
        public void DeleteCustomer(int deleteCustID)
        {
            CustomerRepository.getInstance().DeleteCustomer(deleteCustID);
        }

        /// <summary>
        /// Deposits the amount of credit <paramref name="credit"/> to the account with accountID <paramref name="accountID"/>
        /// of the customer with the customerID <paramref name="customerID"/> from the customer repository
        /// </summary>
        /// <param name="credit">Amount to be deposited</param>
        /// <param name="customerID">Customer ID of customer to be credited </param>
        /// <param name="accountID">Account ID of account to be credited</param>
        public void Deposit(double credit, int customerID, int accountID)
        {
            CustomerRepository.getInstance().DepositToCustomerAccount(credit, customerID, accountID);
        }

        /// <summary>
        /// Withdraw the amount of debit <paramref name="debit"/> from the account with accountID <paramref name="accountID"/>
        /// of the customer with the customerID <paramref name="customerID"/> from the customer repository
        /// </summary>
        /// <param name="debit">Amount to be withdrawn</param>
        /// <param name="customerID">Customer ID of customer to be credited </param>
        /// <param name="accountID">Account ID of account to be credited</param>
        public void Withdraw(double debit, int customerID, int accountID)
        {
            CustomerRepository.getInstance().WithdrawTransactionFromCustomerAccount(debit, customerID, accountID);
        }

        /// <summary>
        /// Deposit the amount of interest <paramref name="interest"/> gained to the account with accountID <paramref name="accountID"/>
        /// of the customer with the customerID <paramref name="customerID"/> from the customer repository
        /// </summary>
        /// <param name="interest">Amount of interest to be deposited</param>
        /// <param name="customerID">Customer ID of customer to be credited </param>
        /// <param name="accountID">Account ID of account to be credited</param>
        public void AddInterest(double interest, int customerID, int accountID)
        {
            CustomerRepository.getInstance().DepositToCustomerAccount(interest, customerID, accountID);
        }

        /// <summary>
        /// The customer with the customerID <paramref name="customerID"/> transfers the transfer Amount <paramref name="transferAmount"/> 
        /// from account with fromAccountId <paramref name="fromAccountID"/> to account with toAccountID <paramref name="toAccountID"/>
        /// of the customer with the customerID <paramref name="customerID"/> from the customer repository
        /// </summary>
        /// <param name="transferAmount">Amount of money to be transferred</param>
        /// <param name="customerID">Customer ID of customer to be credited </param>
        /// <param name="fromAccountID">Account ID of account to be debitted</param>
        /// <param name="toAccountID">Account ID of account to be credited</param>
        public void Transfer(double transferAmount, int customerID, int fromAccountID, int toAccountID)
        {
            CustomerRepository.getInstance().TransferAmountFromAccountToAccount2(transferAmount, customerID, fromAccountID, toAccountID);
        }

        /// <summary>
        /// Stores the transaction <paramref name="transaction"/> in the customer repository for the account
        /// with the accountID <paramref name="accountID"/> of the customer with the customerID <paramref name="customerID"/>
        /// </summary>
        /// <param name="transaction">The transaction to be stored in the customer repository</param>
        /// <param name="customerID">Customer ID of customer to store the transaction </param>
        /// <param name="accountID">Account ID of account to store the transaction</param>
        public void RecordTransaction(Transaction transaction, int customerID, int accountID)
        {
            CustomerRepository.getInstance().RecordTransactionToTransactionList(transaction, customerID, accountID);
        }
    }
}
