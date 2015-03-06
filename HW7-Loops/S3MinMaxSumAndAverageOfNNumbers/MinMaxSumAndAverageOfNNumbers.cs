using System;
using System.Collections.Generic;
using System.Globalization;

namespace S3MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please enter n and after that n lines with integers: ");

            int n = int.Parse(Console.ReadLine().Replace(",", "."));
            int linesCount = n;

            List<int> list = new List<int>();

            double sum = 0.0;
            double avg = 0.0;
            int min = 0;
            int max = 0;

            while (n > 0)
            {
                int lines = int.Parse(Console.ReadLine());

                list.Add(lines);


                n--;
            }

            list.Sort();

            min = list[0];               // min
            max = list[list.Count - 1];  // max

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            avg = sum / linesCount;

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);

        }
    }
}
