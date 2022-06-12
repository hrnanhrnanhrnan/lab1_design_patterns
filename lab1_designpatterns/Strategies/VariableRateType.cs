using lab1_designpatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.Strategies
{
    public class VariableRateType : IRateType
    {
        public string GetRateTypeName() => "Variable rate";
        public decimal GetCurrentInterestRate() => 0.15M;
    }
}
