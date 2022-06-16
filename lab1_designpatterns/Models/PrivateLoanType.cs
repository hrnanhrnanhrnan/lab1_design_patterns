
namespace lab1_designpatterns
{
    //Concrete product which implements the product interface
    public class PrivateLoanType : ILoanType
    {
        public decimal GetBaseRate() => 8.59M;

        public string GetLoanType() => "Private loan";

        public decimal GetMonthlyCharge() => 675M;
    }
}
