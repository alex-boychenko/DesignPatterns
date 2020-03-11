using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var auditTrail = new AuditTrail();

            var transferMoneyTask = new TransferMoneyTask();
            transferMoneyTask.Execute(auditTrail);

            var generateReportTask = new GenerateReportTask();
            generateReportTask.Execute(auditTrail);

            Console.ReadKey();
        }
    }
}
