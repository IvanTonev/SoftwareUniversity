using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> heroesDict = new Dictionary<string, int[]>();

            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroArray = Console.ReadLine().Split(" ");
                string heroName = heroArray[0];
                int hitPoints = int.Parse(heroArray[1]);
                int manaPoints = int.Parse(heroArray[2]);

                heroesDict.Add(heroName, new int[] { hitPoints, manaPoints });
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArray = command.Split(" - ");

                string action = commandArray[0];
                string heroName = commandArray[1];

                switch (action)
                {
                    case "CastSpell":
                        int manaPointsNeeded = int.Parse(commandArray[2]);
                        string spellName = commandArray[3];

                        if (heroesDict[heroName][1] >= manaPointsNeeded)
                        {
                            heroesDict[heroName][1] -= manaPointsNeeded;

                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesDict[heroName][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(commandArray[2]);
                        string attacker = commandArray[3];

                        heroesDict[heroName][0] -= damage;

                        if (heroesDict[heroName][0] > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesDict[heroName][0]} HP left!");
                        }
                        else
                        {
                            heroesDict.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        break;

                    case "Recharge":
                        int amountRecharge = int.Parse(commandArray[2]);

                        int manaPoints = heroesDict[heroName][1];
                        int newManaPoints = manaPoints + amountRecharge;

                        if (newManaPoints > 200)
                        {
                            int differenceManaPoint = 200 - manaPoints;
                            heroesDict[heroName][1] = 200;
                            Console.WriteLine($"{heroName} recharged for {differenceManaPoint} MP!");

                        }
                        else
                        {
                            heroesDict[heroName][1] = newManaPoints;
                            Console.WriteLine($"{heroName} recharged for {amountRecharge} MP!");
                        }

                        break;

                    case "Heal":
                        int amountHeal = int.Parse(commandArray[2]);

                        int hitPoints = heroesDict[heroName][0];
                        int newHitPoints = hitPoints + amountHeal;

                        if (newHitPoints > 100)
                        {
                            int differenceHitPoins = 100 - hitPoints;
                            heroesDict[heroName][0] = 100;
                            Console.WriteLine($"{heroName} healed for {differenceHitPoins} HP!");

                        }
                        else
                        {
                            heroesDict[heroName][0] = newHitPoints;
                            Console.WriteLine($"{heroName} healed for {amountHeal} HP!");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            var orderedHeroesDict = heroesDict.OrderBy(h => h.Key).OrderByDescending(h => h.Value[0]);

            foreach (var orderedHero in orderedHeroesDict)
            {
                Console.WriteLine($"{orderedHero.Key}");
                Console.WriteLine($"  HP: {orderedHero.Value[0]}");
                Console.WriteLine($"  MP: {orderedHero.Value[1]}");
            }
        }
    }
}
