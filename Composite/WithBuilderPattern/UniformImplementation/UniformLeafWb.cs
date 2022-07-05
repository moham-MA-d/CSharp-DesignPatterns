namespace Composite.WithBuilderPattern.UniformImplementation;

public class UniformLeafWb : UniformComponentWb
{
    private readonly int _order;
    public UniformLeafWb(string name, int order) : base(name)
    {
        _order = order;
    }
    public override void Add(UniformComponentWb c)
    {
        // In uniform implementation, client should not add any item to leaf
        // throw new NotImplementedException("A Uniform Leaf Cannot Implement Add Method");
    }

    public override void Remove(UniformComponentWb c)
    {
        // In uniform implementation, client should not remove any item from leaf
        // throw new NotImplementedException("A Uniform Leaf Cannot Implement Remove Method");
    }
    public override void GetMenu(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }

    public override int GetOrdersCount()
    {
        return _order;
    }
}