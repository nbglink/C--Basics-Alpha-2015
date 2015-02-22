using System;
using System.Globalization;
using System.Threading;


namespace S1ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("input your number a: ");
            double a = double.Parse(Console.ReadLine().Replace(","," "));

            Console.Write("input your number b: ");
            double b = double.Parse(Console.ReadLine().Replace(",", " "));

            if (a < b) {
                Console.WriteLine("{0} {1}",a,b);
            }

            if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }

        }
    }
}
