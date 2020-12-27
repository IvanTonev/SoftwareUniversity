using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int confectionersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            decimal fullAmount = daysCount * confectionersCount * (45 * cakesCount + 5.8m * wafflesCount + 3.2m * pancakesCount);
            decimal amount = fullAmount - (fullAmount / 8);

            Console.WriteLine(amount);
        }
    }
}
