using System;

namespace S11NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            int count = 0;
            for (long i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
