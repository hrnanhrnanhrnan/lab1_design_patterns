using lab1_designpatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.Utilities
{
    public class UtilityMethods : IUtilityMethods
    {
        public int GetValidChoice(string header, string[] choices)
        {
            bool validChoice = false;
            int numToReturn = 0;

            while (!validChoice)
            {
                Console.WriteLine(header);
                for (int i = 0; i < choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {choices[i]}");
                }
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice < 1 || choice > choices.Length)
                    {
                        Console.WriteLine("Soryy but that was not a valid choice... please press enter to try again!");
                        Console.ReadLine();
                        validChoice = false;
                        Console.Clear();
                    }
                    else
                    {
                        numToReturn = choice;
                        validChoice = true;
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter a number... please press enter to try again!");
                    Console.ReadLine();
                    validChoice = false;
                    Console.Clear();
                }
            }
            return numToReturn;
        }
    }
}
