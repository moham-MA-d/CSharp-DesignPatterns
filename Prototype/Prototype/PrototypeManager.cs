namespace Prototype.Prototype;

public class PrototypeManager
{
    private readonly Dictionary<int, IPrototype> _prototypeLibrary = new();
        
    public IPrototype this[int key]
    {
        get => _prototypeLibrary[key];
        init => _prototypeLibrary.Add(key, value);
    }
}