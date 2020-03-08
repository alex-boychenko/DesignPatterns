using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointService
    {
        private PointIconFactory _pointIconFactory;

        public PointService(PointIconFactory pointIconFactory)
        {
            _pointIconFactory = pointIconFactory;
        }
        public List<Point> GetPoints()
        {
            var points = new List<Point>
            {
                new Point(1, 2, _pointIconFactory.GetPointIcon(PointType.Cafe)),
                new Point(4, 5, _pointIconFactory.GetPointIcon(PointType.Cinema))
            };

            return points;
        }

    }
}
