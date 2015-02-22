using System;
using System.Globalization;
using System.Threading;

namespace S4MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("input your number a: ");
            double a = double.Parse(Console.ReadLine().Replace(",", " "));

            Console.Write("input your number b: ");
            double b = double.Parse(Console.ReadLine().Replace(",", " "));

            Console.Write("input your number c: ");
            double c = double.Parse(Console.ReadLine().Replace(",", " "));

            if (a * b * c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a * b * c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a * b * c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
