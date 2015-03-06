using System;
using System.Numerics;

namespace S7FactorialsDivisionAdvanced
{
    class FactorialsDivisionAdvanced
    {
        static void Main()
        {
            Console.Write("Enter whole number, bigger from K for N = ");
            string numberStrN = Console.ReadLine();
            int numN = int.Parse(numberStrN);

            Console.Write("Now enter a whole number, bigger from 1 for K = ");
            string numberStrK = Console.ReadLine();
            int numK = int.Parse(numberStrK);

            if (numK < 2 || numN < 3 || numN <= numK || numK >= 100 || numN >= 100)
            {
                Console.WriteLine("Error - Invalid Input !!!");
            }
            else
            /* The factorial function (symbol: !) means to multiply a series of descending
             * natural numbers. That means N! = N * (N - 1) * (N - 2) * ... * 1 also and
             * K! = K * (K - 1) * (K - 2) * ... * 1.
             * If N > K, K! is Subset of N!, wich means:
             * N! = N * (N - 1) * (N - 2) * ... * (K + 1) * K!
             * To optimize time and performance of this application, we will reduce initial
             * formula from task conditions  RESULT = N! / (K! * (N - K)!)  to next:            
             * 1) = First loop multiplay numbers from N to K + 1;
             * 2) = Second loop calculate Factorial of (N - K)!;
             * RESULT = 1) / 2) . Example: N=7 and K=4, RESULT = 35.   */
            {
                BigInteger factorialNtoK = 1;
                for (int i = numN; i > numK; i--)
                {
                    factorialNtoK *= i;
                }

                BigInteger dividerFactorial = 1;
                for (int j = 2; j <= (numN - numK); j++)
                {
                    dividerFactorial *= j;
                }

                System.Numerics.BigInteger resultDivision = factorialNtoK / dividerFactorial;
                Console.WriteLine("The result from that factorials division is:");
                Console.WriteLine("RESULT = {0} !", resultDivision);
            }
        }
    }
}
