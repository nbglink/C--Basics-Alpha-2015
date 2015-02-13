using System;
using System.Threading;
using System.Globalization;

namespace S3CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter radius r: ");
            double r = double.Parse(Console.ReadLine().Replace(',', '.'));

            double perimeter = 2 * Math.PI * r;

            double area = Math.PI * r * r;


            Console.Write("Perimeter is: ");
            Console.WriteLine("{0:F2}",perimeter);
            Console.Write("Area is: ");
            Console.WriteLine("{0:F2}",area);

        }
    }
}
