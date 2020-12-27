using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float deposit = float.Parse(Console.ReadLine());
            byte interval = byte.Parse(Console.ReadLine());
            float annualInterestRate = float.Parse(Console.ReadLine());

            double result = deposit + interval * ((deposit * annualInterestRate/100) / 12);

            Console.WriteLine($"{Math.Round(result, 2)}");
        }
    }
}
