using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace international_referencenumber
{
    class CheckRef
    {
        public static string CheckRefNum(string refNumber)
        {
            if (!refNumber.Contains("RF"))
            {
                return "Invalid referencenumber. Please add RF";
            }
            refNumber = LettersToNumbers(refNumber);
            refNumber = Regex.Replace(refNumber, @"[^\d]", "");
            var toDecimal = Convert.ToDecimal(refNumber) % 97;

            if (toDecimal == 1)
            {
                return "Your referencenumber is correct\nChecksum = " + toDecimal;
            }

            return "Your referencenumber is incorrect\nCheckum " + toDecimal + " needs to be 1";

        }

        public static string LettersToNumbers(string refNumber)
        {
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z' };

            refNumber = refNumber.Substring(4) + refNumber.Substring(0, 4);

            for (int i = 0; i < 25; i++)
            {
                int replacement = 10 + i;
                refNumber = Regex.Replace(refNumber, Convert.ToString(letters[i]), Convert.ToString(replacement));
            }

            return refNumber;
        }
    }
}
