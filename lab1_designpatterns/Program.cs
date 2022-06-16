using lab1_designpatterns.Handlers;
using lab1_designpatterns.StrategyContexts;
using lab1_designpatterns.Utilities;

namespace lab1_designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Factory method design pattern, singleton design pattern, strategy design pattern (and some dependency injection)

            //creates a new menuhandler object
            //to the constructor a new object of the Strategy context class, LoanHandler and RateHandler is passed
            //and to the LoanHandler and RateHandler constructors the instances of UtilityMethods and Logger is passed
            //then the Run method of the menuhandler instance is invoked
            var menuHandler = new MenuHandler(new RateTypeContext(), 
                new LoanHandler(UtilityMethods.GetInstance, Logger.GetInstance),
                new RateHandler(UtilityMethods.GetInstance, Logger.GetInstance));
            menuHandler.Run();
        }
    }
}
