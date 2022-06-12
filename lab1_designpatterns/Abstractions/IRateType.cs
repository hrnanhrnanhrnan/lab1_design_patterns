using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns.Abstractions
{
    public interface IRateType
    {
        string GetRateTypeName();
        decimal GetCurrentInterestRate();
    }
}
