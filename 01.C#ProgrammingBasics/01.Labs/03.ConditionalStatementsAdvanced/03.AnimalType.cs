using System;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string type = string.Empty;

            switch (name)
            {
                case "dog":
                    type = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                case "Friday":
                    type = "reptile";
                    break;
                default:
                    type = "unknown";
                    break;
            }

            Console.WriteLine(type);
        }
    }
}
