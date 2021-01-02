using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> citiesDict = new Dictionary<string, int[]>();

            string input = Console.ReadLine();


            while (input != "Sail")
            {
                string[] inputArray = input.Split("||");
                string city = inputArray[0];
                int population = int.Parse(inputArray[1]);
                int gold = int.Parse(inputArray[2]);

                if (!citiesDict.ContainsKey(city))
                {
                    citiesDict.Add(city, new int[2]);
                }
                citiesDict[city][0] += population;
                citiesDict[city][1] += gold;

                input = Console.ReadLine();
            }

            while (input != "End")
            {
                string[] inputArray = input.Split("=>");
                string plunderOrProsper = inputArray[0];
               

                if (plunderOrProsper == "Plunder")
                {
                    string city = inputArray[1];
                    int people = int.Parse(inputArray[2]);
                    int gold = int.Parse(inputArray[3]);

                    citiesDict[city][0] -= people;
                    citiesDict[city][1] -= gold;

                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (citiesDict[city][0] <= 0 || citiesDict[city][1] <= 0)
                    {
                        citiesDict.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }
                else if (plunderOrProsper == "Prosper")
                {
                    string city = inputArray[1];
                    int gold = int.Parse(inputArray[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesDict[city][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {citiesDict[city][1]} gold.");
                    }
                }
                
                input = Console.ReadLine();
            }

            var orderedCitiesDict = citiesDict.OrderBy(c => c.Key).OrderByDescending(c => c.Value[1]);

            if (orderedCitiesDict.Count() > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {orderedCitiesDict.Count()} wealthy settlements to go to:");

                foreach (var orderedCity in orderedCitiesDict)
                {
                    int population = orderedCity.Value[0];
                    int gold = orderedCity.Value[1];

                    Console.WriteLine($"{orderedCity.Key} -> Population: {population} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }   
        }
    }
}
