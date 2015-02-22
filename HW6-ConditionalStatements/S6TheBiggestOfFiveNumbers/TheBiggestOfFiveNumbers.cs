using System;

namespace S6TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
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

            Console.Write("input your number d: ");
            double d = double.Parse(Console.ReadLine().Replace(",", " "));

            Console.Write("input your number e: ");
            double e = double.Parse(Console.ReadLine().Replace(",", " "));


            if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                Console.WriteLine(a);
            }
            else if ((b > a) && (b > c) && (b > d) && (b > e))
            {
                Console.WriteLine(b);
            }
            else if ((c > a) && (c > b) && (c > d) && (c > e))
            {
                Console.WriteLine(c);
            }
            else if ((d > a) && (d > b) && (d > c) && (d > e))
            {
                Console.WriteLine(d);
            }
            else 
            {
                Console.WriteLine(e);
            }

        }
    }
}
