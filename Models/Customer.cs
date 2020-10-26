/* 
 * Customer.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Used to represent any customer of the banking system.
 *              This class requires all the information the bank needs from the customer to
 *              open a bank account. This class would also hold a list of accounts open by 
 *              the customer in the form of an account ID list.
*/
using System.Collections.Generic;

namespace Assessment2
{
    public class Customer
    {
        private int _customerNumber;
        private string _name;
        private string _phone;
        private string _email;
        private string _address;
        private string _suburb;
        private string _city;
        private string _zip;
        private bool _isStaff; // Used to adjust failed transaction fees

        private List<int> _accountList; // A customer should be able to have any number of accounts.

        public int CustomerNumber { get => _customerNumber; set => _customerNumber = value; }
        public string Name { get => _name; set => _name = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Address { get => _address; set => _address = value; }
        public string Suburb { get => _suburb; set => _suburb = value; }
        public string City { get => _city; set => _city = value; }
        public string Zip { get => _zip; set => _zip = value; }
        public bool IsStaff { get => _isStaff; set => _isStaff = value; }

        public Customer(int customerNumber, string name, string phone, string email, string address, string suburb, string city, string zip, bool isStaff)
        {
            _customerNumber = customerNumber;
            _name = name;
            _phone = phone;
            _email = email;
            _address = address;
            _suburb = suburb;
            _city = city;
            _zip = zip;
            _isStaff = isStaff;

            _accountList = new List<int>();
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Customer Number: {1}, Is Staff: {2}", _name, _customerNumber, _isStaff.ToString());
        }

        //public List<int> Accounts
        //{
        //    get { return _accountList; }
        //    set { _accountList = value; }
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        // Implement getters and setters as necessary...
    }
}
