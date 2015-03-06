using System;

namespace S1NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Please enter n: ");
            string s = Console.ReadLine();
            uint n;
            if (uint.TryParse(s, out n))
            {
                Console.WriteLine("You entered the valid positiveinteger {0}", n);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            for (uint i = 1; i <=  n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
