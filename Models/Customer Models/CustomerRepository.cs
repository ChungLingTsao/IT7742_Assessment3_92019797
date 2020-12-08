/* 
 * CustomerRepository.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: A repository class for holding the data and providing access. 
 *              Normally, the application would be connected to a database.
*/
using System.Collections.Generic;

namespace Assessment3
{
    class CustomerRepository
    {
        private static CustomerRepository _instance = null;

        List<Customer> customerRepo = new List<Customer>();

        public static CustomerRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new CustomerRepository();
                Customer customer1 = new Customer(1, "Charles Tsao", "02102557711", "ctsa181@mywhitecliffe.com", "123 Somewhere Street", "Burnside", "Christchurch", "8053", true);
                Customer customer2 = new Customer(2, "Brady Phelps", "0823916128", "Maecenas.mi.felis@laoreetlectusquis.com", "Ap #972-6122 Sem Rd", "Maule", "Yerbas Buenas", "3809", false);
                Customer customer3 = new Customer(3, "Xavier Stout", "0287944623", "mollis.Integer.tincidunt@arcuvelquam.net", "Ap #949-2417 Mauris Road", "BOL", "Magangue", "51405", false);
                Customer customer4 = new Customer(4, "Daniel Thornton", "0769944547", "sapien.cursus.in@elitsed.edu", "894 - 9952 Curabitur Avenue", "ANT", "Itagüí", "6354", false);
                Customer customer5 = new Customer(5, "Christopher Francis", "0499006135", "augue.eu.tellus@Donec.edu", "947 Sagittis Rd", "ANC", "Huaraz", "195334", true);

                _instance.customerRepo.Add(customer1);
                _instance.customerRepo.Add(customer2);
                _instance.customerRepo.Add(customer3);
                _instance.customerRepo.Add(customer4);
                _instance.customerRepo.Add(customer5);
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
        }

        public void DeleteCustomer(int deleteCustomerID)
        {
            customerRepo.RemoveAll(Customer => Customer.CustomerNumber == deleteCustomerID);
        }

        public List<Customer> GetAllCustomers()
        {
            return this.customerRepo;
        }
    }
}
