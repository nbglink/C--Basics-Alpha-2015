using System;
using System.Threading;
using System.Globalization;

namespace S5FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter integer a: ");
            int a = int.Parse(Console.ReadLine().Replace(',', '.'));

            while (a < 0 || a > 500) //Check number is valid
            {
                Console.WriteLine("Invalid input! Try again!");
                a = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter floating point number b: ");
            decimal b = decimal.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter floating point number c: ");
            decimal c = decimal.Parse(Console.ReadLine().Replace(',', '.'));

            Console.Write("|{0,-10:x}|", a);
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("|{0,10:F2}|", b);
            Console.Write("{0,-10:F3}|", c);
            
            Console.WriteLine();

        }
    }
}
