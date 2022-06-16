using lab1_designpatterns.Abstractions;

namespace lab1_designpatterns.Strategies
{
    //Concrete strategy that implements the abstract strategy interface IRateType
    public class VariableRateType : IRateType
    {
        public string GetRateTypeName() => "Variable rate";
        public decimal GetCurrentInterestRate() => -0.15M;
    }
}
