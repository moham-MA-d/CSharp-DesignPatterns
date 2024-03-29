﻿namespace Composite.SafeImplementation;
internal class SafeComposite : SafeComponent
{
    public SafeComposite(string name) : base(name) { }

    private readonly List<SafeComponent> _children = new();

    public void Add(SafeComponent c)
    {
        _children.Add(c);
    }

    public void Remove(SafeComponent c)
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
