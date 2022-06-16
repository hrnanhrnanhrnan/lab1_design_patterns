using lab1_designpatterns.Abstractions;
using lab1_designpatterns.Strategies;

namespace lab1_designpatterns.Handlers
{
    public class RateHandler : IHandler<IRateType>
    {
        private readonly IUtilityMethods _utilityMethods;
        private readonly ILogger _logger;

        //injects types of IUtiitymethods and ILogger through the constructor
        public RateHandler(IUtilityMethods utilityMethods, ILogger logger)
        {
            _utilityMethods = utilityMethods;
            _logger = logger;
        }

        //Method that creates a new concrete strategy depending on which type the user wants
        public IRateType GetSelectedType()
        {
            //consumes the GetValidMenuChoice method of the utilitymethods class
            //through the injected instance to get the selected loan from the user
            int choice = _utilityMethods.GetValidMenuChoice("Please enter the type of rate that you want:",
                new string[] { "Fixed rate", "Variable rate" });
            switch (choice)
            {
                //depending on what type of rate the user wants
                //a new concrete strategy will be returned as a type of the abstract strategy interface
                //and the logs the the type of rate selected through the logger instance
                case 1:
                    IRateType fixedRateType = new FixedRateType();
                    _logger.Log($"Selected {fixedRateType.GetRateTypeName()}");
                    return fixedRateType;
                case 2:
                    IRateType variableRateType = new VariableRateType();
                    _logger.Log($"Selected {variableRateType.GetRateTypeName()}");
                    return variableRateType;
                default:
                    return null;
            }
        }
    }
}
