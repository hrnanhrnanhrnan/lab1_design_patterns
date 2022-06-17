using lab1_designpatterns.Abstractions;
using lab1_designpatterns.StrategyContexts;
using System;

namespace lab1_designpatterns.Handlers
{
    public class MenuHandler
    {
        private readonly RateTypeContext _rateTypeContext;
        private readonly IHandler<ILoanType> _loanHandler;
        private readonly IHandler<IRateType> _rateHandler;
        public MenuHandler(RateTypeContext rateTypeContext, IHandler<ILoanType> loanHandler, IHandler<IRateType> rateHandler)
        {
            _rateTypeContext = rateTypeContext;
            _loanHandler = loanHandler;
            _rateHandler = rateHandler;
        }
        public void Run()
        {
            Console.WriteLine("----- Welcome to the loan application -----");

            AlertOfEnterToContinue();

            //get object of the product interface type ILoanType
            //through the getselectedtype method through the injected loandhandler instance
            ILoanType loanType = _loanHandler.GetSelectedType();

            AlertOfEnterToContinue();

            //get object of the abstract strategy type IRateType
            //through the getselectedtype method through the injected ratehandler instance
            IRateType ratetype = _rateHandler.GetSelectedType();

            AlertOfEnterToContinue();

            //through the injected instance of the strategy context class RateTypeContext SetRateType method
            //sets the RateType strategy that is selected by the user
            _rateTypeContext.SetRateType(ratetype);

            //writes the loan and rate types to the console
            Console.WriteLine($"Congratulations! You have a approved loan!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Type of loan: {loanType.GetLoanType()}, base rate: {loanType.GetBaseRate()} and monthly charge: {loanType.GetMonthlyCharge()}");
            Console.WriteLine($"You selected {_rateTypeContext.GetName()}, and the rate is then adjusted with: {_rateTypeContext.GetRate()}");
            Console.WriteLine($"Your adjusted interest rate is then: {loanType.GetBaseRate() + _rateTypeContext.GetRate()}");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Thank you! Have a nice day and press enter to exit!");
            Console.ReadLine();
        }

        private void AlertOfEnterToContinue()
        {
            Console.WriteLine("Please press enter to continue!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
