
namespace lab1_designpatterns
{
    //Concrete product which implements the product interface
    public class HouseLoanType : ILoanType
    {
        public decimal GetBaseRate() => 2.09M;

        public string GetLoanType() => "House Loan";

        public decimal GetMonthlyCharge() => 2000M;
    }
}
