using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Account
    {
        private string _accountNmbr;
        private string _activity;
        private decimal _total;
        

        public Account(string accountnumber)
        {
            _accountNmbr = accountnumber;
        }

        public string GetAccountNumber()
        {
            return _accountNmbr;
        }

    }
}
