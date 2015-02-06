using System;

namespace S12ExtractBitFromInteger
{
    class ExtractBitFromInteger
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
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }


        }
    }
}
