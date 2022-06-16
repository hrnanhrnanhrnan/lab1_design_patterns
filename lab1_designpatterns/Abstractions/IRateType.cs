
namespace lab1_designpatterns.Abstractions
{
    //the abstract strategy interface
    public interface IRateType
    {
        string GetRateTypeName();
        decimal GetCurrentInterestRate();
    }
}
