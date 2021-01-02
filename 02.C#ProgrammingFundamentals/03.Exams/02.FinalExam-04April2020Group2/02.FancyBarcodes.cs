using System;
using System.Text.RegularExpressions;

namespace Ex2FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string barcodPattern = "^@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+$";

            string digitPattern = "[0-9]";

            for (int i = 0; i < count; i++)
            {

                string barcode = Console.ReadLine();
                Regex regex = new Regex(barcodPattern);

                Match match = regex.Match(barcode);

                bool isValid = match.ToString() == barcode;

                if (isValid)
                {
                    regex = new Regex(digitPattern);

                    MatchCollection matchCollection = regex.Matches(barcode);

                    string productGroup = string.Join(string.Empty, matchCollection);
                    if (matchCollection.Count == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
