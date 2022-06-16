using lab1_designpatterns.Abstractions;

namespace lab1_designpatterns.StrategyContexts
{
    //the context class that holds a reference to the strategy object, and that strategy object will be set during run-time
    //through the SetRateType method depending on which type of rate the user wants
    //and through the class methods GetRate and GetName the strategy methods of the, during run-time, selected rate type is returned
    public class RateTypeContext
    {
        private IRateType _rateType;
        public void SetRateType(IRateType rateType)
        {
            _rateType = rateType;
        }

        public decimal GetRate() => _rateType.GetCurrentInterestRate();
        public string GetName() => _rateType.GetRateTypeName();
    }
}
