using System;
using System.Linq;
using System.Threading;

namespace Ex1ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandArray = command.Split(">>>");

                int startIndex;
                int endIndex;

                switch (commandArray[0])
                {
                    case "Contains":
                        string substring = commandArray[1];
                        bool isContains = activationKey.Contains(substring);

                        if (isContains)
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        string upperOrLower = commandArray[1];
                        startIndex = int.Parse(commandArray[2]);
                        endIndex = int.Parse(commandArray[3]);

                        string activationKeyFirstPart = activationKey.Substring(0, startIndex);
                        string activationKeySecondPart = activationKey.Substring(startIndex, endIndex- startIndex);
                        string activationKeyThirdPart = activationKey.Substring(endIndex);

                        switch (upperOrLower)
                        {
                            case "Upper":
                                activationKeySecondPart = activationKeySecondPart.ToUpper();
                                break;
                            case "Lower":
                                activationKeySecondPart = activationKeySecondPart.ToLower();
                                break;
                        }
                        activationKey = activationKeyFirstPart + activationKeySecondPart + activationKeyThirdPart;

                        Console.WriteLine(activationKey);
                        break;

                    case "Slice":
                        startIndex = int.Parse(commandArray[1]);
                        endIndex = int.Parse(commandArray[2]);

                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

                        Console.WriteLine(activationKey);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.Write($"Your activation key is: {activationKey}");
        }
    }
}
