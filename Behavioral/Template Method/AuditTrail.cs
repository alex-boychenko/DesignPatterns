using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    public class AuditTrail : IAuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit record");
        }
    }
}
