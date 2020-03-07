using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var contentMonitor = new ContentMonitor();

            IFilter customFilter = new CustomFilter();
            contentMonitor.Monitor(customFilter);
            

            var thirdPartyFilter = new ThirdPartyFilter();
            IFilter thirdPartyFilterAdapter = new ThirdPartyFilterAdapter(thirdPartyFilter);
            contentMonitor.Monitor(thirdPartyFilterAdapter);

            Console.ReadKey();
        }
    }
}
