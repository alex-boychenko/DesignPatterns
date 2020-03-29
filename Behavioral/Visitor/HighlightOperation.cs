using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}
