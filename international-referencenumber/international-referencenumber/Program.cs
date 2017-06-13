using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace international_referencenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select: \n1:Check international referencenumber \n2:Create international referencenumber");
            int userInput = Convert.ToInt16(Console.ReadLine());
            string message;

            switch (userInput)
            {
                case 1:
                    Console.Write("Write international referencenumber to check: ");
                    var refToCheck = Console.ReadLine();
                    message = CheckRef.CheckRefNum(refToCheck);
                    Console.WriteLine(message);
                    break;
                case 2:
                    Console.Write("Write regular referencenumber: ");
                    var refToCreate = Console.ReadLine();
                    message = CreateRef.CreateRefNum(refToCreate);
                    Console.WriteLine(message);
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
            Console.ReadKey();
        }
    }
}
