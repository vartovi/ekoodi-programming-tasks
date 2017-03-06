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
            var hill1 = new Hill("Lahden suurmäki", "116", "1,8");

            var jumper1 = new Jumper("Jumper A");
            var jumper2 = new Jumper("Jumper B");
            var jumper3 = new Jumper("Jumper C");

            // NewJump(jump length, wind avarage +/-, starting point +/-, K-point, points multiplier)
            jumper1.NewJump("124", "1,4", "1,4", hill1.KPoint, hill1.Multiplier);
            jumper1.NewJump("117", "-1,0", "-1,4", hill1.KPoint, hill1.Multiplier);
            jumper1.ShowJumps();
            jumper1.TotalPoints();

            jumper2.NewJump("130", "2,0", "1,2", hill1.KPoint, hill1.Multiplier);
            jumper2.NewJump("129", "0,5", "0,2", hill1.KPoint, hill1.Multiplier);
            jumper2.ShowJumps();
            jumper2.TotalPoints();

            Console.ReadKey();
        }
    }
}
