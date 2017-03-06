using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    class Calculations
    {
        public static Random Rng = new Random();

        public static double CalculateLenghtPoints(double length, double kPoint, double multiplier)
        {
            var points = 0.0;
          
            if (length > kPoint)
            {
                points = 60 + (length - kPoint) * multiplier;
            }

            points = 60 + (length - kPoint) * multiplier;

            //Console.WriteLine("Points from jump length: " + points);
            return points;
        }

        public static double CalculateStylepoints()
        {          
            double[] scores = new double[5];
            var total = 0.0;
            //Console.WriteLine("\nStyle points: ");
            for (int i = 0; i < 5; i++)
            {
                scores[i] = Rng.Next(15, 19) + 0.5*i;
                //Console.Write("[" + scores[i] + "] ");
            }
            Array.Sort(scores);
            //Console.WriteLine("\n\nRemoved min and max:");

            for (int i = 1; i < 4; i++)
            {
                //Console.Write("[" + scores[i] + "] ");
                total += scores[i];
            }

            //Console.WriteLine("\n\nTotal stylepoints: " +  total);
            return total;
        }

        public static double CalculateWindBonus(double wind, double kPoint, double multiplier)
        {
            var windPoints = wind * (kPoint - 36) / 20;
            windPoints *= 2;
            windPoints = Math.Round(windPoints, MidpointRounding.AwayFromZero);
            windPoints /= 2;
            windPoints = windPoints * multiplier;
            //Console.WriteLine("\nWindbonus: " + windPoints);
            return windPoints;
        }

        public static double CalculateStartpointBonus(double startingpoint, double multiplier)
        {
            startingpoint =  startingpoint * 5 * multiplier * -1;
            //Console.WriteLine("\nStartpointbonus: " + startingpoint);          
            return startingpoint;
        }
    }
}
