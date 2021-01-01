using System;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 15;

            if (newMinutes >= 60)
            {
                hours++;
                newMinutes -= 60;
            }
            if (hours == 24)
            {
                hours = 0;
            }


            if (newMinutes < 10)
            {
                Console.WriteLine($"{hours}:{"0" + newMinutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{newMinutes}");
            }
        }
    }
}
