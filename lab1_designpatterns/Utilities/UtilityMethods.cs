using lab1_designpatterns.Abstractions;
using System;

namespace lab1_designpatterns.Utilities
{
    //Thread-safe Singleton class using locks that implements the IUtilitymethods interface
    public sealed class UtilityMethods : IUtilityMethods
    {
        private static readonly object InstanceLock = new();
        private static UtilityMethods instance = null;
        private UtilityMethods()
        {
        }

        public static UtilityMethods GetInstance
        {
            get
            {
                //the lock makes sure that the get method is synchronized,
                //so that only one thread can access it at any given point of time
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UtilityMethods();
                    }
                    return instance;
                }
            }
        }

        //implements the interface method which takes two parameters, one string named header and a array of strings named choices
        //header will be written to the console as a menu header, and choices is the type of choices that the user can choose from
        //the method then makes sure that the choice is valid,
        //by checking that the input from the user is a number and that it's within the available choices to choose from
        public int GetValidMenuChoice(string header, string[] choices)
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
