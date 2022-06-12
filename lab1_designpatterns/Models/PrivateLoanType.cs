using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public class PrivateLoanType : ILoanType
    {
        public decimal GetBaseRate() => 8.59M;

        public string GetLoanType() => "Private loan";

        public decimal GetMonthlyCharge() => 675M;
    }
}
