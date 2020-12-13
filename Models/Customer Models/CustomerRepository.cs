/* 
 * CustomerRepository.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: A repository class for holding the data and providing access. 
 *              Normally, the application would be connected to a database.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assessment3
{
    class CustomerRepository
    {
        int _nextID = 1;
        List<Customer> customerRepo = new List<Customer>();

        /**********************************************************************
        * Basic singleton pattern used to ensure only one instance is created *
        **********************************************************************/
        private static CustomerRepository _instance = null;

        public static CustomerRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new CustomerRepository();
            }
            return _instance;
        }

        // Adds new customer to the repository
        public void AddNewCustomer(Customer newCustomer)
        {
            if (newCustomer.Name == "") // Customer must have a name
            {
                throw new InvalidCustomerException();
            }
            else
            {
                customerRepo.Add(newCustomer);
                _nextID++;
                WriteBinaryData(); // Saves the edited customer repository
            }
        }

        // Edits new customer to the repository
        public void EditCustomer(Customer editedCustomer, int previousID)
        {
            if (editedCustomer.Name == "") // Customer must have a name
            {
                throw new InvalidCustomerException();
            }
            else
            {
                // The old instance of the customer is removed from the repository and replaced
                // with the new instance of the customer.
                customerRepo.RemoveAll(Customer => Customer.CustomerNumber == previousID);
                customerRepo.Add(editedCustomer);
            }
            WriteBinaryData();  // Saves the edited customer repository
        }

        // Deletes a customer from the repository based on customer number
        public void DeleteCustomer(int deleteCustomerID)
        {
            customerRepo.RemoveAll(Customer => Customer.CustomerNumber == deleteCustomerID);
            WriteBinaryData(); // Saves the edited customer repository
        }

        // Removes older account from the customer's account list and replaces with the new account
        public void EditAccount(Customer customer, Account selectedAccount)
        {
            customer.AccountList.RemoveAll(Account => Account.getAccountID() == selectedAccount.getAccountID());
            customer.AccountList.Add(selectedAccount);
        }

        // Getter function to return all customers
        public List<Customer> GetAllCustomers()
        {
            ReadBinaryData(); // Reads the customer repository
            return this.customerRepo;
        }

        // Deposits money to a specific customer account
        public void DepositToCustomerAccount(double deposit, int customerID, int accountID)
        {
            // Selects the relevant customer and account
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            Account selectedAccount = SelectAccountFromAccountList(selectedCustomer, accountID);

            // Deposits money into account
            selectedAccount.Deposit(deposit);

            // Replaces old account in customer account list with new account
            EditAccount(selectedCustomer, selectedAccount);

            // Removes older instance of the customer in the customer repo and replaces with the new account
            EditCustomer(selectedCustomer, customerID);
        }

        // Withdraws money from a specific customer account
        public void WithdrawTransactionFromCustomerAccount(double debit, int customerID, int accountID)
        {
            // Selects the relevant customer and account
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            Account selectedAccount = SelectAccountFromAccountList(selectedCustomer, accountID);

            // Withdraws money from account
            selectedAccount.Withdraw(debit);
            
            // Replaces old account in customer account list with new account
            EditAccount(selectedCustomer, selectedAccount);

            // Removes older instance of the customer in the customer repo and replaces with the new account
            EditCustomer(selectedCustomer, customerID);
        }

        // Logs a transaction to the transaction list of an account
        public void RecordTransactionToTransactionList(Transaction transaction, int customerID, int accountID)
        {
            // Selects the relevant customer and account
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            Account selectedAccount = SelectAccountFromAccountList(selectedCustomer, accountID);

            // Withdraws money from account
            selectedAccount.TransactionsList.Add(transaction);

            // Replaces old account in customer account list with new account
            EditAccount(selectedCustomer, selectedAccount);

            // Removes older instance of the customer in the customer repo and replaces with the new account
            EditCustomer(selectedCustomer, customerID);
        }
        
        //Function to return specific customer from the customer repository
        public Customer SelectCustomerFromCustomerList(int customerID)
        {
            ReadBinaryData(); // Get latest customer repository
            Customer selectedCustomer = (from customer in customerRepo where customer.CustomerNumber == customerID select customer).First();
            return selectedCustomer;
        }

        //Function to select a specific account from a customers account list
        public Account SelectAccountFromAccountList(Customer customer, int accountID)
        {
            ReadBinaryData(); // Get latest customer repository
            Account selectedAccount = (from account in customer.AccountList where account.getAccountID() == accountID select account).First();
            return selectedAccount;
        }

        // Function that allows a customer to transfer money between their own accounts
        public void TransferAmountFromAccountToAccount2(double transferAmount, int customerID, int fromAccountID, int toAccountID) 
        {
            // Selects the relevant customer and accounts
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            Account fromAccount = SelectAccountFromAccountList(selectedCustomer, fromAccountID);
            Account toAccount = SelectAccountFromAccountList(selectedCustomer, toAccountID);

            // Transfer of money between accounts
            fromAccount.Withdraw(transferAmount);
            toAccount.Deposit(transferAmount);

            // Replaces old accounts in customer account list with new accounts
            EditAccount(selectedCustomer, fromAccount);
            EditAccount(selectedCustomer, toAccount);

            // Removes older instance of the customer in the customer repo and replaces with the new account
            EditCustomer(selectedCustomer, customerID);
        }

        // Adds a new account to a customer and saves to customer repo
        public void AddNewAccount(Customer customer, Account account)
        {
            Customer selectedCustomer = SelectCustomerFromCustomerList(customer.CustomerNumber);
            selectedCustomer.AccountList.Add(account);
            EditCustomer(selectedCustomer, customer.CustomerNumber);
        }

        // Writes the customer repository and nextId to a binary file
        public void WriteBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file customers.bin
            Stream stream = new FileStream("customers.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            //use the formatter to serialize the customerRepo and _nextID and send it to the filestream
            formatter.Serialize(stream, customerRepo);
            formatter.Serialize(stream, _nextID);

            //close the file
            stream.Close();
        }

        // Reads the customer repository and nextId from a binary file
        public void ReadBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();
            
            //Create a new IO stream to read to the file customers.bin
            Stream stream = new FileStream("customers.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            //use the formatter to deserialize the customerRepo and _nextID 
            customerRepo = (List<Customer>)formatter.Deserialize(stream);
            _nextID = (int)formatter.Deserialize(stream);

            //close the file
            stream.Close();
        }

        // Function to find the next available customerID. Incrementing from 0.
        public int findAvailableID()
        {
            List<int> customerNumberList = new List<int>();

            // Iterator used to store the customer IDs into a list
            foreach (Customer customer in customerRepo)
            {
                customerNumberList.Add(customer.CustomerNumber);
            }

            // Determines lowest customerID that is not used  
            int firstAvailableID = Enumerable.Range(1, int.MaxValue)
                    .Except(customerNumberList)
                    .FirstOrDefault();

            return firstAvailableID;
        }
    }
}
