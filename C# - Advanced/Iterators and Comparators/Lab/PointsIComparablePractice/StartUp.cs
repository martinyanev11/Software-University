using System;

namespace PointsIComparablePractice
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[] 
            {
                new Point(5, 20),
                new Point(5, 20),
                new Point(11, 20),
                new Point(1, 20),
                new Point(1, 240),
                new Point(114, 20),
                new Point(1, 20515),
                new Point(551, 20),
                new Point(135, 20),
            };

            Array.Sort(points);
            foreach (Point point in points)
            {
                Console.WriteLine(point);
            }
        }
    }
}
