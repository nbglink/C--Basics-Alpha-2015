using System;
using System.Globalization;
using System.Threading;

namespace S9PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string user = Console.ReadLine();

            switch (user)
            {
                case "1":
                    Console.WriteLine("Enter your integer: ");
                    int intInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Yor result is: {0}",intInput+1);
                    break;
                case "2":
                    Console.Write("Enter your double: ");
                    double doubInput = double.Parse(Console.ReadLine());
                    Console.WriteLine("Your result is: {0}",doubInput+1);
                    break;
                case "3":
                    Console.Write("Enter your string: ");
                    string stringInput = Console.ReadLine();
                    Console.WriteLine("Your rezult is: {0}*",stringInput);
                    break;
                default:
                    Console.WriteLine("Bad Input !");
                    break;
            }


        }
    }
}
