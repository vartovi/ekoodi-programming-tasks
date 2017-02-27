using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Bank
    {
        private readonly string _name;
        private string _accounts;
        Random rnd = new Random();

        public Bank(String name)
        {
            _name = name;
        }

        public String RetrieveData()
        {
            return $"Pankki: {_name}";
        }

        public String NewAccount()
        {
            _accounts =  GenerateAccNmbr();
            return _accounts;
        }

        private string GenerateAccNmbr()
        {       
            return "FI" + rnd.Next(10000000, 99999999) + rnd.Next(10000000, 99999999);
        }

    }
}
