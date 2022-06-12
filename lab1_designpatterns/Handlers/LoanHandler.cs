using lab1_designpatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.Handlers
{
    public class LoanHandler
    {
        private readonly IUtilityMethods _utilityMethods;
        public LoanHandler(IUtilityMethods utilityMethods)
        {
            _utilityMethods = utilityMethods;
        }
        public ILoanType GetChosenLoanType()
        {
            int choice = _utilityMethods.GetValidChoice("Please enter the choice of loan that you want:",
                new string[] { "House loan", "Car loan", "Private loan" });
            //get the type of loan from the user
            switch (choice)
            {
                case 1:
                    Logger.GetInstance.Log("Created new House Loan");
                    return new HouseLoanFactory().CreateLoan();
                case 2:
                    Logger.GetInstance.Log("Created new Car Loan");
                    return new CarLoanFactory().CreateLoan();
                case 3:
                    Logger.GetInstance.Log("Created new Private Loan");
                    return new PrivateLoanFactory().CreateLoan();
                default:
                    return null;
            }
        }
    }
}
