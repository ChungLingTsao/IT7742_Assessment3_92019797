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
        private static CustomerRepository _instance = null;
        int _nextID = 1;

        List<Customer> customerRepo = new List<Customer>();

        public static CustomerRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new CustomerRepository();

                /* The following customer data has been transfered to the serialized binary file 'customers.bin' */

                //Customer customer1 = new Customer(1, "Charles Tsao", "02102557711", "ctsa181@mywhitecliffe.com", "123 Somewhere Street", "Burnside", "Christchurch", "8053", true);
                //Customer customer2 = new Customer(2, "Brady Phelps", "0823916128", "Maecenas.mi.felis@laoreetlectusquis.com", "Ap #972-6122 Sem Rd", "Maule", "Yerbas Buenas", "3809", false);
                //Customer customer3 = new Customer(3, "Xavier Stout", "0287944623", "mollis.Integer.tincidunt@arcuvelquam.net", "Ap #949-2417 Mauris Road", "BOL", "Magangue", "51405", false);
                //Customer customer4 = new Customer(4, "Daniel Thornton", "0769944547", "sapien.cursus.in@elitsed.edu", "894 - 9952 Curabitur Avenue", "ANT", "Itagüí", "6354", false);
                //Customer customer5 = new Customer(5, "Christopher Francis", "0499006135", "augue.eu.tellus@Donec.edu", "947 Sagittis Rd", "ANC", "Huaraz", "195334", true);

                //_instance.customerRepo.Add(customer1);
                //_instance.customerRepo.Add(customer2);
                //_instance.customerRepo.Add(customer3);
                //_instance.customerRepo.Add(customer4);
                //_instance.customerRepo.Add(customer5);
            }
            return _instance;
        }

        public void AddNewCustomer(Customer newCustomer)
        {
            if (newCustomer.Name == "")
            {
                throw new InvalidCustomerException();
            }
            else
            {
                customerRepo.Add(newCustomer);
                _nextID++;
                WriteBinaryData();
            }
        }

        public void EditCustomer(Customer editedCustomer, int previousID)
        {
            if (editedCustomer.Name == "")
            {
                throw new InvalidCustomerException();
            }
            else
            {
                customerRepo.RemoveAll(Customer => Customer.CustomerNumber == previousID);

                customerRepo.Add(editedCustomer);
                
                //foreach (Customer uneditedcustomer in customerRepo)
                //{
                //    if (uneditedcustomer.CustomerNumber == editedCustomer.CustomerNumber)
                //    {
                //        customerRepo.Remove(uneditedcustomer);
                //    }
                //}
            }
            WriteBinaryData();
        }

        public void DeleteCustomer(int deleteCustomerID)
        {
            customerRepo.RemoveAll(Customer => Customer.CustomerNumber == deleteCustomerID);
            WriteBinaryData();
        }

        public void EditAccount(Customer editedCustomer, int previousID)
        {
            if (editedCustomer.Name == "")
            {
                throw new InvalidCustomerException();
            }
            else
            {
                customerRepo.RemoveAll(Customer => Customer.CustomerNumber == previousID);

                customerRepo.Add(editedCustomer);

                //foreach (Customer uneditedcustomer in customerRepo)
                //{
                //    if (uneditedcustomer.CustomerNumber == editedCustomer.CustomerNumber)
                //    {
                //        customerRepo.Remove(uneditedcustomer);
                //    }
                //}
            }
            WriteBinaryData();
        }

        public List<Customer> GetAllCustomers()
        {
            ReadBinaryData();
            return this.customerRepo;
        }

        public List<Account> GetAccountListByCustomerId(int customerID)
        {
            ReadBinaryData();
            Customer c = (from customer in customerRepo where customer.CustomerNumber == customerID select customer).First();

            return c.AccountList;
        }

        public void DepositTransactionToCustomerAccount(double deposit, int customerID, int accountID)
        {
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            //Customer c = (from customer in customerRepo where customer.CustomerNumber == customerID select customer).First();
            Account selectedAccount = SelectAccountFromAccountList(selectedCustomer, accountID);
            //Account a = (from account in c.AccountList where account.getAccountID() == accountID select account).First();

            selectedAccount.Deposit(deposit);

            selectedCustomer.AccountList.RemoveAll(Account => Account.getAccountID() == accountID);
            selectedCustomer.AccountList.Add(selectedAccount);

            EditCustomer(selectedCustomer, customerID);
        }

        public void WithdrawTransactionFromCustomerAccount(double debit, int customerID, int accountID)
        {
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            Account selectedAccount = SelectAccountFromAccountList(selectedCustomer, accountID);

            selectedAccount.Withdraw(debit);

            selectedCustomer.AccountList.RemoveAll(Account => Account.getAccountID() == accountID);
            selectedCustomer.AccountList.Add(selectedAccount);

            EditCustomer(selectedCustomer, customerID);
        }

        public void RecordTransactionToTransactionList(Transaction transaction, int customerID, int accountID)
        {
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            Account selectedAccount = SelectAccountFromAccountList(selectedCustomer, accountID);

            selectedAccount.TransactionsList.Add(transaction);

            selectedCustomer.AccountList.RemoveAll(Account => Account.getAccountID() == accountID);
            selectedCustomer.AccountList.Add(selectedAccount);

            EditCustomer(selectedCustomer, customerID);
        }
        

        public Customer SelectCustomerFromCustomerList(int customerID)
        {
            ReadBinaryData();
            Customer selectedCustomer = (from customer in customerRepo where customer.CustomerNumber == customerID select customer).First();

            return selectedCustomer;
        }

        public Account SelectAccountFromAccountList(Customer customer, int accountID)
        {
            ReadBinaryData();
            Account selectedAccount = (from account in customer.AccountList where account.getAccountID() == accountID select account).First();
            return selectedAccount;
        }

        public void TransferAmountFromAccountToAccount2(double transferAmount, int customerID, int fromAccountID, int toAccountID) 
        {
            Customer selectedCustomer = SelectCustomerFromCustomerList(customerID);
            
            Account fromAccount = SelectAccountFromAccountList(selectedCustomer, fromAccountID);
            Account toAccount = SelectAccountFromAccountList(selectedCustomer, toAccountID);

            fromAccount.Withdraw(transferAmount);
            toAccount.Deposit(transferAmount);

            selectedCustomer.AccountList.RemoveAll(Account => Account.getAccountID() == fromAccountID);
            selectedCustomer.AccountList.Add(fromAccount);
            selectedCustomer.AccountList.RemoveAll(Account => Account.getAccountID() == toAccountID);
            selectedCustomer.AccountList.Add(toAccount);

            EditCustomer(selectedCustomer, customerID);
        }

        public void AddNewAccount(Customer customer, Account account)
        {
            Customer selectedCustomer = SelectCustomerFromCustomerList(customer.CustomerNumber);
            selectedCustomer.AccountList.Add(account);
            EditCustomer(selectedCustomer, customer.CustomerNumber);
        }

        public void WriteBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("customers.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            //use the formatter to serialize the customerRepo and _nextID and send it to the filestream
            formatter.Serialize(stream, customerRepo);
            formatter.Serialize(stream, _nextID);

            //close the file
            stream.Close();
        }

        public void ReadBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("customers.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            customerRepo = (List<Customer>)formatter.Deserialize(stream);
            _nextID = (int)formatter.Deserialize(stream);
 //           Console.WriteLine(_nextID);
            stream.Close();
        }

        public int getNextID()
        {
            return _nextID;
        }

        public int findAvailableID()
        {
            List<int> customerNumberList = new List<int>();

            //var sortedCustomerList = customerRepo.OrderBy(c => c.CustomerNumber).ToList();

            // Iterator used to determine lowest customerID that is not used
            foreach (Customer customer in customerRepo)
            {
                customerNumberList.Add(customer.CustomerNumber);
            }

            int firstAvailableID = Enumerable.Range(1, int.MaxValue)
                    .Except(customerNumberList)
                    .FirstOrDefault();
            Console.WriteLine(customerNumberList.Count);
            return firstAvailableID;
        }
    }
}
