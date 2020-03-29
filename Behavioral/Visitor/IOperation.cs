using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IOperation
    {
        void Apply(HeadingNode heading);
        void Apply(AnchorNode anchor);
    }
}
