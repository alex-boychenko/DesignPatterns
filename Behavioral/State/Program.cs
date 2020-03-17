using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas(new SelectionTool());
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.ChangeTool(new BrushTool());
            canvas.MouseDown();
            canvas.MouseUp();

            Console.ReadKey();
        }
    }
}
