using System;
using System.Globalization;


namespace S4DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {

            string firstInput = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(firstInput, "d.MM.yyyy", CultureInfo.CurrentCulture);
            string secondInput = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(secondInput, "d.MM.yyyy", CultureInfo.CurrentCulture);
            int days = (int)NumberOfDays(firstDate, secondDate);
            Console.WriteLine(days);

        }

        static double NumberOfDays(DateTime first, DateTime second)
        {
            TimeSpan difference = second - first;
            int result = (int)difference.TotalDays;
            return result;
        }

    }
}
