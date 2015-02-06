using System;

namespace S13CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter your position: ");
            int p = int.Parse(Console.ReadLine());

            int nRightP = n >> p;
            int bit = nRightP & 1;


            if (bit == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
