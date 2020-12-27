using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double cothingPrice = double.Parse(Console.ReadLine());

            double decor = 0.1 * budget;
            double statistsClothingPrice = statistsCount * cothingPrice;

            if (statistsCount > 150)
            {
                statistsClothingPrice -= 0.1 * statistsClothingPrice;
            }
            
            if (decor + statistsClothingPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {((decor + statistsClothingPrice) - budget):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - (decor + statistsClothingPrice)):F2} leva left.");
            }
        }
    }
}
