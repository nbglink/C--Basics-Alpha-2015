using System;

namespace S11BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {

            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            int p = 3;
                                       // 00000000 00000101 if it is 5
            int nRightP = n >> p;      // 00000000 00000000
            int bit = nRightP & 1;     // 00000000 00000000
            Console.WriteLine("bit #3 is: {0}", bit);    // 0

        }
    }
}
