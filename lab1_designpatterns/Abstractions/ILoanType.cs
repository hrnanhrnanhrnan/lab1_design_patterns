
namespace lab1_designpatterns
{
    //Product interface
    public interface ILoanType
    {
        string GetLoanType();
        decimal GetBaseRate();
        decimal GetMonthlyCharge();
    }
}
