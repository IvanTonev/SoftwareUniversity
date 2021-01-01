using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstTime = byte.Parse(Console.ReadLine());
            byte secondTime = byte.Parse(Console.ReadLine());
            byte thirdTime = byte.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
