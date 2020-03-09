using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var spreadSheet = new SpreadSheet();
            var chart = new Chart();

            var dataSource = new DataSource();
            dataSource.AddObserver(spreadSheet);
            dataSource.AddObserver(chart);

            dataSource.Value = 10;
            dataSource.RemoveObserver(chart);
            dataSource.Value = 20;

            Console.ReadKey();
        }
    }
}
