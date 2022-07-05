namespace Composite.WithBuilderPattern.UniformImplementation;

public abstract class UniformComponentWb
{
    public readonly string _name;

    protected UniformComponentWb(string name)
    {
        _name = name;
    }
    public abstract void Add(UniformComponentWb c);
    public abstract void Remove(UniformComponentWb c);
    public abstract void GetMenu(int depth);
    public abstract int GetOrdersCount();
}