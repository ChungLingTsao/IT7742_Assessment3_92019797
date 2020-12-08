/* 
 * ContactDetails.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: This class is an association relationship with the Customer class.
 *              It is used to provide more specific info about the customer
 *              (i.e. instead of a long unstructured contactDetails string).
*/

namespace IT7742_Assessment1_92019797
{
    class ContactDetails
    {
        private string _phone;
        private string _email;
        private string _address;

        //Constructor 
        public ContactDetails(string phone, string email, string address)
        {
            _phone = phone;
            _email = email;
            _address = address;
        }

        // Implement getters and setters as necessary...
    }
}
