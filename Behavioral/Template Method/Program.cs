using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var auditTrail = new AuditTrail();

            var transferMoneyTask = new TransferMoneyTask();
            transferMoneyTask.Excecute(auditTrail);

            var generateReportTask = new GenerateReportTask();
            generateReportTask.Excecute(auditTrail);

            Console.ReadKey();
        }
    }
}
