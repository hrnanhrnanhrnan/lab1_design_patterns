using lab1_designpatterns.Abstractions;

namespace lab1_designpatterns.Handlers
{
    public class LoanHandler : IHandler<ILoanType>
    {
        private readonly IUtilityMethods _utilityMethods;
        private readonly ILogger _logger;

        //injects types of IUtiitymethods and ILogger through the constructor
        public LoanHandler(IUtilityMethods utilityMethods, ILogger logger)
        {
            _logger = logger;
            _utilityMethods = utilityMethods;
        }

        //Method that depending on which choice the user makes
        //consumes the factory method through the respective concrete creators
        //depending on which type of loan the user wants
        public ILoanType GetSelectedType()
        {
            //consumes the GetValidMenuChoice method of the utilitymethods class
            //through the injected instance to get the selected loan from the user
            int choice = _utilityMethods.GetValidMenuChoice("Please enter the number to the type of loan that you want:",
                new string[] { "House loan", "Car loan", "Private loan" });
            switch (choice)
            {
                //creates the loantype depending on which type of loan that the user wants
                //then logs the type of loan that is created trough the injected logger instance
                //and then returns the type of loan as type of the product interface ILoanType
                case 1:
                    ILoanType houseLoanType = new HouseLoanFactory().CreateLoan();
                    _logger.Log($"Created new {houseLoanType.GetLoanType()}");
                    return houseLoanType;
                case 2:
                    ILoanType carLoanType = new CarLoanFactory().CreateLoan();
                    _logger.Log($"Created new {carLoanType.GetLoanType()}");
                    return carLoanType;
                case 3:
                    ILoanType privateLoanType = new PrivateLoanFactory().CreateLoan();
                    _logger.Log($"Created new {privateLoanType.GetLoanType()}");
                    return privateLoanType;
                default:
                    return null;
            }
        }
    }
}
