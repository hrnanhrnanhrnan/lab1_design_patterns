using lab1_designpatterns.Abstractions;
using lab1_designpatterns.Strategies;
using lab1_designpatterns.StrategyContexts;
using lab1_designpatterns.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.Handlers
{
    public class MenuHandler
    {
        private readonly RateTypeContext _rateTypeContext;
        private readonly LoanHandler _loanHandler;
        private readonly RateHandler _rateHandler;
        public MenuHandler(RateTypeContext rateTypeContext, LoanHandler loanHandler, RateHandler rateHandler)
        {
            _rateTypeContext = rateTypeContext;
            _loanHandler = loanHandler;
            _rateHandler = rateHandler;
        }
        public void Run()
        {
            Console.WriteLine("----- Welcome to the loan application -----");

            AlertOfEnterToContinue();

            //get loantype
            ILoanType loanType = _loanHandler.GetChosenLoanType();

            AlertOfEnterToContinue();

            //get ratetype
            IRateType ratetype = _rateHandler.GetChosenRateType();

            AlertOfEnterToContinue();

            //set ratetype context
            _rateTypeContext.SetRateType(ratetype);

            //info about loan
            Console.WriteLine($"Congratulations! You have a approved loan!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Type of loan: {loanType.GetLoanType()}, base rate: {loanType.GetBaseRate()} and monthly charge: {loanType.GetMonthlyCharge()}");
            Console.WriteLine($"You choose : {_rateTypeContext.GetName()}, and the rate is then adjusted with: {_rateTypeContext.GetRate()}");
            Console.WriteLine($"Your adjusted interest rate is then: {loanType.GetBaseRate() + _rateTypeContext.GetRate()}");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Thank you! Have a nice day and press enter to exit!");
            Console.ReadLine();
        }

        private void AlertOfEnterToContinue()
        {
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
