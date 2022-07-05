namespace Composite.UniformImplementation;

internal class UniformLeaf : UniformComponent
{
    public UniformLeaf(string name) : base(name) { }
    
    public override void Add(UniformComponent c)
    {
        throw new NotImplementedException("A Uniform Leaf Cannot Implement Add Method");
    }

    public override void Remove(UniformComponent c)
    {
        throw new NotImplementedException("A Uniform Leaf Cannot Implement Remove Method");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}