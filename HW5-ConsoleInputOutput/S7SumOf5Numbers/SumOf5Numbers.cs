using System;
using System.Globalization;
using System.Threading;

namespace S7SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please enter a bunch of digits separated by a space: ");
            string[] fourDigits = Console.ReadLine().Replace(',', '.').Split(' ');

            double first = double.Parse(fourDigits[0]);
            double second = double.Parse(fourDigits[1]);
            double third = double.Parse(fourDigits[2]);
            double fourth = double.Parse(fourDigits[3]);
            double fifth = double.Parse(fourDigits[4]);

            double result = first + second + third + fourth + fifth;
           
            Console.WriteLine("The result is: {0}", result);

        }
    }
}
