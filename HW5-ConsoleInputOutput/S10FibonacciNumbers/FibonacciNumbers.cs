using System;
using System.Numerics;


namespace S10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine(0);
            else
            {
                BigInteger first = 0;
                BigInteger second = 1;
                Console.Write("{0} ", first);
                Console.Write("{0} ",second);
                BigInteger third = 0;
                for (int i = 2; i < n; i++)
                {
                    third = first + second;
                    Console.Write(third + " ");
                    first = second; 
                    second = third;
                }
                Console.WriteLine();
            }
        }
    }
}
