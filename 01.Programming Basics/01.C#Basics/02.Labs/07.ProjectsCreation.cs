using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int hours = 3 * projectsCount;

            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {projectsCount} project/s.");
        }
    }
}
