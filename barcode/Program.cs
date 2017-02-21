using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            String iban = "";
            String total;
            String referenceNum;
            String dueDate;
            Decimal checksum = 0;
            String versNum = "4";
            String barcode;
            string startSign = "105";
            string stopSign = "stop";
            bool valid = false;

            do
            {
                Console.Write("Write account number (IBAN): ");
                iban = Console.ReadLine();
                iban = Regex.Replace(iban, @"[^\d]", "");
                if (iban.Length != 16)
                {
                    Console.WriteLine("Invalid Account number\n");
                }
                else
                {
                    valid = true;
                }
            } while (!valid);

            do
            {
                Console.Write("\nWrite total sum of the invoice with 2 decimals: ");
                total = Console.ReadLine();
                
                if (!total.Contains(','))
                {
                    Console.WriteLine("Invalid total sum");
                    valid = false;
                }
                else
                {
                    total = Regex.Replace(total, @"[^\d]", "");
                    total = total.PadLeft(8, '0');
                    valid = true;
                }
            } while (!valid);

            do
            {
                
                Console.Write("\nWrite the reference number: ");
                referenceNum = Console.ReadLine();
                referenceNum = Regex.Replace(referenceNum, @"[^\d]", "");
                referenceNum = referenceNum.PadLeft(23, '0');
                if (referenceNum.Length > 23)
                {
                    Console.WriteLine("Invalid reference number");
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            } while (!valid);

            do
            {
                Console.Write("\nWrite due date (ie. " + DateTime.Now.ToString("dd.MM.yyyy") + "): ");
                dueDate = Console.ReadLine();
                string[] dates = dueDate.Split('.');
                dueDate = dates[2].Substring(2) + dates[1] + dates[0];
                if (dueDate.Length != 6)
                {
                    Console.WriteLine("Invalid date number");
                    valid = false;
                }
                else
                {
                    barcode = versNum + iban + total + referenceNum + dueDate;
                    checksum = 105;
                    int count = 0;
                    Console.Write("\n[" + startSign + "]");
                    for (int i = 1; i < 28; i++)
                    {
                        checksum = checksum + (Convert.ToDecimal(barcode.Substring(count, 2)) * i);
                        Console.Write((" " + barcode.Substring(count, 2)));
                        count = count + 2;

                    }
                    checksum = checksum % 103;
                    Console.Write(" [" + checksum + "] [" + stopSign + "]");

                    //Console.WriteLine("[" + startSign + "]" + versNum + iban + total + referenceNum + dueDate + "[" + checksum + "]" + "[" + stopSign + "]");
                    valid = true;
                }
            } while (!valid);    
              
            Console.ReadKey();

        }
    }
}
