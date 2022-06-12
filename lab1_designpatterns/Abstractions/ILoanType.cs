using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public interface ILoanType
    {
        string GetLoanType();
        decimal GetBaseRate();
        decimal GetMonthlyCharge();
    }
}
