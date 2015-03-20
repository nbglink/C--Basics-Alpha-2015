using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());


            string numbers = String.Join(", ", FindPrimesInRange(startNum, endNum).ToArray());

            Console.WriteLine(numbers);

        }

        //add prime numbers to list method --->
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> numbers = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }

        //is prime method --->
        private static bool IsPrime(long n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n == 2 || n == 3 || n == 5 || n == 7) // Checks numbers 2, 3, 5, 7
            {
                return true;
            }
            else
            {
                if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0) // Checks division with reminder
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
