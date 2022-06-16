
namespace lab1_designpatterns.Abstractions
{
    //abstraction for loggers
    public interface ILogger
    {
        static ILogger GetInstance { get; }
        void Log(string details);
    }
}
