using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lenght = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal percent = decimal.Parse(Console.ReadLine());

            decimal result = ((lenght * width * height) / 1000) - (percent/100) * ((lenght * width * height) / 1000);

            Console.WriteLine(result);       
        }
    }
}