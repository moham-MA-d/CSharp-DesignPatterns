namespace Composite.SafeImplementation;

internal abstract class SafeComponent
{
    protected readonly string _name;

    protected SafeComponent(string name)
    {
        _name = name;
    }
    public abstract void GetMenu(int depth);
    public abstract int GetOrdersCount();
}