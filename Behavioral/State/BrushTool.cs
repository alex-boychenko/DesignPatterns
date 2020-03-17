using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
