using System;
using System.Threading;
using System.Globalization;

namespace S9Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter base a: ");
            double a = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter base b: ");
            double b = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter height h: ");
            double h = double.Parse(Console.ReadLine().Replace(',', '.'));

            double result = ((a + b) / 2) * h;

            Console.WriteLine("The area is: {0}",result);
        }
    }
}
