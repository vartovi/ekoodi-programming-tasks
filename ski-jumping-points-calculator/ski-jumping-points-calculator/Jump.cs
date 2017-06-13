using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_jumping_points_calculator
{
    public class Jump
    {
        private readonly double _length;
        private readonly double _style;
        private readonly double _windBonus;
        private readonly double _startPoint;
        private readonly double _points;

        public Jump(double length, double style, double windBonus, double startPoint, double points)
        {
            _length = length;
            _style = style;
            _windBonus = windBonus;
            _startPoint = startPoint;
            _points = points;
        }

        public double Length
        {
            get { return _length; }
        }

        public double Style
        {
            get { return _style; }
        }

        public double WindBonus
        {
            get { return _windBonus; }
        }

        public double StartPoint
        {
            get { return _startPoint; }
        }

        public double Points
        {
            get { return _points; }
        }

        public override string ToString()
        {
            return
                $"Jump: {_length}  style: {_style:F1}  wind: {_windBonus:F1}  gate: {_startPoint:F1}  Points: {_points}";
        }
    }
}
