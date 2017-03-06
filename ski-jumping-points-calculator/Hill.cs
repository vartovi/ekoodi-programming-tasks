using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Hill
    {
        private string _hillName;

        public Hill(string hillName, string kPoint, string multiplier)
        {
            _hillName = hillName;
            KPoint = kPoint;
            Multiplier = multiplier;
        }

        public string KPoint { get; set; }

        public string Multiplier { get; set; }
    }
}
