using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Point
    {
        private readonly double _x;
        private readonly double _y;
        private readonly PointIcon _pointIcon;

        public Point(double x, double y, PointIcon pointIcon)
        {
            _x = x;
            _y = y;
            _pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"{_pointIcon.PointType} at ({_x},{_y})");
        }

    }
}
