using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Activity
    {
        private string _timestamp;
        private decimal _balance;
        private decimal _amount;

        public Activity (string timestamp, decimal total, decimal amount)
        {
            _timestamp = timestamp;
            _balance = total;
            _amount = amount;
        }
    }
}
