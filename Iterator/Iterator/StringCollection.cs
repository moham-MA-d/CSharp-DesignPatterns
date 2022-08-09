namespace Iterator.Iterator;

public class StringCollection : Interface.ICollection<StringIterator>
{
    private readonly List<string> _foods = new();

    public StringIterator CreateIterator()
    {
        return new StringIterator(this);
    }

    public int Count => _foods.Count;

    public string this[int index]
    {
        get => _foods[index];
        init => _foods.Add(value);
    }
    
}