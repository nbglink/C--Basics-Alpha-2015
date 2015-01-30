using System;

namespace S9ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = a;

            a = b;
            b = c;

            Console.WriteLine("This is a declared like 5 exchanged with b result is: {0}",a);
            Console.WriteLine("This is b declared like 10 exchanged with a result is: {0}", b);
        }
    }
}
