
namespace lab1_designpatterns
{
    //the abstract creator class which through the factory method SetupLoan method returns an object of the product interface type
    public abstract class LoanTypeFactory
    {
        protected abstract ILoanType SetupLoan();

        public ILoanType CreateLoan() => SetupLoan();
    }
}
