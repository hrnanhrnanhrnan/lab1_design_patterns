
namespace lab1_designpatterns
{
    //Concrete creator class which overrides the factory method to return an object of type PrivateLoanType
    public class PrivateLoanFactory : LoanTypeFactory
    {
        protected override ILoanType SetupLoan() => new PrivateLoanType();
    }
}
