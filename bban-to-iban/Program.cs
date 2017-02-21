﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace bban_to_iban
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write account number (BBAN): ");

            string accountNumber = Console.ReadLine();
            string iban = "";
            string countryCode = "FI";
            string countryCodeNum = countryCode;
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z' };
            int replacement;
            decimal checksum = 0;

            if (accountNumber.Contains('-'))
            {
                string[] numbers = accountNumber.Split('-');
                accountNumber = numbers[0] + numbers[1];
            }

            Console.WriteLine(14 - accountNumber.Length);

            if (accountNumber[0] == '4' || accountNumber[0] == '5')
            {
                accountNumber = accountNumber.Substring(0, 7) + "00000" + accountNumber.Substring(7);
            }
            else
            {
               accountNumber = accountNumber.Substring(0, 6) + "00000" + accountNumber.Substring(6);
            }

            
            // Calculate checksum using Luhn-algorithm
            string number = "";
            int total = 0;
            int addition = 0;
            int count = 1;
            foreach (char c in accountNumber)
            {
                number = Convert.ToString(c);
                if (accountNumber.Length == count)
                {
                    addition = 0;
                }
                else if (count % 2 == 0)
                {
                    addition = Convert.ToInt32(number);
                }
                else
                {
                    addition = (Convert.ToInt32(number) * 2);
                    int a = addition / 10;
                    int b = addition % 10;
                    addition = a + b;
                }

                total = total + addition;
                count = count + 1;
            }

            total = 10 - (total % 10);
            Console.WriteLine("Checksum: " + total);


            for (int i = 0; i < 25; i++)
            {
                replacement = 10 + i;
                countryCodeNum = Regex.Replace(countryCodeNum, Convert.ToString(letters[i]), Convert.ToString(replacement));
            }

            accountNumber = accountNumber + countryCodeNum + "00";

            if (decimal.TryParse(accountNumber, out checksum))
            {
                checksum = 98 - (checksum % 97);
                if (checksum < 10)
                {
                    iban = countryCode + "0" + checksum + accountNumber;
                }
                else
                {
                    iban = countryCode + checksum + accountNumber;
                    iban = iban.Replace(countryCodeNum, "");
                    Console.WriteLine("\nYour IBAN-number is: " + iban.Substring(0, 4) + " " + iban.Substring(4, 4) + " " + iban.Substring(8, 4) + " " + iban.Substring(12, 4) + " " + iban.Substring(16, 2));
                }
                
            }
            else
            {
                Console.WriteLine("Input was not a valid number");
            }
            
            Console.ReadKey();
            
        }
    }
}

