﻿using System;
using System.Text.RegularExpressions;

namespace S13BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();

            Console.WriteLine(Convert.ToInt64(inputStr, 2));

        }
    }
}
