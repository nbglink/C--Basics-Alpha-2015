using System;

namespace S14ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter your position: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter your value: ");
            int v = int.Parse(Console.ReadLine());

            int result = 0;

            //int nRightP = n << p;
            //int bit = nRightP & 1;

            if (v == 0)
            {
                int mask = ~(1 << p);       // set to 0
                result = n & mask;         
            }
            else 
            {
                int mask = 1 << p;          c
                result = n | mask;          // set to 1
            }

            


            Console.WriteLine(result);

        }
    }
}
