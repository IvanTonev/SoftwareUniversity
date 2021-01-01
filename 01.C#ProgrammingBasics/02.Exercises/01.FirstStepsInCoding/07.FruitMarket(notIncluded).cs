using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal strawberriesPrice = decimal.Parse(Console.ReadLine());

            decimal bananasQuantity = decimal.Parse(Console.ReadLine());
            decimal orangesQuantity = decimal.Parse(Console.ReadLine());
            decimal raspberriesQuantity = decimal.Parse(Console.ReadLine());
            decimal strawberriesQuantity = decimal.Parse(Console.ReadLine());

            decimal raspberriesPrice = strawberriesPrice / 2m;
            decimal orangesPrice = raspberriesPrice - (0.4m * raspberriesPrice);
            decimal bananasPrice = raspberriesPrice - (0.8m * raspberriesPrice);

            decimal price = bananasQuantity * bananasPrice +
                orangesQuantity * orangesPrice +
                raspberriesQuantity * raspberriesPrice +
                strawberriesQuantity * strawberriesPrice;

            Console.WriteLine($"{price:F2}");
        }
    }
}
