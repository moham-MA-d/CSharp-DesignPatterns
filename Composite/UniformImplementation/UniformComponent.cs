namespace Composite.UniformImplementation;

internal abstract class UniformComponent
{
    protected readonly string _name;

    protected UniformComponent(string name)
    {
        _name = name;
    }

    public abstract void Add(UniformComponent c);
    public abstract void Remove(UniformComponent c);
    public abstract void GetMenu(int depth);
    public abstract int GetOrdersCount();

}