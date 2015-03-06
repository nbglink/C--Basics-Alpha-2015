using System;

namespace S12RandomizeTheNumbers1N
{
    class RandomizeTheNumbers1N
    {
        static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int Min = 1;
            int Max = arrayLength;

            int[] randomSeqArray = new int[arrayLength];

            Random randNum = new Random();
            for (int i = 0; i < randomSeqArray.Length; i++)
            {
                randomSeqArray[i] = randNum.Next(Min, Max + 1);

                Console.Write(randomSeqArray[i] + " ");
            }
        }
    }
}
