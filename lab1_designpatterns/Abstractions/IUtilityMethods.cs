namespace lab1_designpatterns.Abstractions
{
    //abstraction for utilitymethods
    public interface IUtilityMethods
    {
        static IUtilityMethods GetInstance { get; }
        int GetValidMenuChoice(string header, string[] choices);
    }
}