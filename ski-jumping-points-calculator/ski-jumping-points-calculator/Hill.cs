using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Hill
    {
        
        private readonly List<Result> _results = new List<Result>();

        public Hill(string hillName, string kPoint, string multiplier)
        {
            Name = hillName;
            KPoint = kPoint;
            Multiplier = multiplier;
        }

        public string KPoint { get; set; }

        public string Multiplier { get; set; }

        public string Name { get; set; }

        public void Addresult(double points, string name)
        {
            if (_results.Any(r => r.Name == name))
            {
                var update = _results.FirstOrDefault(r => r.Name == name);
                update.Points = points;
            }
            else
            {
                _results.Add(new Result(name, points));
            }
            
        }

        public IEnumerable<string> GetResults()
        {
            
            foreach (var r in _results.OrderByDescending(o => o.Points))
            {
                yield return $"{r}\n";
            }
        }

        public override string ToString()
        {
            return Name + " " + KPoint + " " + Multiplier;
        }
    }
}
