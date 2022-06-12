using lab1_designpatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.StrategyContexts
{
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
