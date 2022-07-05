namespace Composite.WithBuilderPattern.SafeImplementation;
public class SafeCompositeWb : SafeComponentWb
{
    public SafeCompositeWb(string name) : base(name) { }

    public readonly List<SafeComponentWb> _children = new();

    public void Add(SafeComponentWb c)
    {
        _children.Add(c);
    }

    public void Remove(SafeComponentWb c)
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
