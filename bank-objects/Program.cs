using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Program
    {       
        static void Main(string[] args)
        {              
            var bank1 = new Bank("Nordea");
            
            var customer1 = new Customer("Matti", "Meikäläinen");
            var customer2 = new Customer("Teppo", "Testaaja");
            var customer3 = new Customer("Pekka", "Pouta");

            customer1.AccountNumber = bank1.NewAccount();
            customer2.AccountNumber = bank1.NewAccount();
            customer3.AccountNumber = bank1.NewAccount();

            Console.WriteLine(bank1.RetrieveData()+ "\n");
            Console.WriteLine(customer1+ "\n");
            Console.WriteLine(customer2 + "\n");
            Console.WriteLine(customer3 + "\n");

            Console.ReadKey();

        }

    }
}
