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
        private decimal _total;

        public Activity (string timestamp, decimal total)
        {
            _timestamp = timestamp;
            _total = total;
        }
    }
}
