using System;

namespace S1SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {

            Console.WriteLine("Enter your numbers count: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbersCount = new int[n];
            Console.WriteLine("Enter your numbers in separete lines: ");
            for (int i = 0; i < numbersCount.Length; i++)
            {
                numbersCount[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbersCount);
            Console.WriteLine("Your result sequance is: ");
            foreach (var number in numbersCount)
            {
                Console.WriteLine(number);
            }
        }
    }
}
