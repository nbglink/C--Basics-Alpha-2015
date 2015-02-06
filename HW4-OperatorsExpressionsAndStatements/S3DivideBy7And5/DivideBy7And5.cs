using System;

namespace S3DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int number = int.Parse(Console.ReadLine());

            bool result = number==0 ? result = false : (number % 5) == 0 && (number % 7) == 0;

            

            Console.WriteLine(result);
        }
    }
}
