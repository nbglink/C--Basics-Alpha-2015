using System;
using System.Threading;
using System.Globalization;

namespace S4NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter radius a: ");
            double a = double.Parse(Console.ReadLine().Replace(',', '.'));

            Console.Write("Enter radius b: ");
            double b = double.Parse(Console.ReadLine().Replace(',', '.'));

            Console.Write("Greater ");
            Console.WriteLine(a < b ? b : a);

        }
    }
}
