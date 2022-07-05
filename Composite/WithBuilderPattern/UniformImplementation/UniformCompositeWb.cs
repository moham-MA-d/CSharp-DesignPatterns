namespace Composite.WithBuilderPattern.UniformImplementation;
public class UniformCompositeWb : UniformComponentWb
{
    public UniformCompositeWb(string name) : base(name) { }

    public readonly List<UniformComponentWb> _children = new();

    public override void Add(UniformComponentWb c)
    {
        _children.Add(c);
    }

    public override void Remove(UniformComponentWb c)
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
