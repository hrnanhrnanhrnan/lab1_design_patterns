using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public class PrivateLoanFactory : LoanTypeFactory
    {
        protected override ILoanType SetupLoan() => new PrivateLoanType();
    }
}
