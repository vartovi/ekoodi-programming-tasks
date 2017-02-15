using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_price_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            int number = 0;
            string userName = Console.ReadLine();
            Console.WriteLine("\nHello {0} please select: ", userName);
            Console.WriteLine("1 = Normal price 16e \n2 = Under 7 years of age free \n3 = age 65 or more -50% \n4 = age 7-15 -50% \n5 = Member of mtk -15% \n6 = Military service -50% \n7 = student -45%\n");
            bool userSelection = int.TryParse(Console.ReadLine(), out number);
            if (!userSelection || number > 7)
            {
                Console.WriteLine("Incorrect selection");
            }
            else
            {
                double ticket = 16;
                if (number == 1)
                {
                    Console.WriteLine("Your ticket is {0} euros", ticket);
                }
                if (number == 2)
                {
                    Console.WriteLine("Your ticket is free");
                }
                if (number == 5)
                {
                    ticket = ticket - ticket * 0.15;
                    Console.WriteLine("Your ticket is {0} euros", ticket);
                }
                if (number == 7)
                {
                    Console.WriteLine("Are you a member of mtk? yes/no");
                    string choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        ticket = ticket - ticket * 0.45;
                        ticket = ticket - ticket * 0.15;
                        Console.WriteLine("Your ticket is {0} euros", ticket);
                    }
                    if (choice == "no")
                    {
                        ticket = ticket - ticket * 0.45;
                        Console.WriteLine("Your ticket is {0} euros", ticket);
                    }
                    
                }
                if (number == 3 || number == 4 || number == 6)
                {
                    ticket = ticket * 0.50;
                    Console.WriteLine("Your ticket is {0} euros", ticket);
                }
                
                
            }
            Console.ReadKey();
        }
    }
}
