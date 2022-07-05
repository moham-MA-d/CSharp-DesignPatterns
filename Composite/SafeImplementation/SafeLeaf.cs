namespace Composite.SafeImplementation;

internal class SafeLeaf : SafeComponent
{
    public SafeLeaf(string name) : base(name) { }
    
    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}