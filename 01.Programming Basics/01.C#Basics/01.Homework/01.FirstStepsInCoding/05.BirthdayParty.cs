using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            float hallRental = float.Parse(Console.ReadLine());

            float cakePrice = 0.2f * hallRental;
            float baveragePrice = cakePrice - (0.45f * cakePrice);
            float animatorPrice = hallRental / 3;

            double result = hallRental + cakePrice + baveragePrice + animatorPrice;

            Console.WriteLine(result);

        }
    }
}
