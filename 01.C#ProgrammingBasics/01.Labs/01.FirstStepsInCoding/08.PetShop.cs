using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int animalsCount = int.Parse(Console.ReadLine());

            float finaАmount = 2.5f * dogsCount + 4 * animalsCount;

            Console.WriteLine($"{finaАmount} lv.");
        }
    }
}
