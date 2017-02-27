using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Account
    {
        private string _account;
        private string _activity;
        private decimal _balance;

        public Account(string account)
        {
            _account = account;
        }

        public string Activity
        {
            get { return _activity; }
            set { _activity = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
