using System;


namespace S15AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your age:");
            int age =  int.Parse(Console.ReadLine());

            Console.WriteLine("Your age after 10 years will be: {0}", age + 10);

        }
    }
}
