using System;


namespace S11RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int Min = int.Parse(Console.ReadLine());
            int Max = int.Parse(Console.ReadLine());

            int[] randomSeqArray = new int[arrayLength];

            Random randNum = new Random();
            for (int i = 0; i < randomSeqArray.Length; i++)
            {
                randomSeqArray[i] = randNum.Next(Min, Max+1);

                Console.Write(randomSeqArray[i]+ " ");
            }

            
        }
    }
}
