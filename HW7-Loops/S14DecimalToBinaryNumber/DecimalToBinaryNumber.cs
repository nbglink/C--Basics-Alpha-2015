using System;

namespace S14DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
            static void Main()
        {
            string inputStr = Console.ReadLine();

            int test = int.Parse(inputStr);

            string s = Convert.ToString(test, 2);

            Console.WriteLine(s);

        }
        }
    }

