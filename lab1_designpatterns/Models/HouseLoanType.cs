using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public class HouseLoanType : ILoanType
    {
        public decimal GetBaseRate() => 2.09M;

        public string GetLoanType() => "House Loan";

        public decimal GetMonthlyCharge() => 2000M;
    }
}
