namespace Composite.WithBuilderPattern.SafeImplementation;

public class SafeLeafWb : SafeComponentWb
{
    private readonly int _order;
    public SafeLeafWb(string name, int order) : base(name)
    {
        _order = order;
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