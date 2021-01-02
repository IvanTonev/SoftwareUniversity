using System;

namespace WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            string workingDayOrWeekend = string.Empty;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    workingDayOrWeekend = "Working day";
                    break;
                case "Saturday":
                case "Sunday":
                    workingDayOrWeekend = "Weekend";
                    break;
                default:
                    workingDayOrWeekend = "Error";
                    break;
            }

            Console.WriteLine(workingDayOrWeekend);
        }
    }
}
