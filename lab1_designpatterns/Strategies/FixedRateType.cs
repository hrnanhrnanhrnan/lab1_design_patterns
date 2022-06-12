using lab1_designpatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.Strategies
{
    public class FixedRateType : IRateType
    {
        public string GetRateTypeName() => "Fixed rate";
        public decimal GetCurrentInterestRate() =>  0.45M;
    }
}
