using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 5.5d)
            {
                Console.WriteLine("Excellent!");
            }   
        }
    }
}
