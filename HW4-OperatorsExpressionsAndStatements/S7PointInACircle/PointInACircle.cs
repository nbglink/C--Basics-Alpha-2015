using System;
using System.Threading;
using System.Globalization;

namespace S7PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine().Replace(',', '.'));

            bool isInside = (x * x) + (y * y) <= (2 * 2);

            Console.WriteLine("These coordinates are inside the circle = " + isInside);
        }
    }
}
