using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string dimensionFrom = Console.ReadLine();
            string dimensionTo = Console.ReadLine();

            if (dimensionFrom == "mm")
            {
                if (dimensionTo == "cm")
                {
                    Console.WriteLine($"{(number / 10d):F3}");
                }
                else if (dimensionTo == "m")
                {
                    Console.WriteLine($"{(number / 1000d):F3}");
                }
            }
            else if (dimensionFrom == "cm")
            {
                if (dimensionTo == "mm")
                {
                    Console.WriteLine($"{(10 * number):F3}");
                }
                else if (dimensionTo == "m")
                {
                    Console.WriteLine($"{(number / 100d):F3}");
                }
            }
            else if (dimensionFrom == "m")
            {
                if (dimensionTo == "mm")
                {
                    Console.WriteLine($"{(1000d * number):F3}");
                }
                else if (dimensionTo == "cm")
                {
                    Console.WriteLine($"{(100d * number):F3}");
                }
            }
        }
    }
}
