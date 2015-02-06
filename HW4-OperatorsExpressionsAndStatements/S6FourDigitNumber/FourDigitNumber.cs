using System;


namespace S6FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter integer number a: ");
            string a = Console.ReadLine();
            Console.Write("Enter integer number b: ");
            string b = Console.ReadLine();
            Console.Write("Enter integer number c: ");
            string c = Console.ReadLine();
            Console.Write("Enter integer number d: ");
            string d = Console.ReadLine();


            int sum = int.Parse(a) + int.Parse(b) + int.Parse(c) + int.Parse(d);

            int wholeNumberReversed = int.Parse(d + c + b + a);

            int lastDigitInFront = int.Parse(d + a + b + c);

            int exchangeFirstAndLast = int.Parse(a + c + b + d);


            Console.WriteLine("Sum of digits: {0}",sum);
            Console.WriteLine("Reversed: {0}",wholeNumberReversed);
            Console.WriteLine("Last digit in front: {0}",lastDigitInFront);
            Console.WriteLine("Second and third digit exchanged: {0}",exchangeFirstAndLast);
            

            //int a = number % 10;


        }
    }
}
