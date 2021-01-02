using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(0.5d * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(0.4d * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(0.45d * quantity);
                            break;
                        default:
                            break;
                    }
                    break;
                case "water":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(0.8d * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(0.7d * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(0.7d * quantity);
                            break;
                        default:
                            break;
                    }
                    break;
                case "beer":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(1.2d * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.15d * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(1.1d * quantity);
                            break;
                        default:
                            break;
                    }
                    break;
                case "sweets":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(1.45d * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.3d * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(1.35d * quantity);
                            break;
                        default:
                            break;
                    }
                    break;
                case "peanuts":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(1.6d * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.5d * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(1.55d * quantity);
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
