using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    public abstract class Task
    {
        public void Execute(IAuditTrail auditTrail)
        {
            auditTrail.Record();
            Operation();
        }

        protected abstract void Operation();
    }
}
