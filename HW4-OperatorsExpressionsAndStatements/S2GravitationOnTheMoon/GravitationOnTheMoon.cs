using System;
using System.Threading;
using System.Globalization;

namespace S2GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter weight on earth: ");
            double weight = double.Parse(Console.ReadLine().Replace(',', '.'));

            double result = (weight / 100) * 17;

            Console.WriteLine(result);
        }
    }
}
