using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            float area = float.Parse(Console.ReadLine());


            float price = 7.61f * area;
            double discount = Math.Round(0.18f * price, 2);
            double finalPrice = Math.Round(price - discount, 2);

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is : {discount} lv.");
        }
    }
}
