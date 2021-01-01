using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double time = distance * timeForOneMeter;
            double delay = Math.Floor(distance / 15d) * 12.5d;
            double timeWithDelay = time + delay;

            if (timeWithDelay < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeWithDelay:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(timeWithDelay - record):F2} seconds slower.");
            }
        }
    }
}
