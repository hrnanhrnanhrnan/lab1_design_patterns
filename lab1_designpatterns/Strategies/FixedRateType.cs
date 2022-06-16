using lab1_designpatterns.Abstractions;

namespace lab1_designpatterns.Strategies
{
    //Concrete strategy that implements the abstract strategy interface IRateType
    public class FixedRateType : IRateType
    {
        public string GetRateTypeName() => "Fixed rate";
        public decimal GetCurrentInterestRate() =>  0.45M;
    }
}
