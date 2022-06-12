using lab1_designpatterns.Abstractions;
using lab1_designpatterns.Handlers;
using lab1_designpatterns.Strategies;
using lab1_designpatterns.StrategyContexts;
using lab1_designpatterns.Utilities;
using System;

namespace lab1_designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IUtilityMethods utilityMethods = new UtilityMethods();
            //Using Factory method, singleton, strategy (and some dependency injection)
            var menuHandler = new MenuHandler(new RateTypeContext(), 
                new LoanHandler(utilityMethods),
                new RateHandler(utilityMethods));
            menuHandler.Run();
        }

    }
}
