
namespace lab1_designpatterns
{
    //Concrete creator class which overrides the factory method to return an object of type HouseLoanType
    public class HouseLoanFactory : LoanTypeFactory
    {
        protected override ILoanType SetupLoan() => new HouseLoanType();
    }
}
