using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointService = new PointService(new PointIconFactory());

            var points = pointService.GetPoints();

            if (points == null)
                throw new Exception("points don't exist");

            foreach (var point in points)
                point.Draw();

            Console.ReadKey();
        }
    }
}
