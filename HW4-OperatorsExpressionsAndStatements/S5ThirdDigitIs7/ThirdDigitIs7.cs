using System;

namespace S5ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int number = int.Parse(Console.ReadLine());
            //int firstDigit = number % 10;
            //int secondDigit = (number / 10) % 10;
            int thirdDigit = (number / 100) % 10;
            bool check = thirdDigit == 7;
            Console.WriteLine("{0}", check);
        }
    }
}
