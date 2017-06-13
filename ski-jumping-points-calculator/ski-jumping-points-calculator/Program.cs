using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hill1 = new Hill("Lahti", "116", "1,8");

            var jumper1 = new Jumper("Jumper A");
            var jumper2 = new Jumper("Jumper B");
            var jumper3 = new Jumper("Jumper C");

            // NewJump(jump length, wind avarage +/-, starting point +/-, K-point, points multiplier)
            jumper1.NewJump("124", "1,4", "1,4", hill1.KPoint, hill1.Multiplier);
            jumper1.NewJump("117", "-1,0", "-1,4", hill1.KPoint, hill1.Multiplier);
            Console.WriteLine("\nJumps for " + jumper1.JumperName);
            foreach (var item in jumper1.ShowJumps())
                Console.Write(item);
                                  
            Console.WriteLine(jumper1.TotalPoints());

            hill1.Addresult(jumper1.Points, jumper1.JumperName);

            jumper2.NewJump("130", "2,0", "1,2", hill1.KPoint, hill1.Multiplier);
            jumper2.NewJump("129", "0,5", "0,2", hill1.KPoint, hill1.Multiplier);
            foreach (var item in jumper2.ShowJumps())
                Console.Write(item);

            Console.WriteLine(jumper2.TotalPoints());

            hill1.Addresult(jumper2.Points, jumper2.JumperName);

            jumper3.NewJump("110", "1,0", "1,3", hill1.KPoint, hill1.Multiplier);
            jumper3.NewJump("140", "0,0", "2,2", hill1.KPoint, hill1.Multiplier);
            foreach (var item in jumper3.ShowJumps())
                Console.Write(item);

            Console.WriteLine(jumper3.TotalPoints());

            hill1.Addresult(jumper3.Points, jumper3.JumperName);

            Console.WriteLine("\nResults for {0} {1:dd.MM.yyyy}", hill1.Name, DateTime.Now);
            Console.WriteLine("Name:\t\tPoints:");
            foreach (var item in hill1.GetResults())
                Console.Write(item);

            Console.ReadKey();
        }
    }
}
