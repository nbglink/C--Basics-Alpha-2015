using System;
using System.Numerics;

namespace S1FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            

            int n = int.Parse(Console.ReadLine());

            

            BigInteger result = FibNumbers(n);

            Console.WriteLine(result);

        }


        static BigInteger FibNumbers(int n)
        {

            BigInteger fib0 = 1, fib1 = 2;
            for (int i = 3; i <= n; i++)
            {
                BigInteger tmp = fib0;
                fib0 = fib1;
                fib1 = tmp + fib1;
            }
            BigInteger result = (n > 0 ? fib1 : 0);

            return result;
        }

  

 






        
    }
}
