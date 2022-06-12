using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_designpatterns
{
    public abstract class LoanTypeFactory
    {
        protected abstract ILoanType SetupLoan();

        public ILoanType CreateLoan() => SetupLoan();
    }
}
