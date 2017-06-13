using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Result
    {
        private readonly string _name;

        public Result(string name, double points)
        {
            _name = name;
            Points = points;
        }

        public string Name => _name;

        public double Points { get; set; }

        public override string ToString()
        {
            return _name + "\t\t" + Points;
        }
    }
}
