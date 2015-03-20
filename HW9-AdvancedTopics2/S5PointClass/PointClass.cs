using System;

namespace S5PointClass
{
    class PointClass
    {
        static void Main()
        {
            Point a = new Point(20, 30);
            Point b = new Point(0, 100);

            Console.WriteLine("Your points are: x={0}, y={1}", a.X, a.Y);
            Console.WriteLine("Your points are: x={0}, y={1}", b.X, b.Y);

        }
    }
}
