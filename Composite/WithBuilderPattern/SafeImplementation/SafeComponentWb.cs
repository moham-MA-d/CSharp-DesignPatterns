namespace Composite.WithBuilderPattern.SafeImplementation;

public abstract class SafeComponentWb
{
    public readonly string _name;

    protected SafeComponentWb(string name)
    {
        _name = name;
    }
    public abstract void GetMenu(int depth);
    public abstract int GetOrdersCount();
}