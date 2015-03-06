using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S17CalculateGCDvar
{
    class CalculateGCDvar
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int remain = 1;
            while (remain != 0)
            {
                remain = a % b;
                a = b;
                b = remain;
            }
            Console.WriteLine(Math.Abs(a));
        }
    }
}
