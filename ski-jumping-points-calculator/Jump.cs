using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Jump
    {
        private double _length;
        private double _style;
        private double _windBonus;
        private double _startPoint;
        private double _points;

        public Jump(double length, double style, double windBonus, double startPoint, double points)
        {
            _length = length;
            _style = style;
            _windBonus = windBonus;
            _startPoint = startPoint;
            _points = points;
        }

        public override string ToString()
        {
            return
                $"Jump: {_length} style: {_style} wind: {_windBonus} start {_startPoint} Points: {_points}";
        }
    }
}
