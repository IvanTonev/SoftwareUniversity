using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            bool isSocialScholarsip = (income < minimalSalary) && averageSuccess > 4.5d;
            bool isExcellentScholarship = averageSuccess >= 5.5d;

            if (!isSocialScholarsip && !isExcellentScholarship)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (isSocialScholarsip && !isExcellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(0.35 * minimalSalary)} BGN");
            }
            else if (!isSocialScholarsip && isExcellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(25 * averageSuccess)} BGN");
            }
            else
            {
                if ((0.35 * minimalSalary) > (25 * averageSuccess))
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(0.35 * minimalSalary)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(25 * averageSuccess)} BGN");
                }
            }
        }
    }
}
