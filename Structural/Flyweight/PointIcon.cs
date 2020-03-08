using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointIcon
    {
        public PointType PointType { get; }

        private readonly byte[] _icon;

        public PointIcon(PointType pointType, byte[] icon)
        {
            PointType = pointType;
            _icon = icon;
        }

    }
}
