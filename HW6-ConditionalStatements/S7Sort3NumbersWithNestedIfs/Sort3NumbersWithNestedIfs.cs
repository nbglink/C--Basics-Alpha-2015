﻿using System;
using System.Globalization;
using System.Threading;

namespace S7Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
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


            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}
