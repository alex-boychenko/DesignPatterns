using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    public class GenerateReportTask : Task
    {
        protected override void Operation()
        {
            Console.WriteLine("Generate report");
        }
    }
}
