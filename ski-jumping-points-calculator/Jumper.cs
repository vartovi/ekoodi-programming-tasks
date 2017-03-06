using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Jumper
    {
        private string _jumperName;
        private double _totalPoints;
        private List<Jump> _jumps = new List<Jump>();

        public double Points
        {
            get { return _totalPoints; }
            set { _totalPoints = value; }
        }

        public Jumper(string jumperName)
        {
            _jumperName = jumperName;
        }

        public void NewJump(string length, string windbonus, string startingpoint, string kPoint, string multiplier)
        {
            var lengthPoints = Calculations.CalculateLenghtPoints(Convert.ToDouble(length), Convert.ToDouble(kPoint), Convert.ToDouble(multiplier));
            var stylePoints = Calculations.CalculateStylepoints();
            var windPoints = Calculations.CalculateWindBonus(Convert.ToDouble(windbonus), Convert.ToDouble(kPoint), Convert.ToDouble(multiplier));
            var startPointPoints = Calculations.CalculateStartpointBonus(Convert.ToDouble(startingpoint), Convert.ToDouble(multiplier));
            var total = lengthPoints + stylePoints + windPoints + startPointPoints;
            Points = Points + total;
            //Console.WriteLine("\nTotal points : " + total);
            _jumps.Add(new Jump(lengthPoints, stylePoints, windPoints, startPointPoints, total));
        }

        public void ShowJumps()
        {
            Console.WriteLine("\nJumps for " + _jumperName);
            var count = 1;
            foreach (var l in _jumps)
            {
                Console.WriteLine(count + ". " + l);
                count++;
            }
                
        }

        public void TotalPoints()
        {
            Console.WriteLine($"Total points: {Points}");
        }
    }
}
