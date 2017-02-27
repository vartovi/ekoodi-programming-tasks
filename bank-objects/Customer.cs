using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Customer
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private string _accountNumber;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value;  }
        }
        public Customer(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }

        public override string ToString()
        {
            return $"Firstname: {_firstName}\nLastname: {_lastName}\nAccountumber: {_accountNumber}";
        }
    }
}
