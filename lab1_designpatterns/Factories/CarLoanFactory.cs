using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public class CarLoanFactory : LoanTypeFactory
    {
        protected override ILoanType SetupLoan() => new CarLoanType();
    }
}
