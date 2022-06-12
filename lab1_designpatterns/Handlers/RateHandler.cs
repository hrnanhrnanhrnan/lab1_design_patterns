using lab1_designpatterns.Abstractions;
using lab1_designpatterns.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.Handlers
{
    public class RateHandler
    {
        private readonly IUtilityMethods _utilityMethods;
        public RateHandler(IUtilityMethods utilityMethods)
        {
            _utilityMethods = utilityMethods;
        }
        public IRateType GetChosenRateType()
        {
            int choice = _utilityMethods.GetValidChoice("Please enter the type of rate that you want:",
                new string[] { "Fixed rate", "Variable rate" });
            switch (choice)
            {
                case 1:
                    Logger.GetInstance.Log("Chose Fixed rate");
                    return new FixedRateType();
                case 2:
                    Logger.GetInstance.Log("Chose Variable rate");
                    return new VariableRateType();
                default:
                    return null;
            }
        }
    }
}
