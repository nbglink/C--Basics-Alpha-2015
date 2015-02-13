using System;

namespace S8NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter your number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your result: ");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
