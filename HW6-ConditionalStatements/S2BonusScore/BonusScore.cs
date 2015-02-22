using System;
using System.Globalization;
using System.Threading;

namespace S2BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("input your score a: ");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                case "2":
                case "3":
                    Console.WriteLine(int.Parse(a) * 10);
                    break;
                case "4":
                case "5":
                case "6":
                    Console.WriteLine(int.Parse(a) * 100);
                    break;
                case "7":
                case "8":
                case "9":
                    Console.WriteLine(int.Parse(a) * 1000);
                   break;
                default:
                   Console.WriteLine("invalid score");
                   break;
            }
        }
    }
}
