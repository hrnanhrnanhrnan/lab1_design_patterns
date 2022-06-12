using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public class CarLoanType : ILoanType
    {
        public decimal GetBaseRate() => 4.53M;

        public string GetLoanType() => "Car loan";

        public decimal GetMonthlyCharge() => 1000M;
    }
}
