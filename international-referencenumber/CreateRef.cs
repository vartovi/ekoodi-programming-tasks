using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_referencenumber
{
    class CreateRef
    {      
        public static string CreateRefNum(string refNumber)
        {
            var originalRef = refNumber;
            refNumber = refNumber + "2715" + "00";
            var toDecimal = 98 - Convert.ToDecimal(refNumber) % 97;
            var checksum = toDecimal;

            if (checksum < 10)
            {
                var cheksum = Convert.ToString(toDecimal).PadLeft(2, '0');
            }
               
            return "Your international referencenumber is: RF" + checksum + originalRef;
        }
    }
}
