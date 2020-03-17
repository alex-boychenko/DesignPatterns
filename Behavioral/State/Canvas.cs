using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Canvas
    {
        private ITool CurrentTool { get; set; }
        public Canvas(ITool tool)
        {
            CurrentTool = tool;
        }

        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }

        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }

        public void ChangeTool(ITool tool)
        {
            CurrentTool = tool;
        }
    }
}
