using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!icons.ContainsKey(pointType))
                icons[pointType] = new PointIcon(pointType, null);

            return icons[pointType];

        }

    }
}
