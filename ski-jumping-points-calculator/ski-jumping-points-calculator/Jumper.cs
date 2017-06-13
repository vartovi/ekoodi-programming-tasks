using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Jumper
    {
        private readonly List<Jump> _jumps = new List<Jump>();

        public double Points { get; set; }

        public string JumperName { get; set; }

        public Jumper(string jumperName)
        {
            JumperName = jumperName;
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

        public IEnumerable<string> ShowJumps()
        {
            var count = 0;
            foreach (var l in _jumps)
            {
                count = count+1;
                yield return $"{count}. {l}\n";
            }           
        }

        public string TotalPoints()
        {
            return $"Total points: {Points}\n";
        }
    }
}
