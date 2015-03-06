using System;

namespace S2NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
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

            uint i = 1;

            for (i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }

                Console.Write(i + " ");
            }

        }
    }
}
