using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex2EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] inputCharArray = inputString.ToCharArray();

            int coolThresholdSum = 1;

            for (int i = 0; i < inputCharArray.Length; i++)
            {
                if (char.IsDigit(inputCharArray[i]))
                {
                    int digit = int.Parse(inputCharArray[i].ToString());

                    coolThresholdSum *= digit;
                }
            }
            Console.WriteLine($"Cool threshold: {coolThresholdSum}");

            string pattern = @"::[A-Z][a-z]{2,}::|\*\*[A-Z][a-z]{2,}\*\*";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(inputString);

            List<string> coolEmojiesList = new List<string>();
            foreach (var item in matchCollection)
            {
                string emoji = item.ToString();

                int sum = 0;

                for (int i = 2; i < emoji.Length - 2; i++)
                {
                    sum += emoji[i];
                }

                if (sum > coolThresholdSum)
                {
                    coolEmojiesList.Add(emoji);
                }
            }

            Console.WriteLine($"{matchCollection.Count} emojis found in the text. The cool ones are:");

            foreach (var coolEmogi in coolEmojiesList)
            {
                Console.WriteLine(coolEmogi);
            }
        }
    }
}
