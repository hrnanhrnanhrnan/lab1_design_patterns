
namespace lab1_designpatterns.Abstractions
{
    //Generic interface that creates a layer of abstraction for the handlers
    public interface IHandler<T>
    {
        T GetSelectedType();
    }
}
