
namespace lab1_designpatterns
{
    //Concrete creator class which overrides the factory method to return an object of type CarLoanType
    public class CarLoanFactory : LoanTypeFactory
    {
        protected override ILoanType SetupLoan() => new CarLoanType();
    }
}
