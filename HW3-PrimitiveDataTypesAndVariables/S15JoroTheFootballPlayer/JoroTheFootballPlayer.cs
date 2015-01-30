using System;

namespace S15JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main()
        {
            string leapOrNot = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            int yearWeekends = 52;
            int leapYear = 3;

            double hometownWeekends = yearWeekends - h;
            double normalWeekends = (hometownWeekends * 2)/3;

            double holidays = (p/2);

            double holidaysAndNweekends = normalWeekends + holidays + h;

            
            if (leapOrNot == "t")
            {
                Console.WriteLine(Math.Floor(holidaysAndNweekends+leapYear));
            }
            else
            {
                Console.WriteLine(Math.Floor(holidaysAndNweekends));
            }

            



        }
    }
}
