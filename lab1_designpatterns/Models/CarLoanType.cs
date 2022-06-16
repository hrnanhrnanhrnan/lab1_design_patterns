
namespace lab1_designpatterns
{
    //Concrete product which implements the product interface
    public class CarLoanType : ILoanType
    {
        public decimal GetBaseRate() => 4.53M;

        public string GetLoanType() => "Car loan";

        public decimal GetMonthlyCharge() => 1000M;
    }
}
