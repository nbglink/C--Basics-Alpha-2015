using System;
using System.Threading;
using System.Globalization;

namespace S4Rectangles
{
    class Rectangles
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 


            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine().Replace(',', '.'));

            Console.Write("Enter heigh: ");
            double height = double.Parse(Console.ReadLine().Replace(',', '.'));

            double perimeter = 2 * (width + height);

            double area = width * height;
            
            Console.WriteLine(); //gap

            Console.Write("Perimeter: ");
            Console.WriteLine(perimeter);
            Console.Write("Area: ");
            Console.WriteLine(area);
        }
    }
}
