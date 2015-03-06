using System;
using System.Numerics;


namespace S6CalculateFactorialsDivision
{
    class CalculateFactorialsDivision
    {
        static void Main()
        {
            Console.Write("Enter whole number, bigger from K for N = ");
            string numberStrN = Console.ReadLine();
            int numN = int.Parse(numberStrN);

            Console.Write("Now, enter a whole number, bigger from 1 for K = ");
            string numberStrK = Console.ReadLine();
            int numK = int.Parse(numberStrK);
            
            if (numN <= 1 || numK >= numN || numK < 1 || numN > 100 || numK >= 100)
            {
                Console.WriteLine("Error - Invalid Input !!!");
            }
            else
            {
                /* If looked deeply in factorial function formula, we will understand
                 * why is not necessarily calculate N! and K! separately.
                 * N!=N*(N-1)*(N-2)*...*1 and K!=K*(K-1)*(K-2)*...1;
                 * If N>K K! is Subset of N!, that's mean:
                 * N!= N*(N-1)*(N-2)*...*K*(K-1)*(K-2)*...*1;
                 * Division of N! by K! means:
                 * RESULT = N*(N-1)*(N-2)*...(K+1);
                 * Example: What is 7! / 4! = 7 × 6 × 5 = 210;*/

                BigInteger resultDivision = 1;
                for (int i = numN; i > numK; i--)
                {
                    resultDivision *= i;
                }
                Console.WriteLine("The Result from Division of N! by K! is RESULT = " + resultDivision);
            }
            Console.ReadLine();
        }
    }
}

