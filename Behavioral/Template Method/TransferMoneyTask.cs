using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    public class TransferMoneyTask : Task
    {
        protected override void Operation()
        {
            Console.WriteLine("Transfer money");
        }
    }
}
