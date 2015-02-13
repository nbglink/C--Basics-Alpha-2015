using System;
using System.Threading;
using System.Globalization;


namespace S6QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine().Replace(',', '.'));
            double determinant = (b * b) - (4 * a * c);

            if (determinant < 0)
            {
                Console.WriteLine("Determinant < 0 - > No solution");
            }
            else if (determinant > 0)
            {
                Console.WriteLine("x1={0}", (-b - Math.Sqrt(determinant)) / (2 * a));
                Console.WriteLine("x2={0}", (-b + Math.Sqrt(determinant)) / (2 * a));
            }
            else
            {
                Console.WriteLine("Determinant = 0 - > x1=x2={0}", (-b / (2 * a)));
            }
        }
    }
}
