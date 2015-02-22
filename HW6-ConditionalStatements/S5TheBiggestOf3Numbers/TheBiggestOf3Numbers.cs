using System;
using System.Globalization;
using System.Threading;

namespace S5TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
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

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0}", a);
                }
            }
            else if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}", b);
                }
            }
            else if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("{0}", c);
                }
            }


        }
    }
}
