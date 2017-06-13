using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Activity
    {
        private decimal _amount;

        public DateTime Timestamp { get; set; }

        public Activity(DateTime timestamp, decimal amount)
        {
            Timestamp = timestamp;
            _amount = amount;
        }
      
        public override string ToString()
        {
            return Timestamp.ToString("dd.MM.yyyy H:mm:ss") + " \t" + _amount;
        }
    }
}
