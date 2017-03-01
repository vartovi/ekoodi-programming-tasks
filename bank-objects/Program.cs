using System;
using System.Collections.Generic;
using System.Dynamic;
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

            var customer1 = new Customer("Matti", "Meikäläinen") {AccountNumber = bank1.NewAccount()};
            var customer2 = new Customer("Teppo", "Testaaja") {AccountNumber = bank1.NewAccount()};
            var customer3 = new Customer("Pekka", "Pouta") {AccountNumber = bank1.NewAccount()};

            Console.WriteLine("Created new " + bank1);
            Console.WriteLine("\nCreated 3 customers for bank:");
            Console.WriteLine("\n" + customer1);
            Console.WriteLine("\n" + customer2);
            Console.WriteLine("\n" + customer3);

            // Add some money to accounts
            bank1.NewTransaction(customer1.AccountNumber, +3425);
            bank1.NewTransaction(customer2.AccountNumber, +2254);
            bank1.NewTransaction(customer3.AccountNumber, +1500);

            Random rnd = new Random();

            // Remove random amounts of money
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i == 1)
                        bank1.NewTransaction(customer1.AccountNumber, rnd.Next(-150, -10));
                    if (i == 2)
                        bank1.NewTransaction(customer2.AccountNumber, rnd.Next(-150, -10));
                    if (i == 3)
                        bank1.NewTransaction(customer3.AccountNumber, rnd.Next(-150, -10));
                }
            }
            
            // Get transactions
            bank1.GetAllTransactions(customer1.AccountNumber);
            bank1.GetBalance(customer1.AccountNumber);
            bank1.GetAllTransactions(customer2.AccountNumber);
            bank1.GetBalance(customer2.AccountNumber);
            bank1.GetAllTransactions(customer3.AccountNumber);
            bank1.GetBalance(customer3.AccountNumber);

            // Get transactions between given dates
            bank1.GetTransactions(customer1.AccountNumber, "28.2.2017", "1.8.2017");
            
            Console.ReadKey();
        }

    }
}
