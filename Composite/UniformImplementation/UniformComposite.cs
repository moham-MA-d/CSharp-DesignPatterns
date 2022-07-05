namespace Composite.UniformImplementation;
internal class UniformComposite : UniformComponent
{
    public UniformComposite(string name) : base(name) { }

    private readonly List<UniformComponent> _children = new();

    public override void Add(UniformComponent c)
    {
        _children.Add(c);
    }

    public override void Remove(UniformComponent c)
    {
        _children.Remove(c);
    }

    public override void GetMenu(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
        foreach (var c in _children)
        {
            c.GetMenu(depth + 2);
        }
    }    
    public override int GetOrdersCount()
    {
        return _children.Sum(x => x.GetOrdersCount());
    }    
}
