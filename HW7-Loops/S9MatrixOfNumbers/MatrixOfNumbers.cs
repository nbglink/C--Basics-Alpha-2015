using System;

namespace S9MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Please, enter a whole positive number in the range [1...20], N = ");
            
            int numN = int.Parse(Console.ReadLine());

            if (numN < 1 || numN > 20)
            {
                Console.WriteLine("Error - Invalid Number !!!");
            }
            else
            {
                Console.WriteLine("The matrix of numbers is:");
                Console.WriteLine();
                for (int i = 1; i <= numN; i++)
                {
                    for (int j = i; j < numN + i; j++)
                    {
                        Console.Write("{0,2} ", j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
