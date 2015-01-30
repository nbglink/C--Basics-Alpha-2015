using System;

namespace S12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? intVar = null;
            int? intVar1 = 5;
            double? doubleVar = null;
            double? doubleVar1 = 10;

            Console.WriteLine(intVar);
            Console.WriteLine(intVar1);
            Console.WriteLine(doubleVar);
            Console.WriteLine(doubleVar1);
        }
    }
}
