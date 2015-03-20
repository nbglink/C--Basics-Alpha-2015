using System;


namespace S14CurrentDate
{
    class CurrentDate
    {
        static void Main()
        {
            string a = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine(a);
        }
    }
}
