using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double sentimeters = inches * 2.54;
            Console.WriteLine(sentimeters);
        }
    }
}
