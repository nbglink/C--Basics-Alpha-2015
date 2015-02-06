using System;


namespace S1OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {

            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            bool result =  number % 2 != 0;

            Console.WriteLine(result);
        }
    }
}
