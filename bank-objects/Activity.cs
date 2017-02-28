using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Activity
    {
        private DateTime _timestamp;
        private decimal _amount;

        public Activity(DateTime timestamp, decimal amount)
        {
            _timestamp = timestamp;
            _amount = amount;
        }

        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        public override string ToString()
        {
            return _timestamp + " \t" + _amount;
        }
    }
}
