using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {

            long n = long.Parse(Console.ReadLine());


            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n == 2 || n == 3 || n == 5 || n == 7) // Checks numbers 2, 3, 5, 7
            {
                return true;
            }
            else
            {
                if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0) // Checks division with reminder
                {
                   return true;
                }
                else
                {
                    return false;
                }
            }



        }
    }
}
