using System;
using System.Collections.Generic;

namespace Ex1PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandArray = command.Split(" ");

                switch (commandArray[0])
                {
                    case "TakeOdd":
                        List<char> passwordCharList = new List<char>();

                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                passwordCharList.Add(password[i]);
                            }
                        }

                        password = new string(passwordCharList.ToArray(), 0, passwordCharList.Count);

                        Console.WriteLine(password);
                        break;

                    case "Cut":
                        int index = int.Parse(commandArray[1]);
                        int lenght = int.Parse(commandArray[2]);

                        password = password.Remove(index, lenght);

                        Console.WriteLine(password);
                        break;

                    case "Substitute":
                        string substring = commandArray[1];
                        string substitute = commandArray[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
